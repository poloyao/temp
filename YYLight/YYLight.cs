using SimpleDemo.Common;
using SimpleDemo.Device;
using SimpleDemo.Model;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YYLight
{
    public class YYLight : ILightFlowBase
    {
        public bool InPhotoelectric { get; set; }
        public bool InLight { get; set; }
        public List<PortElement> PortItems { get; set; }

        public void DeviceReset()
        {
            throw new NotImplementedException();
        }

        public void GetLightData()
        {
            throw new NotImplementedException();
        }

        public void LightClose()
        {
            throw new NotImplementedException();
        }

        public void LightOpen()
        {
            throw new NotImplementedException();
        }

        public void PhotoelectricOpen()
        {
            var port = SerialPortHelp.GetDevicePort(DeviceType.Photoelectric, DetectionType.Light);

            port.DataReceived += (s, e) =>
            {
                var serialPort = s as SerialPort;
                byte[] bytesData = new byte[0];
                byte[] bytesTemp = new byte[0];
                int bytesRead;
                byte result = 0x00;

                //获取接收缓冲区中字节数
                bytesRead = serialPort.BytesToRead;
                //保存上一次没处理完的数据
                if (bytesData.Length > 0)
                {
                    bytesTemp = new byte[bytesData.Length];
                    bytesData.CopyTo(bytesTemp, 0);
                    bytesData = new byte[bytesRead + bytesData.Length];
                    bytesTemp.CopyTo(bytesData, 0);
                }
                else
                {
                    bytesData = new byte[bytesRead];
                    bytesTemp = new byte[0];
                }
                //保存本次接收的数据
                for (int i = 0; i < bytesRead; i++)
                {
                    bytesData[bytesTemp.Length + i] = Convert.ToByte(serialPort.ReadByte());//read all data
                }

                for (int i = 0; i < bytesData.Length; i++)
                {
                    if ((bytesData[i] == 0xAA) && (bytesData[i + 2] == 0x0D))
                    {
                        result = bytesData[i + 1];
                        InPhotoelectric = result > 0x00 ? true : false;
                        i += 2;
                    }

                }
            };


            if (!port.IsOpen)
                port.Open();
        }

        public void SetLatticeScreen(string Message)
        {
            throw new NotImplementedException();
        }
    }

}
