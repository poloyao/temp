using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDemo.Model
{
    /// <summary>
    /// 检测项目
    /// </summary>
    public enum DetectionType
    {
        /// <summary>
        /// 外检
        /// </summary>
        Shape,
        /// <summary>
        /// 侧滑
        /// </summary>
        SideSlide,
        /// <summary>
        /// 速度
        /// </summary>
        Speed,
        /// <summary>
        /// 灯光
        /// </summary>
        Light,
        /// <summary>
        /// 制动
        /// </summary>
        Brake,
        /// <summary>
        /// 称重
        /// </summary>
        Weigh,
        /// <summary>
        /// 地盘
        /// </summary>
        bottom,
        /// <summary>
        /// 地盘间隙
        /// </summary>
        BoottomInterval,
        /// <summary>
        /// 声级计
        /// </summary>
        SoundLevel,
        /// <summary>
        /// 功率
        /// </summary>
        Power,
        /// <summary>
        /// 油耗
        /// </summary>
        FuelConsumption,
        /// <summary>
        /// 尾气
        /// </summary>
        Exhaust


    }
}
