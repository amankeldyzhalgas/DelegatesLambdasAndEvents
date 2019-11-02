using ConsoleClient.Classes;
using System;
using TimerLibrary;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            Timer timer = new Timer();
            Countdown countdown = new Countdown();

            clock.Register(countdown);
            timer.Register(countdown);

            countdown.TimerStart(10);
            Console.ReadKey();
        }
    }
}
