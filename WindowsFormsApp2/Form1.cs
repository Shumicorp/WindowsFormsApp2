﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2 {
    
    public partial class Form1 : Form {
        static double c = 0;
        public Form1() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {
            textBox5.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e) {
            double a;
            double.TryParse(textBox1.Text,out a); 
            double b;
            double.TryParse(textBox2.Text, out b);
            a = a / 2;
            b = b / 2;
            c = (b*b*3.14) / (a*a*3.14);
            
            textBox3.Text = ($"{c:0.##}");
            textBox4_TextChanged(sender,e);
        }

        private void textBox3_TextChanged(object sender, EventArgs e) {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
            char number = e.KeyChar;
            if (!Char.IsDigit(number)) 
                
            
                e.Handled = true;

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e) {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = true;
        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e) {
            //char number = e.KeyChar;
            //if (!Char.IsDigit(number))
            //    e.Handled = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e) {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e) {
            double newCalcGrams;
            double.TryParse(textBox4.Text,out newCalcGrams);
            newCalcGrams = newCalcGrams * c;
            textBox5.Text = ($"{newCalcGrams:#}");
        }
    }
}