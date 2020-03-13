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
        public Robot()
        {

        }

        public ScoreData ScoreInfo { get; set; }

        #region Misc
        [Index(0)]
        public int TeamNumber { get; set; }

        [Index(1)]
        public int MatchNumber { get; set; }

        [Index(2)]
        public String WatchPosition { get; set; }
        #endregion

        #region Autonomous
        [Index(3)]
        public int BallsAutoInner { get; set; }

        [Index(4)]
        public int BallsAutoOuter { get; set; }

        [Index(5)]
        public int BallsAutoLower { get; set; }

        [Index(6)]
        [Name("CrossedLine")]
        public bool CrossedAutoLine { get; set; }
        #endregion

        #region Teleop
        [Index(7)]
        public int BallsTeleopInner { get; set; }

        [Index(8)]
        public int BallsTeleopOuter { get; set; }

        [Index(9)]
        public int BallsTeleopLower { get; set; }
        #endregion

        #region Endgame

        [Index(10)]
        public bool CanHang { get; set; }

        [Index(11)]
        public bool CanLevel { get; set; }
        #endregion

        #region Control Panel
        [Index(12)]
        public bool WheelPosition { get; set; }

        [Index(13)]
        public bool WheelRotation { get; set; }
        #endregion
    }
}
