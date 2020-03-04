using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRSP_LINQ.Parsing
{
    public class Robot
    {
        //public static Robot self;

        public Robot()
        {

        }

        // all game events and data points. this class is a liason between the UI itself and the VM

        #region Autonomous
        private int ballsAutoLower = 0; // 2pts
        private int ballsAutoOuter = 0; // 4pts
        private int ballsAutoInner = 0; // 6pts
        private bool crossedAutoLine = false; // true if the robot moves during auto

        //[Index(3)]
        public int BallsAutoLower
        {
            get
            {
                return ballsAutoLower;
            }
            set
            {
                ballsAutoLower = value;
            }
        }

        //[Index(4)]
        public int BallsAutoOuter
        {
            get
            {
                return ballsAutoOuter;
            }
            set
            {
                ballsAutoOuter = value;
            }
        }

        //[Index(5)]
        public int BallsAutoInner
        {
            get
            {
                return ballsAutoInner;
            }
            set
            {
                ballsAutoInner = value;
            }
        }

        //[Index(6)]
        public bool CrossedAutoLine
        {
            get
            {
                return crossedAutoLine;
            }
            set
            {
                crossedAutoLine = value;
            }
        }
        #endregion

        #region Teleop
        private int ballsTeleLower = 0; // 1pt
        private int ballsTeleOuter = 0; // 2pts
        private int ballsTeleInner = 0; // 3pts
        private bool wheelRotationControl = false; // 10pts
        private bool wheelPositionControl = false; // 20pts

        //[Index(7)]
        public int BallsTeleLower
        {
            get
            {
                return ballsTeleLower;
            }
            set
            {
                ballsTeleLower = value;
            }
        }

        //[Index(8)]
        public int BallsTeleOuter
        {
            get
            {
                return ballsTeleOuter;
            }
            set
            {
                ballsTeleOuter = value;
            }
        }

        //[Index(9)]
        public int BallsTeleInner
        {
            get
            {
                return ballsTeleInner;
            }
            set
            {
                ballsTeleInner = value;
            }
        }

        //[Index(10)]
        public bool WheelRotation
        {
            get
            {
                return wheelRotationControl;
            }
            set
            {
                wheelRotationControl = value;
            }
        }

        //[Index(10)]
        public bool WheelPosition
        {
            get
            {
                return wheelPositionControl;
            }
            set
            {
                wheelPositionControl = value;
            }
        }
        #endregion

        #region Endgame
        private bool hang = false; // 25pts
        //private bool balance; // neat
        private bool level = false; // 15pts

        //[Index(11)]
        public bool CanHang
        {
            get
            {
                return hang;
            }
            set
            {
                hang = value;
            }
        }

        //[Index(13)]
        public bool IsLevel
        {
            get
            {
                return level;
            }
            set
            {
                level = value;
            }
        }
        #endregion

        #region Misc

        private int? _teamNum;
        private int _matchNum = 1;
        private String _watchPos = string.Empty;

        //[Index(1)]
        public int TeamNumber
        {
            get
            {
                return _teamNum ?? 0;
            }
            set
            {
                _teamNum = value;
            }
        }

        //[Index(0)]
        public int MatchNumber
        {
            get
            {
                return _matchNum;
            }
            set
            {
                _matchNum = value;
            }
        }


        public String WatchPos
        {
            get
            {
                return _watchPos;
            }
            set
            {
                _watchPos = value;
            }
        }
        #endregion

        public void Reset()
        {
            CrossedAutoLine = false;
            BallsAutoInner = 0;
            BallsAutoLower = 0;
            BallsAutoOuter = 0;
            BallsTeleInner = 0;
            BallsTeleOuter = 0;
            BallsTeleLower = 0;
            CanHang = false;
            IsLevel = false;
            WheelPosition = false;
            WheelRotation = false;
            MatchNumber += 1;
            TeamNumber = 0000;
        }
    }
}
