using SimpleDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDemo.Device
{
    /// <summary>
    /// 流程基础接口
    /// </summary>
    public interface ICoreFlowBase
    {
    }

    /// <summary>
    /// 大灯检测接口
    /// </summary>
    public interface ILightFlowBase : ICoreFlowBase
    {
        #region 属性


        /// <summary>
        /// 光电是否到位
        ///  待商议 特殊情况下，如前后2个光电的情况下，1.增加备选参数。2.改为数组
        /// </summary>
        bool InPhotoelectric { get; set; }
        /// <summary>
        /// 
        /// </summary>
        bool InLight { get; set; }


        /// <summary>
        /// 大灯检测流程设备串口列表
        /// </summary>
        List<PortElement> PortItems { get; set; }


        #endregion


        #region 方法函数
        /// <summary>
        /// 传入车籍信息
        /// </summary>
        /// <param name="carBookInfo"></param>
        void SetCarBookInfo(string carBookInfo);
        /// <summary>
        /// 开启检测
        /// </summary>
        void DetectionStart();
        /// <summary>
        /// 设置点阵提示内容
        /// </summary>
        /// <param name="Message"></param>
        void SetLatticeScreen(string Message);
        /// <summary>
        /// 光电开启
        /// </summary>
        void PhotoelectricOpen();

        /// <summary>
        /// 大灯开启
        /// </summary>
        void LightOpen();

        /// <summary>
        /// 大灯关闭
        /// </summary>
        void LightClose();

        /// <summary>
        /// 获取大灯数据。
        /// ！！！！待商议
        /// </summary>
        void GetLightData();

        /// <summary>
        /// 设备复位
        /// </summary>
        void DeviceReset();

        #endregion

    }



}
