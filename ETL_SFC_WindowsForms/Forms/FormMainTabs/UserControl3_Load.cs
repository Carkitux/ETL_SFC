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
                    ETL_SFC_Model.JSON.CreateJSON(saveFileDialog1.FileName);
                    break;
                case "csv":
                    ETL_SFC_Model.CSV.CreateCSV(saveFileDialog1.FileName);
                    break;
                case "xml":
                    ETL_SFC_Model.XML.CreateXML(saveFileDialog1.FileName);
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
    }
}
