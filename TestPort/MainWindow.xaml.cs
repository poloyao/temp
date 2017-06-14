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
          

        }
    }

    public class MainVM
    {

        public List<SettingPortModel> Data { get; set; } = new List<SettingPortModel>();

        public MainVM()
        {
            Data.Add(new SettingPortModel() { Name = "aaaa", ParamType = SettingPortType.ComType, Value = "COM1" });
            Data.Add(new SettingPortModel() { Name = "bbb", ParamType = SettingPortType.ComType, Value = "COM2" });
            Data.Add(new SettingPortModel() { Name = "ccc", ParamType = SettingPortType.ComType, Value = "COM3" });
        }


    }

    public class SettingPortModel
    {
        public string Name { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public SettingPortType ParamType { get; set; }
        /// <summary>
        /// 值
        /// </summary>
        public object Value { get; set; }

    }

    /// <summary>
    /// 类型枚举
    /// </summary>
    public enum SettingPortType
    {
        /// <summary>
        /// COM模式
        /// </summary>
        ComType,
        /// <summary>
        /// 文本模式
        /// </summary>
        TextType,
        /// <summary>
        /// 协议模式，例如显示厂家名
        /// </summary>
        ProtocolType
    }

}
