using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopwatchApp
{
    class Stopwatch
    {
        public DateTime Time { get; set; }
        public bool IsWatchOn { get; set; } = false;

        public Stopwatch()
        {
            IsWatchOn = false;
        }

        public string Start()
        {
            if (IsWatchOn == false)
            {
                IsWatchOn = true;
                Time = DateTime.Now;
                string message = "Stopwatch started";

                return message;
            }

            else
            {
                return "Stopwatch is already started.";
            }

        }

        public string Stop()
        {
            if (IsWatchOn == true)
            {
                IsWatchOn = false;
                DateTime stopTime = DateTime.Now;
                TimeSpan duration = stopTime - Time;

                string message = "Time: " + duration.ToString(@"mm\:ss\.ff");

                return message;

            }
            else
            {
                return "The Stopwatch is not running. \n\nThe stop watch must be started first.";
            }
        }
    }
}
