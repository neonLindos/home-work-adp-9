using home_work_adp_9.task1.types;
using System;

namespace home_work_adp_9.task1.device
{
    public class DVDPlayer : IDevice
    {
        public DeviceState State { get; set; } = DeviceState.Off;
        private bool isPlaying = false;

        public void Enable()
        {
            State = DeviceState.On;
            Console.WriteLine("DVD Player turned ON.");
        }

        public void Disable()
        {
            State = DeviceState.Off;
            Console.WriteLine("DVD Player turned OFF.");
        }

        public void PlayDisc()
        {
            if (State == DeviceState.Off)
            {
                Console.WriteLine("Cannot play — DVD Player is OFF.");
                return;
            }

            isPlaying = true;
            Console.WriteLine("DVD is now playing.");
        }

        public void PauseDisc()
        {
            if (!isPlaying)
            {
                Console.WriteLine("Nothing to pause — DVD not playing.");
                return;
            }

            isPlaying = false;
            Console.WriteLine("DVD paused.");
        }

        public void StopDisc()
        {
            isPlaying = false;
            Console.WriteLine("DVD stopped.");
        }
    }
}
