using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FRSP_LINQ.Parsing;

namespace FRSP_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = CSVParser.GetAllData();
        }
    }
}
