using static ETL_SFC_Model.Enums;

namespace ETL_SFC_Model
{
    public class DataCell
    {
        public DataCell(DateRow _datensatz, Attribut _attribut, string _inhalt)
        {
            datensatz = _datensatz;
            Attribut = _attribut;
            Inhalt = _inhalt;
            LogWriter.Log($"Neue SingleData für StagingObject \"{Datensatz.StagingObject}\" und Datensatz \"{Datensatz}\" erstellt");
        }

        private DateRow datensatz;
        public DateRow Datensatz
        {
            get { return datensatz; }
            set { datensatz = value; }
        }

        private Attribut attribut;
        public Attribut Attribut
        {
            get { return attribut; }
            set
            {
                if (Datensatz.StagingObject.Attribute.Contains(value))
                {
                    attribut = value;
                }
            }
        }

        private string inhalt;
        public string Inhalt
        {
            get { return inhalt; }
            set { inhalt = value; }
        }
    }
}