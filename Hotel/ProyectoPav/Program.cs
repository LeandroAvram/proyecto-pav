using System;
using System.Windows.Forms;

namespace ProyectoPav
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Login login = new Login();
            //login.Show();
            //Application.Run();
            Application.Run(new Login());
        }
    }
}
