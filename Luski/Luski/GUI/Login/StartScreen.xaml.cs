using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Luski.GUI.Login
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class StartScreen : Page
    {
        public StartScreen()
        {
            this.InitializeComponent();
            //code for custome title bar
            Color back = new Color() { A = 255, R = 45, G = 45, B = 45 };
            Color hover = new Color() { A = 255, R = 50, G = 50, B = 50 };
            ApplicationViewTitleBar titlebar = ApplicationView.GetForCurrentView().TitleBar;
            titlebar.BackgroundColor = back;
            titlebar.ButtonBackgroundColor = back;
            titlebar.InactiveBackgroundColor = back;
            titlebar.ButtonInactiveBackgroundColor = back;
            titlebar.ButtonHoverBackgroundColor = hover;
        }
    }
}
