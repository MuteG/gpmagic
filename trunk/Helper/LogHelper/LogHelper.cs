/*
 *********************************************************************
 * 程序名称 : Helper（辅助功能类）
 * 类名称   : LogHelper
 * 说明     : 提供书写日志的方法（文本日志/系统日志）
 * 作者     : 高云鹏
 * 作成日期 : 2008-10-27
 * 修改履历 :
 * 日期         修改者  程序版本    类型    理由
 * 2008-10-27   高云鹏  1.0.0.0     新规    初次做成
 * 2008-12-18   高云鹏  1.0.0.0     修改    写日志函数加入异常处理，防止日志文件被占用时抛出异常
 * 2009-07-14   高云鹏  1.0.0.5     修改    ①加入工厂方法
 *                                          ②加入输出空行的方法
 * 2009-07-16   高云鹏  1.0.0.6     添加    加入数据库操作的日志输出类型
 *********************************************************************
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace ORID.Helper.LogHelper
{
    public enum LogInstance
    {
        /// <summary>
        /// 文本日志
        /// </summary>
        LITxtLog = 0,
        /// <summary>
        /// 系统日志
        /// </summary>
        LIEventLog = 1
    }

    /// <summary>
    /// 日志信息类型
    /// </summary>
    public enum LogType
    {
        /// <summary>
        /// 细节（仅为向下兼容，推荐使用LTProcDetail）
        /// </summary>
        LTDetail = 0,
        /// <summary>
        /// 过程开始
        /// </summary>
        LTProcStart = 1,
        /// <summary>
        /// 过程结束
        /// </summary>
        LTProcStop = 2,
        /// <summary>
        /// 异常（仅为向下兼容，推荐使用LTProcError）
        /// </summary>
        LTError = 3,
        /// <summary>
        /// 数据库操作（仅为向下兼容，推荐使用LTDBDetail）
        /// </summary>
        LTDB = 4,
        /// <summary>
        /// 空行
        /// </summary>
        LTNull = 5,
        /// <summary>
        /// 数据库操作开始
        /// </summary>
        LTDBStart = 6,
        /// <summary>
        /// 数据库操作结束
        /// </summary>
        LTDBStop = 7,
        /// <summary>
        /// 数据库操作异常
        /// </summary>
        LTDBError = 8,
        /// <summary>
        /// 数据库操作细节
        /// </summary>
        LTDBDetail = 9,
        /// <summary>
        /// 过程细节
        /// </summary>
        LTProcDetail = 10,
        /// <summary>
        /// 过程异常
        /// </summary>
        LTProcError = 11
    }

    public interface ILogHelper
    {
        void WriteLog(LogType logType, string message, string source, string logName);

        void WriteLog(LogType logType, string message, string source);

        void WriteLog(LogType logType, string message);

        void WriteSpaceLine();
    }

    public class LogHelper
    {
        private ILogHelper log;
        private LogInstance ins;

        public LogInstance InstanceType
        {
            get { return this.ins; }
        }

        private LogHelper() { }

        public LogHelper(LogInstance li)
        {
            ins = li;
            switch (li)
            {
                case LogInstance.LITxtLog:
                    {
                        log = new TxtLogHelper();
                        break;
                    }
                case LogInstance.LIEventLog:
                    {
                        log = new EventLogHelper();
                        break;
                    }
            }
        }
        /// <summary>
        /// 写日志（ログを書きます）
        /// </summary>
        /// <param name="logType">日志类型（ログのタイプ）、LogType参照</param>
        /// <param name="message">日志信息（ログの情報）</param>
        /// /// <param name="source">日志路径（ログのパス）</param>
        /// <param name="logName">日志文件名（ログの名）</param>
        public void WriteLog(LogType logType, string message, string source, string logName)
        {
            log.WriteLog(logType, message, source, logName);
        }
        /// <summary>
        /// 写日志（ログを書きます）
        /// </summary>
        /// <param name="logType">日志类型（ログのタイプ）、LogType参照</param>
        /// <param name="message">日志信息（ログの情報）</param>
        /// /// <param name="source">日志路径（ログのパス）</param>
        public void WriteLog(LogType logType, string message, string source)
        {
            log.WriteLog(logType, message, source);
        }
        /// <summary>
        /// 写日志（ログを書きます）
        /// </summary>
        /// <param name="logType">日志类型（ログのタイプ）、LogType参照</param>
        /// <param name="message">日志信息（ログの情報）</param>
        public void WriteLog(LogType logType, string message)
        {
            log.WriteLog(logType, message);
        }
    }

    public class LogHelperFactory
    {
        private LogHelperFactory() { }

        public static ILogHelper GetInstance(LogInstance li)
        {
            ILogHelper result = null;
            switch (li)
            {
                case LogInstance.LITxtLog:
                    {
                        result = new TxtLogHelper();
                        break;
                    }
                case LogInstance.LIEventLog:
                    {
                        result = new EventLogHelper();
                        break;
                    }
            }
            return result;
        }
    }

    public class TxtLogHelper : ILogHelper
    {
        #region 写文本日志（ログを書きます）

        /// <summary>
        /// 向日志文件中输出一个空行
        /// </summary>
        public void WriteSpaceLine()
        {
            WriteLog(LogType.LTNull, string.Empty);
        }

        /// <summary>
        /// 写日志（ログを書きます）
        /// </summary>
        /// <param name="logType">日志类型（ログのタイプ）、LogType参照</param>
        /// <param name="message">日志信息（ログの情報）</param>
        /// /// <param name="logPath">日志路径（ログのパス）</param>
        /// <param name="logName">日志文件名（ログの名）</param>
        public void WriteLog(LogType logType, string message, string logPath, string logName)
        {
            string logMsg = DateTime.Now.ToString("HH:mm:ss fff\t");
            string logFile = Path.Combine(logPath, logName);  // logPath + "\\" + logName;  //2008-09-05 修改
            //如果路径不存在，建立目录
            if (!Directory.Exists(logPath))
            {
                Directory.CreateDirectory(logPath);
            }
            //如果文件不存在，建立文件
            if (!File.Exists(logFile))
            {
                File.Create(logFile).Close();
            }

            switch (logType)
            {
                case LogType.LTProcDetail:
                case LogType.LTDetail:
                    {
                        logMsg += "■\t";
                        break;
                    }
                case LogType.LTProcError:
                case LogType.LTError:
                    {
                        logMsg += "◆\t";
                        break;
                    }
                case LogType.LTProcStart:
                    {
                        logMsg += "▼\t";
                        break;
                    }
                case LogType.LTProcStop:
                    {
                        logMsg += "▲\t";
                        break;
                    }
                case LogType.LTDBDetail:
                case LogType.LTDB:
                    {
                        logMsg += "□\t";
                        break;
                    }
                case LogType.LTNull:
                    {
                        logMsg = string.Empty;
                        break;
                    }
                case LogType.LTDBStart:
                    {
                        logMsg += "▽\t";
                        break;
                    }
                case LogType.LTDBStop:
                    {
                        logMsg += "△\t";
                        break;
                    }
                case LogType.LTDBError:
                    {
                        logMsg += "◇\t";
                        break;
                    }
                default:
                    break;
            }
            logMsg += message;

            try
            {
                WriteToFile(logFile, logMsg);
            }
            catch
            {
                // do nothing
            }
        }

        /// <summary>
        /// 写日志（ログを書きます）
        /// </summary>
        /// <param name="logType">日志类型（ログのタイプ）、LogType参照</param>
        /// <param name="message">日志信息（ログの情報）</param>
        /// /// <param name="logPath">日志路径（ログのパス）</param>
        public void WriteLog(LogType logType, string message, string logPath)
        {
            WriteLog(logType, message, logPath, DateTime.Now.ToString("yyyy-MM-dd.LOG"));
        }

        /// <summary>
        /// 写日志（ログを書きます）
        /// </summary>
        /// <param name="logType">日志类型（ログのタイプ）、LogType参照</param>
        /// <param name="sMessage">日志信息（ログの情報）</param>
        public void WriteLog(LogType logType, string message)
        {
            WriteLog(logType, message, AppDomain.CurrentDomain.BaseDirectory + "\\LOG");
        }

        /// <summary>
        /// 把信息写到指定文件的尾部
        /// </summary>
        /// <param name="fileName">文件完整路径</param>
        /// <param name="msg">信息文本</param>
        public void WriteToFile(string fileName, string msg)
        {
            StreamWriter swWriter = new StreamWriter(new FileStream(fileName, FileMode.Append));
            swWriter.WriteLine(msg);
            swWriter.Close();
        }
        #endregion
    }

    public class EventLogHelper : ILogHelper
    {
        #region 写系统日志

        public void WriteSpaceLine()
        {
        }

        /// <summary>
        /// 写系统日志
        /// </summary>
        /// <param name="logType">日志内容的类型，参照LogType</param>
        /// <param name="message">日志信息</param>
        /// <param name="source">日志源</param>
        /// <param name="logName">日志名</param>
        public void WriteLog(LogType logType, string message, string source, string logName)
        {
            try
            {
                if (!EventLog.SourceExists(source))
                {
                    EventLog.CreateEventSource(source, logName);
                }
                //日志初始化
                EventLog log = new EventLog();
                log.Source = source;
                //判断日志类型
                EventLogEntryType elet;
                switch (logType)
                {
                    case LogType.LTDBError:
                    case LogType.LTError:
                        {
                            elet = EventLogEntryType.Error;
                            break;
                        }
                    default:
                        {
                            elet = EventLogEntryType.Information;
                            break;
                        }
                }
                //写日志
                log.WriteEntry(message, elet);
            }
            catch
            {
                // do nothing
            }
        }

        /// <summary>
        /// 写系统日志
        /// </summary>
        /// <param name="logType">日志内容的类型，参照LogType</param>
        /// <param name="message">日志信息</param>
        /// <param name="source">日志源</param>
        public void WriteLog(LogType logType, string message, string source)
        {
            string logName = source + "EventLog";
            WriteLog(logType, message, source, logName);
        }

        /// <summary>
        /// 写系统日志
        /// </summary>
        /// <param name="logType">日志内容的类型，参照LogType</param>
        /// <param name="message">日志信息</param>
        public void WriteLog(LogType logType, string message)
        {
            string source = Process.GetCurrentProcess().ProcessName;
            WriteLog(logType, message, source);
        }

        #endregion
    }
}
