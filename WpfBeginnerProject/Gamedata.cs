using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfBeginnerProject.Models;

namespace WpfBeginnerProject
{
    public class Gamedata
    {
        private string[] csvData;
        private List<Street> streetData = new List<Street>();

        public void ReadCsvData()
        {
            string projectPath = Directory.GetParent(Path.GetDirectoryName(Environment.CurrentDirectory)).FullName;
            string filePath = @"\Data Tables\streets.csv";

            string path = projectPath + filePath;

            csvData = File.ReadAllLines(path);
        }

        public void ParseCsvData()
        {
            try
            {
                foreach (string rowData in csvData)
                {
                    string[] cellData = rowData.Split(';');

                    Street street = new Street();
                    street.Name = cellData[0];
                    street.Preis = Int32.Parse(cellData[1]);
                    street.Miete = Int32.Parse(cellData[2]);
                    street.Einkommen = Int32.Parse(cellData[3]);
                    street.FeldArt = cellData[4];
                }
            }
            catch (Exception exc)
            {
                //Do something
            }
        }

    }
}
