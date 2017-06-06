using SimpleDemo.Device;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YYLight
{
    /// <summary>
    /// YY型号的灯光设备
    /// </summary>
    public class YYLight : IDeviceLightBase
    {
        public override string DeviceModel => "KKhe948";

        public override DeviceType? DeviceType => SimpleDemo.Device.DeviceType.Device4;

        public override string DeviceName => "YY型号的灯光设备";

    }
}
