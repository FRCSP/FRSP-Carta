using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRSP_Carta
{
    public class ScoreData
    {
        public int RawScore { get; set; }

        public int AutoScore { get; set; }

        public int TeleScore { get; set; }

        public ScoreData(int r, int a, int t)
        {
            RawScore = r;
            AutoScore = a;
            TeleScore = t;
        }
    }
}
