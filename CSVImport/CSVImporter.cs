using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic.FileIO;
using System.IO;

namespace FRSP_Carta.CSVImport
{
    public class CSVImporter
    {
        static List<Robot> robots = new List<Robot>();

        public static List<Robot> Parse(string filepath)
        {
            var lines = File.ReadAllLines(filepath).ToList();
            lines.RemoveAt(0);
            foreach(string line in lines)
            {
                var fields = line.Split(new[] { ',' });
                try
                {
                    robots.Add(new Robot
                    {
                        TeamNumber = int.Parse(fields[0]),
                        MatchNumber = int.Parse(fields[1]),
                        WatchPosition = fields[2],
                        BallsAutoInner = int.Parse(fields[3]),
                        BallsAutoOuter = int.Parse(fields[4]),
                        BallsAutoLower = int.Parse(fields[5]),
                        CrossedAutoLine = bool.Parse(fields[6]),
                        BallsTeleopInner = int.Parse(fields[7]),
                        BallsTeleopOuter = int.Parse(fields[8]),
                        BallsTeleopLower = int.Parse(fields[9]),
                        CanHang = bool.Parse(fields[10]),
                        CanLevel = bool.Parse(fields[11]),
                        WheelPosition = bool.Parse(fields[12]),
                        WheelRotation = bool.Parse(fields[13])
                    });
                }
                catch (Exception e)
                {
                    MainWindow.LogEx(e.StackTrace);
                }
            }

            return robots;
        }
    }
}
