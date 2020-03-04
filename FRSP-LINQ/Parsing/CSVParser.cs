using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Reflection;

namespace FRSP_LINQ.Parsing
{
    public class CSVParser
    {
        static string path = Assembly.GetExecutingAssembly().CodeBase + "/test.csv";
        static readonly string header = "TeamNumber,MatchNumber,WatchPosition,BallsAutoInner,BallsAutoOuter,BallsAutoLower,CrossedLine,BallsTeleopInner,BallsTeleopOuter,BallsTeleopLower,CanHang,CanLevel,WheelPosition,WheelRotation";
        public static IEnumerable<T> GetAllData<T>()
        {
            List<Robot> robots = new List<Robot>();
            FileStream rs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);

            rs.Close();
        }
    }
}
