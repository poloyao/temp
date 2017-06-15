using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.IO.Ports;

namespace SimpleDemo.Model
{
    ///// <summary>
    ///// 串口设置参数
    ///// </summary>
    //public class SettingPortModelTemp
    //{
    //    /// <summary>
    //    /// 点阵屏
    //    /// </summary>
    //    public PortIndex? LatticeScreen { get; set; }

    //    /// <summary>
    //    /// 灯光检测
    //    /// </summary>
    //    public PortIndex LightDevice { get; set; }

    //    /// <summary>
    //    /// 光电
    //    /// </summary>
    //    public PortIndex Photoelectric { get; set; }


    //    public string Name { get; set; }

    //    /// <summary>
    //    /// 自定义类型
    //    /// </summary>
    //    public SettingPortType ParamType { get; set; }




    //}

    ///// <summary>
    ///// 串口设置参数
    ///// </summary>
    //public class SettingPortModel
    //{
    //    public string Name { get; set; }

    //    /// <summary>
    //    /// 类型
    //    /// </summary>
    //    public SettingPortType ParamType { get; set; }
    //    /// <summary>
    //    /// 值
    //    /// </summary>
    //    public object Value { get; set; }

    //}

    ///// <summary>
    ///// 类型枚举
    ///// </summary>
    //public enum SettingPortType
    //{
    //    /// <summary>
    //    /// COM模式
    //    /// </summary>
    //    ComType,
    //    /// <summary>
    //    /// 文本模式
    //    /// </summary>
    //    TextType,
    //    /// <summary>
    //    /// 协议模式，例如显示厂家名
    //    /// </summary>
    //    ProtocolType
    //}



    public class DeviceElement
    {
        /// <summary>
        /// 协议类型
        /// </summary>
        [Display(Name = "协议类型", Order = 99)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [Display(Name = "设备类型")]
        public DeviceType DeviceType { get; set; }

        /// <summary>
        /// 检测项目
        /// </summary>
        [Display(Name = "检测项目")]
        public DetectionType DetectionType { get; set; }

        /// <summary>
        /// 编号。用于区分同一工位或流程中出现的同款设备
        /// </summary>
        [Display(Name = "编号", Description = "用于区分同一工位或流程中出现的同款设备")]
        public int Index { get; set; }

    }

    public class PortElement: SerialPort
    {
        //[Display(Name = "端口")]
        //public PortIndex PortName { get; set; }
        //[Display(Name = "波特率")]
        //public int BaudRate { get; set; }
        //[Display(Name = "数据位")]
        //public int DataBits { get; set; }
        //[Display(Name = "奇偶校验")]
        //public Parity Parity { get; set; }
        //[Display(Name = "停止位")]
        //public StopBits StopBits { get; set; }

        /// <summary>
        /// 协议类型
        /// </summary>
        [Display(Name = "协议类型", Order = 99)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [Display(Name = "设备类型")]
        public DeviceType DeviceType { get; set; }

        /// <summary>
        /// 检测项目
        /// </summary>
        [Display(Name = "检测项目")]
        public DetectionType DetectionType { get; set; }

        /// <summary>
        /// 编号。用于区分同一工位或流程中出现的同款设备
        /// </summary>
        [Display(Name = "编号", Description = "用于区分同一工位或流程中出现的同款设备")]
        public int Index { get; set; }

        /// <summary>
        /// 设备在线清空
        /// </summary>
        public bool IsOnline { get; set; }

    }


    //public class SettingBase
    //{
    //    public string SettingName { get; set; }

    //    public List<PortElement> PortList { get; set; } = new List<PortElement>();

    //}





    ///// <summary>
    ///// 大灯检测配置参数
    ///// </summary>
    //[MetadataType(typeof(LightSettingLayoutMetadata))]
    //public class LightSetting:SettingBase
    //{
    //    const string GName = "大灯";
    //    /// <summary>
    //    /// 灯屏
    //    /// </summary>
    //    [Display(Name = "灯屏", GroupName = GName)]
    //    public PortElement LatticeScreen { get; set; } = new PortElement();
    //    /// <summary>
    //    /// 大灯
    //    /// </summary>
    //    [Display(Name = "大灯", GroupName = GName)]
    //    public PortElement LightDevice { get; set; } = new PortElement();

    //    /// <summary>
    //    /// 光电
    //    /// </summary>
    //    [Display(Name = "光电", GroupName = GName)]
    //    public PortElement Photoelectric { get; set; } = new PortElement();


    //    public string XX { get; set; }
    //    /// <summary>
    //    /// 协议类型
    //    /// </summary>
    //    //[Display(Name = "协议类型", GroupName = GName)]
    //    //public string ProtocolType { get; set; }



    //}

    //public static class LightSettingLayoutMetadata
    //{
    //    public static void BuildMetadata(MetadataBuilder<LightSetting> builder)
    //    {
    //        builder.DataFormLayout()
    //            .GroupBox("大灯参数", Orientation.Vertical)
    //            .ContainsProperty(x => x.LatticeScreen)
    //            .ContainsProperty(x => x.LightDevice)
    //            .ContainsProperty(x => x.Photoelectric);
    //    }
    //}



   



}
