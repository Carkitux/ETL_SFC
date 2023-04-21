using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;

namespace ETL_SFC_Model
{
    public class StagingObject
    {
        public StagingObject(string filename)
        {
            FileName = filename;
            DataRows = new List<DataRow>();
            Attributes = new List<Attribut>();

            LogWriter.Log($"New StagingObject \"{filename}\"");
        }

        private string fileName;
        public string FileName
        {
            get { return fileName; }
            private set { fileName = value; }
        }

        private List<DataRow> dataRows;
        public List<DataRow> DataRows
        {
            get { return dataRows; }
            set { dataRows = value; }
        }

        private List<Attribut> attributes;
        public List<Attribut> Attributes
        {
            get { return attributes; }
            set { attributes = value; }
        }
    }
}
