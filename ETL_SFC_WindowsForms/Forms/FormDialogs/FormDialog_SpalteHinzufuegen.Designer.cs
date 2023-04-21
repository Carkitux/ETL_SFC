namespace ETL_SFC_WindowsForms
{
    partial class FormDialog_SpalteHinzufuegen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(397, 149);
            button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(139, 49);
            button1.TabIndex = 0;
            button1.Text = "Okay";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(548, 149);
            button2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(139, 49);
            button2.TabIndex = 1;
            button2.Text = "Abbrechen";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(22, 26);
            textBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Spaltenname";
            textBox1.Size = new System.Drawing.Size(661, 39);
            textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(22, 87);
            comboBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(661, 40);
            comboBox1.TabIndex = 3;
            comboBox1.Text = "Datentyp";
            // 
            // Form3_Button_SpalteHinzufuegen
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(709, 218);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form3_Button_SpalteHinzufuegen";
            ShowInTaskbar = false;
            Text = "Spalte hinzufügen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}