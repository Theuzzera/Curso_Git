﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace athenas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Matheus" && textBox2.Text == "1234")
            {
                
                Home home = new Home();
                home.ShowDialog();

            }
            else
            {
                MessageBox.Show("Login e senha invalidos");
            }
            

        }
    }
}
