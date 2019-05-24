﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class BarApp : Form
    {
        public BarApp()
        {
            InitializeComponent();
            Exit.Visible = false;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Time.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(+1);
            if (progressBar1.Value == 100)
            {
                Time.Enabled = false;
                Exit.Visible = true;
            }           
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
