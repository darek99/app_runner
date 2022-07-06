namespace app_runner
{
    partial class frmMain
    {

        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.btnNextDate = new System.Windows.Forms.Button();
            this.btnPreviousDate = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusLab = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "dd- MM- yyyy ";
            this.datePicker.Enabled = false;
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(12, 12);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(116, 23);
            this.datePicker.TabIndex = 0;
            this.datePicker.TabStop = false;
            this.datePicker.Value = new System.DateTime(2021, 3, 29, 0, 0, 0, 0);
            // 
            // btnNextDate
            // 
            this.btnNextDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNextDate.Location = new System.Drawing.Point(231, 12);
            this.btnNextDate.Name = "btnNextDate";
            this.btnNextDate.Size = new System.Drawing.Size(75, 23);
            this.btnNextDate.TabIndex = 0;
            this.btnNextDate.Text = "-->";
            this.btnNextDate.UseVisualStyleBackColor = true;
            this.btnNextDate.Click += new System.EventHandler(this.btnNextDate_Click);
            // 
            // btnPreviousDate
            // 
            this.btnPreviousDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPreviousDate.Location = new System.Drawing.Point(150, 12);
            this.btnPreviousDate.Name = "btnPreviousDate";
            this.btnPreviousDate.Size = new System.Drawing.Size(75, 23);
            this.btnPreviousDate.TabIndex = 4;
            this.btnPreviousDate.Text = "<--";
            this.btnPreviousDate.UseVisualStyleBackColor = true;
            this.btnPreviousDate.Click += new System.EventHandler(this.btnPreviousDate_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEnd.Location = new System.Drawing.Point(150, 41);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 3;
            this.btnEnd.Text = "&Koniec";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(45, 41);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(83, 23);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "&Uruchom";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(231, 41);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(75, 23);
            this.btnToday.TabIndex = 2;
            this.btnToday.Text = "&Dzisiaj";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(12, 41);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(27, 23);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.TabStop = false;
            this.btnSelect.Text = "...";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // openFileDlg
            // 
            this.openFileDlg.DefaultExt = "exe";
            this.openFileDlg.Filter = "exe (*.exe)|*.exe";
            this.openFileDlg.Title = "Wybierz program do uruchomienia";
            this.openFileDlg.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDlg_FileOk);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLab});
            this.statusBar.Location = new System.Drawing.Point(0, 81);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(318, 22);
            this.statusBar.SizingGrip = false;
            this.statusBar.TabIndex = 6;
            // 
            // statusLab
            // 
            this.statusLab.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.statusLab.Name = "statusLab";
            this.statusLab.Size = new System.Drawing.Size(0, 17);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 103);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnPreviousDate);
            this.Controls.Add(this.btnNextDate);
            this.Controls.Add(this.datePicker);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "app_runner_with_date";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.frmMain_HelpButtonClicked);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button btnNextDate;
        private System.Windows.Forms.Button btnPreviousDate;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusLab;
    }
}

