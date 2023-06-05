using System;

namespace StopwatchDesktopApp.src
{
    [Serializable]
    public class MyStopwatchData
    {
        public TimeSpan Accumulation { get; set; } = new TimeSpan();
        public DateTime StartTime { get; set; } = new DateTime();
        public bool IsRunning { get; set; } = false;
    }

    public class MyStopwatch
    {
        private MyStopwatchData Data = null;
        public MyStopwatch(MyStopwatchData data)
        {
            Data = data;
            Data.IsRunning = false;
            Data.StartTime = DateTime.Now;
        }

        public void StopAndReset()
        {
            Data.Accumulation = new TimeSpan();
            Data.StartTime = new DateTime();
            Data.IsRunning = false;
        }

        public void Start()
        {
            if (Data.IsRunning) return;
            Data.StartTime = DateTime.Now;
            Data.IsRunning = true;
        }

        public void Stop()
        {
            if (!Data.IsRunning) return;
            Data.Accumulation += DateTime.Now - Data.StartTime;
            Data.IsRunning = false;
        }

        public void Accumulate()
        {
            Data.Accumulation += DateTime.Now - Data.StartTime;
            Data.StartTime = DateTime.Now;
        }

        public TimeSpan GetElapsed()
        {
            return Data.IsRunning ? DateTime.Now - Data.StartTime + Data.Accumulation : Data.Accumulation;
        }

        public bool GetIsRunning()
        {
            return Data.IsRunning;
        }
    }
}
