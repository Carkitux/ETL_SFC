namespace ETL_SFC_WindowsForms
{
    partial class UserControl2_Transform
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
            this.button2 = new System.Windows.Forms.Button();
            this.button_SpalteLoeschen = new System.Windows.Forms.Button();
            this.button_SpalteHinzufuegen = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Eras Demi ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(254, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "Daten zuweisen";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_SpalteLoeschen
            // 
            this.button_SpalteLoeschen.AutoEllipsis = true;
            this.button_SpalteLoeschen.BackColor = System.Drawing.Color.LightGray;
            this.button_SpalteLoeschen.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_SpalteLoeschen.FlatAppearance.BorderSize = 0;
            this.button_SpalteLoeschen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SpalteLoeschen.Font = new System.Drawing.Font("Eras Demi ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_SpalteLoeschen.Location = new System.Drawing.Point(127, 0);
            this.button_SpalteLoeschen.Name = "button_SpalteLoeschen";
            this.button_SpalteLoeschen.Size = new System.Drawing.Size(127, 49);
            this.button_SpalteLoeschen.TabIndex = 1;
            this.button_SpalteLoeschen.Text = "Spalte löschen";
            this.button_SpalteLoeschen.UseVisualStyleBackColor = false;
            this.button_SpalteLoeschen.Click += new System.EventHandler(this.button_SpalteLoeschen_Click);
            // 
            // button_SpalteHinzufuegen
            // 
            this.button_SpalteHinzufuegen.BackColor = System.Drawing.Color.LightGray;
            this.button_SpalteHinzufuegen.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_SpalteHinzufuegen.FlatAppearance.BorderSize = 0;
            this.button_SpalteHinzufuegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SpalteHinzufuegen.Font = new System.Drawing.Font("Eras Demi ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_SpalteHinzufuegen.Location = new System.Drawing.Point(0, 0);
            this.button_SpalteHinzufuegen.Name = "button_SpalteHinzufuegen";
            this.button_SpalteHinzufuegen.Size = new System.Drawing.Size(127, 49);
            this.button_SpalteHinzufuegen.TabIndex = 0;
            this.button_SpalteHinzufuegen.Text = "Spalte Hinzufügen";
            this.button_SpalteHinzufuegen.UseVisualStyleBackColor = false;
            this.button_SpalteHinzufuegen.Click += new System.EventHandler(this.button_SpalteHinzufuegen_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(800, 551);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button_SpalteLoeschen);
            this.panel1.Controls.Add(this.button_SpalteHinzufuegen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 49);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 551);
            this.panel2.TabIndex = 2;
            // 
            // UserControl2_Transform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserControl2_Transform";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_SpalteLoeschen;
        private System.Windows.Forms.Button button_SpalteHinzufuegen;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
