using System;

namespace stopwatch
{
    public class Stopwatch
    {
        private TimeSpan duration { get; set; }
        private readonly DateTime startTime = new DateTime();
        private DateTime stopTime { get; set; }

        

        public void Start()
        {
            this.startTime = DateTime.Now;
        }

        public void Stop()
        {
            this.stopTime = DateTime.Now;
        }

        public TimeSpan Duration()
        {
            this.duration = stopTime.Subtract(startTime);
            return this.duration;
        }

    }
}