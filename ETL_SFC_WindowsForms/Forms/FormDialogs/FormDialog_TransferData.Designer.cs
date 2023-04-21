namespace ETL_SFC_WindowsForms
{
    partial class FormDialog_TransferData
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
            this.components = new System.ComponentModel.Container();
            this.listBox_QuellAttribute = new System.Windows.Forms.ListBox();
            this.listBox_TransferAttribute = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_Schließen = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_QuellStObj = new System.Windows.Forms.ComboBox();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_Ausfuehren = new System.Windows.Forms.Button();
            this.comboBox_ZielAttribut = new System.Windows.Forms.ComboBox();
            this.comboBox_ZielAttribut2 = new System.Windows.Forms.ComboBox();
            this.radioButton_Transfer = new System.Windows.Forms.RadioButton();
            this.radioButton_Merge = new System.Windows.Forms.RadioButton();
            this.radioButton_Split = new System.Windows.Forms.RadioButton();
            this.listBox_ZielAttribute = new System.Windows.Forms.ListBox();
            this.textBox_Split = new System.Windows.Forms.TextBox();
            this.textBox_Merge = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_QuellAttribute
            // 
            this.listBox_QuellAttribute.FormattingEnabled = true;
            this.listBox_QuellAttribute.ItemHeight = 15;
            this.listBox_QuellAttribute.Location = new System.Drawing.Point(8, 45);
            this.listBox_QuellAttribute.Name = "listBox_QuellAttribute";
            this.listBox_QuellAttribute.Size = new System.Drawing.Size(262, 244);
            this.listBox_QuellAttribute.TabIndex = 1;
            // 
            // listBox_TransferAttribute
            // 
            this.listBox_TransferAttribute.FormattingEnabled = true;
            this.listBox_TransferAttribute.ItemHeight = 15;
            this.listBox_TransferAttribute.Location = new System.Drawing.Point(401, 70);
            this.listBox_TransferAttribute.Name = "listBox_TransferAttribute";
            this.listBox_TransferAttribute.Size = new System.Drawing.Size(241, 49);
            this.listBox_TransferAttribute.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "->";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(298, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "<-";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button_Schließen
            // 
            this.button_Schließen.Location = new System.Drawing.Point(565, 293);
            this.button_Schließen.Name = "button_Schließen";
            this.button_Schließen.Size = new System.Drawing.Size(75, 23);
            this.button_Schließen.TabIndex = 5;
            this.button_Schließen.Text = "Schließen";
            this.button_Schließen.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Quelle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Transferierte Spalten";
            // 
            // comboBox_QuellStObj
            // 
            this.comboBox_QuellStObj.FormattingEnabled = true;
            this.comboBox_QuellStObj.Location = new System.Drawing.Point(8, 21);
            this.comboBox_QuellStObj.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comboBox_QuellStObj.Name = "comboBox_QuellStObj";
            this.comboBox_QuellStObj.Size = new System.Drawing.Size(262, 23);
            this.comboBox_QuellStObj.TabIndex = 10;
            this.comboBox_QuellStObj.Text = "Bitte auswählen";
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(298, 19);
            this.button_Reset.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(69, 22);
            this.button_Reset.TabIndex = 11;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            // 
            // button_Ausfuehren
            // 
            this.button_Ausfuehren.Location = new System.Drawing.Point(274, 240);
            this.button_Ausfuehren.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button_Ausfuehren.Name = "button_Ausfuehren";
            this.button_Ausfuehren.Size = new System.Drawing.Size(123, 22);
            this.button_Ausfuehren.TabIndex = 12;
            this.button_Ausfuehren.Text = "Ausführen";
            this.button_Ausfuehren.UseVisualStyleBackColor = true;
            // 
            // comboBox_ZielAttribut
            // 
            this.comboBox_ZielAttribut.FormattingEnabled = true;
            this.comboBox_ZielAttribut.Location = new System.Drawing.Point(401, 22);
            this.comboBox_ZielAttribut.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comboBox_ZielAttribut.Name = "comboBox_ZielAttribut";
            this.comboBox_ZielAttribut.Size = new System.Drawing.Size(241, 23);
            this.comboBox_ZielAttribut.TabIndex = 13;
            this.comboBox_ZielAttribut.Text = "1. Zielspalte";
            // 
            // comboBox_ZielAttribut2
            // 
            this.comboBox_ZielAttribut2.FormattingEnabled = true;
            this.comboBox_ZielAttribut2.Location = new System.Drawing.Point(401, 46);
            this.comboBox_ZielAttribut2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comboBox_ZielAttribut2.Name = "comboBox_ZielAttribut2";
            this.comboBox_ZielAttribut2.Size = new System.Drawing.Size(241, 23);
            this.comboBox_ZielAttribut2.TabIndex = 14;
            this.comboBox_ZielAttribut2.Text = "2. Zielspalte für Datensplitting";
            // 
            // radioButton_Transfer
            // 
            this.radioButton_Transfer.AutoSize = true;
            this.radioButton_Transfer.Location = new System.Drawing.Point(298, 131);
            this.radioButton_Transfer.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.radioButton_Transfer.Name = "radioButton_Transfer";
            this.radioButton_Transfer.Size = new System.Drawing.Size(66, 19);
            this.radioButton_Transfer.TabIndex = 15;
            this.radioButton_Transfer.TabStop = true;
            this.radioButton_Transfer.Text = "Transfer";
            this.radioButton_Transfer.UseVisualStyleBackColor = true;
            // 
            // radioButton_Merge
            // 
            this.radioButton_Merge.AutoSize = true;
            this.radioButton_Merge.Location = new System.Drawing.Point(298, 151);
            this.radioButton_Merge.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.radioButton_Merge.Name = "radioButton_Merge";
            this.radioButton_Merge.Size = new System.Drawing.Size(59, 19);
            this.radioButton_Merge.TabIndex = 16;
            this.radioButton_Merge.TabStop = true;
            this.radioButton_Merge.Text = "Merge";
            this.radioButton_Merge.UseVisualStyleBackColor = true;
            // 
            // radioButton_Split
            // 
            this.radioButton_Split.AutoSize = true;
            this.radioButton_Split.Location = new System.Drawing.Point(298, 194);
            this.radioButton_Split.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.radioButton_Split.Name = "radioButton_Split";
            this.radioButton_Split.Size = new System.Drawing.Size(48, 19);
            this.radioButton_Split.TabIndex = 17;
            this.radioButton_Split.TabStop = true;
            this.radioButton_Split.Text = "Split";
            this.radioButton_Split.UseVisualStyleBackColor = true;
            // 
            // listBox_ZielAttribute
            // 
            this.listBox_ZielAttribute.FormattingEnabled = true;
            this.listBox_ZielAttribute.ItemHeight = 15;
            this.listBox_ZielAttribute.Location = new System.Drawing.Point(401, 120);
            this.listBox_ZielAttribute.Name = "listBox_ZielAttribute";
            this.listBox_ZielAttribute.Size = new System.Drawing.Size(241, 169);
            this.listBox_ZielAttribute.TabIndex = 18;
            // 
            // textBox_Split
            // 
            this.textBox_Split.Location = new System.Drawing.Point(298, 213);
            this.textBox_Split.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox_Split.Name = "textBox_Split";
            this.textBox_Split.PlaceholderText = "Seperator";
            this.textBox_Split.Size = new System.Drawing.Size(71, 23);
            this.textBox_Split.TabIndex = 19;
            // 
            // textBox_Merge
            // 
            this.textBox_Merge.Location = new System.Drawing.Point(298, 171);
            this.textBox_Merge.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox_Merge.Name = "textBox_Merge";
            this.textBox_Merge.PlaceholderText = "Connector";
            this.textBox_Merge.Size = new System.Drawing.Size(71, 23);
            this.textBox_Merge.TabIndex = 20;
            // 
            // Form2_Button_TransferData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 322);
            this.Controls.Add(this.textBox_Merge);
            this.Controls.Add(this.textBox_Split);
            this.Controls.Add(this.listBox_ZielAttribute);
            this.Controls.Add(this.radioButton_Split);
            this.Controls.Add(this.radioButton_Merge);
            this.Controls.Add(this.radioButton_Transfer);
            this.Controls.Add(this.comboBox_ZielAttribut2);
            this.Controls.Add(this.listBox_TransferAttribute);
            this.Controls.Add(this.comboBox_ZielAttribut);
            this.Controls.Add(this.button_Ausfuehren);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.comboBox_QuellStObj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Schließen);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox_QuellAttribute);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2_Button_TransferData";
            this.ShowInTaskbar = false;
            this.Text = "Datentransfer";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox_QuellAttribute;
        private System.Windows.Forms.ListBox listBox_TransferAttribute;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_Schließen;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_QuellStObj;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_Ausfuehren;
        private System.Windows.Forms.ComboBox comboBox_ZielAttribut;
        private System.Windows.Forms.ComboBox comboBox_ZielAttribut2;
        private System.Windows.Forms.RadioButton radioButton_Transfer;
        private System.Windows.Forms.RadioButton radioButton_Merge;
        private System.Windows.Forms.RadioButton radioButton_Split;
        private System.Windows.Forms.ListBox listBox_ZielAttribute;
        private System.Windows.Forms.TextBox textBox_Split;
        private System.Windows.Forms.TextBox textBox_Merge;
    }
}