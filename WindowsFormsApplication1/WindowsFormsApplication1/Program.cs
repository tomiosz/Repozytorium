using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.IO;
using System.Collections;


namespace LoginApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
          }
        }
    }

    public class Register
{
    public string Name;
    public string Surname;
    public string Login;
    public string Password;
    public string email;

    public static void Savedata(string name, string surname, string Login, string Password, string email)
    {
        FileStream fs = new FileStream("D:\\dane.txt",FileMode.Append, FileAccess.Write);
        try
        {

            using (StreamWriter outfile = new StreamWriter(fs))
            {

                outfile.Write(name + " " + surname + " " + Login + " " + Password + " " + email + "\r\n");
               
          
            }

            MessageBox.Show("Data correctly saved");
        }
        catch (Exception)
        {
            MessageBox.Show("Error! Data didn't saved");
        }
    }
}


