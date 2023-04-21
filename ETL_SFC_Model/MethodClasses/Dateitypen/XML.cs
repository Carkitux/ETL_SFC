using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Linq;
using System.Diagnostics;

namespace ETL_SFC_Model
{
    public class XML
    {
        public static StagingObject LoadFromXmlFile(string path)
        {
            // Holt alle XML Objekte innerhalb der XML Datei und speichert sie in einem Dokument.
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            // Lesen des Dateinamens aus dem übergebenen Dateipfad
            var dateipfad = path.Split('\\');
            var dateiname = dateipfad[dateipfad.Length - 1];

            // Erstellen des neuen StagingObjects
            StagingObject stagingObject = new StagingObject(dateiname);

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                // Erstellen eines neuen Datensatzes für jedes Objekt der XML
                DateRow d = new DateRow(stagingObject, dateiname, Enums.Quelltyp.XML);

                foreach (XmlNode node2 in node.ChildNodes)
                {
                    Attribut attribut = stagingObject.Attribute.Where(x => x.Name == node2.Name).FirstOrDefault();
                    if (attribut is null)
                    {
                        Attribut newAttribut = new Attribut(node2.Name, Enums.Datentyp.Unbekannt);
                        stagingObject.Attribute.Add(newAttribut);
                        attribut = newAttribut;
                    }
                    DataCell sd = new DataCell(d, attribut, node2.InnerText);

                    // Fügt das erstellte SingleData dem Datensatz hinzu
                    d.SingleDatas.Add(sd);
                    //LogWriter.LogWrite(attribut + " " + inhalt);
                }
                // Fügt den Datensatz dem aktuellem Staging Objekt hinzu
                stagingObject.Datensaetze.Add(d);
            }
            // Fügt das Staging Object unserer global verfügabren Staging Area für spätere Benutzung hinzu
            // und returned das aktuelle Staging Object für eine Verwendung im Frontend
            StagingArea.StagingObjects.Add(stagingObject);
            return stagingObject;
        }

        public static void CreateXML(string path)
        {
            // Objekt, in dem die transformierte Tabelle gespeichert ist.
            var stagingObject = StagingArea.StagingObjects[0];

            // Erstellung des Dokumentes und der Deklaration.
            var xmlDocument = new XmlDocument();
            var declaration = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
            xmlDocument.AppendChild(declaration);

            var root = xmlDocument.CreateElement("vereinsverwaltung");
            xmlDocument.AppendChild(root);

            foreach (var datensatz in stagingObject.Datensaetze)
            {
                // Erstellen von Xml Elementen für jeden Datensatz.
                var singleDataList = xmlDocument.CreateElement("mitglied");

                // Hinzufügen der Key-Value-Paare aus jedem Single Data Objekt als XML Element zum mitglied XML Element.
                foreach (var singleData in datensatz.SingleDatas)
                {
                    var singleDataElement = xmlDocument.CreateElement(singleData.Attribut.Name);
                    singleDataElement.InnerText = singleData.Inhalt;
                    singleDataList.AppendChild(singleDataElement);
                }
                // Hinzufügen des Mitglied Xml Elements zum übergeordneten Vereinsverwaltung Element.
                root.AppendChild(singleDataList);
            }
            // Exportieren des Xml Dokumentes in den ausgewählten Pfad.
            xmlDocument.Save(path);
        }
    }
}