using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

//https://stackoverflow.com/questions/20185015/how-to-write-log-file-in-c

namespace ETL_SFC_Model
{
    public static class LogWriter
    {
        private static string logPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\" + "Logs";
        private static string logFile = $"Log {DateTime.Now.GetDateTimeFormats()[2]}.txt";

        static LogWriter()
        {
            if (!Directory.Exists(logPath))
                Directory.CreateDirectory(logPath);

            bool doNewLine = (File.Exists(FilePath));

            using (StreamWriter textWriter = File.AppendText(FilePath))
            {
                if (doNewLine)
                    textWriter.WriteLine("");
                textWriter.WriteLine($"Started new Log from {DateTime.Now}:");
                textWriter.WriteLine("-----------------------------------------");
            }
        }

        public static string FilePath
        {
            get { return logPath + "\\" + logFile; }
        }

        public static int FileCount
        {
            get { return Directory.GetFiles(logPath).Length; }
        }

        public static float FileSizeMB
        {
            get
            {
                float fileSize = 0;
                foreach (var fullFilePath in Directory.GetFiles(logPath))
                {
                    FileInfo fileInfo = new FileInfo(fullFilePath);
                    fileSize += (float)fileInfo.Length;
                }
                fileSize = (float)Math.Round(fileSize / 1024 / 1024, 2);
                return fileSize;
            }
        }

        public static void Log(string logMessage)
        {
            WriteInFile(logMessage);
        }

        private static void WriteInFile(string logMessage)
        {
            using (StreamWriter w = File.AppendText(FilePath))
            {
                w.WriteLine("\t" + DateTime.Now + ": " + logMessage);
            }
        }

        public static void OpenExplorerLogPath()
        {
            if (!Directory.Exists(logPath))
                return;
            Process.Start("explorer.exe", logPath);
        }

        public static void OpenTxtLogFile()
        {
            if (!File.Exists(FilePath))
                return;
            using Process fileopener = new Process();
            fileopener.StartInfo.FileName = "explorer";
            fileopener.StartInfo.Arguments = "\"" + FilePath + "\"";
            fileopener.Start();
        }

        public static string GetLastLines(int countLastLines)
        {
            string[] lines = File.ReadLines(FilePath, Encoding.UTF8).ToArray();
            int linesCount = lines.Count();
            string[] lastLinesReverse = new string[countLastLines];
            string lastLines = String.Empty;

            if (linesCount < countLastLines)
            {
                countLastLines = linesCount;
            }

            for (int i = 1; i <= countLastLines; i++)
            {
                lastLinesReverse[i - 1] = lines[linesCount - i];
            }

            foreach (var item in lastLinesReverse.Reverse())
            {
                lastLines += item + Environment.NewLine;
            }

            return lastLines;
        }
    }
}
