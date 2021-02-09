using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Luski.net.Interfaces;

namespace Luski.UI.MainScreen.User_Control
{
    public partial class CallPanel : UserControl
    {
        IAudioClient audioClient;

        public CallPanel()
        {
            InitializeComponent();
        }

        private void luskiFilledButton1_Click(object sender, EventArgs e)
        {
            audioClient = Program.Server.CreateAudioClient(Program.Server.CurrentUser.SelectedChannel);
            audioClient.Connected += AudioClient_Connected;
            audioClient.JoinCall();
        }

        private async Task AudioClient_Connected()
        {
            audioClient.PlaySoundTo(net.Sound.Devices.GetDefaltPlaybackDevice());
            audioClient.RecordSoundFrom(net.Sound.Devices.GetDefaltRecordingDevice());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            audioClient = Program.Server.CreateAudioClient(Program.Server.CurrentUser.SelectedChannel);
            audioClient.Connected += AudioClient_Connected;
            audioClient.JoinCall();
        }
    }
}
