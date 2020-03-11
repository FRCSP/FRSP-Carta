using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRSP_Carta.CSVImport
{
    public class Robot
    {
        public ScoreData ScoreInfo { get; set; }

        #region Autonomous

        [Index(5)]
        public int BallsAutoLower { get; set; }

        [Index(4)]
        public int BallsAutoOuter { get; set; }

        [Index(3)]
        public int BallsAutoInner { get; set; }

        [Index(6)]
        public bool CrossedAutoLine { get; set; }
        #endregion

        #region Teleop
        [Index(9)]
        public int BallsTeleLower { get; set; }

        [Index(8)]
        public int BallsTeleOuter { get; set; }

        [Index(7)]
        public int BallsTeleInner { get; set; }

        [Index(12)]
        public bool WheelRotation { get; set; }

        [Index(13)]
        public bool WheelPosition { get; set; }
        #endregion

        #region Endgame

        [Index(10)]
        public bool CanHang { get; set; }

        [Index(11)]
        public bool IsLevel { get; set; }
        #endregion

        #region Misc

        [Index(0)]
        public int TeamNumber { get; set; }

        [Index(1)]
        public int MatchNumber { get; set; }

        [Index(2)]
        public String WatchPos { get; set; }
        #endregion
    }
}
