using System;
using System.Collections.Generic;
using System.Text;

namespace ETL_SFC_Model
{
    public class Attribut
    {
        public Attribut(string _name, Enums.Datentyp _datentyp)
        {
            name= _name;
            datentyp= _datentyp;
            WurdeTransferiertVon = new List<Attribut>();
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Enums.Datentyp datentyp;
        public Enums.Datentyp Datentyp
        {
            get { return datentyp; }
            set { datentyp = value; }
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
