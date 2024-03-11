﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _.Net_Basics
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void redirectToMathOp_Click(object sender, EventArgs e)
        {
            MathOp mathOp = new MathOp();
            mathOp.Show();
            this.Hide();
        }

        private void redirectTo_NumGuesser_Click(object sender, EventArgs e)
        {
            NumberGuesser numGuesser = new NumberGuesser();
            numGuesser.Show();
            this.Hide();
        }

        private void github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Anilgvnc");
        }

        private void linkedin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/kemal-anil-guvenc/");
        }

        private void website_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://green-wave-0ee2a0b03.4.azurestaticapps.net/");
        }
    }
}
