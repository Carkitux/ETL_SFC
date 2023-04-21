using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Diagnostics;

namespace ETL_SFC_Model
{
    public class CSV
    {
        public static StagingObject LoadFromCSV(string path, string separator, bool hasHeader)
        {
            LogWriter.Log($"Step Extract - Startet Export CSV: \"{path}\"");

            // Liest alle Zeilen der CSV Datei in einen String ein
            var lines = File.ReadLines(path, Encoding.UTF8);

            // Lesen des Dateinamens aus dem übergebenen Dateipfad
            var dateipfad = path.Split('\\');
            var dateiname = dateipfad[dateipfad.Length - 1];

            // Erstellen des neuen StagingObjects
            StagingObject stagingObject = new StagingObject(dateiname);

            // Wenn die CSV Datei Header hat, dann werden diese als Attribute im erstellten Staging Object hinterlegt
            // um diese später den einzelnen Daten zuweisen zu können
            if (hasHeader)
            {
                string[] attribute = new string[0];
                attribute = lines.First().Replace(separator + " ", separator).Split(separator);
                lines = lines.Skip(1);
                foreach (string attribut in attribute)
                {
                    Attribut newAttribut = new Attribut(attribut, Enums.Datentyp.Unbekannt);
                    stagingObject.Attribute.Add(newAttribut);
                }
            }

            foreach (var line in lines)
            {
                // Erstellen eines neuen Datensatzes für jede Zeile der CSV
                DateRow datensatz = new DateRow(stagingObject, dateiname, Enums.Quelltyp.CSV);

                // Splittet die Zeile nach dem übergeben Seperator in einzelne Felder zum einfügen in SingleData
                string[] fields = line.Replace(separator + " ", separator).Split(separator);

                // Zähler um das jeweilige Attribut zuweisen zu können
                int currentFieldID = 0;
                foreach (var field in fields)
                {
                    DataCell singleData;

                    // Wenn die CSV Header hat, dann wird die SingleData mit dem vorher erstellten Attribut hinterlegt
                    // sonst wird es Ohne Attributskennung erstellt
                    if (hasHeader)
                    {
                        singleData = new DataCell(datensatz, stagingObject.Attribute[currentFieldID], field);
                    }
                    else
                    {
                        singleData = new DataCell(datensatz, null, field);
                    }
                    // Fügt das erstellte SingleData dem Datensatz hinzu
                    datensatz.SingleDatas.Add(singleData);

                    currentFieldID++;
                }
                // Fügt den Datensatz dem aktuellem Staging Objekt hinzu
                stagingObject.Datensaetze.Add(datensatz);
            }
            // Fügt das Staging Object unserer global verfügabren Staging Area für spätere Benutzung hinzu
            // und returned das aktuelle Staging Object für eine Verwendung im Frontend
            StagingArea.StagingObjects.Add(stagingObject);
            return stagingObject;
        }

        public static void CreateCSV(string path)
        {
            // Das TranformStagingObjekt, in dem die transformierte Tabelle gespeichert ist
            StagingObject stagingObject = StagingArea.StagingObjects[0]; //.Where(x => x.IamTransform).First();

            // Schreiben des CSV Headers mit Semikolon Seperator
            using var writer = new StreamWriter(path);
            writer.WriteLine(string.Join(';', stagingObject.Attribute));

            foreach (var datensatz in stagingObject.Datensaetze)
            {
                // Für jedes SingleData Objekt wird nur der Inhalt in ein Array geschrieben
                // und dieser wird dann Zeile für Zeile in die Datei geschrieben
                var csvDatensatz = datensatz.SingleDatas.Select(singleData => singleData.Inhalt).ToArray();
                writer.WriteLine(string.Join(';', csvDatensatz));
            }
        }
    }
}