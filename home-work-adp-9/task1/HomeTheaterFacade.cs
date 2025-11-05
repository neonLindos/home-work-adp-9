using home_work_adp_9.task1.device;
using System;

namespace home_work_adp_9.task1
{
    internal class HomeTheaterFacade
    {
        private readonly TV tv;
        private readonly AudioSystem audio;
        private readonly DVDPlayer dvd;
        private readonly GameConsole console;

        public HomeTheaterFacade(TV tv, AudioSystem audio, DVDPlayer dvd, GameConsole console)
        {
            this.tv = tv;
            this.audio = audio;
            this.dvd = dvd;
            this.console = console;
        }

        public void WatchMovie()
        {
            Console.WriteLine("\n=== Setting up Movie Mode ===");
            tv.Enable();
            audio.Enable();
            dvd.Enable();

            tv.SetChannel(3);
            audio.SetVolume(40);
            dvd.PlayDisc();

            Console.WriteLine("Movie mode ready. Enjoy!\n");
        }

        public void EndMovie()
        {
            Console.WriteLine("\n=== Shutting down Movie Mode ===");
            dvd.StopDisc();
            dvd.Disable();
            audio.Disable();
            tv.Disable();
        }

        public void PlayGame(string gameTitle)
        {
            Console.WriteLine("\n=== Setting up Game Mode ===");
            tv.Enable();
            audio.Enable();
            console.Enable();
            console.StartGame(gameTitle);
        }

        public void StopGame()
        {
            Console.WriteLine("\n=== Stopping Game Mode ===");
            console.StopGame();
            console.Disable();
            audio.Disable();
            tv.Disable();
        }

        public void ListenToMusic()
        {
            Console.WriteLine("\n=== Setting up Music Mode ===");
            tv.Enable();
            audio.Enable();
            audio.SetVolume(60);
            Console.WriteLine("Music mode ready.\n");
        }

        public void SetVolume(int volume)
        {
            audio.SetVolume(volume);
            tv.SetVolume(volume / 2); 
        }

        public void PowerOffAll()
        {
            Console.WriteLine("\n=== Powering off all devices ===");
            tv.Disable();
            audio.Disable();
            dvd.Disable();
            console.Disable();
        }
    }
}
