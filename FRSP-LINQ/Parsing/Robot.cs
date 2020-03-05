using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRSP_LINQ.Parsing
{
    public class Robot
    {

        public int BallsAutoLower { get; set; }

        public int BallsAutoOuter { get; set; }

        public int BallsAutoInner { get; set; }

        public bool CrossedAutoLine { get; set; }

        public int BallsTeleLower { get; set; }

        public int BallsTeleOuter { get; set; }

        public int BallsTeleInner { get; set; }

        public bool WheelRotation { get; set; }
        
        public bool WheelPosition { get; set; }

        public bool CanHang { get; set; }

        public bool IsLevel { get; set; }

        public int TeamNumber { get; set; }

        public int MatchNumber { get; set; }

        public String WatchPos { get; set; }
    }
}
