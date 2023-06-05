using System;

namespace StopwatchDesktopApp.src
{
    public class MyStopwatch
    {
        private MyStopwatchData Data = null;
        public MyStopwatch(MyStopwatchData data)
        {
            Data = data;
            Data.IsRunning = false;
            Data.FromTime = DateTime.Now;
        }

        public void StopAndReset()
        {
            Data.Accumulation = new TimeSpan();
            Data.FromTime = new DateTime();
            Data.IsRunning = false;
        }

        public void Start()
        {
            if (Data.IsRunning) return;
            Data.FromTime = DateTime.Now;
            Data.IsRunning = true;
        }

        public void Stop()
        {
            if (!Data.IsRunning) return;
            Data.Accumulation += DateTime.Now - Data.FromTime;
            Data.IsRunning = false;
        }

        public void Accumulate()
        {
            Data.Accumulation += DateTime.Now - Data.FromTime;
            Data.FromTime = DateTime.Now;
        }

        public TimeSpan GetElapsed()
        {
            return Data.IsRunning ? DateTime.Now - Data.FromTime + Data.Accumulation : Data.Accumulation;
        }

        public bool GetIsRunning()
        {
            return Data.IsRunning;
        }
    }
}
