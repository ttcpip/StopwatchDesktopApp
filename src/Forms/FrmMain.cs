using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopwatchDesktopApp.src.forms
{   
    public partial class FrmMain : Form
    {
        #region Properties
        private const int WorkerActiveIntervalLabels = 20;
        private const int WorkerInactiveIntervalLabels = 1000;
        private const int WorkerIntervalSaveConfig = 5000;
        private const int NotificationTimeout = 400;
        private MyStopwatch Stopwatcher { get; set; }
        private StringsManager StringsManager { get; set; }
        private Config Config { get; set; }
        #endregion

        public FrmMain(Config config, StringsManager stringsManager)
        {
            InitializeComponent();

            Config = config;
            Stopwatcher = new MyStopwatch(Config.MyStopwatchData);
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
                if (Stopwatcher.GetIsRunning())
                {
                    Stopwatcher.Accumulate();
                    Config.SaveToFile();
                }
                await Task.Delay(WorkerIntervalSaveConfig);
            }
        }

        private async void StartBackgroundWokerLabels()
        {
            while (true)
            {
                var iterationStartTime = DateTime.Now;

                if (Stopwatcher.GetIsRunning())
                    UpdateTimeLabelsText(Stopwatcher.GetElapsed());

                var intervalMs = ActiveForm == this ? WorkerActiveIntervalLabels : WorkerInactiveIntervalLabels;
                var diff = (DateTime.Now - iterationStartTime).TotalMilliseconds;
                var timeToWait = Convert.ToInt32(
                    Math.Max(intervalMs - diff, 1)
                );

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
        private void ResetHandler()
        {
            Stopwatcher.StopAndReset();
            UpdateTimeLabelsText(Stopwatcher.GetElapsed());
            btnStartStop.Text = StringsManager.GetString("start");

        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            ResetHandler();
        }
        #endregion

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            var isCopy = ActiveForm == this && keyData == (Keys.Control | Keys.C);
            var isReset = ActiveForm == this && keyData == (Keys.Control | Keys.R);
            var isClose = ActiveForm == this && keyData == (Keys.Control | Keys.Q);

            if (isCopy)
            {
                Clipboard.SetData(DataFormats.StringFormat, labelTotalHours.Text);
                labelNotifyText.Text = "Copied!";
            }
            if (isReset)
            {
                ResetHandler();
                labelNotifyText.Text = "Reset!";
            }
            if (isClose)
            {
                Close();
                return true;
            }

            if (isCopy || isReset)
            {
                Task.Run(async () =>
                {
                    await Task.Delay(NotificationTimeout);
                    Invoke((MethodInvoker)delegate { labelNotifyText.Text = String.Empty; });
                });
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Stopwatcher.Stop();
            Config.SaveToFile();
        }
    }
}
