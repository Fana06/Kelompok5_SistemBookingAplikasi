using System;
using System.Windows.Forms;
using SistemBookingPasien_5.Forms;

namespace SistemBookingPasien_5
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
