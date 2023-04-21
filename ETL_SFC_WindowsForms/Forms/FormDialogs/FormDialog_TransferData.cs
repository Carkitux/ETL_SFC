using ETL_SFC_Model;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.LinkLabel;

//https://stackoverflow.com/questions/19692514/get-value-from-dialog-window

namespace ETL_SFC_WindowsForms
{
    public partial class FormDialog_TransferData : Form
    {
        public FormDialog_TransferData()
        {
            InitializeComponent();

            foreach (var item in StagingArea.StagingObjects)
            {
                comboBox_QuellStObj.Items.Add(item.FileName);
            }
            foreach (var item in StagingArea.TransformStagingObject.Attribute)
            {
                comboBox_ZielAttribut.Items.Add(item.Name);
                comboBox_ZielAttribut2.Items.Add(item.Name);
            }

            listBoxUpdate();
        }

        public string ZielAttribut;

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox_QuellAttribute.SelectedItem is null)
            {
                MessageBox.Show("Bitte wählen Sie die Zielspalte aus und die Quellspalte.");
                return;
            }

            listBox_TransferAttribute.Items.Add(listBox_QuellAttribute.SelectedItem);
            listBox_QuellAttribute.Items.Remove(listBox_QuellAttribute.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox_QuellAttribute.Items.Add(listBox_TransferAttribute.SelectedItem);
            listBox_TransferAttribute.Items.Remove(listBox_TransferAttribute.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string[]> listbox3select = new List<string[]>();

            foreach (var item in listBox_TransferAttribute.Items)
            {
                listbox3select.Add(item.ToString().Split(" // "));
            }
            var listbox3group = listbox3select.GroupBy(x => x[0]).ToList();

            foreach (var group in listbox3group)
            {
                List<string> asd = new List<string>();
                foreach (var item in group)
                {
                    asd.Add(item[1]);
                }
                Transform.TransferData(group.Key, asd, ZielAttribut);
            }

            this.DialogResult = DialogResult.OK;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void listBoxUpdate()
        {
            listBox_QuellAttribute.Items.Clear();
            listBox_TransferAttribute.Items.Clear();
            listBox_ZielAttribute.Items.Clear();

            foreach (var item in StagingArea.StagingObjects.Where(x => x.FileName == comboBox_QuellStObj.SelectedItem?.ToString()))
            {
                foreach (var head in item.Attribute.Where(x => x.WurdeTransferiert == false))
                {
                    listBox_QuellAttribute.Items.Add(item.FileName + " // " + head.Name);
                }
            }

            foreach (var Attribut in StagingArea.TransformStagingObject.Attribute.Where(x => x.Name == comboBox_ZielAttribut.SelectedItem?.ToString()))
            {
                foreach (var item in Attribut.WurdeTransferiertVon)
                {
                    listBox_ZielAttribute.Items.Add(item.Name);
                }
                
            }
        }

        private void comboBox_QuellStObj_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxUpdate();
        }
    }
}