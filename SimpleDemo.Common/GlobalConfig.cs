using SimpleDemo.Device;
using SimpleDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDemo.Common
{
    /// <summary>
    /// 全局配置文件访问
    /// </summary>
    public  class GlobalConfig
    {

        private static readonly GlobalConfig instance = new GlobalConfig();
        

        public static GlobalConfig GetInstance()
        {
            return instance;
        }
        private GlobalConfig()
        {

        }

        /// <summary>
        /// 根据泛型获取到动态加载的流程模块dll
        /// </summary>
        /// <typeparam name="TFlow"></typeparam>
        /// <returns></returns>
        public TFlowModule GetDynamicModule<TFlowModule>() where TFlowModule : ICoreFlowBase
        {
            TFlowModule module = default(TFlowModule);
            
            return module;
        }


        ///// <summary>
        ///// 获取大灯设置参数的克隆
        ///// </summary>
        ///// <returns></returns>
        //public LightSetting GetLightSetting()
        //{
        //    var result = new LightSetting();
        //    return result;
        //}

        //internal SettingBase GetXXSetting()
        //{
        //    var result = new LightSetting();
        //    result.LatticeScreen.PortName = "COM2";
        //    result.XX = "xx";
        //    return result;
        //}


    }
}
