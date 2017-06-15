using SimpleDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace SimpleDemo.Common
{
    /// <summary>
    /// 串口帮助类，获取设备的串口实例
    /// </summary>
    public class SerialPortHelp
    {
        private static List<PortElement> StaticPort { get;  set; } = new List<PortElement>();

        private static readonly SerialPortHelp instance = new SerialPortHelp();

        public static SerialPortHelp GetInstance()
        {
            return instance;
        }

        private SerialPortHelp()
        {
            InitPort();
        }

        /// <summary>
        /// 初始化串口列表，
        /// 根据配置文件创建。
        /// 联动关闭所有串口连接并清空串口列表
        /// </summary>
        public static void InitPort()
        {
            ClearPorts();
            StaticPort.Add(new PortElement()
            {
                DeviceType = DeviceType.LatticeScreen,
                DetectionType = DetectionType.Light,
                PortName = "COM1",
                BaudRate = 9600,
                DataBits = 8,
                Parity = Parity.None,
                StopBits = StopBits.One
            });
            StaticPort.Add(new PortElement()
            {
                DeviceType = DeviceType.Photoelectric,
                DetectionType = DetectionType.Light,
                PortName = "COM1",
                BaudRate = 9600,
                DataBits = 8,
                Parity = Parity.None,
                StopBits = StopBits.One
            });
        }

        /// <summary>
        /// 清空并关闭所有串口
        /// </summary>
        private static void ClearPorts()
        {
            if (StaticPort == null)
                return;
            CloseAllPort();
            StaticPort.Clear();
        }


        /// <summary>
        /// 获取指定的串口实例
        /// </summary>
        /// <param name="device">设备类型</param>
        /// <param name="detection">检测项目</param>
        /// <param name="index">编号</param>
        /// <returns></returns>
        public static PortElement GetDevicePort(DeviceType device, DetectionType detection,int index= 0)
        {
            try
            {
                if (StaticPort == null)
                    throw new Exception();
                var port = StaticPort.Single(x => x.DeviceType == device && x.DetectionType == detection && x.Index == index);
                return port;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 断开全部串口，例：应用于全局配置文件修改后
        /// </summary>
        public static void CloseAllPort()
        {
            if (StaticPort == null)
                return;
            StaticPort.ForEach(x =>
            {
                if (x.IsOpen)
                    x.Close();
            });
        }

        public static void ClosePort(DeviceType device, DetectionType detection, int index = 0)
        {
            try
            {
                if (StaticPort == null)
                    throw new Exception();
                var port = StaticPort.Single(x => x.DeviceType == device && x.DetectionType == detection && x.Index == index);
                if (port.IsOpen)
                    port.Close();


            }
            catch (Exception)
            {

                throw;
            }
        }      
        

    }
    

    //public class aadaaaa
    //{
    //    public void aaa()
    //    {
    //        var op = SerialPortHelp.GetDevicePort(DeviceType.LatticeScreen, DetectionType.Light);
    //        op.Open();
    //    }
    //}

}
