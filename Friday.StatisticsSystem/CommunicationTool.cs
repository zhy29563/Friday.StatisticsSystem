using System;
using System.Linq;
using System.Text;
using HPSocket;
using HPSocket.Tcp;
using NLog;

namespace Friday.StatisticsSystem
{
    internal class CommunicationTool
    {
        internal readonly ILogger LogHelper = LogManager.GetCurrentClassLogger();
        
        #region 事件
        public event Action<bool> ConnectedStateChanged;
        public event Action<string, string> DataAvailable;
        #endregion

        #region 字段
        /// <summary>
        /// 客户端对象
        /// </summary>
        private readonly TcpClient _tcpClient = new TcpClient();

        #endregion

        /// <summary>
        /// 网络地址
        /// </summary>
        public string NetworkHost { get; set; }

        /// <summary>
        /// 网络端口
        /// </summary>
        public ushort NetworkPort { get; set; }

        public CommunicationTool(string networkHost, ushort networkPort)
        {
            NetworkHost = networkHost;
            NetworkPort = networkPort;

            // 连接
            _tcpClient.OnConnect += ss =>
            {
                ConnectedStateChanged?.Invoke(true);
                return HandleResult.Ok;
            };

            // 关闭
            _tcpClient.OnClose += (ss, enOperation, errorCode) =>
            {
                ConnectedStateChanged?.Invoke(false);
                return HandleResult.Ok;
            };

            // 接收
            _tcpClient.OnReceive += (ss, bytes) =>
            {
                // 获取字符串数据
                var strData = Encoding.ASCII.GetString(bytes).Substring(1, bytes.Length - 2);

                LogHelper.Info($"Received Data: {networkHost} >>> {strData}");

                // 分解字符串
                var infos = strData.Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
                var index = infos[0];
                var codes = string.Join(",", infos.Skip(1).ToArray());

                // 事件回调
                DataAvailable?.BeginInvoke(index, codes, null, null);

                return HandleResult.Ok;
            };
        }

        /// <summary>
        /// 连接MSC
        /// </summary>
        public void Connect() => _tcpClient.Connect(NetworkHost, NetworkPort);

        /// <summary>
        /// 关闭连接
        /// </summary>
        public void Close()
        {
            if (_tcpClient.HasStarted)
                _tcpClient.Stop();
        }
    }
}
