using System;
using TimerLibrary;

namespace ConsoleClient.Classes
{
    public class Clock
    {
        public void Register(Countdown countdown)
        {
            countdown.TimerIsOver += ShowMessage;
        }
        public void Unregister(Countdown countdown)
        {
            countdown.TimerIsOver -= ShowMessage;
        }

        private void ShowMessage(object sender, TimerEventArgs e)
        {
            Console.WriteLine($"Class {this.GetType()}. {e}");
        }
    }
}
