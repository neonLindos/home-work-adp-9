using home_work_adp_9.task1.types;
using System;

namespace home_work_adp_9.task1.device
{
    public class TV : IDevice, IVolumeControl
    {
        public DeviceState State { get; set; } = DeviceState.Off;
        public int MaxVolumeLevel { get; set; } = 100;
        public int CurrentVolumeLevel { get; set; } = 20;
        private bool isMuted = false;
        private int currentChannel = 1;

        public void Enable()
        {
            State = DeviceState.On;
            Console.WriteLine("TV is now ON.");
        }

        public void Disable()
        {
            State = DeviceState.Off;
            Console.WriteLine("TV is now OFF.");
        }

        public void SetVolume(int volumeLevel)
        {
            if (State == DeviceState.Off)
            {
                Console.WriteLine("TV is OFF. Cannot set volume.");
                return;
            }

            if (volumeLevel < 0) volumeLevel = 0;
            if (volumeLevel > MaxVolumeLevel) volumeLevel = MaxVolumeLevel;

            CurrentVolumeLevel = volumeLevel;
            isMuted = false;
            Console.WriteLine($"TV volume set to {CurrentVolumeLevel}.");
        }

        public void Mute()
        {
            isMuted = true;
            Console.WriteLine("TV muted.");
        }

        public void Unmute()
        {
            isMuted = false;
            Console.WriteLine("TV unmuted.");
        }

        public void SetChannel(int channel)
        {
            if (channel < 1)
            {
                Console.WriteLine("Invalid channel number.");
                return;
            }

            currentChannel = channel;
            Console.WriteLine($"TV channel set to {currentChannel}.");
        }
    }
}
