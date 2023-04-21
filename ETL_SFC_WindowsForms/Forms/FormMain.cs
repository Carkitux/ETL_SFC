using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ETL_SFC_WindowsForms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            activeUserControl = new UserControl0_Start();
            activeUserControl.Dock = DockStyle.Fill;
            activeUserControl.Parent = panel1;
        }

        private UserControl activeUserControl;

        private void button2_Click(object sender, EventArgs e)
        {
            UserControlSwitch(new UserControl1_Extract(), (Button)sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserControlSwitch(new UserControl2_Transform(), (Button)sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserControlSwitch(new UserControl3_Load(), (Button)sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserControlSwitch(new UserControl4_Log(), (Button)sender);
        }

        private void UserControlSwitch(UserControl newUserConrol, Button currentButton)
        {
            button2.BackColor = Color.Silver;
            button3.BackColor = Color.Silver;
            button4.BackColor = Color.Silver;
            button5.BackColor = Color.Silver;

            if (activeUserControl.Name == newUserConrol.Name)
            {
                newUserConrol = new UserControl0_Start();
            }
            else
            {
                currentButton.BackColor = Color.LightGray;
            }

            activeUserControl?.Dispose();
            activeUserControl = newUserConrol;
            activeUserControl.Dock = DockStyle.Fill;
            activeUserControl.Parent = panel1;
        }
    }
}
