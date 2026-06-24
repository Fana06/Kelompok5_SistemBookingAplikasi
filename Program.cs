using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using BookingKontrolPasien.Forms;

namespace BookingKontrolPasien
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormLogin());
            }
            catch (Exception ex)
            {
                ShowStartupError(ex);
            }
        }

        private static void Application_ThreadException(
            object sender,
            ThreadExceptionEventArgs e)
        {
            ShowStartupError(e.Exception);
        }

        private static void CurrentDomain_UnhandledException(
            object sender,
            UnhandledExceptionEventArgs e)
        {
            ShowStartupError(e.ExceptionObject as Exception);
        }

        private static void ShowStartupError(Exception ex)
        {
            string message = ex?.ToString() ?? "Unknown startup error.";
            string logPath = SaveStartupError(message);

            MessageBox.Show(
                "Aplikasi gagal dibuka." + Environment.NewLine +
                "Detail error disimpan di:" + Environment.NewLine +
                logPath + Environment.NewLine + Environment.NewLine +
                message,
                "Startup Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private static string SaveStartupError(string message)
        {
            string folder = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "BookingKontrolPasien");

            Directory.CreateDirectory(folder);

            string logPath = Path.Combine(folder, "startup-error.log");
            string content =
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") +
                Environment.NewLine +
                message +
                Environment.NewLine +
                new string('-', 80) +
                Environment.NewLine;

            File.AppendAllText(logPath, content, Encoding.UTF8);
            return logPath;
        }
    }
}
