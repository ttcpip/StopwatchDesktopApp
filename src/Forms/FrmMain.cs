using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;

namespace StopwatchDesktopApp.src.forms
{
    public partial class FrmMain : Form
    {
        #region Properties
        private List<string> NotesList { get; set; } = new List<string>();
        private Stopwatch Stopwatcher { get; set; } = null;
        private bool IsStopwatcherCounting { get; set; } = false;
        private bool IsStopwatcherExists { get; set; } = false;
        private double LastTotalHours { get; set; }
        private StringsManager StringsManager { get; set; }
        #endregion

        public FrmMain(StringsManager stringsManager)
        {
            InitializeComponent();

            Size = new Size(MinimumSize.Width, Size.Height);

            tbxHourPrice.Text = Constants.DEFAULT_HOUR_PRICE.ToString();

            StringsManager = stringsManager;
            listBoxNotes.DataSource = notesBindingSource;

            //MessageBox.Show("Current: " + StringsManager.GetString("langStringKey"));

            //StringsManager.SetLang(Language.English);
            //MessageBox.Show("En: " + StringsManager.GetString("langStringKey"));
            //StringsManager.SetLang(Language.Russian);
            //MessageBox.Show("Ru: " + StringsManager.GetString("langStringKey"));

            UpdateStrings();
            StartBackgroundWoker();
        }

        #region Methods
        private void UpdateStrings()
        {
            Text = StringsManager.GetString("stopwatch");

            languageToolStripMenuItem.Text = StringsManager.GetString("language");

            labelTextMinutes.Text = StringsManager.GetString("minutes:");
            labelTextHours.Text = StringsManager.GetString("hours:");
            labelTextNotes.Text = StringsManager.GetString("notes:");
            labelTextFinalCost.Text = StringsManager.GetString("finalCost:");
            labelTextHourPrice.Text = StringsManager.GetString("hourPirce:");

            btnStartStop.Text = IsStopwatcherCounting ? StringsManager.GetString("stop") : StringsManager.GetString("start");
            btnRestart.Text = StringsManager.GetString("reset");
            btnNote.Text = StringsManager.GetString("note");
        }
        private async void StartBackgroundWoker()
        {
            do // infinity loop with interval
            {
                var iterationStartTime = DateTime.Now;

                WorkerTick();

                var iterationEndTime = DateTime.Now;
                var diff = (iterationEndTime - iterationStartTime).TotalMilliseconds;
                var timeToWait = Convert.ToInt32(Math.Max(Constants.WORKER_WAIT_INTERVAL - diff, 0));

                await Task.Delay(timeToWait);
            } while (true);
        }
        
        private void WorkerTick()
        {
            if (!IsStopwatcherExists || !IsStopwatcherCounting)
                return;

            LastTotalHours = Stopwatcher.Elapsed.TotalHours;
            UpdateTimeLabelsText(Stopwatcher.Elapsed);
            UpdateCostLabelText();
        }
        private void UpdateTimeLabelsText(TimeSpan elapsed)
        {
            var seconds = elapsed.TotalSeconds;

            var _ss = Convert.ToInt32(Math.Floor(seconds % 60));
            var _mm = Convert.ToInt32(Math.Floor(seconds % 3600 / 60));
            var _hh = Convert.ToInt32(Math.Floor(seconds / 3600));

            var ss = _ss > 9 ? $"{_ss}" : $"0{_ss}";
            var mm = _mm > 9 ? $"{_mm}" : $"0{_mm}";
            var hh = _hh > 9 ? $"{_hh}" : $"0{_hh}";

            labelStopwatchTime.Text = $"{hh}:{mm}:{ss}";
            labelTotalMinutes.Text = elapsed.TotalMinutes.ToString(@"0.##", CultureInfo.InvariantCulture);
            labelTotalHours.Text = elapsed.TotalHours.ToString(@"0.####", CultureInfo.InvariantCulture);
        }
        private void UpdateCostLabelText()
        {
            var hourPrice = 0.0;
            try
            {
                hourPrice = Convert.ToDouble(tbxHourPrice.Text, NumberFormatInfo.InvariantInfo);
            }
            catch (Exception){}
            var hours = LastTotalHours;
            var cost = hours * hourPrice;

            labelCost.Text = cost.ToString(@"0.##", CultureInfo.InvariantCulture);
        }
        private void UpdateCostLabelText(double cost)
        {
            labelCost.Text = cost.ToString(@"0.##", CultureInfo.InvariantCulture);
        }
        private void StartOrStopOrContinueStopwatcher()
        {
            if (IsStopwatcherExists)
            {
                if (IsStopwatcherCounting) // need to stop
                {
                    Stopwatcher.Stop();
                    IsStopwatcherCounting = false;
                }
                else // need to continue
                {
                    Stopwatcher.Start();
                    IsStopwatcherCounting = true;
                }
            }
            else // need to start new stopwatch
            {
                Stopwatcher = Stopwatch.StartNew();
                IsStopwatcherExists = true;
                IsStopwatcherCounting = true;
            }
        }
        #endregion

        #region Event handlers
        private void listBoxNotes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.C) // Copy selected item
            {
                string s = listBoxNotes.SelectedItem as string;
                if (s.Length > 0)
                {
                    Clipboard.SetData(DataFormats.StringFormat, s);
                    e.Handled = true;
                }
            }
            else if (e.KeyCode == Keys.Delete) // Delete selected item
            {
                if (listBoxNotes.SelectedIndex > -1)
                {
                    NotesList.RemoveAt(listBoxNotes.SelectedIndex);
                    notesBindingSource.DataSource = new BindingList<string>(NotesList);
                    e.Handled = true;
                }
            }
        }
        private void CopyTextToClipboardOnAnyLabelDoubleClick(object sender, EventArgs e)
        {
            var label = sender as Label;
            if (label == null)
                return;
            Clipboard.SetData(DataFormats.StringFormat, label.Text);
        }
        private void btnStartStop_Click(object sender, EventArgs e)
        {
            StartOrStopOrContinueStopwatcher();

            btnStartStop.Text = IsStopwatcherCounting ? StringsManager.GetString("stop") : StringsManager.GetString("start");
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            IsStopwatcherExists = false;
            Stopwatcher = null;
            IsStopwatcherCounting = false;

            UpdateTimeLabelsText(new TimeSpan());
            UpdateCostLabelText(0.0);

            btnStartStop.Text = StringsManager.GetString("start");
        }
        private void btnNote_Click(object sender, EventArgs e)
        {
            var addInfo = tbxNoteText.Text.Length > 0 ? " " + tbxNoteText.Text : "";
            var note = $"{NotesList.Count + 1}. {labelStopwatchTime.Text}{addInfo}";

            NotesList.Add(note);
            listBoxNotes.Focus();
            tbxNoteText.Text = "";
            notesBindingSource.DataSource = new BindingList<string>(NotesList);
        }
        private void tbxHourPrice_TextChanged(object sender, EventArgs e)
        {
            tbxHourPrice.Text = Regex.Match(tbxHourPrice.Text.Trim(), @"[0-9\.]+").Value;

            UpdateCostLabelText();
        }
        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringsManager.SetLang(Language.English);
            UpdateStrings();
        }
        private void русскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringsManager.SetLang(Language.Russian);
            UpdateStrings();
        }
        #endregion
    }
}
