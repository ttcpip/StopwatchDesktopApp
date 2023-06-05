namespace StopwatchDesktopApp.src.forms
{
    partial class FrmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelStopwatchTime = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.labelTotalHours = new System.Windows.Forms.Label();
            this.labelStopwatchTimeAfterSeconds = new System.Windows.Forms.Label();
            this.labelNotifyText = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStopwatchTime
            // 
            this.labelStopwatchTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelStopwatchTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStopwatchTime.Location = new System.Drawing.Point(3, 6);
            this.labelStopwatchTime.Name = "labelStopwatchTime";
            this.labelStopwatchTime.Size = new System.Drawing.Size(363, 48);
            this.labelStopwatchTime.TabIndex = 0;
            this.labelStopwatchTime.Text = "00:00:00";
            this.labelStopwatchTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStopwatchTime.DoubleClick += new System.EventHandler(this.CopyTextToClipboardOnAnyLabelDoubleClick);
            // 
            // btnStartStop
            // 
            this.btnStartStop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStartStop.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnStartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartStop.Location = new System.Drawing.Point(13, 94);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(161, 34);
            this.btnStartStop.TabIndex = 1;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRestart.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Location = new System.Drawing.Point(192, 94);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(161, 34);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.Text = "Reset";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // labelTotalHours
            // 
            this.labelTotalHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTotalHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalHours.Location = new System.Drawing.Point(138, 55);
            this.labelTotalHours.Name = "labelTotalHours";
            this.labelTotalHours.Size = new System.Drawing.Size(91, 38);
            this.labelTotalHours.TabIndex = 5;
            this.labelTotalHours.Text = "0.1234";
            this.labelTotalHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTotalHours.DoubleClick += new System.EventHandler(this.CopyTextToClipboardOnAnyLabelDoubleClick);
            // 
            // labelStopwatchTimeAfterSeconds
            // 
            this.labelStopwatchTimeAfterSeconds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelStopwatchTimeAfterSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStopwatchTimeAfterSeconds.Location = new System.Drawing.Point(274, 27);
            this.labelStopwatchTimeAfterSeconds.Name = "labelStopwatchTimeAfterSeconds";
            this.labelStopwatchTimeAfterSeconds.Size = new System.Drawing.Size(87, 33);
            this.labelStopwatchTimeAfterSeconds.TabIndex = 12;
            this.labelStopwatchTimeAfterSeconds.Text = ". 123";
            this.labelStopwatchTimeAfterSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNotifyText
            // 
            this.labelNotifyText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNotifyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNotifyText.Location = new System.Drawing.Point(12, 53);
            this.labelNotifyText.Name = "labelNotifyText";
            this.labelNotifyText.Size = new System.Drawing.Size(105, 38);
            this.labelNotifyText.TabIndex = 13;
            this.labelNotifyText.Text = "Copied!";
            this.labelNotifyText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.labelNotifyText);
            this.panelTop.Controls.Add(this.labelStopwatchTimeAfterSeconds);
            this.panelTop.Controls.Add(this.labelTotalHours);
            this.panelTop.Controls.Add(this.btnRestart);
            this.panelTop.Controls.Add(this.btnStartStop);
            this.panelTop.Controls.Add(this.labelStopwatchTime);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(361, 120);
            this.panelTop.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 120);
            this.Controls.Add(this.panelTop);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(383, 176);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(383, 176);
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stopwatch";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelStopwatchTime;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label labelTotalHours;
        private System.Windows.Forms.Label labelStopwatchTimeAfterSeconds;
        private System.Windows.Forms.Label labelNotifyText;
        private System.Windows.Forms.Panel panelTop;
    }
}

