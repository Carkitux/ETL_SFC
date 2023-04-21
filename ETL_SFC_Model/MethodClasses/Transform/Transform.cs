using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ETL_SFC_Model
{
    public class Transform
    {
        public static void TransferData(string _quellStObj, List<string> _quellAttribut, string _zielAttribut)
        {
            StagingObject TransformStObj = StagingArea.TransformStagingObject;

            StagingObject quellStObj = StagingArea.StagingObjects.Where(x => x.FileName == _quellStObj).First();
            List<Attribut> quellAttribute = quellStObj.Attribute.Where(x => _quellAttribut.Contains(x.Name)).ToList();
            Attribut zielAttribut = TransformStObj.Attribute.Where(x => x.Name == _zielAttribut).First();

            foreach (DateRow quelldatenSatz in quellStObj.Datensaetze)
            {
                List<DataCell> quellsingleDatas = quelldatenSatz.SingleDatas.Where(x => quellAttribute.Where(y => y.Name == x.Attribut.Name).Count() > 0).ToList();
                string quellInhalt = Transform.Zusammenfuegen(quellsingleDatas);

                DateRow TransformDatenSatz = TransformStObj.Datensaetze.Where(x => x.QuellDateiName == quelldatenSatz.QuellDateiName && x.ID == quelldatenSatz.ID).FirstOrDefault();
                if (TransformDatenSatz is null)
                {
                     DateRow newTransformDatensatz = new DateRow(quelldatenSatz.ID, TransformStObj, quelldatenSatz.QuellDateiName, quelldatenSatz.Quelltyp);
                     DataCell newTransformSingleData = new DataCell(newTransformDatensatz, zielAttribut, quellInhalt);
                     newTransformDatensatz.SingleDatas.Add(newTransformSingleData);
                     TransformStObj.Datensaetze.Add(newTransformDatensatz);
                }
                else
                {
                     DataCell newTransformSingleData = new DataCell(TransformDatenSatz, zielAttribut, quellInhalt);
                     TransformDatenSatz.SingleDatas.Add(newTransformSingleData);
                }
            }
            quellAttribute.ForEach(x => x.WurdeTransferiert = true);
            zielAttribut.WurdeTransferiertVon.AddRange(quellAttribute);
        }

        public static void StornoTransferData(string _quellStObj, string _quellAttribut, string _zielAttribut)
        {

        }

        private static string Zusammenfuegen(List<DataCell> quellsingleDatas)
        {
            string neuerInhalt = string.Empty;
            int i = 0;
            foreach (var item in quellsingleDatas)
            {
                if (quellsingleDatas.Count() - i == 1)
                {
                    neuerInhalt = neuerInhalt + item.Inhalt;
                }
                else
                {
                    neuerInhalt = neuerInhalt + item.Inhalt + " ";
                }
                i++;
            }
            return neuerInhalt;
        }

        public static void Splitten(string _quellStObj, string _quellAttribut, string _zielAttribut)
        {

        }

        public static void Ersetzen(string _quellStObj, string _quellAttribut, string _zielAttribut)
        {

        }

        public static void CreateAttribut(string name, Enums.Datentyp datentyp)
        {
            StagingObject TransformStObj = StagingArea.TransformStagingObject;
            Attribut newAttribut = new Attribut(name, datentyp);
            TransformStObj.Attribute.Add(newAttribut);
        }

        public static void DeleteAttribut(string attributsName)
        {
            StagingObject TransformStObj = StagingArea.TransformStagingObject;
            Attribut selectedAttribut = TransformStObj.Attribute.Where(x => x.Name == attributsName).First();
            selectedAttribut.WurdeTransferiertVon.ForEach(x => x.WurdeTransferiert = false);
            foreach (var datensatz in TransformStObj.Datensaetze)
            {
                DataCell singleData = datensatz.SingleDatas.Where(x => x.Attribut == selectedAttribut).First();
                datensatz.SingleDatas.Remove(singleData);
            }
            TransformStObj.Datensaetze.RemoveAll(x => x.SingleDatas.Count == 0);
            TransformStObj.Attribute.Remove(selectedAttribut);
        }
    }
}
