using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Luski.UI.Theme
{
    public static class ThemeManager
    {
        public static string Folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Luski/Themes/";
        public static int Version = 1;

        public static event Func<Task> ThemeUpdate;

        public static Theme CurrentTheme;

        public static Theme Defalt = new Theme("Defalt");

        public static void ReloadTheme(Theme Theme = null)
        {
            if (Theme != null)
            {
                Theme.LoadFile();
                CurrentTheme = Theme;
            }
            ThemeUpdate.Invoke();
        }
    }
}
