namespace ETL_SFC_WindowsForms
{
    partial class FormMain
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
            panel2 = new System.Windows.Forms.Panel();
            button5 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.Silver;
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Margin = new System.Windows.Forms.Padding(6);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1486, 105);
            panel2.TabIndex = 1;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button5.Font = new System.Drawing.Font("Eras Bold ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button5.Location = new System.Drawing.Point(943, 0);
            button5.Margin = new System.Windows.Forms.Padding(0);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(236, 105);
            button5.TabIndex = 3;
            button5.Text = "Logging";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button4.Font = new System.Drawing.Font("Eras Bold ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button4.Location = new System.Drawing.Point(708, 0);
            button4.Margin = new System.Windows.Forms.Padding(0);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(236, 105);
            button4.TabIndex = 3;
            button4.Text = "Load";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.Font = new System.Drawing.Font("Eras Bold ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button3.Location = new System.Drawing.Point(472, 0);
            button3.Margin = new System.Windows.Forms.Padding(0);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(236, 105);
            button3.TabIndex = 3;
            button3.Text = "Transform";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Eras Bold ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button2.Location = new System.Drawing.Point(236, 0);
            button2.Margin = new System.Windows.Forms.Padding(0);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(236, 105);
            button2.TabIndex = 1;
            button2.Text = "Extract";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Eras Bold ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(0, 0);
            button1.Margin = new System.Windows.Forms.Padding(0);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(236, 105);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 105);
            panel1.Margin = new System.Windows.Forms.Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1486, 855);
            panel1.TabIndex = 2;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1486, 960);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new System.Windows.Forms.Padding(6);
            MinimumSize = new System.Drawing.Size(1000, 800);
            Name = "FormMain";
            Text = "Extract, Transform & Load - SFC";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}