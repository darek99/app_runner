namespace SUBIEKT_RUNNER
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
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.btnNextDate = new System.Windows.Forms.Button();
            this.btnPreviousDate = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "dd- MM- yyyy ";
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(12, 12);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(111, 23);
            this.datePicker.TabIndex = 0;
            this.datePicker.Value = new System.DateTime(2021, 3, 25, 0, 0, 0, 0);
            // 
            // btnNextDate
            // 
            this.btnNextDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNextDate.Location = new System.Drawing.Point(211, 12);
            this.btnNextDate.Name = "btnNextDate";
            this.btnNextDate.Size = new System.Drawing.Size(75, 23);
            this.btnNextDate.TabIndex = 1;
            this.btnNextDate.Text = "-->";
            this.btnNextDate.UseVisualStyleBackColor = true;
            this.btnNextDate.Click += new System.EventHandler(this.btnNextDate_Click);
            // 
            // btnPreviousDate
            // 
            this.btnPreviousDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPreviousDate.Location = new System.Drawing.Point(130, 12);
            this.btnPreviousDate.Name = "btnPreviousDate";
            this.btnPreviousDate.Size = new System.Drawing.Size(75, 23);
            this.btnPreviousDate.TabIndex = 2;
            this.btnPreviousDate.Text = "<--";
            this.btnPreviousDate.UseVisualStyleBackColor = true;
            this.btnPreviousDate.Click += new System.EventHandler(this.btnPreviousDate_Click);
            // 
            // btnSet
            // 
            this.btnSet.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnSet.Location = new System.Drawing.Point(12, 41);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 3;
            this.btnSet.Text = "&Ustaw";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEnd.Location = new System.Drawing.Point(211, 43);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 4;
            this.btnEnd.Text = "&Koniec";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSet;
            this.ClientSize = new System.Drawing.Size(294, 79);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnPreviousDate);
            this.Controls.Add(this.btnNextDate);
            this.Controls.Add(this.datePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SUBIEKT RUNNER";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.frmMain_HelpButtonClicked);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button btnNextDate;
        private System.Windows.Forms.Button btnPreviousDate;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnEnd;
    }
}

