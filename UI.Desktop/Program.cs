using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
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
            Application.Run(new frmLogin());


            frmLogin login = new frmLogin();
            login.FormClosed += loginForm_Closed; // agrega esto aquí
            login.Show();
            Application.Run();


        }
        public static void loginForm_Closed(object sender, FormClosedEventArgs e)
            {
                ((Form)sender).FormClosed -= loginForm_Closed;

                if (Application.OpenForms.Count == 0)
                {
                    Application.ExitThread();
                }
                else
                {
                    Application.OpenForms[0].FormClosed += loginForm_Closed;
                }
            }


    }
}
