using System;
using Luski.UI.Login;
using System.Windows.Forms;
using Luski.UI.Main_Form;
using Luski.net;

namespace Luski
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static Server.Login Server;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_Form(new Server.Login("bob", "bob")));
        }
    }
}
