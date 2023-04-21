using static ETL_SFC_Model.Enums;

namespace ETL_SFC_Model
{
    public class DataCell
    {
        public DataCell(DataRow _datensatz, Attribut _attribut, string _inhalt)
        {
            DataRow = _datensatz;
            Attribut = _attribut;
            Inhalt = _inhalt;

            LogWriter.Log($"In StagingObject \"{DataRow.StagingObject.FileName}\" in DataRow \"{DataRow.ID}\" : New DataCell \"{Inhalt}\" with Attribut \"{Attribut.Name}\"");
        }

        private DataRow dataRow;
        public DataRow DataRow
        {
            get { return dataRow; }
            set { dataRow = value; }
        }

        private Attribut attribut;
        public Attribut Attribut
        {
            get { return attribut; }
            set
            {
                if (DataRow.StagingObject.Attributes.Contains(value))
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