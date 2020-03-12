using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;


namespace FRSP_Carta.CSVImport
{
    public class CSVImporter
    {
        static List<Robot> robots = new List<Robot>();
        static CsvConfiguration config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            HeaderValidated = null,
            HasHeaderRecord = true,
            Delimiter = ","
        };

        public static List<Robot> Import(string filepath)
        {
            using (StreamReader sr = new StreamReader(filepath))
            {
                using (CsvReader read = new CsvReader(sr, CultureInfo.InvariantCulture))
                {
                    read.Configuration.RegisterClassMap<RobotMap>();
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
