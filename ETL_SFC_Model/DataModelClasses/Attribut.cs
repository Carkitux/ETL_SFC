using System;
using System.Collections.Generic;
using System.Text;

namespace ETL_SFC_Model
{
    public class Attribut
    {
        public Attribut(StagingObject stagingObject, string name, Enums.Datentyp datentyp)
        {
            StagingObject = stagingObject;
            Name = name;
            Datatyp = datentyp;
            DataCells = new List<DataCell>();
            WurdeTransferiert = false;
            WurdeTransferiertVon = new List<Attribut>();

            LogWriter.Log($"In StagingObject \"{StagingObject.FileName}\" : New Attribut \"{Name}\" with Datatyp \"{Datatyp}\"");
        }

        private StagingObject stagingObject;
        public StagingObject StagingObject
        {
            get { return stagingObject; }
            set { stagingObject = value; }
        }

        private List<DataCell> dataCells;
        public List<DataCell> DataCells
        {
            get { return dataCells; }
            set { dataCells = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Enums.Datentyp datatyp;
        public Enums.Datentyp Datatyp
        {
            get { return datatyp; }
            set { datatyp = value; }
        }

        private bool wurdeTransferiert;
        public bool WurdeTransferiert
        {
            get { return wurdeTransferiert; }
            set { wurdeTransferiert = value; }
        }

        private List<Attribut> wurdeTransferiertVon;
        public List<Attribut> WurdeTransferiertVon
        {
            get { return wurdeTransferiertVon; }
            set { wurdeTransferiertVon = value; }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
