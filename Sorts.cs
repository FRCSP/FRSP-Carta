using FRSP_Carta.CSVImport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRSP_Carta
{
    public class Sorts
    {
        private ScoreData CalculateRawScore(Robot robot)
        {
            int autoscore = robot.BallsAutoInner * 6 + robot.BallsAutoOuter * 4 + robot.BallsAutoLower * 2;
            int telescore = robot.BallsAutoInner * 3 + robot.BallsAutoOuter * 2 + robot.BallsAutoLower * 1;
            if (robot.WheelPosition)
            {
                telescore += 20;
            }
            if (robot.WheelRotation)
            {
                telescore += 10;
            }
            if (robot.CanHang)
            {
                telescore += 25;
            }
            if (robot.CrossedAutoLine)
            {
                autoscore += 5;
            }
            int rawscore = autoscore + telescore;
            robot.ScoreInfo = new ScoreData(rawscore, autoscore, telescore);

            return robot.ScoreInfo;
        }

        static void SortByRawScore(ref List<Robot> data)
        {
            var sortedbyraw = from r in data
                              orderby r.ScoreInfo.RawScore
                              select r;
            data = sortedbyraw.ToList();
        }

        static void SortByAutoScore(ref List<Robot> data)
        {
            var sortedbyauto = from r in data
                              orderby r.ScoreInfo.AutoScore
                              select r;
            data = sortedbyauto.ToList();
        }
    }
}
