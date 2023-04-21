using ETL_SFC_Model;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ETL_SFC_WindowsForms
{
    public class DataGridViewHelper
    {
        public static void UpdateData(DataGridView dataGridView, StagingObject stagingObject)
        {
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();

            // Holt sich alle Attribute der Datei und erstellt demnach die Spalten der Tabelle
            foreach (var attribut in stagingObject.Attribute)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.HeaderText = attribut.Name;
                column.Name = attribut.Name;
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView.Columns.Add(column);
            }

            // Erstellt nun eine Zeile für jeden Datensatz und ordnet die einzelnen Daten zu
            foreach (var datensatz in stagingObject.Datensaetze)
            {
                string[] dataRow = new string[datensatz.SingleDatas.Count];
                int i = 0;
                foreach (var singledata in datensatz.SingleDatas)
                {
                    dataRow[i] = singledata.Inhalt;
                    i++;
                }
                dataGridView.Rows.Add(dataRow);
            }
        }
    }
}
