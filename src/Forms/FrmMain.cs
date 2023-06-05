using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopwatchDesktopApp.src.forms
{
    public partial class FrmMain : Form
    {
        #region Properties
        private const int WorkerIntervalLabels = 100;
        private const int WorkerIntervalSaveConfig = 2000;
        private const int CopiedNotificationTimeout = 400;
        private MyStopwatch Stopwatcher { get; set; } = new MyStopwatch();
        private StringsManager StringsManager { get; set; }
        private Config Config { get; set; }
        #endregion

        public FrmMain(Config config, StringsManager stringsManager)
        {
            InitializeComponent();

            Config = config;
            StringsManager = stringsManager;
            Size = new Size(MinimumSize.Width, Size.Height);

            labelNotifyText.Text = string.Empty;
            UpdateTimeLabelsText(Stopwatcher.GetElapsed());
            UpdateStrings();
            StartBackgroundWokerLabels();
            StartBackgroundWokerSaveConfig();
        }

        #region Methods
        private void UpdateStrings()
        {
            Text = StringsManager.GetString("stopwatch");
            btnStartStop.Text = Stopwatcher.GetIsRunning() ? StringsManager.GetString("stop") : StringsManager.GetString("start");
            btnRestart.Text = StringsManager.GetString("reset");
        }

        private async void StartBackgroundWokerSaveConfig()
        {
            while (true)
            {
                Config.SaveToFile();
                await Task.Delay(WorkerIntervalSaveConfig);
            }
        }

        private async void StartBackgroundWokerLabels()
        {
            while (true)
            {
                var iterationStartTime = DateTime.Now;

                if (Stopwatcher.GetIsRunning() && Form.ActiveForm == this)
                    UpdateTimeLabelsText(Stopwatcher.GetElapsed());


                var diff = (DateTime.Now - iterationStartTime).TotalMilliseconds;
                var timeToWait = Convert.ToInt32(Math.Max(WorkerIntervalLabels - diff, 1));

                await Task.Delay(timeToWait);
            }
        }

        private void UpdateTimeLabelsText(TimeSpan elapsed)
        {
            int totalMs = Convert.ToInt32(elapsed.TotalMilliseconds);
            int totalSecs = totalMs / 1000;

            var hh = totalSecs / 3600;
            var mm = totalSecs % 3600 / 60;
            var ss = totalSecs % 60;
            var afterSeconds = ((totalMs - totalSecs * 1000d) / 10);

            var f = "00";
            labelStopwatchTime.Text = $"{hh.ToString(f)}:{mm.ToString(f)}:{ss.ToString(f)}";
            labelTotalHours.Text = elapsed.TotalHours.ToString(@"0.0000");
            labelStopwatchTimeAfterSeconds.Text = $". {afterSeconds.ToString(f)}";
        }

        private void StartOrStopOrContinueStopwatcher()
        {
            if (Stopwatcher.GetIsRunning()) // Need to stop
                Stopwatcher.Stop();
            else // Need to continue
                Stopwatcher.Start();
        }
        #endregion

        #region Event handlers
        private void CopyTextToClipboardOnAnyLabelDoubleClick(object sender, EventArgs e)
        {
            var label = sender as Label;
            if (label == null) return;
            Clipboard.SetData(DataFormats.StringFormat, label.Text);
        }
        private void btnStartStop_Click(object sender, EventArgs e)
        {
            StartOrStopOrContinueStopwatcher();
            btnStartStop.Text = Stopwatcher.GetIsRunning()
                ? StringsManager.GetString("stop")
                : StringsManager.GetString("start");
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            Stopwatcher.StopAndReset();
            UpdateTimeLabelsText(Stopwatcher.GetElapsed());
            btnStartStop.Text = StringsManager.GetString("start");
        }
        #endregion

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!(Form.ActiveForm == this && keyData == (Keys.Control | Keys.C)))
                return base.ProcessCmdKey(ref msg, keyData);
            Clipboard.SetData(DataFormats.StringFormat, labelTotalHours.Text);
            labelNotifyText.Text = "Copied!";
            Task.Run(async () =>
            {
                await Task.Delay(CopiedNotificationTimeout);
                Invoke((MethodInvoker)delegate { labelNotifyText.Text = String.Empty; });
            });
            return true; // true == "mark event as handled"
        }
    }
}
