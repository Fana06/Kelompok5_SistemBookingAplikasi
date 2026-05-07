using System;
using System.Windows.Forms;
using BookingKontrolPasien.Forms;

namespace BookingKontrolPasien
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}
