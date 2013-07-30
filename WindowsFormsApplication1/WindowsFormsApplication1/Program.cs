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
    public string Password2;
    public string email;
// Dodanie zmiennych w klasie Register sluzacych do zapisu danych do pliku.
   
        public static void Savedata(string name, string surname, string Login, string Password, string Password2, string email)
    {
// Dodanie metody Savedata ze zmiennymi z klasy Register.

        FileStream fs = new FileStream("C:\\dane.txt",FileMode.Append, FileAccess.Write);
// Utworzenie zmiennej typu filestream do obslugi podanego pliku, oraz przejscie metoda Append na koniec pliku.
        try
        {

            using (StreamWriter outfile = new StreamWriter(fs))
            {
// Uzycie metody StreamWriter do zapisu do pliku ze zmienej (fs).

                outfile.Write(name + " " + surname + " " + Login + " " + Password + " " + Password2 + " " + email + "\r\n");
               
        
            }

            MessageBox.Show("Data correctly saved");
// Wyswietlana wiadomosc "Dane zostaly pomyslnie zapisane".
        }
        catch (Exception)
        {
            MessageBox.Show("Error! Data didn't saved");
// Wyswietlenie "Error'u".
        }
    }
}


