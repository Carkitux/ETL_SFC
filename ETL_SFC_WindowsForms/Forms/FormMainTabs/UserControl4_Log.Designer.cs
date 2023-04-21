namespace ETL_SFC_WindowsForms
{
    partial class UserControl4_Log
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonLogOeffnen = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelPreviewRowCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelCurrentLogSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLogFileCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLogFileSizeSum = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxLog
            // 
            this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLog.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLog.Location = new System.Drawing.Point(0, 0);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLog.Size = new System.Drawing.Size(727, 322);
            this.textBoxLog.TabIndex = 0;
            this.textBoxLog.WordWrap = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.buttonLogOeffnen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 49);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Eras Demi ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(127, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "Dateipfad öffnen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonLogOeffnen
            // 
            this.buttonLogOeffnen.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonLogOeffnen.FlatAppearance.BorderSize = 0;
            this.buttonLogOeffnen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOeffnen.Font = new System.Drawing.Font("Eras Demi ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLogOeffnen.Location = new System.Drawing.Point(0, 0);
            this.buttonLogOeffnen.Name = "buttonLogOeffnen";
            this.buttonLogOeffnen.Size = new System.Drawing.Size(127, 49);
            this.buttonLogOeffnen.TabIndex = 0;
            this.buttonLogOeffnen.Text = "Log öffnen";
            this.buttonLogOeffnen.UseVisualStyleBackColor = true;
            this.buttonLogOeffnen.Click += new System.EventHandler(this.buttonLogOeffnen_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxLog);
            this.panel2.Controls.Add(this.statusStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(727, 346);
            this.panel2.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelPreviewRowCount,
            this.toolStripStatusLabelCurrentLogSize,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelLogFileCount,
            this.toolStripStatusLabelLogFileSizeSum});
            this.statusStrip1.Location = new System.Drawing.Point(0, 322);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(727, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelPreviewRowCount
            // 
            this.toolStripStatusLabelPreviewRowCount.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.toolStripStatusLabelPreviewRowCount.Name = "toolStripStatusLabelPreviewRowCount";
            this.toolStripStatusLabelPreviewRowCount.Size = new System.Drawing.Size(193, 19);
            this.toolStripStatusLabelPreviewRowCount.Text = "Preview Zeilen Anzahl: (max. 1000)";
            // 
            // toolStripStatusLabelCurrentLogSize
            // 
            this.toolStripStatusLabelCurrentLogSize.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.toolStripStatusLabelCurrentLogSize.Name = "toolStripStatusLabelCurrentLogSize";
            this.toolStripStatusLabelCurrentLogSize.Size = new System.Drawing.Size(68, 19);
            this.toolStripStatusLabelCurrentLogSize.Text = "Loggröße: ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(212, 19);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // toolStripStatusLabelLogFileCount
            // 
            this.toolStripStatusLabelLogFileCount.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.toolStripStatusLabelLogFileCount.Name = "toolStripStatusLabelLogFileCount";
            this.toolStripStatusLabelLogFileCount.Size = new System.Drawing.Size(102, 19);
            this.toolStripStatusLabelLogFileCount.Text = "Logdatei Anzahl: ";
            // 
            // toolStripStatusLabelLogFileSizeSum
            // 
            this.toolStripStatusLabelLogFileSizeSum.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.toolStripStatusLabelLogFileSizeSum.Name = "toolStripStatusLabelLogFileSizeSum";
            this.toolStripStatusLabelLogFileSizeSum.Size = new System.Drawing.Size(137, 19);
            this.toolStripStatusLabelLogFileSizeSum.Text = "Gesamtgröße alle Logs: ";
            // 
            // UserControl4_Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserControl4_Log";
            this.Size = new System.Drawing.Size(727, 395);
            this.Load += new System.EventHandler(this.UserControl4_Log_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLogOeffnen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPreviewRowCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCurrentLogSize;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLogFileCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLogFileSizeSum;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}
