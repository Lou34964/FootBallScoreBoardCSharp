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
    public partial class Controller : Form
    {
        public Controller()
        {
            InitializeComponent();
            
        }

        #region Home
        private void TouchDownHome_Click(object sender, EventArgs e)
        {
            Values.HomeScore += 6;
            Values.UpdateBoard();
        }

        private void FieldGoalHome_Click(object sender, EventArgs e)
        {
            Values.HomeScore += 3;
            Values.UpdateBoard();
        }

        private void ExtraPointHome_Click(object sender, EventArgs e)
        {
            Values.HomeScore ++;
            Values.UpdateBoard();
        }

        private void SetScoreHome_Click(object sender, EventArgs e)
        {
            setWhatShow((sender as Button).Text + "H");

        }

        private void TimeOutHome_Click(object sender, EventArgs e)
        {
            Values.HomeTO--;
            Values.UpdateBoard();
            Forms.scoreBoard.timer.Enabled = false;
        }

        private void TimeOutRevHome_Click(object sender, EventArgs e)
        {
            Values.HomeTO ++;
            Values.UpdateBoard();
        }

        private void PosHome_Click(object sender, EventArgs e)
        {
            Values.HomePos = true;
            Forms.scoreBoard.PosHome.BackColor = Values.GetPos(true);
            Values.VisitorPos = false;
            Forms.scoreBoard.PosVisitor.BackColor = Values.GetPos(false);
        }

        #endregion

        #region Visitor
        private void TouchDownVisitor_Click(object sender, EventArgs e)
        {
            Values.VisitorScore += 6;
            Values.UpdateBoard();
        }

        private void FieldGoalVisitor_Click(object sender, EventArgs e)
        {
            Values.VisitorScore += 3;
            Values.UpdateBoard();
        }

        private void ExtraPointVisitor_Click(object sender, EventArgs e)
        {
            Values.VisitorScore++;
            Values.UpdateBoard();
        }

        private void SetScoreVisitor_Click(object sender, EventArgs e)
        {
            setWhatShow((sender as Button).Text + "V");
        }

        private void TimeOutVisitor_Click(object sender, EventArgs e)
        {
            Values.VisitorTO--;
            Values.UpdateBoard();
            Forms.scoreBoard.timer.Enabled = false;
        }

        private void TimeOutRevVisitor_Click(object sender, EventArgs e)
        {
            Values.VisitorTO++;
            Values.UpdateBoard();
        }

        private void PosVisitor_Click(object sender, EventArgs e)
        {
            Values.HomePos = false;
            Forms.scoreBoard.PosHome.BackColor = Values.GetPos(false);
            Values.VisitorPos = true;
            Forms.scoreBoard.PosVisitor.BackColor = Values.GetPos(true);
            Values.UpdateBoard();
        }

        #endregion

        #region General
        private void TimeStart_Click(object sender, EventArgs e)
        {
            Forms.scoreBoard.timer.Enabled = true;
        }

        private void SetTime_Click(object sender, EventArgs e)
        {
            SetTimeLabel.Visible = true;
            SetTimeInput.Visible = true;
            SetTimeOK.Visible = true;
            AcceptButton = SetTimeOK;
            SetTimeInput.Select();
        }

        private void TimeStop_Click(object sender, EventArgs e)
        {
            Forms.scoreBoard.timer.Enabled = false;
        }

        private void DownUp_Click(object sender, EventArgs e)
        {
            if (Values.Down < 4)
            {
                Values.Down++;
                Values.UpdateBoard();
            }
        }

        private void DownDown_Click(object sender, EventArgs e)
        {
            if (Values.Down > 1)
            {
                Values.Down--;
                Values.UpdateBoard();
            }
        }

        private void SetToGo_Click(object sender, EventArgs e)
        {
            setWhatShow((sender as Button).Text);
        }

        private void SetBallOn_Click(object sender, EventArgs e)
        {
            setWhatShow((sender as Button).Text);
        }

        private void QuarterUp_Click(object sender, EventArgs e)
        {
            
            Values.Quarter++;
            Values.UpdateBoard();
        }

        private void QuarterDown_Click(object sender, EventArgs e)
        {
            Values.Quarter--;
            Values.UpdateBoard();
        }

        #endregion

        #region sets

        private void setWhatShow(string str)
        {
            SetWhatLabel.Visible = true;
            SetWhatOK.Visible = true;
            ValueInput.Visible = true;
            ValueInput.Text = "Value";
            SetWhatLabel.Text = str;
            ValueInput.Select();
            AcceptButton = SetWhatOK;
        }
        private void setWhatHide()
        {
            SetWhatLabel.Visible = false;
            SetWhatOK.Visible = false;
            ValueInput.Visible = false;
        }
        bool isDef = false;
        private void SetTimeOK_Click(object sender, EventArgs e)
        {
            if (isDef)
            {
                if (!SetTimeInput.Text.Contains(':'))
                {
                    MessageBox.Show("Error: Expected ':', Please check your formatting. Formating: {00:00}");
                }
                else
                {
                    if (SetTimeInput.Text.Length > 5)
                    {
                        MessageBox.Show("Error: Missing Digits, Formating: {00:00}");
                    }
                    else
                    {
                        deconInput(SetTimeInput.Text);
                    }
                }
                void deconInput(string str)
                {
                    int min = Convert.ToInt32(str.Substring(0, 2));
                    int sec = Convert.ToInt32(str.Substring(3, 2));
                    DefaultValues.TimeMinute = min;
                    DefaultValues.TimeSecond = sec;
                    //Forms.scoreBoard.GameTime.Text = str;
                    SetTimeInput.Visible = false;
                    SetTimeLabel.Visible = false;
                    SetTimeOK.Visible = false;
                    AcceptButton = null;
                }
            }
            else
            {
                if (!SetTimeInput.Text.Contains(':'))
                {
                    MessageBox.Show("Error: Expected ':', Please check your formatting. Formating: {00:00}");
                }
                else
                {
                    if (SetTimeInput.Text.Length > 5)
                    {
                        MessageBox.Show("Error: Missing Digits, Formating: {00:00}");
                    }
                    else
                    {
                        deconInput(SetTimeInput.Text);
                    }
                }
                void deconInput(string str)
                {
                    int min = Convert.ToInt32(str.Substring(0, 2));
                    int sec = Convert.ToInt32(str.Substring(3, 2));
                    Values.TimeMinute = min;
                    Values.TimeSecond = sec;
                    Forms.scoreBoard.GameTime.Text = str;
                    SetTimeInput.Visible = false;
                    SetTimeLabel.Visible = false;
                    SetTimeOK.Visible = false;
                    AcceptButton = null;
                }
            }
        }

        private void SetWhatOK_Click(object sender, EventArgs e)
        {
            string what = SetWhatLabel.Text;
            Label boardElement = null;
            if(what=="Set ScoreH")
            {
                boardElement = Forms.scoreBoard.ScoreHome;
                Values.HomeScore = Convert.ToInt32(ValueInput.Text);
            }
            if(what=="Set ScoreV")
            {
                boardElement = Forms.scoreBoard.ScoreVisitor;
                Values.HomeScore = Convert.ToInt32(ValueInput.Text);
            }
            if(what == "To Go")
            {
                boardElement = Forms.scoreBoard.ToGo;
                Values.ToGo = Convert.ToInt32(ValueInput.Text);
            }
            if(what == "Ball On")
            {
                boardElement = Forms.scoreBoard.BallOn;
                Values.BallOn = Convert.ToInt32(ValueInput.Text);
                
            }

            boardElement.Text = ValueInput.Text;
            
            setWhatHide();
            AcceptButton = null;
        }

        private void SetTimeInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ':'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ':') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void DigOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        private void Controller_Load(object sender, EventArgs e)
        {
            Values.initDefaults();
            Forms.scoreBoard.GameTime.Text = Values.BuildTime(Values.TimeMinute, Values.TimeSecond);
            
        }

        private void BtnShowScoreBoard_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ScoreBoard>().Count() > 0)
            {
                Forms.scoreBoard.Hide();
                Forms.scoreBoard.Show();
            }
            else
            {
                Forms.scoreBoard.Show();
            }
        }

        private void SetDef_Click(object sender, EventArgs e)
        {
            isDef = true;
            SetTimeLabel.Visible = true;
            SetTimeInput.Visible = true;
            SetTimeOK.Visible = true;
            AcceptButton = SetTimeOK;
            SetTimeInput.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Values.TimeMinute = DefaultValues.TimeMinute;
            Values.TimeSecond = DefaultValues.TimeSecond;
            Forms.scoreBoard.GameTime.Text = Values.BuildTime(Values.TimeMinute, Values.TimeSecond);
        }

        private void FirstDown_Click(object sender, EventArgs e)
        {
            Values.Down = 1;
            Values.ToGo = 10;
            Values.UpdateBoard();
        }

        private void Goal_Click(object sender, EventArgs e)
        {
            Values.ToGo = -1;
            Values.UpdateBoard();
        }

        private void SaftyHome_Click(object sender, EventArgs e)
        {
            Values.HomeScore++;
            Values.HomeScore++;
            Values.UpdateBoard();
        }

        private void SaftyVisitor_Click(object sender, EventArgs e)
        {
            Values.VisitorScore++;
            Values.VisitorScore++;
            Values.UpdateBoard();
        }

        private void btnPlus2Home_Click(object sender, EventArgs e)
        {
            Values.HomeScore += 2;
            Values.UpdateBoard();
        }

        private void btnPlus2Visitor_Click(object sender, EventArgs e)
        {
            Values.VisitorScore += 2;
            Values.UpdateBoard();
        }
    }
}
