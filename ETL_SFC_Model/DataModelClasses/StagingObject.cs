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
        public StagingObject()
        {
            datensaetze = new List<DateRow>();
            attribute = new List<Attribut>();
            LogWriter.Log($"Neues StagingObject erstellt");
        }
        public StagingObject(string filename)
        {
            FileName = filename;
            datensaetze = new List<DateRow>();
            attribute = new List<Attribut>();
            LogWriter.Log($"Neues StagingObject \"{filename}\" erstellt");
        }

        private string fileName;
        public string FileName
        {
            get { return fileName; }
            private set { fileName = value; }
        }

        private List<DateRow> datensaetze;
        public List<DateRow> Datensaetze
        {
            get { return datensaetze; }
            set { datensaetze = value; }
        }

        private List<Attribut> attribute;
        public List<Attribut> Attribute
        {
            get { return attribute; }
            set { attribute = value; }
        }
    }
}
