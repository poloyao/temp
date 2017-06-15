using SimpleDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDemo.Device
{
    /// <summary>
    /// 流程基类
    /// </summary>
    public abstract class CoreFlowBase
    {
    }

    /// <summary>
    /// 大灯检测基类
    /// </summary>
    public abstract class LightFlowBase : CoreFlowBase
    {
        #region 属性

        
        /// <summary>
        /// 光电是否到位
        ///  待商议 特殊情况下，如前后2个光电的情况下，1.增加备选参数。2.改为数组
        /// </summary>
        public abstract bool InPhotoelectric { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public abstract bool InLight { get; set; }
        

        /// <summary>
        /// 大灯检测流程设备串口列表
        /// </summary>
        public abstract List<PortElement> PortItems { get; set; }


        #endregion


        #region 方法函数


        /// <summary>
        /// 设置点阵提示内容
        /// </summary>
        /// <param name="Message"></param>
        public abstract void SetLatticeScreen(string Message);
        /// <summary>
        /// 光电开启
        /// </summary>
        public abstract void PhotoelectricOpen();

        /// <summary>
        /// 大灯开启
        /// </summary>
        public abstract void LightOpen();

        /// <summary>
        /// 大灯关闭
        /// </summary>
        public abstract void LightClose();

        /// <summary>
        /// 获取大灯数据。
        /// ！！！！待商议
        /// </summary>
        public abstract void GetLightData();

        /// <summary>
        /// 设备复位
        /// </summary>
        public abstract void DeviceReset();

        #endregion

    }


 
}
