// <copyright file="TimerEventArgs.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TimerLibrary
{
    using System;

    /// <summary>
    /// .
    /// </summary>
    public class TimerEventArgs : EventArgs
    {
        private int Value { get; set; }

        private string Message { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimerEventArgs"/> class.
        /// </summary>
        /// <param name="value">The secunds.</param>
        /// <param name="message">The message.</param>
        public TimerEventArgs(int value, string message)
        {
            this.Value = value;
            this.Message = message;
        }

        /// <summary>
        /// The method returns a string representation of the object.
        /// </summary>
        /// <returns>.</returns>
        public override string ToString()
        {
            return $"{this.Message} {this.Value} seconds passed";
        }
    }
}
