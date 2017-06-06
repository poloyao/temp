using SimpleDemo.Device;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XXLight
{
    /// <summary>
    /// XX型号的灯光设备
    /// </summary>
    public class XXLight : IDeviceLightBase<XXLightConfig>
    {
        public override string DeviceModel => "XKKSL";

        public override DeviceType? DeviceType => SimpleDemo.Device.DeviceType.Device4;
        
        public override string DeviceName => "XX型号的灯光设备";


        #region 重写

        public override bool GetCheckReuslut()
        {
            return base.GetCheckReuslut();
        }

        public override string GetLeftLight()
        {
            return base.GetLeftLight();
        }

        public override string GetRightLight()
        {
            return base.GetRightLight();
        }

        public override bool GetIsOnLine()
        {
            return base.GetIsOnLine();
        }

        #endregion
    }
    /// <summary>
    /// XXLight的配置文档
    /// </summary>
    public class XXLightConfig : DeviceConfig
    {
        public override string ConfigName
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override string DeviceFctory
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override string DeviceModel
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override DeviceType? DeviceType
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override string IPAddress
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override string Name
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
    

}

