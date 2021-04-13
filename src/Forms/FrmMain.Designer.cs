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
            this.labelTextHourPrice = new System.Windows.Forms.Label();
            this.labelTextFinalCost = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.tbxHourPrice = new System.Windows.Forms.TextBox();
            this.labelTextHours = new System.Windows.Forms.Label();
            this.labelTextMinutes = new System.Windows.Forms.Label();
            this.labelTotalHours = new System.Windows.Forms.Label();
            this.labelTotalMinutes = new System.Windows.Forms.Label();
            this.btnNote = new System.Windows.Forms.Button();
            this.tbxNoteText = new System.Windows.Forms.TextBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.labelStopwatchTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTextNotes = new System.Windows.Forms.Label();
            this.listBoxNotes = new System.Windows.Forms.ListBox();
            this.notesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStripLanguage = new System.Windows.Forms.MenuStrip();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.русскийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notesBindingSource)).BeginInit();
            this.menuStripLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelTop.Controls.Add(this.labelTextHourPrice);
            this.panelTop.Controls.Add(this.labelTextFinalCost);
            this.panelTop.Controls.Add(this.labelCost);
            this.panelTop.Controls.Add(this.tbxHourPrice);
            this.panelTop.Controls.Add(this.labelTextHours);
            this.panelTop.Controls.Add(this.labelTextMinutes);
            this.panelTop.Controls.Add(this.labelTotalHours);
            this.panelTop.Controls.Add(this.labelTotalMinutes);
            this.panelTop.Controls.Add(this.btnNote);
            this.panelTop.Controls.Add(this.tbxNoteText);
            this.panelTop.Controls.Add(this.btnRestart);
            this.panelTop.Controls.Add(this.btnStartStop);
            this.panelTop.Controls.Add(this.labelStopwatchTime);
            this.panelTop.Location = new System.Drawing.Point(0, 22);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(376, 286);
            this.panelTop.TabIndex = 0;
            // 
            // labelTextHourPrice
            // 
            this.labelTextHourPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTextHourPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextHourPrice.Location = new System.Drawing.Point(9, 189);
            this.labelTextHourPrice.Name = "labelTextHourPrice";
            this.labelTextHourPrice.Size = new System.Drawing.Size(165, 38);
            this.labelTextHourPrice.TabIndex = 11;
            this.labelTextHourPrice.Text = "Hour price:";
            this.labelTextHourPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTextFinalCost
            // 
            this.labelTextFinalCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTextFinalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextFinalCost.Location = new System.Drawing.Point(9, 227);
            this.labelTextFinalCost.Name = "labelTextFinalCost";
            this.labelTextFinalCost.Size = new System.Drawing.Size(217, 38);
            this.labelTextFinalCost.TabIndex = 10;
            this.labelTextFinalCost.Text = "Final cost:";
            this.labelTextFinalCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCost
            // 
            this.labelCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCost.Location = new System.Drawing.Point(232, 227);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(138, 38);
            this.labelCost.TabIndex = 9;
            this.labelCost.Text = "0";
            this.labelCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelCost.DoubleClick += new System.EventHandler(this.CopyTextToClipboardOnAnyLabelDoubleClick);
            // 
            // tbxHourPrice
            // 
            this.tbxHourPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxHourPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.5F);
            this.tbxHourPrice.Location = new System.Drawing.Point(209, 190);
            this.tbxHourPrice.MaxLength = 20;
            this.tbxHourPrice.Name = "tbxHourPrice";
            this.tbxHourPrice.Size = new System.Drawing.Size(161, 34);
            this.tbxHourPrice.TabIndex = 8;
            this.tbxHourPrice.Text = "0";
            this.tbxHourPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxHourPrice.TextChanged += new System.EventHandler(this.tbxHourPrice_TextChanged);
            // 
            // labelTextHours
            // 
            this.labelTextHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTextHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTextHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextHours.Location = new System.Drawing.Point(205, 68);
            this.labelTextHours.Name = "labelTextHours";
            this.labelTextHours.Size = new System.Drawing.Size(74, 38);
            this.labelTextHours.TabIndex = 7;
            this.labelTextHours.Text = "Hours:";
            this.labelTextHours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTextMinutes
            // 
            this.labelTextMinutes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTextMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextMinutes.Location = new System.Drawing.Point(9, 68);
            this.labelTextMinutes.Name = "labelTextMinutes";
            this.labelTextMinutes.Size = new System.Drawing.Size(89, 38);
            this.labelTextMinutes.TabIndex = 6;
            this.labelTextMinutes.Text = "Minutes:";
            this.labelTextMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTotalHours
            // 
            this.labelTotalHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.labelTotalMinutes.Location = new System.Drawing.Point(98, 68);
            this.labelTotalMinutes.Name = "labelTotalMinutes";
            this.labelTotalMinutes.Size = new System.Drawing.Size(80, 38);
            this.labelTotalMinutes.TabIndex = 5;
            this.labelTotalMinutes.Text = "0";
            this.labelTotalMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelTotalMinutes.DoubleClick += new System.EventHandler(this.CopyTextToClipboardOnAnyLabelDoubleClick);
            // 
            // btnNote
            // 
            this.btnNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnRestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.labelStopwatchTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.panel1.Controls.Add(this.labelTextNotes);
            this.panel1.Controls.Add(this.listBoxNotes);
            this.panel1.Location = new System.Drawing.Point(376, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 286);
            this.panel1.TabIndex = 1;
            // 
            // labelTextNotes
            // 
            this.labelTextNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTextNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextNotes.Location = new System.Drawing.Point(9, 9);
            this.labelTextNotes.Name = "labelTextNotes";
            this.labelTextNotes.Size = new System.Drawing.Size(165, 39);
            this.labelTextNotes.TabIndex = 8;
            this.labelTextNotes.Text = "Notes:";
            this.labelTextNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.listBoxNotes.Size = new System.Drawing.Size(276, 196);
            this.listBoxNotes.TabIndex = 0;
            this.listBoxNotes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxNotes_KeyDown);
            // 
            // menuStripLanguage
            // 
            this.menuStripLanguage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem});
            this.menuStripLanguage.Location = new System.Drawing.Point(0, 0);
            this.menuStripLanguage.Name = "menuStripLanguage";
            this.menuStripLanguage.Size = new System.Drawing.Size(677, 24);
            this.menuStripLanguage.TabIndex = 2;
            this.menuStripLanguage.Text = "menuStrip1";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.русскийToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // русскийToolStripMenuItem
            // 
            this.русскийToolStripMenuItem.Name = "русскийToolStripMenuItem";
            this.русскийToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.русскийToolStripMenuItem.Text = "Русский";
            this.русскийToolStripMenuItem.Click += new System.EventHandler(this.русскийToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 291);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.menuStripLanguage);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStripLanguage;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(400, 330);
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stopwatch";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.notesBindingSource)).EndInit();
            this.menuStripLanguage.ResumeLayout(false);
            this.menuStripLanguage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label labelTextHours;
        private System.Windows.Forms.Label labelTextMinutes;
        private System.Windows.Forms.Label labelTotalHours;
        private System.Windows.Forms.Label labelTotalMinutes;
        private System.Windows.Forms.BindingSource notesBindingSource;
        private System.Windows.Forms.Label labelTextNotes;
        private System.Windows.Forms.Label labelTextFinalCost;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.TextBox tbxHourPrice;
        private System.Windows.Forms.Label labelTextHourPrice;
        private System.Windows.Forms.MenuStrip menuStripLanguage;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem русскийToolStripMenuItem;
    }
}

