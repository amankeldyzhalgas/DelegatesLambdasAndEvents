// <copyright file="Countdown.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TimerLibrary
{
    using System;
    using System.Threading;

    /// <summary>
    /// A Countdown class, which implements the capability after the appointed time.
    /// </summary>
    public class Countdown
    {
        /// <summary>
        /// Event when time over.
        /// </summary>
        public event EventHandler<TimerEventArgs> TimerIsOver = (sender, e) => { };

        /// <summary>
        /// Starts  countdown.
        /// </summary>
        /// <param name="timer">The amount of seconds.</param>
        public void TimerStart(int timer)
        {
            if (timer <= 0)
            {
                throw new ArgumentNullException($"{nameof(timer)} must ne positive number.");
            }

            Thread.Sleep(timer * 1000);
            this.OnTimerIsOver(new TimerEventArgs(timer, "Timer is over."));
        }

        private void OnTimerIsOver(TimerEventArgs e)
        {
            this.TimerIsOver(this, e);
        }
    }
}
