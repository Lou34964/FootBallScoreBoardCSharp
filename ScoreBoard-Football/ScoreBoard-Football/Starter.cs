﻿using System;
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
    public partial class Starter : Form
    {
        public Starter()
        {
            InitializeComponent();
        }

        private void Starter_Load(object sender, EventArgs e)
        {
            Forms.controller.Show();
            Forms.scoreBoard.Show();
            this.ShowInTaskbar = false;
            this.Hide();
        }
    }
}
