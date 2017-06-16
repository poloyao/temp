using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using System.IO.Ports;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm.POCO;
using System.Threading;
using SimpleDemo.Model;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System.Configuration;
using SimpleDemo.Device;
using System.Linq;
using SimpleDemo.Common;
using YYLight;

namespace SimpleDemo.UI.ViewModels
{
    [POCOViewModel]
    public class TestViewModel
    {

        protected IDispatcherService dispatcherService { get { return this.GetService<IDispatcherService>(); } }
        public virtual int InPhotoelectric { get; set; }
        public int tempPhotoelctric;


        public virtual int TaskOnline { get; set; }
        
        public virtual string Data { get; set; }

        public virtual int TempData { get; set; }


        public virtual int InPhotoelectric2 { get; set; }
        public virtual int TaskOnline2 { get; set; }
        public virtual int TempData2 { get; set; }

        //SerialPort port = new SerialPort();

        ILightFlowBase yy;

        public TestViewModel()
        {
            //port.PortName = "COM1";
            //port.BaudRate = 9600;
            //port.DataBits = 8;
            //port.Parity = Parity.None;
            //port.StopBits = StopBits.One;

            yy = new YYLight.YYLight();

            //IUnityContainer mycontainer = new UnityContainer();

            //UnityConfigurationSection section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            //section.Configure(mycontainer);

            //yy = mycontainer.Resolve<ILightFlowBase>();
        }

        public void Close()
        {
            //if(port.IsOpen)
            //{
            //    port.Close();
            //}
            //cts.Cancel();

            //var port = yy.PortItems.SingleOrDefault(x => x.DeviceType == DeviceType.Photoelectric
            //     && x.DetectionType == DetectionType.Light);

            //var port = SerialPortHelp.GetDevicePort(DeviceType.Photoelectric, DetectionType.Light);

            //if (port.IsOpen)
            //{
            //    port.Close();
            //}
            SerialPortHelp.ClosePort(DeviceType.Photoelectric, DetectionType.Light);

            cts.Cancel();
        }

        CancellationTokenSource cts = new CancellationTokenSource();

        public void PhotoelectricInit()
        {


            cts = new CancellationTokenSource();
            var ct = cts.Token;


           

            Task task = new TaskFactory(ct).StartNew(() =>
            {
                yy.PhotoelectricOpen();
                while (true)
                {
                    if (ct.IsCancellationRequested)
                    {
                        break;
                    }

                    InPhotoelectric = yy.InPhotoelectric == true ? 2 : 0;

                    //InPhotoelectric = yy.GetInPhot() == true ? 1 : 0;
                    //Console.WriteLine("task-ok");
                    TaskOnline = 1;

                    if (yy.AllowGetData)
                    {
                        TempData = yy.GetLightData();
                    }

                   // ct.ThrowIfCancellationRequested();
                }

            });

            Task task2 = new TaskFactory(ct).StartNew(() =>
            {
                while(true)
                {
                    if (ct.IsCancellationRequested)
                    {
                        break;
                    }
                    TaskOnline2 = 1;
                    TempData2++;
                    System.Threading.Thread.Sleep(new Random(Guid.NewGuid().GetHashCode()).Next(0, 500));
                }
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


        public void TestSetting()
        {
            //var op = Common.SerialPortHelp.GetDevicePort(DeviceType.LatticeScreen, DetectionType.Light);
            //if (!op.IsOpen)
            //    op.Open();

            //var op2 = Common.SerialPortHelp.GetDevicePort(DeviceType.LatticeScreen, DetectionType.Light);
            //if (!op.IsOpen)
            //    op.Open();

            //var query = GetClass<Device.LightFlowBase>();
            //var query2 = Common.GlobalConfig.GetInstance().GetDynamicModule<Device.LightFlowBase>();

        }

        //public TBase GetClass<TBase>() where TBase : Device.CoreFlowBase
        //{
        //    //TBase t = default(TBase);
        //    //return t;
        //    YYLight sda = new YYLight();

        //    return (TBase)((object)sda);
        //}
    }
}