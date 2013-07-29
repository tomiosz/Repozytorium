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
        
                Register.Savedata(this.NameBox.Text, this.SurmaneBox.Text, this.LoginBox.Text, this.PassBox.Text, this.EmBox.Text);
         }
// Inicjacja metody savedata do zapisu do pliku podanych danych.

        private void button3_Click(object sender, EventArgs e)
        {
             registerForm = new Form3();
             registerForm.Close();
                   
        }
    }
}
