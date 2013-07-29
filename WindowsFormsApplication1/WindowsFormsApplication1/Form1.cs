using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace LoginApplication
{
    public partial class Form1 : Form
    {
        public Form2 mainForm = null;
        public Form1 loginForm = null;
        public Form3 registerForm = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Tomasz" && textBox2.Text == "Bobek")
            {
                mainForm = new Form2();
                mainForm.Visible = true;
                loginForm = new Form1();
                loginForm.Visible = false;
            }
            else
            {
                MessageBox.Show("Wrong Login or Password please try again with correct data.", "Wrong Login or Password");
            }
        }



        private void addButton_Click_1(object sender, EventArgs e)
        {

     
            registerForm = new Form3();
            registerForm.Visible = true;
            loginForm = new Form1();
            loginForm.Visible = false;
    }
        }
    }

  



  
            