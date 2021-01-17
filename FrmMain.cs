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

namespace StopwatchDesktopApp
{
    public partial class FrmMain : Form
    {
        private List<string> NotesList { get; set; }
        private Stopwatch Stopwatcher { get; set; } = null;
        private bool IsStopwatcherCounting { get; set; }
        private bool IsStopwatcherExists { get; set; }
        private double LastTotalHours { get; set; }

        public FrmMain()
        {
            InitializeComponent();

            IsStopwatcherExists = false;
            IsStopwatcherCounting = false;

            NotesList = new List<string>();
            listBoxNotes.DataSource = notesBindingSource;

            StartBackgroundWoker();
        }

        private async void StartBackgroundWoker()
        {
            do // infinity loop with interval
            {
                do  // no loop, executes one time per top level loop
                {
                    if (!IsStopwatcherExists || !IsStopwatcherCounting)
                        break;

                    UpdateTimeLabelsAppearance(Stopwatcher.Elapsed);
                } while (false);

                await Task.Delay(1000);
            } while (true);
        }
        private void UpdateTimeLabelsAppearance(TimeSpan elapsed)
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
            LastTotalHours = elapsed.TotalHours;

            UpdateCostAppearance();
        }
        private void UpdateCostAppearance()
        {
            var hourPrice = 0.0;
            try
            {
                hourPrice = Convert.ToDouble(tbxHourPrice.Text, NumberFormatInfo.InvariantInfo);
            }
            catch (Exception){}
            var hours = LastTotalHours;
            var cost = (hours * hourPrice);

            labelCost.Text = (cost > 0 ? cost : 0).ToString(@"0.##", CultureInfo.InvariantCulture);
        }

        private void listBoxNotes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.C)
            {
                string s = listBoxNotes.SelectedItem as string;
                if (s.Length > 0)
                {
                    Clipboard.SetData(DataFormats.StringFormat, s);
                    e.Handled = true;
                }
            }
            else if (e.KeyCode == Keys.Delete)
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

            btnStartStop.Text = IsStopwatcherCounting ? "Stop" : "Start";
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

        private void btnRestart_Click(object sender, EventArgs e)
        {
            IsStopwatcherExists = false;
            Stopwatcher = null;
            IsStopwatcherCounting = false;

            UpdateTimeLabelsAppearance(new TimeSpan());

            btnStartStop.Text = "Start";
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

            UpdateCostAppearance();
        }
    }
}
