namespace VideoPlayer
{
    partial class PlayerVid
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerVid));
            this.PanelShow = new System.Windows.Forms.Panel();
            this.PVideo = new System.Windows.Forms.Button();
            this.SVideo = new System.Windows.Forms.Button();
            this.VolBar = new System.Windows.Forms.TrackBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.FullScreen = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.FullStopBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VolBar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelShow
            // 
            this.PanelShow.BackgroundImage = global::VideoPlayer.Properties.Resources._141_6219;
            this.PanelShow.Location = new System.Drawing.Point(0, 27);
            this.PanelShow.Name = "PanelShow";
            this.PanelShow.Size = new System.Drawing.Size(1260, 594);
            this.PanelShow.TabIndex = 0;
            // 
            // PVideo
            // 
            this.PVideo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PVideo.Font = new System.Drawing.Font("Georgia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PVideo.Image = global::VideoPlayer.Properties.Resources.iconfinder_ic_play_arrow_48px_352072;
            this.PVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PVideo.Location = new System.Drawing.Point(633, 627);
            this.PVideo.Name = "PVideo";
            this.PVideo.Size = new System.Drawing.Size(88, 38);
            this.PVideo.TabIndex = 2;
            this.PVideo.Text = "Play";
            this.PVideo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PVideo.UseVisualStyleBackColor = false;
            this.PVideo.Click += new System.EventHandler(this.PVideo_Click);
            // 
            // SVideo
            // 
            this.SVideo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SVideo.Font = new System.Drawing.Font("Georgia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SVideo.Image = global::VideoPlayer.Properties.Resources.iconfinder_Pause_Icon_743894;
            this.SVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SVideo.Location = new System.Drawing.Point(727, 627);
            this.SVideo.Name = "SVideo";
            this.SVideo.Size = new System.Drawing.Size(88, 38);
            this.SVideo.TabIndex = 3;
            this.SVideo.Text = "Pause";
            this.SVideo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SVideo.UseVisualStyleBackColor = false;
            this.SVideo.Click += new System.EventHandler(this.SVideo_Click);
            // 
            // VolBar
            // 
            this.VolBar.AutoSize = false;
            this.VolBar.BackColor = System.Drawing.Color.Silver;
            this.VolBar.Location = new System.Drawing.Point(12, 637);
            this.VolBar.Maximum = 0;
            this.VolBar.Minimum = -7000;
            this.VolBar.Name = "VolBar";
            this.VolBar.Size = new System.Drawing.Size(239, 28);
            this.VolBar.TabIndex = 4;
            this.VolBar.TickFrequency = 20;
            this.VolBar.Value = -5000;
            this.VolBar.Scroll += new System.EventHandler(this.VolBar_Scroll);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FullScreen
            // 
            this.FullScreen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FullScreen.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullScreen.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.FullScreen.Location = new System.Drawing.Point(1160, 628);
            this.FullScreen.Name = "FullScreen";
            this.FullScreen.Size = new System.Drawing.Size(88, 38);
            this.FullScreen.TabIndex = 5;
            this.FullScreen.Text = "Полный экран";
            this.toolTip1.SetToolTip(this.FullScreen, "Развернуть");
            this.FullScreen.UseVisualStyleBackColor = false;
            this.FullScreen.Click += new System.EventHandler(this.FullScreen_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.AboutProgToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1260, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpFileToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // OpFileToolStripMenuItem
            // 
            this.OpFileToolStripMenuItem.Name = "OpFileToolStripMenuItem";
            this.OpFileToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.OpFileToolStripMenuItem.Text = "Открыть файл";
            this.OpFileToolStripMenuItem.ToolTipText = "Выбрать видео";
            this.OpFileToolStripMenuItem.Click += new System.EventHandler(this.OpFileToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.ToolTipText = "Выйти из приложения";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // AboutProgToolStripMenuItem
            // 
            this.AboutProgToolStripMenuItem.Name = "AboutProgToolStripMenuItem";
            this.AboutProgToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.AboutProgToolStripMenuItem.Text = "О программе";
            this.AboutProgToolStripMenuItem.ToolTipText = "Информация";
            this.AboutProgToolStripMenuItem.Click += new System.EventHandler(this.AboutProgToolStripMenuItem_Click);
            // 
            // FullStopBtn
            // 
            this.FullStopBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FullStopBtn.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullStopBtn.Image = global::VideoPlayer.Properties.Resources.iconfinder_square__rounded_293648;
            this.FullStopBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FullStopBtn.Location = new System.Drawing.Point(821, 628);
            this.FullStopBtn.Name = "FullStopBtn";
            this.FullStopBtn.Size = new System.Drawing.Size(88, 38);
            this.FullStopBtn.TabIndex = 7;
            this.FullStopBtn.Text = "Stop";
            this.FullStopBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.FullStopBtn, "Полная остановка");
            this.FullStopBtn.UseVisualStyleBackColor = false;
            this.FullStopBtn.Click += new System.EventHandler(this.FullStopBtn_Click);
            // 
            // PlayerVid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VideoPlayer.Properties.Resources._141_6219;
            this.ClientSize = new System.Drawing.Size(1260, 677);
            this.Controls.Add(this.FullStopBtn);
            this.Controls.Add(this.FullScreen);
            this.Controls.Add(this.VolBar);
            this.Controls.Add(this.SVideo);
            this.Controls.Add(this.PVideo);
            this.Controls.Add(this.PanelShow);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "PlayerVid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YanisVplayer";
            this.Load += new System.EventHandler(this.PlayerVid_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayerVid_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PlayerVid_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.VolBar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelShow;
        private System.Windows.Forms.Button PVideo;
        private System.Windows.Forms.Button SVideo;
        private System.Windows.Forms.TrackBar VolBar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button FullScreen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutProgToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem OpFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.Button FullStopBtn;
    }
}

