using System;

namespace StopwatchDesktopApp.src
{
    class MyStopwatch
    {
        private TimeSpan Accumulation { get; set; }
        private DateTime StartTime { get; set; }
        private bool IsRunning { get; set; }

        public MyStopwatch()
        {
            StopAndReset();
        }

        public void StopAndReset()
        {
            Accumulation = new TimeSpan();
            StartTime = new DateTime();
            IsRunning = false;
        }

        public void Start()
        {
            if (IsRunning) return;
            StartTime = DateTime.Now;
            IsRunning = true;
        }

        public void Stop()
        {
            if (!IsRunning) return;
            Accumulation += DateTime.Now - StartTime;
            IsRunning = false;
        }

        public TimeSpan GetElapsed()
        {
            return IsRunning ? DateTime.Now - StartTime + Accumulation : Accumulation;
        }

        public bool GetIsRunning()
        {
            return IsRunning;
        }
    }
}
