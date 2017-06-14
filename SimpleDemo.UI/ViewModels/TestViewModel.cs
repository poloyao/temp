using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using System.IO.Ports;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm.POCO;
using System.Threading;

namespace SimpleDemo.UI.ViewModels
{
    [POCOViewModel]
    public class TestViewModel
    {

        protected IDispatcherService dispatcherService { get { return this.GetService<IDispatcherService>(); } }
        public virtual int InPhotoelectric { get; set; }
        public int tempPhotoelctric;
        
        public virtual string Data { get; set; }
        SerialPort port = new SerialPort();

        public TestViewModel()
        {
            port.PortName = "COM1";
            port.BaudRate = 9600;
            port.DataBits = 8;
            port.Parity = Parity.None;
            port.StopBits = StopBits.One;
        }

        public void Close()
        {
            if(port.IsOpen)
            {
                port.Close();
            }
            cts.Cancel();
        }

        CancellationTokenSource cts = new CancellationTokenSource();

        public void PhotoelectricInit()
        {
            port.DataReceived += Photoelectric_DataReceived;
            if (!port.IsOpen)
            {
                port.Open();
            }
            cts = new CancellationTokenSource();
            var ct = cts.Token;
            var testPort = port.BytesToRead;
            if (testPort == 0)
            {
                //无返回数据，未通
                return;
            }
            

            Task task = new TaskFactory(ct).StartNew(() =>
            {
                while (port.IsOpen)
                {
                    InPhotoelectric = tempPhotoelctric;
                    ct.ThrowIfCancellationRequested();
                }

                InPhotoelectric = 3;
            });
        }

        private void Port_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {

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

            try
            {
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
                        dispatcherService.BeginInvoke(() =>
                        {
                            tempPhotoelctric = result > 0x00 ? 2 : 0;
                        });
                        
                        Data += ($"{bytesData[i].ToString("X2")} {bytesData[i + 1].ToString("X2")} {bytesData[i + 2].ToString("X2")} ");
                        i += 2;
                    }

                }
            }
            catch (Exception ex)
            {
                
            }

            
        }
    }
}