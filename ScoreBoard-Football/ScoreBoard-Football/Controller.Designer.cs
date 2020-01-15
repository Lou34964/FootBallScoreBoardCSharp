using System.Windows.Forms;

namespace ScoreBoard_Football
{
    partial class Controller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            Application.Exit();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaftyHome = new System.Windows.Forms.Button();
            this.PosHome = new System.Windows.Forms.Button();
            this.TimeOutRevHome = new System.Windows.Forms.Button();
            this.TimeOutHome = new System.Windows.Forms.Button();
            this.FieldGoalHome = new System.Windows.Forms.Button();
            this.SetScoreHome = new System.Windows.Forms.Button();
            this.ExtraPointHome = new System.Windows.Forms.Button();
            this.TouchDownHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Goal = new System.Windows.Forms.Button();
            this.FirstDown = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SetDef = new System.Windows.Forms.Button();
            this.BtnShowScoreBoard = new System.Windows.Forms.Button();
            this.SetWhatOK = new System.Windows.Forms.Button();
            this.SetTimeOK = new System.Windows.Forms.Button();
            this.SetTimeLabel = new System.Windows.Forms.Label();
            this.SetTimeInput = new System.Windows.Forms.TextBox();
            this.SetWhatLabel = new System.Windows.Forms.Label();
            this.ValueInput = new System.Windows.Forms.TextBox();
            this.QuarterDown = new System.Windows.Forms.Button();
            this.QuarterUp = new System.Windows.Forms.Button();
            this.SetBallOn = new System.Windows.Forms.Button();
            this.SetToGo = new System.Windows.Forms.Button();
            this.DownDown = new System.Windows.Forms.Button();
            this.DownUp = new System.Windows.Forms.Button();
            this.TimeStop = new System.Windows.Forms.Button();
            this.TimeStart = new System.Windows.Forms.Button();
            this.SetTime = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SaftyVisitor = new System.Windows.Forms.Button();
            this.PosVisitor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeOutRevVisitor = new System.Windows.Forms.Button();
            this.FieldGoalVisitor = new System.Windows.Forms.Button();
            this.TimeOutVisitor = new System.Windows.Forms.Button();
            this.TouchDownVisitor = new System.Windows.Forms.Button();
            this.ExtraPointVisitor = new System.Windows.Forms.Button();
            this.SetScoreVisitor = new System.Windows.Forms.Button();
            this.btnPlus2Home = new System.Windows.Forms.Button();
            this.btnPlus2Visitor = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnPlus2Home);
            this.panel1.Controls.Add(this.SaftyHome);
            this.panel1.Controls.Add(this.PosHome);
            this.panel1.Controls.Add(this.TimeOutRevHome);
            this.panel1.Controls.Add(this.TimeOutHome);
            this.panel1.Controls.Add(this.FieldGoalHome);
            this.panel1.Controls.Add(this.SetScoreHome);
            this.panel1.Controls.Add(this.ExtraPointHome);
            this.panel1.Controls.Add(this.TouchDownHome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 416);
            this.panel1.TabIndex = 0;
            // 
            // SaftyHome
            // 
            this.SaftyHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaftyHome.Location = new System.Drawing.Point(235, 109);
            this.SaftyHome.Name = "SaftyHome";
            this.SaftyHome.Size = new System.Drawing.Size(63, 44);
            this.SaftyHome.TabIndex = 8;
            this.SaftyHome.Text = "ST";
            this.SaftyHome.UseVisualStyleBackColor = true;
            this.SaftyHome.Click += new System.EventHandler(this.SaftyHome_Click);
            // 
            // PosHome
            // 
            this.PosHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PosHome.Location = new System.Drawing.Point(91, 268);
            this.PosHome.Name = "PosHome";
            this.PosHome.Size = new System.Drawing.Size(119, 60);
            this.PosHome.TabIndex = 7;
            this.PosHome.Text = "Possession";
            this.PosHome.UseVisualStyleBackColor = true;
            this.PosHome.Click += new System.EventHandler(this.PosHome_Click);
            // 
            // TimeOutRevHome
            // 
            this.TimeOutRevHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeOutRevHome.Location = new System.Drawing.Point(102, 234);
            this.TimeOutRevHome.Name = "TimeOutRevHome";
            this.TimeOutRevHome.Size = new System.Drawing.Size(93, 28);
            this.TimeOutRevHome.TabIndex = 6;
            this.TimeOutRevHome.Text = "Time Out Rev.";
            this.TimeOutRevHome.UseVisualStyleBackColor = true;
            this.TimeOutRevHome.Click += new System.EventHandler(this.TimeOutRevHome_Click);
            // 
            // TimeOutHome
            // 
            this.TimeOutHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeOutHome.Location = new System.Drawing.Point(91, 168);
            this.TimeOutHome.Name = "TimeOutHome";
            this.TimeOutHome.Size = new System.Drawing.Size(119, 60);
            this.TimeOutHome.TabIndex = 5;
            this.TimeOutHome.Text = "Time Out";
            this.TimeOutHome.UseVisualStyleBackColor = true;
            this.TimeOutHome.Click += new System.EventHandler(this.TimeOutHome_Click);
            // 
            // FieldGoalHome
            // 
            this.FieldGoalHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FieldGoalHome.Location = new System.Drawing.Point(120, 33);
            this.FieldGoalHome.Name = "FieldGoalHome";
            this.FieldGoalHome.Size = new System.Drawing.Size(60, 60);
            this.FieldGoalHome.TabIndex = 4;
            this.FieldGoalHome.Text = "FG";
            this.FieldGoalHome.UseVisualStyleBackColor = true;
            this.FieldGoalHome.Click += new System.EventHandler(this.FieldGoalHome_Click);
            // 
            // SetScoreHome
            // 
            this.SetScoreHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetScoreHome.Location = new System.Drawing.Point(91, 102);
            this.SetScoreHome.Name = "SetScoreHome";
            this.SetScoreHome.Size = new System.Drawing.Size(119, 60);
            this.SetScoreHome.TabIndex = 3;
            this.SetScoreHome.Text = "Set Score";
            this.SetScoreHome.UseVisualStyleBackColor = true;
            this.SetScoreHome.Click += new System.EventHandler(this.SetScoreHome_Click);
            // 
            // ExtraPointHome
            // 
            this.ExtraPointHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtraPointHome.Location = new System.Drawing.Point(215, 34);
            this.ExtraPointHome.Name = "ExtraPointHome";
            this.ExtraPointHome.Size = new System.Drawing.Size(60, 60);
            this.ExtraPointHome.TabIndex = 2;
            this.ExtraPointHome.Text = "EP";
            this.ExtraPointHome.UseVisualStyleBackColor = true;
            this.ExtraPointHome.Click += new System.EventHandler(this.ExtraPointHome_Click);
            // 
            // TouchDownHome
            // 
            this.TouchDownHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TouchDownHome.Location = new System.Drawing.Point(24, 34);
            this.TouchDownHome.Name = "TouchDownHome";
            this.TouchDownHome.Size = new System.Drawing.Size(60, 60);
            this.TouchDownHome.TabIndex = 1;
            this.TouchDownHome.Text = "TD";
            this.TouchDownHome.UseVisualStyleBackColor = true;
            this.TouchDownHome.Click += new System.EventHandler(this.TouchDownHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(126, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Goal);
            this.panel2.Controls.Add(this.FirstDown);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.SetDef);
            this.panel2.Controls.Add(this.BtnShowScoreBoard);
            this.panel2.Controls.Add(this.SetWhatOK);
            this.panel2.Controls.Add(this.SetTimeOK);
            this.panel2.Controls.Add(this.SetTimeLabel);
            this.panel2.Controls.Add(this.SetTimeInput);
            this.panel2.Controls.Add(this.SetWhatLabel);
            this.panel2.Controls.Add(this.ValueInput);
            this.panel2.Controls.Add(this.QuarterDown);
            this.panel2.Controls.Add(this.QuarterUp);
            this.panel2.Controls.Add(this.SetBallOn);
            this.panel2.Controls.Add(this.SetToGo);
            this.panel2.Controls.Add(this.DownDown);
            this.panel2.Controls.Add(this.DownUp);
            this.panel2.Controls.Add(this.TimeStop);
            this.panel2.Controls.Add(this.TimeStart);
            this.panel2.Controls.Add(this.SetTime);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(333, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 416);
            this.panel2.TabIndex = 1;
            // 
            // Goal
            // 
            this.Goal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Goal.Location = new System.Drawing.Point(174, 186);
            this.Goal.Name = "Goal";
            this.Goal.Size = new System.Drawing.Size(40, 26);
            this.Goal.TabIndex = 21;
            this.Goal.Text = "GL";
            this.Goal.UseVisualStyleBackColor = true;
            this.Goal.Click += new System.EventHandler(this.Goal_Click);
            // 
            // FirstDown
            // 
            this.FirstDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstDown.Location = new System.Drawing.Point(17, 202);
            this.FirstDown.Name = "FirstDown";
            this.FirstDown.Size = new System.Drawing.Size(40, 26);
            this.FirstDown.TabIndex = 20;
            this.FirstDown.Text = "FD";
            this.FirstDown.UseVisualStyleBackColor = true;
            this.FirstDown.Click += new System.EventHandler(this.FirstDown_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Set to Def.";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SetDef
            // 
            this.SetDef.Location = new System.Drawing.Point(74, 97);
            this.SetDef.Name = "SetDef";
            this.SetDef.Size = new System.Drawing.Size(75, 23);
            this.SetDef.TabIndex = 18;
            this.SetDef.Text = "Set Def.";
            this.SetDef.UseVisualStyleBackColor = true;
            this.SetDef.Click += new System.EventHandler(this.SetDef_Click);
            // 
            // BtnShowScoreBoard
            // 
            this.BtnShowScoreBoard.Location = new System.Drawing.Point(3, 3);
            this.BtnShowScoreBoard.Name = "BtnShowScoreBoard";
            this.BtnShowScoreBoard.Size = new System.Drawing.Size(72, 39);
            this.BtnShowScoreBoard.TabIndex = 17;
            this.BtnShowScoreBoard.Text = "Show Scoreboard";
            this.BtnShowScoreBoard.UseVisualStyleBackColor = true;
            this.BtnShowScoreBoard.Click += new System.EventHandler(this.BtnShowScoreBoard_Click);
            // 
            // SetWhatOK
            // 
            this.SetWhatOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetWhatOK.Location = new System.Drawing.Point(143, 338);
            this.SetWhatOK.Name = "SetWhatOK";
            this.SetWhatOK.Size = new System.Drawing.Size(40, 26);
            this.SetWhatOK.TabIndex = 16;
            this.SetWhatOK.Text = "OK";
            this.SetWhatOK.UseVisualStyleBackColor = true;
            this.SetWhatOK.Visible = false;
            this.SetWhatOK.Click += new System.EventHandler(this.SetWhatOK_Click);
            // 
            // SetTimeOK
            // 
            this.SetTimeOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetTimeOK.Location = new System.Drawing.Point(330, 340);
            this.SetTimeOK.Name = "SetTimeOK";
            this.SetTimeOK.Size = new System.Drawing.Size(40, 26);
            this.SetTimeOK.TabIndex = 15;
            this.SetTimeOK.Text = "OK";
            this.SetTimeOK.UseVisualStyleBackColor = true;
            this.SetTimeOK.Visible = false;
            this.SetTimeOK.Click += new System.EventHandler(this.SetTimeOK_Click);
            // 
            // SetTimeLabel
            // 
            this.SetTimeLabel.AutoSize = true;
            this.SetTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetTimeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SetTimeLabel.Location = new System.Drawing.Point(239, 309);
            this.SetTimeLabel.Name = "SetTimeLabel";
            this.SetTimeLabel.Size = new System.Drawing.Size(72, 20);
            this.SetTimeLabel.TabIndex = 14;
            this.SetTimeLabel.Text = "Set Time";
            this.SetTimeLabel.Visible = false;
            // 
            // SetTimeInput
            // 
            this.SetTimeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetTimeInput.Location = new System.Drawing.Point(225, 332);
            this.SetTimeInput.Name = "SetTimeInput";
            this.SetTimeInput.Size = new System.Drawing.Size(100, 38);
            this.SetTimeInput.TabIndex = 13;
            this.SetTimeInput.Text = "00:00";
            this.SetTimeInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SetTimeInput.Visible = false;
            this.SetTimeInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetTimeInput_KeyPress);
            // 
            // SetWhatLabel
            // 
            this.SetWhatLabel.AutoSize = true;
            this.SetWhatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetWhatLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SetWhatLabel.Location = new System.Drawing.Point(51, 309);
            this.SetWhatLabel.Name = "SetWhatLabel";
            this.SetWhatLabel.Size = new System.Drawing.Size(76, 20);
            this.SetWhatLabel.TabIndex = 12;
            this.SetWhatLabel.Text = "Set What";
            this.SetWhatLabel.Visible = false;
            // 
            // ValueInput
            // 
            this.ValueInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueInput.Location = new System.Drawing.Point(37, 332);
            this.ValueInput.Name = "ValueInput";
            this.ValueInput.Size = new System.Drawing.Size(100, 38);
            this.ValueInput.TabIndex = 11;
            this.ValueInput.Text = "Value";
            this.ValueInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ValueInput.Visible = false;
            this.ValueInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigOnly);
            // 
            // QuarterDown
            // 
            this.QuarterDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuarterDown.Location = new System.Drawing.Point(350, 218);
            this.QuarterDown.Name = "QuarterDown";
            this.QuarterDown.Size = new System.Drawing.Size(40, 26);
            this.QuarterDown.TabIndex = 10;
            this.QuarterDown.Text = "QD";
            this.QuarterDown.UseVisualStyleBackColor = true;
            this.QuarterDown.Click += new System.EventHandler(this.QuarterDown_Click);
            // 
            // QuarterUp
            // 
            this.QuarterUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuarterUp.Location = new System.Drawing.Point(350, 186);
            this.QuarterUp.Name = "QuarterUp";
            this.QuarterUp.Size = new System.Drawing.Size(40, 26);
            this.QuarterUp.TabIndex = 9;
            this.QuarterUp.Text = "QU";
            this.QuarterUp.UseVisualStyleBackColor = true;
            this.QuarterUp.Click += new System.EventHandler(this.QuarterUp_Click);
            // 
            // SetBallOn
            // 
            this.SetBallOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetBallOn.Location = new System.Drawing.Point(199, 137);
            this.SetBallOn.Name = "SetBallOn";
            this.SetBallOn.Size = new System.Drawing.Size(75, 45);
            this.SetBallOn.TabIndex = 8;
            this.SetBallOn.Text = "Ball On";
            this.SetBallOn.UseVisualStyleBackColor = true;
            this.SetBallOn.Click += new System.EventHandler(this.SetBallOn_Click);
            // 
            // SetToGo
            // 
            this.SetToGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetToGo.Location = new System.Drawing.Point(118, 137);
            this.SetToGo.Name = "SetToGo";
            this.SetToGo.Size = new System.Drawing.Size(75, 45);
            this.SetToGo.TabIndex = 7;
            this.SetToGo.Text = "To Go";
            this.SetToGo.UseVisualStyleBackColor = true;
            this.SetToGo.Click += new System.EventHandler(this.SetToGo_Click);
            // 
            // DownDown
            // 
            this.DownDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownDown.Location = new System.Drawing.Point(63, 218);
            this.DownDown.Name = "DownDown";
            this.DownDown.Size = new System.Drawing.Size(40, 26);
            this.DownDown.TabIndex = 6;
            this.DownDown.Text = "DD";
            this.DownDown.UseVisualStyleBackColor = true;
            this.DownDown.Click += new System.EventHandler(this.DownDown_Click);
            // 
            // DownUp
            // 
            this.DownUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownUp.Location = new System.Drawing.Point(63, 186);
            this.DownUp.Name = "DownUp";
            this.DownUp.Size = new System.Drawing.Size(40, 26);
            this.DownUp.TabIndex = 5;
            this.DownUp.Text = "DU";
            this.DownUp.UseVisualStyleBackColor = true;
            this.DownUp.Click += new System.EventHandler(this.DownUp_Click);
            // 
            // TimeStop
            // 
            this.TimeStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TimeStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeStop.Location = new System.Drawing.Point(199, 35);
            this.TimeStop.Name = "TimeStop";
            this.TimeStop.Size = new System.Drawing.Size(75, 45);
            this.TimeStop.TabIndex = 4;
            this.TimeStop.Text = "Time Stop";
            this.TimeStop.UseVisualStyleBackColor = false;
            this.TimeStop.Click += new System.EventHandler(this.TimeStop_Click);
            // 
            // TimeStart
            // 
            this.TimeStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TimeStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeStart.Location = new System.Drawing.Point(118, 35);
            this.TimeStart.Name = "TimeStart";
            this.TimeStart.Size = new System.Drawing.Size(75, 45);
            this.TimeStart.TabIndex = 3;
            this.TimeStart.Text = "Time Start";
            this.TimeStart.UseVisualStyleBackColor = false;
            this.TimeStart.Click += new System.EventHandler(this.TimeStart_Click);
            // 
            // SetTime
            // 
            this.SetTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetTime.Location = new System.Drawing.Point(155, 86);
            this.SetTime.Name = "SetTime";
            this.SetTime.Size = new System.Drawing.Size(75, 45);
            this.SetTime.TabIndex = 2;
            this.SetTime.Text = "Set Time";
            this.SetTime.UseVisualStyleBackColor = true;
            this.SetTime.Click += new System.EventHandler(this.SetTime_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(181, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "General";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnPlus2Visitor);
            this.panel3.Controls.Add(this.SaftyVisitor);
            this.panel3.Controls.Add(this.PosVisitor);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.TimeOutRevVisitor);
            this.panel3.Controls.Add(this.FieldGoalVisitor);
            this.panel3.Controls.Add(this.TimeOutVisitor);
            this.panel3.Controls.Add(this.TouchDownVisitor);
            this.panel3.Controls.Add(this.ExtraPointVisitor);
            this.panel3.Controls.Add(this.SetScoreVisitor);
            this.panel3.Location = new System.Drawing.Point(755, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(317, 416);
            this.panel3.TabIndex = 1;
            // 
            // SaftyVisitor
            // 
            this.SaftyVisitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaftyVisitor.Location = new System.Drawing.Point(235, 109);
            this.SaftyVisitor.Name = "SaftyVisitor";
            this.SaftyVisitor.Size = new System.Drawing.Size(63, 44);
            this.SaftyVisitor.TabIndex = 9;
            this.SaftyVisitor.Text = "ST";
            this.SaftyVisitor.UseVisualStyleBackColor = true;
            this.SaftyVisitor.Click += new System.EventHandler(this.SaftyVisitor_Click);
            // 
            // PosVisitor
            // 
            this.PosVisitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PosVisitor.Location = new System.Drawing.Point(93, 269);
            this.PosVisitor.Name = "PosVisitor";
            this.PosVisitor.Size = new System.Drawing.Size(119, 60);
            this.PosVisitor.TabIndex = 14;
            this.PosVisitor.Text = "Possession";
            this.PosVisitor.UseVisualStyleBackColor = true;
            this.PosVisitor.Click += new System.EventHandler(this.PosVisitor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(132, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Visitor";
            // 
            // TimeOutRevVisitor
            // 
            this.TimeOutRevVisitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeOutRevVisitor.Location = new System.Drawing.Point(104, 235);
            this.TimeOutRevVisitor.Name = "TimeOutRevVisitor";
            this.TimeOutRevVisitor.Size = new System.Drawing.Size(93, 28);
            this.TimeOutRevVisitor.TabIndex = 13;
            this.TimeOutRevVisitor.Text = "Time Out Rev.";
            this.TimeOutRevVisitor.UseVisualStyleBackColor = true;
            this.TimeOutRevVisitor.Click += new System.EventHandler(this.TimeOutRevVisitor_Click);
            // 
            // FieldGoalVisitor
            // 
            this.FieldGoalVisitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FieldGoalVisitor.Location = new System.Drawing.Point(122, 34);
            this.FieldGoalVisitor.Name = "FieldGoalVisitor";
            this.FieldGoalVisitor.Size = new System.Drawing.Size(60, 60);
            this.FieldGoalVisitor.TabIndex = 11;
            this.FieldGoalVisitor.Text = "FG";
            this.FieldGoalVisitor.UseVisualStyleBackColor = true;
            this.FieldGoalVisitor.Click += new System.EventHandler(this.FieldGoalVisitor_Click);
            // 
            // TimeOutVisitor
            // 
            this.TimeOutVisitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeOutVisitor.Location = new System.Drawing.Point(93, 169);
            this.TimeOutVisitor.Name = "TimeOutVisitor";
            this.TimeOutVisitor.Size = new System.Drawing.Size(119, 60);
            this.TimeOutVisitor.TabIndex = 12;
            this.TimeOutVisitor.Text = "Time Out";
            this.TimeOutVisitor.UseVisualStyleBackColor = true;
            this.TimeOutVisitor.Click += new System.EventHandler(this.TimeOutVisitor_Click);
            // 
            // TouchDownVisitor
            // 
            this.TouchDownVisitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TouchDownVisitor.Location = new System.Drawing.Point(26, 35);
            this.TouchDownVisitor.Name = "TouchDownVisitor";
            this.TouchDownVisitor.Size = new System.Drawing.Size(60, 60);
            this.TouchDownVisitor.TabIndex = 8;
            this.TouchDownVisitor.Text = "TD";
            this.TouchDownVisitor.UseVisualStyleBackColor = true;
            this.TouchDownVisitor.Click += new System.EventHandler(this.TouchDownVisitor_Click);
            // 
            // ExtraPointVisitor
            // 
            this.ExtraPointVisitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtraPointVisitor.Location = new System.Drawing.Point(217, 35);
            this.ExtraPointVisitor.Name = "ExtraPointVisitor";
            this.ExtraPointVisitor.Size = new System.Drawing.Size(60, 60);
            this.ExtraPointVisitor.TabIndex = 9;
            this.ExtraPointVisitor.Text = "EP";
            this.ExtraPointVisitor.UseVisualStyleBackColor = true;
            this.ExtraPointVisitor.Click += new System.EventHandler(this.ExtraPointVisitor_Click);
            // 
            // SetScoreVisitor
            // 
            this.SetScoreVisitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetScoreVisitor.Location = new System.Drawing.Point(93, 103);
            this.SetScoreVisitor.Name = "SetScoreVisitor";
            this.SetScoreVisitor.Size = new System.Drawing.Size(119, 60);
            this.SetScoreVisitor.TabIndex = 10;
            this.SetScoreVisitor.Text = "Set Score";
            this.SetScoreVisitor.UseVisualStyleBackColor = true;
            this.SetScoreVisitor.Click += new System.EventHandler(this.SetScoreVisitor_Click);
            // 
            // btnPlus2Home
            // 
            this.btnPlus2Home.Location = new System.Drawing.Point(281, 53);
            this.btnPlus2Home.Name = "btnPlus2Home";
            this.btnPlus2Home.Size = new System.Drawing.Size(29, 23);
            this.btnPlus2Home.TabIndex = 9;
            this.btnPlus2Home.Text = "+2";
            this.btnPlus2Home.UseVisualStyleBackColor = true;
            this.btnPlus2Home.Click += new System.EventHandler(this.btnPlus2Home_Click);
            // 
            // btnPlus2Visitor
            // 
            this.btnPlus2Visitor.Location = new System.Drawing.Point(281, 55);
            this.btnPlus2Visitor.Name = "btnPlus2Visitor";
            this.btnPlus2Visitor.Size = new System.Drawing.Size(29, 23);
            this.btnPlus2Visitor.TabIndex = 10;
            this.btnPlus2Visitor.Text = "+2";
            this.btnPlus2Visitor.UseVisualStyleBackColor = true;
            this.btnPlus2Visitor.Click += new System.EventHandler(this.btnPlus2Visitor_Click);
            // 
            // Controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1100, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Controller";
            this.Load += new System.EventHandler(this.Controller_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button PosHome;
        private System.Windows.Forms.Button TimeOutRevHome;
        private System.Windows.Forms.Button TimeOutHome;
        private System.Windows.Forms.Button FieldGoalHome;
        private System.Windows.Forms.Button SetScoreHome;
        private System.Windows.Forms.Button ExtraPointHome;
        private System.Windows.Forms.Button TouchDownHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SetTimeLabel;
        private System.Windows.Forms.TextBox SetTimeInput;
        private System.Windows.Forms.Label SetWhatLabel;
        private System.Windows.Forms.TextBox ValueInput;
        private System.Windows.Forms.Button QuarterDown;
        private System.Windows.Forms.Button QuarterUp;
        private System.Windows.Forms.Button SetBallOn;
        private System.Windows.Forms.Button SetToGo;
        private System.Windows.Forms.Button DownDown;
        private System.Windows.Forms.Button DownUp;
        private System.Windows.Forms.Button TimeStop;
        private System.Windows.Forms.Button TimeStart;
        private System.Windows.Forms.Button SetTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PosVisitor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TimeOutRevVisitor;
        private System.Windows.Forms.Button FieldGoalVisitor;
        private System.Windows.Forms.Button TimeOutVisitor;
        private System.Windows.Forms.Button TouchDownVisitor;
        private System.Windows.Forms.Button ExtraPointVisitor;
        private System.Windows.Forms.Button SetScoreVisitor;
        private System.Windows.Forms.Button SetWhatOK;
        private System.Windows.Forms.Button SetTimeOK;
        private System.Windows.Forms.Button BtnShowScoreBoard;
        private Button SetDef;
        private Button button1;
        private Button FirstDown;
        private Button Goal;
        private Button SaftyHome;
        private Button SaftyVisitor;
        private Button btnPlus2Home;
        private Button btnPlus2Visitor;
    }
}