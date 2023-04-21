using System.Collections.Generic;
using System.Dynamic;
using static ETL_SFC_Model.Enums;

namespace ETL_SFC_Model
{
    public class DateRow
    {
        public static int id_DatensatzCounter = 0;

        public DateRow(StagingObject _stagingObject, string quellDateiName, Quelltyp quelltyp)
        {
            ID = System.Threading.Interlocked.Increment(ref id_DatensatzCounter) - 1;
            stagingObject = _stagingObject;
            QuellDateiName = quellDateiName;
            Quelltyp = quelltyp;
            SingleDatas = new List<DataCell>();
            LogWriter.Log($"Neuen Datensatz für StagingObject \"{StagingObject}\" erstellt");
        }

        public DateRow(int _id, StagingObject _stagingObject, string quellDateiName, Quelltyp quelltyp)
        {
            ID = _id;
            stagingObject = _stagingObject;
            QuellDateiName = quellDateiName;
            Quelltyp = quelltyp;
            SingleDatas = new List<DataCell>();
        }

        private StagingObject stagingObject;
        public StagingObject StagingObject
        {
            get { return stagingObject; }
            set { stagingObject = value; }
        }

        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string quellDateiName;
        public string QuellDateiName
        {
            get { return quellDateiName; }
            set { quellDateiName = value; }
        }

        private Quelltyp quelltyp;
        public Quelltyp Quelltyp
        {
            get { return quelltyp; }
            set { quelltyp = value; }
        }

        private List<DataCell> singleDatas;
        public List<DataCell> SingleDatas
        {
            get { return singleDatas; }
            set { singleDatas = value; }
        }
    }
}