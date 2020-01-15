using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ScoreBoard_Football
{
    public static class Values
    {
        public static int TimeMinute = 15;
        public static int TimeSecond = 0;
        public static string TimeFull = "15:00";
        public static int Down = 1;
        public static int ToGo = 10;
        public static int BallOn = 10;
        public static int Quarter = 1;
        

        public static int HomeScore = 0;
        public static bool HomePos = false;
        public static int HomeTO = 3;

        public static int VisitorScore = 0;
        public static bool VisitorPos = false;
        public static int VisitorTO = 3;

        

        public static void UpdateBoard()
        {
            
            Forms.scoreBoard.ScoreHome.Text = BuildScore(HomeScore);
            Forms.scoreBoard.PosHome.BackColor = GetPos(HomePos);
            Forms.scoreBoard.tolHome.Text = HomeTO.ToString();

            Forms.scoreBoard.ScoreVisitor.Text = BuildScore(VisitorScore);
            Forms.scoreBoard.PosVisitor.BackColor = GetPos(VisitorPos);
            Forms.scoreBoard.tolVisitor.Text = VisitorTO.ToString();

            Forms.scoreBoard.Down.Text = Down.ToString();
            if (ToGo < 0)
            {
                Forms.scoreBoard.ToGo.Text = "GL";
            }
            else
            {
                Forms.scoreBoard.ToGo.Text = ToGo.ToString();
            }
            Forms.scoreBoard.BallOn.Text = BallOn.ToString();
            if(Quarter > 4)
            {
                Forms.scoreBoard.Quarter.Text = "0T";
            }
            else
            {
                Forms.scoreBoard.Quarter.Text = Quarter.ToString();
            }
            
        }

        public static string BuildScore(int score)
        {
            if (score < 10)
            {
                return string.Format("0{0}", score);
            }
            else return score.ToString();
        }
        public static Color GetPos(bool pos)
        {
            if (pos)
            {
                return Color.Red;
            }
            else return Color.Black;
        }
        public static string BuildTime(int min, int sec)
        {
            string timem = min.ToString();
            string times = sec.ToString();
            string time;
            if (min < 10)
            {
                timem = string.Format("0{0}", min);
            }
            if (sec < 10)
            {
                times = string.Format("0{0}", sec);
            }
            time = string.Format("{0}:{1}", timem, times);
            return time;


        }
        public static void initDefaults()
        {
        TimeMinute = DefaultValues.TimeMinute;
        TimeSecond = DefaultValues.TimeSecond;
        TimeFull = DefaultValues.TimeFull;
        Down = DefaultValues.Down;
        ToGo = DefaultValues.ToGo;
        BallOn = DefaultValues.BallOn;
        Quarter = DefaultValues.Quarter;


        HomeScore = DefaultValues.HomeScore;
        HomePos = DefaultValues.HomePos;
        HomeTO = DefaultValues.HomeTO;

        VisitorScore = DefaultValues.VisitorScore;
        VisitorPos = DefaultValues.VisitorPos;
        VisitorTO = DefaultValues.VisitorTO;
    }


    }
    public static class DefaultValues
    {
        public static int TimeMinute = 15;
        public static int TimeSecond = 0;
        public static string TimeFull = "15:00";
        public static int Down = 1;
        public static int ToGo = 10;
        public static int BallOn = 10;
        public static int Quarter = 1;


        public static int HomeScore = 0;
        public static bool HomePos = false;
        public static int HomeTO = 3;

        public static int VisitorScore = 0;
        public static bool VisitorPos = false;
        public static int VisitorTO = 3;
    }
}
