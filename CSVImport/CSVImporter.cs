using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CsvHelper;
using System.Globalization;


namespace FRSP_Carta.CSVImport
{
    public class CSVImporter
    {
        static List<Robot> robots = new List<Robot>();
        public static List<Robot> Import(string filepath)
        {
            using (StreamReader sr = new StreamReader(filepath))
            {
                using (CsvReader read = new CsvReader(sr, CultureInfo.InvariantCulture))
                {
                    var list = read.GetRecords<Robot>().ToList();
                    if (robots != list)
                    {
                        robots = list;
                    }
                    return robots;
                }
            }
        }
    }
}
