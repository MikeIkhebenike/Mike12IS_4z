﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mike12IS_4z
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int v0, t, a; 
             double   s;
            v0 = Convert.ToInt32(textBox1.Text);
            t = Convert.ToInt32(textBox2.Text);
            a = Convert.ToInt32(textBox3.Text);
            s = v0 * t + ((a * Math.Pow(t,2)) / 2);
            listBox1.Items.Add("s = "+s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
