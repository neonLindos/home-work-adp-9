using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_adp_9.task1.types
{
    public enum DeviceState
    {
        On,
        Off,
    }
    public interface IDevice
    {
        DeviceState State { get; set; }

        void Enable();
        void Disable();
    }
}
