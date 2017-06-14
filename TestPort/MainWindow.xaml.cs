using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO.Ports;
using DevExpress.Xpf.Gauges;

namespace TestPort
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            comboBox.ItemsSource = System.Enum.GetValues(typeof(Parity));
            comboBox_Copy.ItemsSource = Enum.GetValues(typeof(StopBits));

            Binding bd = new Binding();
            bd.Mode = BindingMode.OneWay;
            bd.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            bd.Source = lampState;
            lampStateIndicatorControl.SetBinding(StateIndicatorControl.StateIndexProperty, bd);

        }


        public int lampState { get; set; } = 2;

        public List<Parity> parity = new List<Parity>();

        private void button_Click(object sender, RoutedEventArgs e)
        {
            SerialPort port = new SerialPort();
            port.PortName = textBox.Text;
            port.BaudRate = int.Parse(textBox_Copy.Text);
            port.Parity = Parity.None;//(Parity)Enum.Parse(typeof(Parity), comboBox.SelectedValue.ToString());
            //port.StopBits = StopBits.None;//(StopBits)Enum.Parse(typeof(StopBits), comboBox_Copy.SelectedValue.ToString());
            port.DataBits = int.Parse(textBox_Copy1.Text);

            port.DataReceived += Port_DataReceived;

            if (port.IsOpen)
            {

            }
            else
            {
                port.Open();
            }

        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
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
                    if ((result) > 0x00)
                    {

                    }
                    else
                    {
                        // boolLastTimeLogOn = false;
                    }

                    lampState = result > 0x00 ? 1 : 0;
                    i += 2;
                }

            }


        }


    }
}
