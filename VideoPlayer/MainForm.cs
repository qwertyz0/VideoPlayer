using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.DirectX;
using Microsoft.DirectX.AudioVideoPlayback;



namespace VideoPlayer
{
    public partial class PlayerVid : Form
    {
        Video ourVideo;

        private Size formSize;
        private Size pnlSize;

        public PlayerVid()
        {
            InitializeComponent();
        }

        private void PlayerVid_Load(object sender, EventArgs e)
        {
            formSize = new Size(this.Width, this.Height);
            pnlSize = new Size(PanelShow.Width, PanelShow.Height);
        }

        private void PVideo_Click(object sender, EventArgs e)
        {
            try
            {
                if (ourVideo.Playing == false)
                {
                    ourVideo.Play();
                }
            }
            catch (Exception ex)
            {
                string err = string.Format("Сначала выбирите видео. {0}", ex.Message);
                MessageBox.Show(err, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }


        private void OpenMedia()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ourVideo = new Video(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    string err = string.Format("Выберите файл с расширением .AVI {0}", ex.Message);
                    MessageBox.Show(err, "Неподдерживаемый  формат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    OpenMedia();
                }

                ourVideo.Open(openFileDialog1.FileName);
                ourVideo.Play();
                ourVideo.Owner = PanelShow;
                PanelShow.Size = pnlSize;
            }

        }

        private void SVideo_Click(object sender, EventArgs e)
        {
            try
            {
                if (ourVideo.Playing == true)
                {
                    ourVideo.Pause();
                }
            }
            catch (Exception ex)
            {
                string err = string.Format("Сначала выбирите видео. {0}", ex.Message);
                MessageBox.Show(err, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }


        private void FullScreen_Click(object sender, EventArgs e)
        {
            try
            {
                ourVideo.Owner = this;
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                string err = string.Format("Нужно запустить видео. {0}", ex.Message);
                MessageBox.Show(err, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                WindowState = FormWindowState.Normal;
            }

        }

        


        private void PlayerVid_KeyDown(object sender, KeyEventArgs e) //esc для выхода из видео
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                Size = formSize;
                ourVideo.Owner = PanelShow;
                PanelShow.Size = pnlSize;
            }
           
        }

        private void VolBar_Scroll(object sender, EventArgs e)
        {
            try
            {
                ourVideo.Audio.Volume = VolBar.Value;
            }
            catch (Exception ex)
            {
                string err = string.Format("Зачем крутить громкость, запусти видео. {0}", ex.Message);
                MessageBox.Show(err, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void PlayerVid_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (ourVideo.Playing == true)
                {
                    ourVideo.Pause();
                }
                else
                {
                    ourVideo.Play();
                }
            }
            

        }

        private void AboutProgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProg dopWindow = new AboutProg();
            dopWindow.ShowDialog();
        }

        private void FullStopBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ourVideo.Playing == true)
                {
                    ourVideo.Stop();
                }
                else
                {
                    ourVideo.Stop();
                }
            }
            catch (Exception ex)
            {
                string err = string.Format("Нужно запустить видео. {0}", ex.Message);
                MessageBox.Show(err, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void OpFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMedia();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
