namespace ETL_SFC_WindowsForms
{
    partial class UserControl2Transform_Menu1Columns
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
            this.buttonColumnAdd = new System.Windows.Forms.Button();
            this.buttonColumnEdit = new System.Windows.Forms.Button();
            this.buttonColumnDelete = new System.Windows.Forms.Button();
            this.buttonColumnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonColumnAdd
            // 
            this.buttonColumnAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonColumnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonColumnAdd.FlatAppearance.BorderSize = 0;
            this.buttonColumnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColumnAdd.Font = new System.Drawing.Font("Eras Demi ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonColumnAdd.Location = new System.Drawing.Point(127, 0);
            this.buttonColumnAdd.Name = "buttonColumnAdd";
            this.buttonColumnAdd.Size = new System.Drawing.Size(127, 49);
            this.buttonColumnAdd.TabIndex = 1;
            this.buttonColumnAdd.Text = "Spalte hinzufügen";
            this.buttonColumnAdd.UseVisualStyleBackColor = false;
            this.buttonColumnAdd.Click += new System.EventHandler(this.buttonColumnAdd_Click);
            // 
            // buttonColumnEdit
            // 
            this.buttonColumnEdit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonColumnEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonColumnEdit.FlatAppearance.BorderSize = 0;
            this.buttonColumnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColumnEdit.Font = new System.Drawing.Font("Eras Demi ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonColumnEdit.Location = new System.Drawing.Point(254, 0);
            this.buttonColumnEdit.Name = "buttonColumnEdit";
            this.buttonColumnEdit.Size = new System.Drawing.Size(127, 49);
            this.buttonColumnEdit.TabIndex = 2;
            this.buttonColumnEdit.Text = "Spalte bearbeiten";
            this.buttonColumnEdit.UseVisualStyleBackColor = false;
            this.buttonColumnEdit.Click += new System.EventHandler(this.buttonColumnEdit_Click);
            // 
            // buttonColumnDelete
            // 
            this.buttonColumnDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonColumnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonColumnDelete.FlatAppearance.BorderSize = 0;
            this.buttonColumnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColumnDelete.Font = new System.Drawing.Font("Eras Demi ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonColumnDelete.Location = new System.Drawing.Point(381, 0);
            this.buttonColumnDelete.Name = "buttonColumnDelete";
            this.buttonColumnDelete.Size = new System.Drawing.Size(127, 49);
            this.buttonColumnDelete.TabIndex = 3;
            this.buttonColumnDelete.Text = "Spalte\r\nlöschen";
            this.buttonColumnDelete.UseVisualStyleBackColor = false;
            this.buttonColumnDelete.Click += new System.EventHandler(this.buttonColumnDelete_Click);
            // 
            // buttonColumnGenerate
            // 
            this.buttonColumnGenerate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonColumnGenerate.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonColumnGenerate.FlatAppearance.BorderSize = 0;
            this.buttonColumnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColumnGenerate.Font = new System.Drawing.Font("Eras Demi ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonColumnGenerate.Location = new System.Drawing.Point(0, 0);
            this.buttonColumnGenerate.Name = "buttonColumnGenerate";
            this.buttonColumnGenerate.Size = new System.Drawing.Size(127, 49);
            this.buttonColumnGenerate.TabIndex = 4;
            this.buttonColumnGenerate.Text = "Spalten\r\ngenerieren";
            this.buttonColumnGenerate.UseVisualStyleBackColor = false;
            this.buttonColumnGenerate.Click += new System.EventHandler(this.buttonColumnGenerate_Click);
            // 
            // UserControl2Transform_Menu1Columns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.buttonColumnDelete);
            this.Controls.Add(this.buttonColumnEdit);
            this.Controls.Add(this.buttonColumnAdd);
            this.Controls.Add(this.buttonColumnGenerate);
            this.Name = "UserControl2Transform_Menu1Columns";
            this.Size = new System.Drawing.Size(709, 49);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonColumnAdd;
        private System.Windows.Forms.Button buttonColumnEdit;
        private System.Windows.Forms.Button buttonColumnDelete;
        private System.Windows.Forms.Button buttonColumnGenerate;
    }
}
