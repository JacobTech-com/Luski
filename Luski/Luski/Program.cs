using System;
using System.Windows.Forms;
using Luski.UI.Login;
using Luski.net;
using System.Threading.Tasks;

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
            string[] login = System.IO.File.ReadAllText("config.lsk").Split(':');
            Application.Run(new Login()); // decrypt later
        }
    }
}
