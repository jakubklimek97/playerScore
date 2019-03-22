namespace PlayerScore
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.reportsTable = new System.Windows.Forms.DataGridView();
            this.ParsingProgressBar = new System.Windows.Forms.ProgressBar();
            this.genButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reportsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pobierz raporty";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 12);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // reportsTable
            // 
            this.reportsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.reportsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportsTable.Location = new System.Drawing.Point(187, 12);
            this.reportsTable.Name = "reportsTable";
            this.reportsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reportsTable.Size = new System.Drawing.Size(545, 331);
            this.reportsTable.TabIndex = 2;
            // 
            // ParsingProgressBar
            // 
            this.ParsingProgressBar.Location = new System.Drawing.Point(18, 244);
            this.ParsingProgressBar.Name = "ParsingProgressBar";
            this.ParsingProgressBar.Size = new System.Drawing.Size(157, 23);
            this.ParsingProgressBar.TabIndex = 3;
            // 
            // genButton
            // 
            this.genButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.genButton.Location = new System.Drawing.Point(18, 215);
            this.genButton.Name = "genButton";
            this.genButton.Size = new System.Drawing.Size(157, 23);
            this.genButton.TabIndex = 4;
            this.genButton.Text = "Generuj Raport";
            this.genButton.UseVisualStyleBackColor = true;
            this.genButton.Click += new System.EventHandler(this.genButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 567);
            this.Controls.Add(this.genButton);
            this.Controls.Add(this.ParsingProgressBar);
            this.Controls.Add(this.reportsTable);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.reportsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView reportsTable;
        private System.Windows.Forms.ProgressBar ParsingProgressBar;
        private System.Windows.Forms.Button genButton;
    }
}

