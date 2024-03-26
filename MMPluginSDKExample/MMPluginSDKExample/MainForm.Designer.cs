namespace MMPluginTest
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GetPluginVerButton = new Button();
            GetPlayingButton = new Button();
            GetPlayAudioButton = new Button();
            GetMMVerButton = new Button();
            GetMMRunningButton = new Button();
            GetPlayAudioKeyButton = new Button();
            GetToggleStreamKeyButton = new Button();
            GetVBVolumeButton = new Button();
            GetVolumeButton = new Button();
            GetTipsVolumeButton = new Button();
            RealTime = new CheckBox();
            group = new GroupBox();
            delay = new TrackBar();
            label = new Label();
            group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)delay).BeginInit();
            SuspendLayout();
            // 
            // GetPluginVerButton
            // 
            GetPluginVerButton.Location = new Point(6, 13);
            GetPluginVerButton.Name = "GetPluginVerButton";
            GetPluginVerButton.Size = new Size(172, 36);
            GetPluginVerButton.TabIndex = 0;
            GetPluginVerButton.Text = "获取插件SDK版本";
            GetPluginVerButton.UseVisualStyleBackColor = true;
            GetPluginVerButton.Click += GetPluginVerButton_Click;
            // 
            // GetPlayingButton
            // 
            GetPlayingButton.Location = new Point(362, 13);
            GetPlayingButton.Name = "GetPlayingButton";
            GetPlayingButton.Size = new Size(172, 36);
            GetPlayingButton.TabIndex = 1;
            GetPlayingButton.Text = "获取是否正在使用音频源";
            GetPlayingButton.UseVisualStyleBackColor = true;
            GetPlayingButton.Click += GetPlayingButton_Click;
            // 
            // GetPlayAudioButton
            // 
            GetPlayAudioButton.Location = new Point(184, 13);
            GetPlayAudioButton.Name = "GetPlayAudioButton";
            GetPlayAudioButton.Size = new Size(172, 36);
            GetPlayAudioButton.TabIndex = 2;
            GetPlayAudioButton.Text = "获取播放音频状态";
            GetPlayAudioButton.UseVisualStyleBackColor = true;
            GetPlayAudioButton.Click += GetPlayAudioButton_Click;
            // 
            // GetMMVerButton
            // 
            GetMMVerButton.Location = new Point(184, 55);
            GetMMVerButton.Name = "GetMMVerButton";
            GetMMVerButton.Size = new Size(172, 36);
            GetMMVerButton.TabIndex = 3;
            GetMMVerButton.Text = "获取MM版本";
            GetMMVerButton.UseVisualStyleBackColor = true;
            GetMMVerButton.Click += GetMMVerButton_Click;
            // 
            // GetMMRunningButton
            // 
            GetMMRunningButton.Location = new Point(362, 55);
            GetMMRunningButton.Name = "GetMMRunningButton";
            GetMMRunningButton.Size = new Size(172, 36);
            GetMMRunningButton.TabIndex = 4;
            GetMMRunningButton.Text = "获取MM运行目录";
            GetMMRunningButton.UseVisualStyleBackColor = true;
            GetMMRunningButton.Click += GetMMRunningButton_Click;
            // 
            // GetPlayAudioKeyButton
            // 
            GetPlayAudioKeyButton.Location = new Point(6, 55);
            GetPlayAudioKeyButton.Name = "GetPlayAudioKeyButton";
            GetPlayAudioKeyButton.Size = new Size(172, 36);
            GetPlayAudioKeyButton.TabIndex = 5;
            GetPlayAudioKeyButton.Text = "获取播放音频键";
            GetPlayAudioKeyButton.UseVisualStyleBackColor = true;
            GetPlayAudioKeyButton.Click += GetPlayAudioKeyButton_Click;
            // 
            // GetToggleStreamKeyButton
            // 
            GetToggleStreamKeyButton.Location = new Point(540, 13);
            GetToggleStreamKeyButton.Name = "GetToggleStreamKeyButton";
            GetToggleStreamKeyButton.Size = new Size(172, 36);
            GetToggleStreamKeyButton.TabIndex = 6;
            GetToggleStreamKeyButton.Text = "获取切换流键";
            GetToggleStreamKeyButton.UseVisualStyleBackColor = true;
            GetToggleStreamKeyButton.Click += GetToggleStreamKeyButton_Click;
            // 
            // GetVBVolumeButton
            // 
            GetVBVolumeButton.Location = new Point(6, 97);
            GetVBVolumeButton.Name = "GetVBVolumeButton";
            GetVBVolumeButton.Size = new Size(172, 36);
            GetVBVolumeButton.TabIndex = 7;
            GetVBVolumeButton.Text = "获取VB音量";
            GetVBVolumeButton.UseVisualStyleBackColor = true;
            GetVBVolumeButton.Click += GetVBVolumeButton_Click;
            // 
            // GetVolumeButton
            // 
            GetVolumeButton.Location = new Point(184, 97);
            GetVolumeButton.Name = "GetVolumeButton";
            GetVolumeButton.Size = new Size(172, 36);
            GetVolumeButton.TabIndex = 8;
            GetVolumeButton.Text = "获取音量";
            GetVolumeButton.UseVisualStyleBackColor = true;
            GetVolumeButton.Click += GetVolumeButton_Click;
            // 
            // GetTipsVolumeButton
            // 
            GetTipsVolumeButton.Location = new Point(540, 55);
            GetTipsVolumeButton.Name = "GetTipsVolumeButton";
            GetTipsVolumeButton.Size = new Size(172, 36);
            GetTipsVolumeButton.TabIndex = 9;
            GetTipsVolumeButton.Text = "获取提示音量";
            GetTipsVolumeButton.UseVisualStyleBackColor = true;
            GetTipsVolumeButton.Click += GetTipsVolumeButton_Click;
            // 
            // RealTime
            // 
            RealTime.AutoSize = true;
            RealTime.Location = new Point(13, 159);
            RealTime.Name = "RealTime";
            RealTime.Size = new Size(51, 21);
            RealTime.TabIndex = 10;
            RealTime.Text = "实时";
            RealTime.UseVisualStyleBackColor = true;
            RealTime.CheckedChanged += RealTime_CheckedChanged;
            // 
            // group
            // 
            group.Controls.Add(GetPluginVerButton);
            group.Controls.Add(GetPlayingButton);
            group.Controls.Add(GetPlayAudioButton);
            group.Controls.Add(GetTipsVolumeButton);
            group.Controls.Add(GetMMVerButton);
            group.Controls.Add(GetVolumeButton);
            group.Controls.Add(GetMMRunningButton);
            group.Controls.Add(GetVBVolumeButton);
            group.Controls.Add(GetPlayAudioKeyButton);
            group.Controls.Add(GetToggleStreamKeyButton);
            group.Location = new Point(11, 12);
            group.Name = "group";
            group.Size = new Size(718, 141);
            group.TabIndex = 11;
            group.TabStop = false;
            // 
            // delay
            // 
            delay.Location = new Point(94, 186);
            delay.Maximum = 2000;
            delay.Minimum = 1;
            delay.Name = "delay";
            delay.Size = new Size(329, 45);
            delay.TabIndex = 11;
            delay.TickStyle = TickStyle.None;
            delay.Value = 1000;
            delay.Visible = false;
            delay.Scroll += delay_Scroll;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(11, 187);
            label.Name = "label";
            label.Size = new Size(90, 17);
            label.TabIndex = 12;
            label.Text = "延迟(1000MS):";
            label.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 406);
            Controls.Add(label);
            Controls.Add(RealTime);
            Controls.Add(delay);
            Controls.Add(group);
            Name = "MainForm";
            Text = "数据获取示例";
            group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)delay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GetPluginVerButton;
        private Button GetPlayingButton;
        private Button GetPlayAudioButton;
        private Button GetMMVerButton;
        private Button GetMMRunningButton;
        private Button GetPlayAudioKeyButton;
        private Button GetToggleStreamKeyButton;
        private Button GetVBVolumeButton;
        private Button GetVolumeButton;
        private Button GetTipsVolumeButton;
        private CheckBox RealTime;
        private GroupBox group;
        private TrackBar delay;
        private Label label;
    }
}
