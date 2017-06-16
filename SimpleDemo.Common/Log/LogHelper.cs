using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDemo.Common
{
    /// <summary>
    /// 日志操作类
    /// </summary>
    public  class LogHelper
    {
        private static Logger LOGGER = LogManager.GetCurrentClassLogger();


        /// <summary>
        /// 写入日志
        /// </summary>
        /// <param name="message"></param>
        /// <param name="level"></param>
        public static void WriteLog(string message, CustomLogLevel level)
        {
            switch (level)
            {
                case CustomLogLevel.Trace:
                    LOGGER.Trace(message);
                    break;
                case CustomLogLevel.Debug:
                    LOGGER.Debug(message);
                    break;
                case CustomLogLevel.Info:
                    LOGGER.Info(message);
                    break;
                case CustomLogLevel.Error:
                    LOGGER.Error(message);
                    break;
                case CustomLogLevel.Fatal:
                    LOGGER.Fatal(message);
                    break;
            }
        }

        /// <summary>
        /// 写入日志
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="message"></param>
        /// <param name="level"></param>
        public static void WriteLog(Exception exception, string message, CustomLogLevel level)
        {
            switch (level)
            {
                case CustomLogLevel.Trace:
                    LOGGER.Trace(exception, message);
                    break;
                case CustomLogLevel.Debug:
                    LOGGER.Debug(exception, message);
                    break;
                case CustomLogLevel.Info:
                    LOGGER.Info(exception, message);
                    break;
                case CustomLogLevel.Error:
                    LOGGER.Error(exception, message);
                    break;
                case CustomLogLevel.Fatal:
                    LOGGER.Fatal(exception, message);
                    break;
            }
        }

    }

    /// <summary>
    /// 自定义日志等级
    /// </summary>
    public enum CustomLogLevel
    {
        /// <summary>
        /// 跟踪
        /// </summary>
        Trace,
        /// <summary>
        /// 调试
        /// </summary>
        Debug,
        /// <summary>
        /// 信息
        /// </summary>
        Info,
        /// <summary>
        /// 一般错误
        /// </summary>
        Error,
        /// <summary>
        /// 严重，崩溃
        /// </summary>
        Fatal
    }
}
