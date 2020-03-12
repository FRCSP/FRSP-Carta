using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;





namespace FRSP_Carta.CSVImport
{
    public class CSVImporter
    {
        static List<Robot> robots = new List<Robot>();

        public static List<Robot> Import(string filepath)
        {
            robots = ReadObjects(ReadFile(filepath));
            return robots;
        }

        private static string[] ReadFile(string filepath)
        {
            return File.ReadAllLines(filepath);
        }

        private static List<Robot> ReadObjects(string[] lines)
        {
            for (int i = 0; i < lines.Length; i++)
            {

            }
        }
    }
}
