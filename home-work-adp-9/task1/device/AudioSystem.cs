using home_work_adp_9.task1.types;
using System;

namespace home_work_adp_9.task1.device
{
    public class AudioSystem : IDevice, IVolumeControl
    {
        public DeviceState State { get; set; } = DeviceState.Off;
        public int MaxVolumeLevel { get; set; } = 100;
        public int CurrentVolumeLevel { get; set; } = 50;
        private bool isMuted = false;

        public void Enable()
        {
            State = DeviceState.On;
            Console.WriteLine("Audio system enabled.");
        }

        public void Disable()
        {
            State = DeviceState.Off;
            Console.WriteLine("Audio system disabled.");
        }

        public void SetVolume(int volumeLevel)
        {
            if (State == DeviceState.Off)
            {
                Console.WriteLine("Audio system is OFF. Cannot set volume.");
                return;
            }

            if (volumeLevel < 0) volumeLevel = 0;
            if (volumeLevel > MaxVolumeLevel) volumeLevel = MaxVolumeLevel;

            CurrentVolumeLevel = volumeLevel;
            isMuted = false;
            Console.WriteLine($"Audio system volume set to {CurrentVolumeLevel}.");
        }

        public void Mute()
        {
            isMuted = true;
            Console.WriteLine("Audio system muted.");
        }

        public void Unmute()
        {
            isMuted = false;
            Console.WriteLine("Audio system unmuted.");
        }
    }
}
