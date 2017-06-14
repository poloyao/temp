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
        /// 获取大灯设置参数的克隆
        /// </summary>
        /// <returns></returns>
        public LightSetting GetLightSetting()
        {
            var result = new LightSetting();
            //result.LatticeScreen = PortIndex.COM8;
            //result.LightDevice = PortIndex.COM16;
            return result;
        }

    }
}
