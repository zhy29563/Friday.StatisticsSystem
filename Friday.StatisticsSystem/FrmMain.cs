using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using NLog;
using NLog.Windows.Forms;

namespace Friday.StatisticsSystem
{
    public partial class FrmMain : Form
    {
        internal static readonly object DataLocker = new object();
        internal static readonly object SaveLocker = new object();

        internal readonly ILogger LogHelper = LogManager.GetCurrentClassLogger();
        internal readonly IniHelper IniHelper = new IniHelper();
        internal List<UnionCodeInfo> InfoList = new List<UnionCodeInfo>();

        private string _networkHostOne;
        private ushort _networkPortOne;
        private string _networkHostTwo;
        private ushort _networkPortTwo;
        private CommunicationTool _communicationOne;
        private CommunicationTool _communicationTwo;


        private ulong _readOk;
        private ulong _readNg;
        private ulong _readAll;
        private float _readRatio;

        public FrmMain()
        {
            InitializeComponent();
            RichTextBoxTarget.ReInitializeAllTextboxes(this);

            this.label5.Text = @"数据格式:" + Environment.NewLine +
                               @"<STX>Index___Code1_Code2 ....<ETX>" + Environment.NewLine +
                               @"<STX>Index___NoRead<ETX>";
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LogHelper.Info("应用程序正在启动...");

            try
            {
                // 参数加载
                _networkHostOne = IniHelper.ReadIni("System", "NetworkHostOne", "127.0.0.1");
                _networkHostTwo = IniHelper.ReadIni("System", "NetworkHostTwo", "127.0.0.1");

                _networkPortOne = IniHelper.ReadIni("System", "NetworkPortOne", (ushort)5001);
                _networkPortTwo = IniHelper.ReadIni("System", "NetworkPortTwo", (ushort)5002);

                // 界面显示
                txtNetworkHostOne.Text = _networkHostOne;
                txtNetworkHostTwo.Text = _networkHostTwo;

                txtNetworkPortOne.Text = _networkPortOne.ToString();
                txtNetworkPortTwo.Text = _networkPortTwo.ToString();

                // 通讯组件
                _communicationOne = new CommunicationTool(_networkHostOne, _networkPortOne);
                _communicationTwo = new CommunicationTool(_networkHostTwo, _networkPortTwo);

                // 事件处理
                _communicationOne.ConnectedStateChanged += CommunicationOne_ConnectedStateChanged;
                _communicationTwo.ConnectedStateChanged += CommunicationTwo_ConnectedStateChanged;

                _communicationOne.DataAvailable += CommunicationOne_DataAvailable;
                _communicationTwo.DataAvailable += CommunicationTwo_DataAvailable;

                // 启动连接
                _communicationOne.Connect();
                _communicationTwo.Connect();
            }
            catch(Exception ex)
            {
                LogHelper.Error(ex, ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void CommunicationTwo_DataAvailable(string index, string codes)
        {
            try
            {
                lock(DataLocker)
                {
                    if (InfoList.Count > 10)
                        InfoList.RemoveAt(0);

                    var infos = InfoList.Where(item => item.Index == index && item.Time > DateTime.Now.AddSeconds(-5)).ToArray();
                    switch (infos.Length)
                    {
                        case 0:
                        {
                            var info = new UnionCodeInfo();
                            info.DataCompleted += Info_DataCompleted;
                            info.Time = DateTime.Now;
                            info.Index = index;
                            info.CodeTwo = codes;

                            InfoList.Add(info);
                            break;
                        }
                        case 1:
                            infos[0].CodeTwo = codes;
                            break;
                        default:
                            throw new Exception("数据异常");
                    }
                }
            }
            catch(Exception ex)
            {
                LogHelper.Error(ex, ex.Message);
            }
        }

        private void CommunicationOne_DataAvailable(string index, string codes)
        {
            try
            {
                lock (DataLocker)
                {
                    if (InfoList.Count > 10)
                        InfoList.RemoveAt(0);

                    var infos = InfoList.Where(item => item.Index == index && item.Time > DateTime.Now.AddSeconds(-5)).ToArray();
                    switch (infos.Length)
                    {
                        case 0:
                        {
                            var info = new UnionCodeInfo();
                            info.DataCompleted += Info_DataCompleted;
                            info.Time = DateTime.Now;
                            info.Index = index;
                            info.CodeOne = codes;

                            InfoList.Add(info);
                            break;
                        }
                        case 1:
                            infos[0].CodeOne = codes;
                            break;
                        default:
                            throw new Exception("数据异常");
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex, ex.Message);
            }
        }

        private void Info_DataCompleted(string index, DateTime time, string codeOne, string codeTwo)
        {
            try
            {
                // 数据显示
                var list = new List<string[]> { codeOne.Split(','), codeTwo.Split(',') };
                var dist = list.Aggregate((current, next) => current.Union(next).ToArray()).ToArray();
                if(dist.Any(item => item != "NoRead"))
                {
                    dist = dist.Where(item => item != "NoRead").Select(item => item).ToArray();
                }

                var codes = string.Join(",", dist);
                var strTime = time.ToString("yyyyMMddHHmmssfff");

                if (codes.Contains("NoRead"))
                    _readNg++;
                else
                    _readOk++;
                _readAll++;
                _readRatio = _readOk * 100.0f / _readAll;

                // 显示数据
                BeginInvoke( new Action(() =>
                {
                    // 统计
                    txtReadOK.Text = _readOk.ToString();
                    txtReadNG.Text = _readNg.ToString();
                    txtReadAll.Text = _readAll.ToString();
                    txtReadRatio.Text = _readRatio.ToString("F2");

                    if (dgvData.Rows.Count > 100)
                        dgvData.Rows.Clear();

                    dgvData.Rows.Add(index, codes, strTime);
                }));

                // 保存数据
                var fileName = time.ToString("yyyyMMdd") + ".csv";
                ThreadPool.QueueUserWorkItem(obj =>
                {
                    if (!File.Exists(fileName))
                        CreateCsv(fileName);

                    AppendDataToCsv(fileName, index, codeOne, codeTwo, codes, strTime);
                });
                
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex, ex.Message);
            }
        }

        private void CreateCsv(string fileName)
        {
            try
            {
                lock (SaveLocker)
                {
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine("Index, CodeOne,CodeTwo, Codes, Time");
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex, ex.Message);
            }
        }

        private void AppendDataToCsv(string fileName, string index, string codeOne, string codeTwo, string codes, string time)
        {
            try
            {
                lock (SaveLocker)
                {
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine($"{index},{codeOne},{codeTwo}, {codes}, '{time}");
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex, ex.Message);
            }
        }

        

        private void CommunicationTwo_ConnectedStateChanged(bool enable)
        {
            BeginInvoke(new Action(() =>
            {
                txtNetworkHostTwo.Enabled = !enable;
                txtNetworkPortTwo.Enabled = !enable;

                btnConnectTwo.Enabled = !enable;
                btnDisconnectTwo.Enabled = enable;
            }));
        }

        private void CommunicationOne_ConnectedStateChanged(bool enable)
        {
            BeginInvoke(new Action(() =>
            {
                txtNetworkHostOne.Enabled = !enable;
                txtNetworkPortOne.Enabled = !enable;

                btnConnectOne.Enabled = !enable;
                btnDisconnectOne.Enabled = enable;
            }));
        }

        private void btnConnectOne_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IPAddress.TryParse(txtNetworkHostOne.Text.Trim(), out var address))
                {
                    throw new Exception("输入的地址不正确");
                }

                _networkHostOne = txtNetworkHostOne.Text.Trim();

                if (!ushort.TryParse(txtNetworkPortOne.Text.Trim(), out var port))
                {
                    throw new Exception("输入的端口不正确");
                }

                _networkPortOne = port;


                _communicationOne.NetworkHost = _networkHostOne;
                _communicationOne.NetworkPort = _networkPortOne;
                _communicationOne.Connect();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDisconnectOne_Click(object sender, EventArgs e)
        {
            try
            {
                _communicationOne.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveConfigOne_Click(object sender, EventArgs e)
        {
            try
            {
                IniHelper.WriteIni("System", "NetworkHostOne", _networkHostOne);
                IniHelper.WriteIni("System", "NetworkPortOne", _networkPortOne);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConnectTwo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IPAddress.TryParse(txtNetworkHostTwo.Text.Trim(), out var address))
                {
                    throw new Exception("输入的地址不正确");
                }

                _networkHostTwo = txtNetworkHostTwo.Text.Trim();

                if (!ushort.TryParse(txtNetworkPortTwo.Text.Trim(), out var port))
                {
                    throw new Exception("输入的端口不正确");
                }

                _networkPortTwo = port;

                _communicationTwo.NetworkHost = _networkHostTwo;
                _communicationTwo.NetworkPort = _networkPortTwo;
                _communicationTwo.Connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDisconnectTwo_Click(object sender, EventArgs e)
        {
            try
            {
                _communicationTwo.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveConfigTwo_Click(object sender, EventArgs e)
        {
            try
            {
                IniHelper.WriteIni("System", "NetworkHostTwo", _networkHostTwo);
                IniHelper.WriteIni("System", "NetworkPortTwo", _networkPortTwo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
