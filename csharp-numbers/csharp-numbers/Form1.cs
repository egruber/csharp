﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int myInteger = 25;
            MessageBox.Show(myInteger.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float myFloat = 3.1F;
            MessageBox.Show(myFloat.ToString());
        }
    }
}
