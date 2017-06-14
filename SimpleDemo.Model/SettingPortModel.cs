﻿using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SimpleDemo.Model
{
    /// <summary>
    /// 串口设置参数
    /// </summary>
    public class SettingPortModelTemp
    {
        /// <summary>
        /// 点阵屏
        /// </summary>
        public PortIndex? LatticeScreen { get; set; }

        /// <summary>
        /// 灯光检测
        /// </summary>
        public PortIndex LightDevice { get; set; }

        /// <summary>
        /// 光电
        /// </summary>
        public PortIndex Photoelectric { get; set; }


        public string Name { get; set; }

        /// <summary>
        /// 自定义类型
        /// </summary>
        public SettingPortType ParamType { get; set; }

        


    }

    /// <summary>
    /// 串口设置参数
    /// </summary>
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


    /// <summary>
    /// 大灯检测配置参数
    /// </summary>
    [MetadataType(typeof(LightSettingLayoutMetadata))]
    public class LightSetting
    {
        /// <summary>
        /// 灯屏
        /// </summary>
        [Display(Name = "灯屏")]
        public PortIndex LatticeScreen { get; set; }
        /// <summary>
        /// 大灯
        /// </summary>
        [Display(Name = "大灯")]
        public PortIndex LightDevice { get; set; }

        /// <summary>
        /// 光电
        /// </summary>
        [Display(Name = "光电")]
        public PortIndex Photoelectric { get; set; }

        /// <summary>
        /// 协议类型
        /// </summary>
        [Display(Name = "协议类型")]
        public string ProtocolType { get; set; }
    }

    public static class LightSettingLayoutMetadata
    {
        public static void BuildMetadata(MetadataBuilder<LightSetting> builder)
        {
            builder.DataFormLayout()
                .GroupBox("大灯参数", Orientation.Vertical)
                .ContainsProperty(x => x.LatticeScreen)
                .ContainsProperty(x => x.LightDevice)
                .ContainsProperty(x => x.Photoelectric)
                .ContainsProperty(x => x.ProtocolType);
                              
        }
    }

}