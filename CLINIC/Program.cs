using System;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Globalization;
using BusinessLogicLayer;

namespace UserInterface
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            try
            {
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("fa-IR");
                Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

                if (IsPrevInstance())
                    return;
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                SplashScreen _SplashScreen = new SplashScreen();
                _SplashScreen.Show();
                UserLogin _UserLogin = new UserLogin();
                _SplashScreen.Refresh(); 
                System.Threading.Thread.Sleep(2000);
                _SplashScreen.Close();
                _SplashScreen.Dispose();                
                Application.Run(_UserLogin);
            }
            catch (Exception exception)
            {
                ExceptionHandlerBLL.HandleException(exception);                
            }
        }
        private static bool IsPrevInstance()
        {
            string processName = Process.GetCurrentProcess().ProcessName;
            Process[] instances = Process.GetProcessesByName(processName);
            if (instances.Length > 1)
                return true;
            else
                return false;
        }
    }
}
