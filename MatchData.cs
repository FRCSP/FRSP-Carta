using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRSP_Carta
{
    public class MatchData
    {
        public int RawScore { get; set; }

        public int AutoScore { get; set; }

        public int TeleScore { get; set; }

        public bool PositionPanel { get; set; }

        public bool RotationPanel { get; set; }

        public MatchData(int r, int a, int t, bool pos, bool rot)
        {
            RawScore = r;
            AutoScore = a;
            TeleScore = t;
            PositionPanel = pos;
            RotationPanel = rot;
        }

        public MatchData(int a, int t, bool pos, bool rot)
        {
            AutoScore = a;
            TeleScore = t;
            PositionPanel = pos;
            RotationPanel = rot;
            RawScore = AutoScore + TeleScore + Convert.ToInt32(PositionPanel) * 20 + Convert.ToInt32(RotationPanel) * 10;
        }
    }
}
