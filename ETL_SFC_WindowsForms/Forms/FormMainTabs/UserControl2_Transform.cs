﻿using ETL_SFC_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace ETL_SFC_WindowsForms
{
    public partial class UserControl2_Transform : UserControl
    {
        public UserControl2_Transform()
        {
            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;
            dataGridView1.MultiSelect = false;
        }

        private void button_SpalteHinzufuegen_Click(object sender, EventArgs e)
        {
            using (var form3 = new FormDialog_SpalteHinzufuegen())
            {
                if (form3.ShowDialog(this) == DialogResult.OK)
                {
                    dataGridUpdate();
                }
                else
                {

                }
            }
        }

        private void button_SpalteLoeschen_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedColumns.Count == 0)
            {
                MessageBox.Show("Bitte wählen Sie eine zu löschende Spalte aus.");
                return;
            }
            Transform.DeleteAttribut(dataGridView1.SelectedColumns[0].Name);
            dataGridUpdate();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var form2 = new FormDialog_TransferData())
            {
                if (form2.ShowDialog(this) == DialogResult.OK)
                {
                    dataGridUpdate();
                }
                else
                {

                }
            }
        }

        private void dataGridUpdate()
        {
            StagingObject TransformStObj = StagingArea.TransformStagingObject;

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            // Holt sich alle Header der Datei und erstellt demnach die Spalten der Tabelle
            List<string> headers = new List<string>();
            TransformStObj.Attribute?.ForEach(data => headers.Add(data.Name));
            foreach (var header in headers.Distinct())
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.HeaderText = header;
                column.Name = header;
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns.Add(column);
            }

            // Erstellt nun eine Zeile für jeden Datensatz und ordnet die einzelnen Daten zu
            foreach (var datensatz in TransformStObj.Datensaetze)
            {
                string[] dataRow = new string[datensatz.SingleDatas.Count];
                int i = 0;
                foreach (var singledata in datensatz.SingleDatas)
                {
                    dataRow[i] = singledata.Inhalt;
                    i++;
                }
                dataGridView1.Rows.Add(dataRow);
            }
        }
    }
}