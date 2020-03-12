using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace FRSP_Carta.CSVImport
{
    public class RobotMap : ClassMap<Robot>
    {
        public RobotMap()
        {
            AutoMap(CultureInfo.CurrentCulture);
        }
    }
}
