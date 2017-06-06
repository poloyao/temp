using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace SimpleDemo.Common
{
    /// <summary>
    /// 灯光操作通用类
    /// 具体操作跟串口通讯
    /// </summary>
    public class LightOperationHelper
    {

        public static bool GetCheckReuslut()
        {
            return true;
        }

        public static string GetLeftLight()
        {   
            return "";
        }

        public static string GetRightLight()
        {
            return "";
        }

        public static bool GetIsOnLine()
        {
            SerialPort sp = new SerialPort();
            sp.Parity = Parity.Mark;
            sp.PortName = "COM1";
            sp.BaudRate = 9600;
            //sp.Open();
            return sp.IsOpen;
        }
    }
}
