﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mip_ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void renkalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 renkFormu = new Form2();
            renkFormu.ShowDialog();
        }

        private void griyöntemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 griFormu = new Form3();
            griFormu.ShowDialog();
        }
    }
}
