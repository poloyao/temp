using SimpleDemo.Device;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace XXLight
{
    /// <summary>
    /// XX型号的灯光设备
    /// </summary>
    public class XXLight : IDeviceLightBase<XXLightConfig>
    {
        public override string DeviceModel => "XKKSL";

        public override DeviceType? DeviceType => SimpleDemo.Device.DeviceType.Device4;

        public override string DeviceName => "XX型号的灯光设备";

        /// <summary>
        /// 光电到位
        /// </summary>
        public bool InPhotoelectric { get; set; }


        #region 重写

        public override bool GetCheckReuslut()
        {
            return base.GetCheckReuslut();
        }

        public override string GetLeftLight()
        {
            return base.GetLeftLight();
        }

        public override string GetRightLight()
        {
            return base.GetRightLight();
        }

        public override bool GetIsOnLine()
        {
            return base.GetIsOnLine();
        }

        #endregion

        /// <summary>
        /// 点阵提示
        /// </summary>
        /// <param name="message">内容</param>
        /// <returns></returns>
        public bool LatticeScreenDisplay(string message)
        {
            return true;
        }

        public void PhotoelectricInit()
        {
            SerialPort port = new SerialPort();
            port.PortName = "COM1";
            port.BaudRate = 9600;
            port.DataBits = 8;
            port.Parity = Parity.None;
            port.StopBits = StopBits.None;

            port.DataReceived += Photoelectric_DataReceived;

            if (!port.IsOpen)
            {
                port.Open();
            }
        }

        /// <summary>
        /// 光电到位接受事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Photoelectric_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var serialPort = sender as SerialPort;
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
        }



        /// <summary>
        /// 定位光源。
        /// </summary>
        /// <returns></returns>
        public bool GetLightSource()
        {
            return true;
        }

        /// <summary>
        /// 获取大灯检测回馈数据，内置设备检测处理
        /// </summary>
        public int GetLightData()
        {
            return 0;
        }

        /// <summary>
        /// 设备归位，复位
        /// </summary>
        public void InitDevice()
        {

        }


        public void Start()
        {
            if (InPhotoelectric)
            {
                if(GetLightSource())
                {
                    while (true)
                    {
                        var temp = GetLightData();
                        //模拟计算过程
                        if (1+1==0)
                        {
                            break;
                        }
                        else//错误
                        {
                            //判断是否是双灯同检
                            if (true)
                            {

                            }
                            else
                            {
                                LatticeScreenDisplay("检测失败");
                            }
                        }
                    }
                }

            }
            else
            {
                LatticeScreenDisplay("车辆未到位");
            }
        }



    }
    /// <summary>
    /// XXLight的配置文档
    /// </summary>
    public class XXLightConfig : DeviceConfig
    {
        public override string ConfigName
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override string DeviceFctory
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override string DeviceModel
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override DeviceType? DeviceType
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override string IPAddress
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override string Name
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
    
}

