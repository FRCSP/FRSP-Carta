
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRSP_Carta.CSVImport
{
    public class Robot
    {

        public MatchData MatchInfo { get; set; }

        #region Misc
        public int TeamNumber { get; set; }

        public int MatchNumber { get; set; }

        public String WatchPosition { get; set; }
        #endregion

        #region Autonomous
        public int BallsAutoInner { get; set; }

        public int BallsAutoOuter { get; set; }

        public int BallsAutoLower { get; set; }

        public bool CrossedAutoLine { get; set; }
        #endregion

        #region Teleop
        public int BallsTeleopInner { get; set; }

        public int BallsTeleopOuter { get; set; }

        public int BallsTeleopLower { get; set; }
        #endregion

        #region Endgame

        public bool CanHang { get; set; }

        public bool CanLevel { get; set; }
        #endregion

        #region Control Panel
        public bool WheelPosition { get; set; }

        public bool WheelRotation { get; set; }
        #endregion
    }
}
