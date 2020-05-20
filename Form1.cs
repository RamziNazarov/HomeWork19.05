﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork19._05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btn0.Click += AddNumber_Click;
            btn1.Click += AddNumber_Click;
            btn2.Click += AddNumber_Click;
            btn3.Click += AddNumber_Click;
            btn4.Click += AddNumber_Click;
            btn5.Click += AddNumber_Click;
            btn6.Click += AddNumber_Click;
            btn7.Click += AddNumber_Click;
            btn8.Click += AddNumber_Click;
            btn9.Click += AddNumber_Click;
            btnDot.Click += AddNumber_Click;
            btnC.Click += (s,a) => { txbRes.Text = ""; };
            btnBack.Click += (s, a) =>
            {
                txbRes.Text =  (!string.IsNullOrEmpty(txbRes.Text))?txbRes.Text.Substring(0, txbRes.Text.Length - 1):"";

            };
            btnSqt.Click += (s,a)=>
            {
                txbRes.Text = (!string.IsNullOrEmpty(txbRes.Text))?Math.Sqrt(double.Parse(txbRes.Text)).ToString():"";
            };
            btnMS.Click += (s, a) =>
            {
                txbMem.Text = txbRes.Text;
            };
            btnMC.Click += (s, a) =>
            {
                txbMem.Text = "";
            };
            btnMR.Click += (s, a) =>
            {
                txbRes.Text = (!string.IsNullOrEmpty(txbMem.Text))?txbMem.Text:txbRes.Text;
            };
        }
        private void AddNumber_Click(object sender, EventArgs e)
        {
            var a = sender as Button;
            if (a.Text == ",")
            {
                char[] numbers = txbRes.Text.ToCharArray();
                if (!numbers.Contains(','))
                    txbRes.Text = txbRes.Text + a.Text;
            }
            else
            {
                txbRes.Text = txbRes.Text + a.Text;
            }
        }
    }
}
