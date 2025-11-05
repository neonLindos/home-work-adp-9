using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_adp_9.task1.types
{
    public interface IVolumeControl
    {
        public int MaxVolumeLevel { get; set; }
        public int CurrentVolumeLevel { get; set; }
        void SetVolume(int volumeLevel);
        void Mute();
        void Unmute();
        
    }
}
