using SimpleDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDemo.Device
{
    /// <summary>
    /// 基础设备接口
    /// </summary>
    public interface IDevice
    {
        string DeviceName { get; }
        string IPAddress { get; set; }
        DeviceType DeviceType { get; }
        string DeviceModel { get; }
        string DeviceFctory { get; set; }
        bool IsOnline { get; }
    }

    /// <summary>
    /// 设备抽象基类
    /// </summary>
    public abstract class IDeviceBase:IDevice
    {
        /// <summary>
        /// 设备名称
        /// </summary>
        public abstract string DeviceName { get; }

        /// <summary>
        /// IP地址
        /// </summary>
        public  string IPAddress { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        public abstract DeviceType DeviceType { get;}

        /// <summary>
        /// 设备型号
        /// </summary>
        public abstract string DeviceModel { get;  }

        /// <summary>
        /// 设备生产厂家
        /// </summary>
        public  string DeviceFctory { get; set; }
        
        /// <summary>
        /// 是否在线
        /// </summary>
        public abstract bool IsOnline { get; }

        
    }
    

    /// <summary>
    /// 设备类型枚举
    /// </summary>
    //public enum DeviceType
    //{
    //    /// <summary>
    //    /// 测速
    //    /// </summary>
    //    Device1,
    //    /// <summary>
    //    /// 测重
    //    /// </summary>
    //    Device2,
    //    /// <summary>
    //    /// 外廓
    //    /// </summary>
    //    Device3,
    //    /// <summary>
    //    /// 灯光
    //    /// </summary>
    //    Device4
    //}
    /// <summary>
    /// 测速基类
    /// </summary>
    public abstract class IDeviceSpeedBase : IDeviceBase
    {

    }
    /// <summary>
    /// 测重基类
    /// </summary>
    public abstract class IDeviceWeightBase : IDeviceBase
    {

    }
    /// <summary>
    /// 外廓基类
    /// </summary>
    public abstract class IDeviceProfileBase : IDeviceBase
    { }

    /// <summary>
    /// 灯光基类
    /// 获取数据方法可重写，默认使用common获取
    /// </summary>
    /// <typeparam name="TConfig">配置文件</typeparam>
    public abstract class IDeviceLightBase<TConfig> : IDeviceBase where TConfig :  DeviceConfig
    {

        public TConfig config { get; set; }

        /// <summary>
        /// 检测最少时间
        /// </summary>
        public string CheckMinTime { get; set; } 

        /// <summary>
        /// 检测方式 应为枚举形式
        /// </summary>
        public string CheckType { get; set; }

        public override bool IsOnline => GetIsOnLine();

        public virtual bool GetIsOnLine()
        {
            TConfig query = default(TConfig);
            return true;//LightOperationHelper.GetIsOnLine(); 
        }

        /// <summary>
        /// 获取检测结果
        /// </summary>
        /// <returns></returns>
        public virtual bool GetCheckReuslut()
        {
            return true;//LightOperationHelper.GetCheckReuslut();
        }

        /// <summary>
        /// 获取左侧灯光信息
        /// </summary>
        /// <returns></returns>
        public virtual string GetLeftLight()
        {
            return "";//LightOperationHelper.GetLeftLight();
        }
        /// <summary>
        /// 获取右侧灯光信息
        /// </summary>
        /// <returns></returns>
        public virtual string GetRightLight()
        {
            return "";//LightOperationHelper.GetRightLight();
        }




    }
    

}
