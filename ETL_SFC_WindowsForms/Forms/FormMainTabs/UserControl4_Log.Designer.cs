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
            this.textBoxFileCount = new System.Windows.Forms.TextBox();
            this.textBoxFileSize = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonLogOeffnen = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxLog
            // 
            this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLog.Location = new System.Drawing.Point(0, 0);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLog.Size = new System.Drawing.Size(565, 346);
            this.textBoxLog.TabIndex = 0;
            this.textBoxLog.WordWrap = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.textBoxFileCount);
            this.panel1.Controls.Add(this.textBoxFileSize);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.buttonLogOeffnen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 49);
            this.panel1.TabIndex = 1;
            // 
            // textBoxFileCount
            // 
            this.textBoxFileCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBoxFileCount.Location = new System.Drawing.Point(345, 0);
            this.textBoxFileCount.Name = "textBoxFileCount";
            this.textBoxFileCount.ReadOnly = true;
            this.textBoxFileCount.Size = new System.Drawing.Size(110, 23);
            this.textBoxFileCount.TabIndex = 4;
            // 
            // textBoxFileSize
            // 
            this.textBoxFileSize.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBoxFileSize.Location = new System.Drawing.Point(455, 0);
            this.textBoxFileSize.Name = "textBoxFileSize";
            this.textBoxFileSize.ReadOnly = true;
            this.textBoxFileSize.Size = new System.Drawing.Size(110, 23);
            this.textBoxFileSize.TabIndex = 3;
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
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(565, 346);
            this.panel2.TabIndex = 2;
            // 
            // UserControl4_Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserControl4_Log";
            this.Size = new System.Drawing.Size(565, 395);
            this.Load += new System.EventHandler(this.UserControl4_Log_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLogOeffnen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxFileCount;
        private System.Windows.Forms.TextBox textBoxFileSize;
    }
}
