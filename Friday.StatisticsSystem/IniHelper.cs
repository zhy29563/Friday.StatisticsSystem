/*
 * INI文件说明:
 * INI是Initialization头三个字母的缩写；其后缀名也不一定是".ini"也可以是".cfg"，".conf ”或者是".txt"
 * 
 * INI文件由节、键、值组成
 * 节
 *      [section]
 * 参数（键=值）
 *      name=value
 * 注解
 *      注解使用分号表示（;）。在分号后面的文字，直到该行结尾都全部为注解。
 *
 * NI文件的格式很简单，最基本的三个要素是：parameters，sections和comments。
 * 
 * 什么是parameters？
 *      INI所包含的最基本的“元素”就是parameter；每一个parameter都有一个name和一个value，
 *      name和value是由等号“=”隔开。name在等号的左边。
 *      如：
 *          name = value
 * 
 * 什么是sections？
 *      所有的parameters都是以sections为单位结合在一起的。所有的section名称都是独占一行，
 *      并且sections名字都被方括号包围着。在section声明后的所有parameters都是属于该section。
 *      对于一个section没有明显的结束标志符，一个section的开始就是上一个section的结束，
 *      或者是end of the file。Sections一般情况下不能被nested，当然特殊情况下也可以实现sections的嵌套。
 *      section如下所示：
 *          [section]
 * 
 * 什么是comments？
 *      在INI文件中注释语句是以分号“;”开始的。所有的所有的注释语句不管多长都是独占一行直到结束的。
 *      在分号和行结束符之间的所有内容都是被忽略的。
 *      注释实例如下：
 *          ;comments text
 */

using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;

namespace Friday.StatisticsSystem
{
    public class IniHelper
    {
        #region Fields

        #endregion

        #region Properties

        public string FullName { get; }

        public int ReadBufferSize { get; set; } = 512;

        #endregion

        #region Constructors

        public IniHelper(string fullName = "./config.ini")
        {
            FullName = fullName;
        }

        #endregion

        #region Fuction Declare

        /// <summary>
        /// 写入INI文件
        /// </summary>
        /// <param name="section">节点名称,这个字串不区分大小写[如[TypeName]]</param>
        /// <param name="key">键,不区分大小写</param>
        /// <param name="val">值</param>
        /// <param name="filepath">INI文件的完整路径和文件名</param>
        /// <returns>非零表示成功，零表示失败</returns>
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filepath);


        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string defValue, StringBuilder builder, int size, string filePath);

        #endregion

        #region Public Functions

        #region Write
        /// <summary>
        /// 向Ini文件中写入字符串
        /// </summary>
        /// <param name="section">节点名称</param>
        /// <param name="keyName">参数名称</param>
        /// <param name="keyValue">参数值</param>
        public void WriteIni(string section, string keyName, string keyValue)
        {
            long size = WritePrivateProfileString(section, keyName, keyValue, FullName);
            if (size == 0)
            {
                throw new Exception("Writing data to ini file is fail" + Environment.NewLine + FullName);
            }
        }

        /// <summary>
        /// 向Ini文件中写入INT
        /// </summary>
        /// <param name="section">节点名称</param>
        /// <param name="keyName">参数名称</param>
        /// <param name="keyValue">参数值</param>
        public void WriteIni(string section, string keyName, int keyValue)
        {
            WriteIni(section, keyName, keyValue.ToString());
        }

        /// <summary>
        /// 向Ini文件中写入USHORT
        /// </summary>
        /// <param name="section">节点名称</param>
        /// <param name="keyName">参数名称</param>
        /// <param name="keyValue">参数值</param>
        public void WriteIni(string section, string keyName, ushort keyValue)
        {
            WriteIni(section, keyName, keyValue.ToString());
        }

        /// <summary>
        /// 向Ini文件中写入DOUBLE
        /// </summary>
        /// <param name="section">节点名称</param>
        /// <param name="keyName">参数名称</param>
        /// <param name="keyValue">参数值</param>
        public void WriteIni(string section, string keyName, double keyValue)
        {
            WriteIni(section, keyName, keyValue.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// 向Ini文件中写入BOOL
        /// </summary>
        /// <param name="section">节点名称</param>
        /// <param name="keyName">参数名称</param>
        /// <param name="keyValue">参数值</param>
        public void WriteIni(string section, string keyName, bool keyValue)
        {
            WriteIni(section, keyName, keyValue.ToString());
        }
        #endregion

        #region Read
        /// <summary>
        /// 从Ini文件中读取字符串
        /// </summary>
        /// <param name="section">节点名称</param>
        /// <param name="keyName">参数名称</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns>读取值</returns>
        public string ReadIni(string section, string keyName, string defaultValue)
        {
            var stringBuilder = new StringBuilder(ReadBufferSize);
            long size = GetPrivateProfileString(section, keyName, defaultValue, stringBuilder, ReadBufferSize, FullName);
            if (size == ReadBufferSize - 1)
            {
                throw new Exception("The read buffer is small, please change the buffer size");
            }

            if (size == ReadBufferSize - 2)
            {
                throw new Exception("The section or key is not found, please check it");
            }

            return stringBuilder.ToString();
        }

        /// <summary>
        /// 从Ini文件中读取INT
        /// </summary>
        /// <param name="section">节点名称</param>
        /// <param name="keyName">参数名称</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns>读取值</returns>
        public int ReadIni(string section, string keyName, int defaultValue)
        {
            int ret;
            string str = ReadIni(section, keyName, defaultValue.ToString());
            ret = int.TryParse(str, out ret) ? ret : defaultValue;

            return ret;
        }

        /// <summary>
        /// 从Ini文件中读取USHORT
        /// </summary>
        /// <param name="section">节点名称</param>
        /// <param name="keyName">参数名称</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns>读取值</returns>
        public ushort ReadIni(string section, string keyName, ushort defaultValue)
        {
            ushort ret;
            string str = ReadIni(section, keyName, defaultValue.ToString());
            ret = ushort.TryParse(str, out ret) ? ret : defaultValue;

            return ret;
        }

        /// <summary>
        /// 从Ini文件中读取DOUBLE
        /// </summary>
        /// <param name="section">节点名称</param>
        /// <param name="keyName">参数名称</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns>读取值</returns>
        public double ReadIni(string section, string keyName, double defaultValue)
        {
            double ret;
            string str = ReadIni(section, keyName, defaultValue.ToString(CultureInfo.InvariantCulture));
            ret = double.TryParse(str, out ret) ? ret : defaultValue;

            return ret;
        }

        /// <summary>
        /// 从Ini文件中读取BOOL
        /// </summary>
        /// <param name="section">节点名称</param>
        /// <param name="keyName">参数名称</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns>读取值</returns>
        public bool ReadIni(string section, string keyName, bool defaultValue)
        {
            bool ret;
            string str = ReadIni(section, keyName, defaultValue.ToString());
            ret = bool.TryParse(str, out ret) ? ret : defaultValue;

            return ret;
        }
        #endregion

        #region Delete
        public void DeleteKey(string section, string key)
        {
            WriteIni(section, key, null);
        }

        public void DeleteSection(string section)
        {
            WriteIni(section, null, null);
        }

        public void DeleteAllSection()
        {
            WriteIni(null, null, null);
        }
        #endregion

        #endregion
    }
}