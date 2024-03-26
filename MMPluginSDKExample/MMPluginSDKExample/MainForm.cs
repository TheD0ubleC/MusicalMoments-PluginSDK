namespace MMPluginTest
{
    public partial class MainForm : Form
    {
        public static PluginSDK pluginSDK;
        private Thread realtimeThread;
        private bool isRealtimeRunning = false;
        private string[] originalButtonTexts;
        public MainForm(string arg)
        {
            InitializeComponent();
            pluginSDK = new PluginSDK(arg);
            SaveOriginalButtonTexts();
        }
        private void GetPluginVerButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pluginSDK.GetPluginVer());
        }
        private void GetPlayAudioButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pluginSDK.GetPlaying().ToString());
        }
        private void GetPlayingButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pluginSDK.GetPlayAudio().ToString());
        }
        private void GetToggleStreamKeyButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pluginSDK.GetToggleStreamKey());
        }
        private void GetPlayAudioKeyButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pluginSDK.GetPlayAudioKey());
        }
        private void GetMMVerButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pluginSDK.GetMMVer());
        }
        private void GetMMRunningButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pluginSDK.GetMMRunning());
        }
        private void GetTipsVolumeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pluginSDK.GetTipsVolume().ToString());
        }
        private void GetVBVolumeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pluginSDK.GetVBVolume().ToString());
        }
        private void GetVolumeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pluginSDK.GetVolume().ToString());
        }
        private void delay_Scroll(object sender, EventArgs e)
        {
            label.Text = $"ясЁы({delay.Value}MS):";
        }
        private void SaveOriginalButtonTexts()
        {
            originalButtonTexts = new string[]
            {
                GetPluginVerButton.Text,
                GetPlayAudioButton.Text,
                GetPlayingButton.Text,
                GetToggleStreamKeyButton.Text,
                GetPlayAudioKeyButton.Text,
                GetMMVerButton.Text,
                GetMMRunningButton.Text,
                GetTipsVolumeButton.Text,
                GetVBVolumeButton.Text,
                GetVolumeButton.Text
            };
        }
        private void ResetButtonText()
        {
            for (int i = 0; i < originalButtonTexts.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        GetPluginVerButton.Text = originalButtonTexts[i];
                        break;
                    case 1:
                        GetPlayAudioButton.Text = originalButtonTexts[i];
                        break;
                    case 2:
                        GetPlayingButton.Text = originalButtonTexts[i];
                        break;
                    case 3:
                        GetToggleStreamKeyButton.Text = originalButtonTexts[i];
                        break;
                    case 4:
                        GetPlayAudioKeyButton.Text = originalButtonTexts[i];
                        break;
                    case 5:
                        GetMMVerButton.Text = originalButtonTexts[i];
                        break;
                    case 6:
                        GetMMRunningButton.Text = originalButtonTexts[i];
                        break;
                    case 7:
                        GetTipsVolumeButton.Text = originalButtonTexts[i];
                        break;
                    case 8:
                        GetVBVolumeButton.Text = originalButtonTexts[i];
                        break;
                    case 9:
                        GetVolumeButton.Text = originalButtonTexts[i];
                        break;
                }
            }
        }
        private async void RealTime_CheckedChanged(object sender, EventArgs e)
        {
            if (RealTime.Checked)
            {
                isRealtimeRunning = true;
                label.Visible = true;
                delay.Visible = true;
                await Task.Run(RealtimeUpdate);
            }
            else
            {
                isRealtimeRunning = false;
                label.Visible = false;
                delay.Visible = false;
                ResetButtonText();
            }
        }
        private async Task RealtimeUpdate()
        {
            while (isRealtimeRunning)
            {
                GetPluginVerButton.Text = await Task.Run(() => pluginSDK.GetPluginVer());
                GetPlayAudioButton.Text = await Task.Run(() => pluginSDK.GetPlaying().ToString());
                GetPlayingButton.Text = await Task.Run(() => pluginSDK.GetPlayAudio().ToString());
                GetToggleStreamKeyButton.Text = await Task.Run(() => pluginSDK.GetToggleStreamKey());
                GetPlayAudioKeyButton.Text = await Task.Run(() => pluginSDK.GetPlayAudioKey());
                GetMMVerButton.Text = await Task.Run(() => pluginSDK.GetMMVer());
                GetMMRunningButton.Text = await Task.Run(() => pluginSDK.GetMMRunning());
                GetTipsVolumeButton.Text = await Task.Run(() => pluginSDK.GetTipsVolume().ToString());
                GetVBVolumeButton.Text = await Task.Run(() => pluginSDK.GetVBVolume().ToString());
                GetVolumeButton.Text = await Task.Run(() => pluginSDK.GetVolume().ToString());
                await Task.Delay(delay.Value);
            }
        }
    }
}
