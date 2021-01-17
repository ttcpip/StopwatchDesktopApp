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
            this.components = new System.ComponentModel.Container();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.tbxHourPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotalHours = new System.Windows.Forms.Label();
            this.labelTotalMinutes = new System.Windows.Forms.Label();
            this.btnNote = new System.Windows.Forms.Button();
            this.tbxNoteText = new System.Windows.Forms.TextBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.labelStopwatchTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxNotes = new System.Windows.Forms.ListBox();
            this.notesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Controls.Add(this.labelCost);
            this.panelTop.Controls.Add(this.tbxHourPrice);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.labelTotalHours);
            this.panelTop.Controls.Add(this.labelTotalMinutes);
            this.panelTop.Controls.Add(this.btnNote);
            this.panelTop.Controls.Add(this.tbxNoteText);
            this.panelTop.Controls.Add(this.btnRestart);
            this.panelTop.Controls.Add(this.btnStartStop);
            this.panelTop.Controls.Add(this.labelStopwatchTime);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(376, 233);
            this.panelTop.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(205, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 38);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cost:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCost
            // 
            this.labelCost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCost.Location = new System.Drawing.Point(258, 187);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(118, 38);
            this.labelCost.TabIndex = 9;
            this.labelCost.Text = "0";
            this.labelCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelCost.DoubleClick += new System.EventHandler(this.CopyTextToClipboardOnAnyLabelDoubleClick);
            // 
            // tbxHourPrice
            // 
            this.tbxHourPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.5F);
            this.tbxHourPrice.Location = new System.Drawing.Point(13, 189);
            this.tbxHourPrice.MaxLength = 20;
            this.tbxHourPrice.Name = "tbxHourPrice";
            this.tbxHourPrice.Size = new System.Drawing.Size(161, 34);
            this.tbxHourPrice.TabIndex = 8;
            this.tbxHourPrice.Text = "850";
            this.tbxHourPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxHourPrice.TextChanged += new System.EventHandler(this.tbxHourPrice_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(205, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hours:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Minutes:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTotalHours
            // 
            this.labelTotalHours.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTotalHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTotalHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalHours.Location = new System.Drawing.Point(285, 68);
            this.labelTotalHours.Name = "labelTotalHours";
            this.labelTotalHours.Size = new System.Drawing.Size(91, 38);
            this.labelTotalHours.TabIndex = 5;
            this.labelTotalHours.Text = "0";
            this.labelTotalHours.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelTotalHours.DoubleClick += new System.EventHandler(this.CopyTextToClipboardOnAnyLabelDoubleClick);
            // 
            // labelTotalMinutes
            // 
            this.labelTotalMinutes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTotalMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalMinutes.Location = new System.Drawing.Point(84, 68);
            this.labelTotalMinutes.Name = "labelTotalMinutes";
            this.labelTotalMinutes.Size = new System.Drawing.Size(94, 38);
            this.labelTotalMinutes.TabIndex = 5;
            this.labelTotalMinutes.Text = "0";
            this.labelTotalMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelTotalMinutes.DoubleClick += new System.EventHandler(this.CopyTextToClipboardOnAnyLabelDoubleClick);
            // 
            // btnNote
            // 
            this.btnNote.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNote.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNote.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNote.Location = new System.Drawing.Point(209, 149);
            this.btnNote.Name = "btnNote";
            this.btnNote.Size = new System.Drawing.Size(161, 34);
            this.btnNote.TabIndex = 4;
            this.btnNote.Text = "Note";
            this.btnNote.UseVisualStyleBackColor = true;
            this.btnNote.Click += new System.EventHandler(this.btnNote_Click);
            // 
            // tbxNoteText
            // 
            this.tbxNoteText.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.5F);
            this.tbxNoteText.Location = new System.Drawing.Point(13, 149);
            this.tbxNoteText.Name = "tbxNoteText";
            this.tbxNoteText.Size = new System.Drawing.Size(161, 34);
            this.tbxNoteText.TabIndex = 3;
            // 
            // btnRestart
            // 
            this.btnRestart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRestart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRestart.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Location = new System.Drawing.Point(209, 109);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(161, 34);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.Text = "Reset";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnStartStop
            // 
            this.btnStartStop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStartStop.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnStartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartStop.Location = new System.Drawing.Point(13, 109);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(161, 34);
            this.btnStartStop.TabIndex = 1;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // labelStopwatchTime
            // 
            this.labelStopwatchTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelStopwatchTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelStopwatchTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStopwatchTime.Location = new System.Drawing.Point(3, 7);
            this.labelStopwatchTime.Name = "labelStopwatchTime";
            this.labelStopwatchTime.Size = new System.Drawing.Size(367, 59);
            this.labelStopwatchTime.TabIndex = 0;
            this.labelStopwatchTime.Text = "00:00:00";
            this.labelStopwatchTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStopwatchTime.DoubleClick += new System.EventHandler(this.CopyTextToClipboardOnAnyLabelDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.listBoxNotes);
            this.panel1.Location = new System.Drawing.Point(376, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 233);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 39);
            this.label3.TabIndex = 8;
            this.label3.Text = "Notes:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBoxNotes
            // 
            this.listBoxNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxNotes.FormattingEnabled = true;
            this.listBoxNotes.ItemHeight = 24;
            this.listBoxNotes.Location = new System.Drawing.Point(13, 51);
            this.listBoxNotes.Name = "listBoxNotes";
            this.listBoxNotes.Size = new System.Drawing.Size(211, 172);
            this.listBoxNotes.TabIndex = 0;
            this.listBoxNotes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxNotes_KeyDown);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 245);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTop);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(628, 284);
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stopwatch";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.notesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Label labelStopwatchTime;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnNote;
        private System.Windows.Forms.TextBox tbxNoteText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxNotes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotalHours;
        private System.Windows.Forms.Label labelTotalMinutes;
        private System.Windows.Forms.BindingSource notesBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.TextBox tbxHourPrice;
    }
}

