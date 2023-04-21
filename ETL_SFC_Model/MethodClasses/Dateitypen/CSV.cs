using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Diagnostics;
using System.Xml.Linq;

namespace ETL_SFC_Model
{
    public class CSV
    {
        public static void LoadFromCSV(string path, string separator, bool hasHeader)
        {
            LogWriter.LogHeader($"Step Extract - Startet Export CSV: \"{path}\"");

            // Liest alle Zeilen der CSV Datei in einen String ein
            var lines = File.ReadLines(path);

            // Lesen des Dateinamens aus dem übergebenen Dateipfad
            string fileName = DateitypenHelper.GetFileName(path);

            // Erstellen des neuen StagingObjects
            StagingObject stagingObject = new StagingObject(fileName);

            // Befüllt das StagingObject mit allen Attributen und Zeilen der CSV
            CSVHeader(separator, hasHeader, lines, stagingObject);
            CSVLines(separator, hasHeader, lines, fileName, stagingObject);

            // Fügt das Staging Object unserer global verfügbaren Staging Area für spätere Benutzung hinzu
            StagingArea.StagingObjects.Add(stagingObject);
        }

        public static StagingObject LoadTempFromCSV(string path, string separator, bool hasHeader, int lineCount)
        {
            // Logging ausschalten, da wir nur ein temporäes StagingObject erstellen für Userfeedback
            LogWriter.SkipLogging = true;

            // Liest lediglich X Zeilen der CSV Datei in einen String ein
            var lines = File.ReadLines(path);
            lines = lines.Reverse().Skip(lines.Count() - lineCount).Reverse();

            // Lesen des Dateinamens aus dem übergebenen Dateipfad
            string fileName = DateitypenHelper.GetFileName(path);

            // Erstellen des temporären StagingObjects
            StagingObject tempStagingObject = new StagingObject(fileName);

            // Befüllt das temporäre StagingObject mit allen Attributen und den X Zeilen der CSV
            CSVHeader(separator, hasHeader, lines, tempStagingObject);
            CSVLines(separator, hasHeader, lines, fileName, tempStagingObject);

            // Logging wieder anschalten
            LogWriter.SkipLogging = false;

            // Gibt das temporäre StagingObject zur weiteren Verwendung zurück, da dieses diemsal nicht in die StagingArea integriert wird
            return tempStagingObject;
        }

        private static void CSVHeader(string separator, bool hasHeader, IEnumerable<string> lines, StagingObject stagingObject)
        {
            // Wenn die CSV Datei Header hat, dann werden diese als Attribute im erstellten Staging Object hinterlegt
            // um diese später den einzelnen Daten zuweisen zu können
            if (hasHeader)
            {
                string[] attribute = new string[0];
                attribute = lines.First().Replace(separator + " ", separator).Split(separator);
                foreach (string attribut in attribute)
                {
                    Attribut newAttribut = new Attribut(stagingObject, attribut, Enums.Datentyp.Unbekannt);
                    stagingObject.Attributes.Add(newAttribut);
                }
            }
            // Wenn die CSV Datei keine Header hat, wird für jede Spalte ein Ersatz Attribut erzeugt mit hochzählenden Spaltennamen
            else
            {
                string[] attribute = new string[0];
                int count = lines.First().Replace(separator + " ", separator).Split(separator).Count();
                for (int i = 0; i < count; i++)
                {
                    Attribut newAttribut = new Attribut(stagingObject, $"Spalte{i}", Enums.Datentyp.Unbekannt);
                    stagingObject.Attributes.Add(newAttribut);
                }
            }
        }

        private static void CSVLines(string separator, bool hasHeader, IEnumerable<string> lines, string dateiname, StagingObject stagingObject)
        {
            if (hasHeader)
            {
                lines = lines.Skip(1);
            }
            foreach (var line in lines)
            {
                // Erstellen eines neuen Datensatzes für jede Zeile der CSV
                DataRow datensatz = new DataRow(stagingObject, dateiname, Enums.Quelltyp.CSV);

                // Splittet die Zeile nach dem übergeben Seperator in einzelne Felder zum einfügen in SingleData
                string[] fields = line.Replace(separator + " ", separator).Split(separator);

                // Zähler um das jeweilige Attribut zuweisen zu können
                int currentFieldID = 0;
                foreach (var field in fields)
                {
                    DataCell singleData;

                    // Wenn die CSV Header hat, dann wird die SingleData mit dem vorher erstellten Attribut hinterlegt
                    // sonst wird es Ohne Attributskennung erstellt
                    //if (hasHeader)
                    //{
                        singleData = new DataCell(datensatz, stagingObject.Attributes[currentFieldID], field);
                    //}
                    //else
                    //{
                    //    singleData = new DataCell(datensatz, null, field);
                    //}
                    // Fügt das erstellte SingleData dem Datensatz hinzu
                    datensatz.DataCells.Add(singleData);

                    currentFieldID++;
                }
                // Fügt den Datensatz dem aktuellem Staging Objekt hinzu
                stagingObject.DataRows.Add(datensatz);
            }
        }

        public static void CreateCSV(string path)
        {
            // Das TranformStagingObjekt, in dem die transformierte Tabelle gespeichert ist
            StagingObject stagingObject = StagingArea.StagingObjects[0]; //.Where(x => x.IamTransform).First();

            // Schreiben des CSV Headers mit Semikolon Seperator
            using var writer = new StreamWriter(path);
            writer.WriteLine(string.Join(';', stagingObject.Attributes));

            foreach (var datensatz in stagingObject.DataRows)
            {
                // Für jedes SingleData Objekt wird nur der Inhalt in ein Array geschrieben
                // und dieser wird dann Zeile für Zeile in die Datei geschrieben
                var csvDatensatz = datensatz.DataCells.Select(singleData => singleData.Inhalt).ToArray();
                writer.WriteLine(string.Join(';', csvDatensatz));
            }
        }
    }
}