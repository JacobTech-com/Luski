using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Luski.UI.Theme
{
    public class Theme
    {
        public dynamic theme { get; private set; }

        public Theme(string ThemeName)
        {
            Name = ThemeName;
            using (WebClient web = new WebClient())
            {
                string result = web.DownloadString($"https://JacobTech.com/Luski/GetThemeInfo/{Name}");
                dynamic data = JsonConvert.DeserializeObject<dynamic>(result);
                if (string.IsNullOrEmpty((string)data.Error))
                {
                    if ((string)data.Result == "Found")
                    {
                        OnlineVersion = (int)data.Version;
                        Description = (string)data.Description;
                        List<string> Versions = ((string)data.Versions).Split('|').ToList();
                        if (File.Exists(ThemeManager.Folder + Name + ".LuskiTheme"))
                        {
                            string file = File.ReadAllText(ThemeManager.Folder + Name + ".LuskiTheme");
                            theme = JsonConvert.DeserializeObject<dynamic>(file);
                            LocalVersion = (int)theme.Version;
                            Description = (string)theme.Description;
                            if (LocalVersion != OnlineVersion) Status = ThemeStatus.OutdatedLocal;
                            else Status = ThemeStatus.Dwnloaded;
                        }
                        else
                        {
                            if (OnlineVersion < ThemeManager.Version) Status = ThemeStatus.OutdatedOnline;
                            else
                            {
                                if (Versions.Contains(ThemeManager.Version.ToString()))
                                {
                                    Status = ThemeStatus.Web;
                                }
                                else
                                {
                                    Status = ThemeStatus.NotSouportedOnline;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (File.Exists(ThemeManager.Folder + Name + ".LuskiTheme"))
                        {
                            string file = File.ReadAllText(ThemeManager.Folder + Name + ".LuskiTheme");
                            theme = JsonConvert.DeserializeObject<dynamic>(file);
                            LocalVersion = (int)theme.Version;
                            Description = (string)theme.Description;
                            Status = ThemeStatus.Local;
                        }
                        else
                        {
                            Status = ThemeStatus.NotReal;
                        }
                    }
                }
                else
                {
                    throw new Exception((string)data.Error);
                }
            }
        }

        public void LoadFile()
        {
            if (Status == ThemeStatus.Dwnloaded || Status == ThemeStatus.OutdatedLocal)
            if (File.Exists(ThemeManager.Folder + Name + ".LuskiTheme"))
            {
                string file = File.ReadAllText(ThemeManager.Folder + Name + ".LuskiTheme");
                theme = JsonConvert.DeserializeObject<dynamic>(file);
            }
        }

        public ThemeStatus Status { get; }

        public string Name { get; }

        public string Description { get; }

        public int LocalVersion { get; } = 0;

        public int OnlineVersion { get; } = 0;

        public void Apply()
        {
            ThemeManager.ReloadTheme();
        }

        public void Download()
        {
            if (Status == ThemeStatus.OutdatedLocal || Status == ThemeStatus.Web)
            {
                DownloadTheme();
            }
            else
            {
                if (Status != ThemeStatus.Local  || Status != ThemeStatus.NotReal)
                {
                    DialogResult result = MessageBox.Show("This theme is currently downloaded would you like to redownload the theme from the store?", "Already downloaded", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes) DownloadTheme();
                }
                else
                {
                    MessageBox.Show("That theme can not be downloaded");
                }
            }
        }

        private void DownloadTheme()
        {
            CheckDir();
            if (File.Exists(ThemeManager.Folder + Name + ".LuskiTheme"))
            {
                File.Delete(ThemeManager.Folder + Name + ".LuskiTheme");
            }
            using (WebClient web = new WebClient())
            {
                web.DownloadFile($"https://JacobTech.com/Luski/GetTheme/{Name}", ThemeManager.Folder + Name + ".LuskiTheme");
            }
        }

        private void CheckDir()
        {
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Luski/"))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Luski/");
            }

            if (!Directory.Exists(ThemeManager.Folder))
            {
                Directory.CreateDirectory(ThemeManager.Folder);
            }
        }
    }
}
