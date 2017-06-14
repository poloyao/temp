using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDemo.Device
{
    /// <summary>
    /// 设备的配置文件
    /// </summary>
    public abstract class  DeviceConfig 
    {
        /// <summary>
        /// 配置名称
        /// </summary>
        public abstract string ConfigName { get; set; }
        public abstract string Name { get; set; }
        public abstract string IPAddress { get; set; }

        public abstract string DeviceModel { get; set; }

        public abstract DeviceType? DeviceType { get; set; }

        public abstract string DeviceFctory { get; set; }
    }

    ///// <summary>
    ///// 配置文件
    ///// </summary>
    //public class ConfigInfo:DeviceConfig
    //{
    //    public string name { get; set; }
    //    public string IPAddress { get; set; }

    //    public string DeviceModel { get; set; }

    //    public DeviceType? DeviceType { get; set; }


    //    public string DeviceFctory { get; set; }
    //}
}
