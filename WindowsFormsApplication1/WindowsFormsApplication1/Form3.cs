using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoginApplication
{
    public partial class Form3 : Form
    {
        public Form3 registerForm = null;
        public Form3()
        {
            
            InitializeComponent();
            
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (PassBox.Text == PassBox2.Text)
            {
                Register.Savedata(this.NameBox.Text, this.SurmaneBox.Text, this.LoginBox.Text, this.PassBox.Text, this.PassBox2.Text, this.EmBox.Text);
            }
            else
            {
                MessageBox.Show("Password is not the same!");
               
            }
// Sprawdzanie poprawnoci 2 podanych ciagow znakow (hasel).
         }

// Inicjacja metody savedata do zapisu do pliku podanych danych.

        private void button3_Click(object sender, EventArgs e)
        {
           registerForm = new Form3();
           registerForm.Close();
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void EmBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PassBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PassBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
