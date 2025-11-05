using home_work_adp_9.task1.types;
using System;

namespace home_work_adp_9.task1.device
{
    public class GameConsole : IDevice
    {
        public DeviceState State { get; set; } = DeviceState.Off;
        private bool gameRunning = false;

        public void Enable()
        {
            State = DeviceState.On;
            Console.WriteLine("Game console powered ON.");
        }

        public void Disable()
        {
            State = DeviceState.Off;
            Console.WriteLine("Game console powered OFF.");
        }

        public void StartGame(string gameTitle)
        {
            if (State == DeviceState.Off)
            {
                Console.WriteLine("Cannot start game — console is OFF.");
                return;
            }

            gameRunning = true;
            Console.WriteLine($"Starting game: {gameTitle}");
        }

        public void StopGame()
        {
            if (!gameRunning)
            {
                Console.WriteLine("No game is running.");
                return;
            }

            gameRunning = false;
            Console.WriteLine("Game stopped.");
        }
    }
}
