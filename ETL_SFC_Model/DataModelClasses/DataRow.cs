using System.Collections.Generic;
using System.Dynamic;
using static ETL_SFC_Model.Enums;

namespace ETL_SFC_Model
{
    public class DataRow
    {
        public static int id_DatensatzCounter = 0;

        public DataRow(StagingObject stagingObject, string quellDateiName, Quelltyp quelltyp)
        {
            StagingObject = stagingObject;
            ID = System.Threading.Interlocked.Increment(ref id_DatensatzCounter) - 1;
            QuellDateiName = quellDateiName;
            Quelltyp = quelltyp;
            DataCells = new List<DataCell>();

            LogWriter.Log($"In StagingObject \"{StagingObject.FileName}\" : New DataRow \"{ID}\"");
        }

        public DataRow(int id, StagingObject stagingObject, string quellDateiName, Quelltyp quelltyp)
        {
            StagingObject = stagingObject;
            ID = id;
            QuellDateiName = quellDateiName;
            Quelltyp = quelltyp;
            DataCells = new List<DataCell>();

            LogWriter.Log($"New DataRow \"{ID}\" in StagingObject \"{StagingObject.FileName}\"");
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

        private List<DataCell> dataCells;
        public List<DataCell> DataCells
        {
            get { return dataCells; }
            set { dataCells = value; }
        }
    }
}