using ETL_SFC_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ETL_SFC_WindowsForms
{
    public partial class UserControl4_Log : UserControl
    {
        public UserControl4_Log()
        {
            InitializeComponent();

            textBoxFileCount.Text = $"Anzahl: {LogWriter.FileCount}";
            textBoxFileSize.Text = $"Größe: {LogWriter.FileSizeMB} mb";
        }

        private void buttonLogOeffnen_Click(object sender, EventArgs e)
        {
            LogWriter.OpenTxtLogFile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogWriter.OpenExplorerLogPath();
        }

        private void UserControl4_Log_Load(object sender, EventArgs e)
        {
            textBoxLog.Text = LogWriter.GetLastLines(1000);
            textBoxLog.Focus();
            textBoxLog.SelectionStart = textBoxLog.Text.Length;
            textBoxLog.ScrollToCaret();
        }
    }
}
