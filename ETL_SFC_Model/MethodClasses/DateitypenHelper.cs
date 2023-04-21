using System;
using System.Collections.Generic;
using System.Text;

namespace ETL_SFC_Model
{
    public class DateitypenHelper
    {
        public static string GetFileName(string path)
        {
            string[] filePath = path.Split('\\');
            string fileName = filePath[filePath.Length - 1];
            return fileName;
        }
    }
}
