using BKT.ITT421.LF08.SteveFinnCarsten.ETL.UI.WindowsForms.Helper;
using ETL_SFC_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ETL_SFC_WindowsForms
{
    public partial class UserControl2Transform_Menu1Columns : UserControl
    {
        public UserControl2Transform_Menu1Columns(DataGridView dataGridView, Panel informationPanel)
        {
            InitializeComponent();

            dataGridView1 = dataGridView;
            informationPanel1 = informationPanel;
        }

        private DataGridView dataGridView1;
        private Panel informationPanel1;

        private void buttonColumnGenerate_Click(object sender, EventArgs e)
        {

        }

        private void buttonColumnAdd_Click(object sender, EventArgs e)
        {
            using (var form3 = new FormDialog_SpalteHinzufuegen())
            {
                if (form3.ShowDialog(this) == DialogResult.OK)
                {
                    DataGridViewHelper.UpdateData(dataGridView1, StagingArea.TransformStagingObject);
                }
                else
                {

                }
            }
        }

        private void buttonColumnEdit_Click(object sender, EventArgs e)
        {
            using (var form3 = new FormDialog_SpalteHinzufuegen())
            {
                if (form3.ShowDialog(this) == DialogResult.OK)
                {
                    DataGridViewHelper.UpdateData(dataGridView1, StagingArea.TransformStagingObject);
                }
                else
                {

                }
            }
        }

        private void buttonColumnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedColumns.Count == 0)
            {
                MessageBox.Show("Bitte wählen Sie eine zu löschende Spalte aus.");
                return;
            }
            Transform.DeleteAttribut(dataGridView1.SelectedColumns[0].Name);
            DataGridViewHelper.UpdateData(dataGridView1, StagingArea.TransformStagingObject);
        }
    }
}
