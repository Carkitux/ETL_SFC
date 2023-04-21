using ETL_SFC_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.CheckedListBox;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ETL_SFC_WindowsForms
{
    public partial class UserControl1_Extract : UserControl
    {
        public UserControl1_Extract()
        {
            InitializeComponent();

            Refresh();
        }

        private void button_import_Click(object sender, EventArgs e)
        {
            // Öffnet den Windows Dialog um eine Datei auszuwählen.
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName == string.Empty)
            {
                return;
            }

            foreach (TabPage tabpage in tabControl1.TabPages)
            {
                if (tabpage.Text == openFileDialog1.SafeFileName)
                {
                    MessageBox.Show("Eine Datei mit diesem Namen wurde bereits geladen.");
                    return;
                }
            }

            // Splittet die Endung/den Dateityp vom Namen der ausgewählten Datei für
            // die Verwendung im folgendem switch
            string[] dateipfad = openFileDialog1.SafeFileName.Split('.');
            string dateityp = dateipfad[dateipfad.Length - 1];

            // switch zum ausführen der jeweiligen Load-Methode je nach Dateityp
            switch (dateityp)
            {
                case "csv":
                    CSV.LoadFromCSV(openFileDialog1.FileName, ";", true);
                    break;
                case "json":
                    JSON.LoadFromJson(openFileDialog1.FileName);
                    break;
                case "xml":
                    XML.LoadFromXmlFile(openFileDialog1.FileName);
                    break;
                default:
                    // Hinweis für den User falls eine nicht supportete Datei auswählt wird
                    MessageBox.Show("Bitte eine Datei vom Typ .csv, .json oder .xml auswählen.");
                    return;
            }

            Refresh();
        }

        public override void Refresh()
        {
            base.Refresh();

            foreach (var stagingObject in StagingArea.StagingObjects)
            {
                CreateTabePage(tabControl1, stagingObject);

                // Erstellt eine Tabelle die im neu erstellten Reiter angedockt wird
                DataGridView dataGridView = new DataGridView();
                this.Controls.Add(dataGridView);
                dataGridView.Parent = tabControl1.TabPages[tabControl1.TabCount - 1];
                dataGridView.Dock = DockStyle.Fill;
                dataGridView.AllowUserToAddRows = false;
                dataGridView.AllowUserToDeleteRows = false;
                dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
                dataGridView.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;

                // Erstellt die Spalten und befüllt die Tabelle
                DataGridViewHelper.UpdateData(dataGridView, stagingObject);
            }
        }

        private void CreateTabePage(TabControl tabControl, StagingObject stagingObject)
        {
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Text == stagingObject.FileName)
                {
                    return;
                }
            }

            // Erstellt einen neuen Reiter mit dem Dateinamen
            TabPage tabPage = new TabPage();
            tabPage.Text = stagingObject.FileName;
            tabControl.TabPages.Add(tabPage);
        }
    }
}
