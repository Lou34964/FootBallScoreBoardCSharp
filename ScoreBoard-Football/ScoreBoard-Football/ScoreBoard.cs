using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreBoard_Football
{
    public partial class ScoreBoard : Form
    {
        public ScoreBoard()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int min = Values.TimeMinute;
            int sec = Values.TimeSecond;
            if(min == 0 && sec == 1)
            {
                sec--;
                timer.Enabled = false;
                if(Values.Quarter > 4) 
                { 
                    Values.Quarter++; 
                }
                else
                {
                    if(Values.HomeScore == Values.VisitorScore)
                    {
                        Values.Quarter++;
                    }
                    else
                    {
                        //do nothing
                    }
                }
                Values.UpdateBoard();
            }
            else if(sec > 0)
            {
                sec--;
            }
            else
            {
                min--;
                sec = 59;
            }
            Values.TimeMinute = min;
            Values.TimeSecond = sec;
            GameTime.Text = Values.BuildTime(min, sec);
            
        }
    }
}
