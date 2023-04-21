using ETL_SFC_Model;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace ETL_SFC_WindowsForms
{
    public partial class UserControl3_Load : UserControl
    {
        public UserControl3_Load()
        {
            InitializeComponent();

            comboBox_Export.Items.Add("json");
            comboBox_Export.Items.Add("csv");
            comboBox_Export.Items.Add("xml");

            Refresh();
        }

        private void button_Export_Click(object sender, EventArgs e)
        {
            if (comboBox_Export.SelectedItem == null)
            {
                MessageBox.Show("Bitte einen Dateityp in der Combobox auswählen.");
                return;
            }

            saveFileDialog1.Filter = $"{comboBox_Export.SelectedItem} | *.{comboBox_Export.SelectedItem}";
            saveFileDialog1.FileName = string.Empty;

            if (!(saveFileDialog1.ShowDialog() == DialogResult.OK))
            {
                return;
            }

            switch (comboBox_Export.SelectedItem)
            {
                case "json":
                    JSON.CreateJSON(saveFileDialog1.FileName);
                    break;
                case "csv":
                    CSV.CreateCSV(saveFileDialog1.FileName);
                    break;
                case "xml":
                    XML.CreateXML(saveFileDialog1.FileName);
                    break;
                default:
                    break;
            }

            string[] fileNameSplit = saveFileDialog1.FileName.Split('\\');
            string path = string.Empty;
            foreach (var item in fileNameSplit.Reverse().Skip(1).Reverse())
            {
                path = path + item + "\\";
            }
            Process.Start("explorer.exe", path);
        }

        public override void Refresh()
        {
            base.Refresh();

            // Erstellt eine Tabelle die im neu erstellten Reiter angedockt wird
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;

            // Erstellt die Spalten und befüllt die Tabelle
            DataGridViewHelper.UpdateData(dataGridView1, StagingArea.TransformStagingObject);
        }
    }
}
