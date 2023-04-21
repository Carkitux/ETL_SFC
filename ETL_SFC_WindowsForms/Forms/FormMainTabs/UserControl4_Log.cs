using ETL_SFC_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        }

        private void buttonLogOeffnen_Click(object sender, EventArgs e)
        {
            if (!File.Exists(LogWriter.filePath))
                return;
            using Process fileopener = new Process();
            fileopener.StartInfo.FileName = "explorer";
            fileopener.StartInfo.Arguments = "\"" + LogWriter.filePath + "\"";
            fileopener.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (!Directory.Exists(LogWriter.logPath))
                return;
            Process.Start("explorer.exe", LogWriter.logPath);
        }

        private void UserControl4_Log_Load(object sender, EventArgs e)
        {
            textBoxLog.Text = LogWriter.GetLastLines(1000);
            textBoxLog.Focus();
            textBoxLog.SelectionStart = textBoxLog.Text.Length;
            textBoxLog.ScrollToCaret();

            toolStripStatusLabelPreviewRowCount.Text = $"Preview Zeilen Anzahl: {textBoxLog.Lines.Count()} (max. 1000)";
            toolStripStatusLabelCurrentLogSize.Text = $"Loggröße: {LogWriter.FileSizeMBCurrent} mb";
            toolStripStatusLabelLogFileCount.Text = $"Alle Logs Anzahl: {LogWriter.FileCount}";
            toolStripStatusLabelLogFileSizeSum.Text = $"Alle Logs Größe: {LogWriter.FileSizeMBAll} mb";
        }
    }
}
