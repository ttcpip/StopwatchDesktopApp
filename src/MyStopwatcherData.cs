using System;

namespace StopwatchDesktopApp.src
{
    [Serializable]
    public class MyStopwatchData
    {
        public TimeSpan Accumulation { get; set; } = new TimeSpan();
        public DateTime FromTime { get; set; } = new DateTime();
        public bool IsRunning { get; set; } = false;
    }
}
