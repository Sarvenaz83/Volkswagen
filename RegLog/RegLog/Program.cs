using CsharpLoginAndRegister;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RegLog
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            LoginAndRegisterForm loginform = new LoginAndRegisterForm();

            if (loginform.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MenuForm());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
