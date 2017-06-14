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
    public static class SerialPortHelp
    {

        /// <summary>
        /// 获取光电串口实例，
        /// 例如获取大灯光电GetPhotoelectric(DetectionType.Light).
        /// </summary>
        /// <param name="dt">检验类型</param>
        public static void GetPhotoelectric(DetectionType dt)
        {
            SerialPort port = new SerialPort();
            var config = GlobalConfig.GetInstance();
            switch (dt)
            {
                case DetectionType.Shape:
                    break;
                case DetectionType.SideSlide:
                    break;
                case DetectionType.Speed:
                    break;
                case DetectionType.Light:
                    port.PortName = config.GetLightSetting().Photoelectric.PortName.ToString();
                   // port.
                    break;
                case DetectionType.Brake:
                    break;
                case DetectionType.Weigh:
                    break;
                case DetectionType.bottom:
                    break;
                case DetectionType.BoottomInterval:
                    break;
                case DetectionType.SoundLevel:
                    break;
                case DetectionType.Power:
                    break;
                case DetectionType.FuelConsumption:
                    break;
                case DetectionType.Exhaust:
                    break;
                default:
                    break;
            }
        }

    }
}
