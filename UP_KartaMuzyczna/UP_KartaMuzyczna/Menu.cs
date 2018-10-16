using System;
using System.Windows.Forms;

namespace UP_KartaMuzyczna
{
    public partial class Menu : Form
    {
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        private string path;
        private Player soundPlayer = new Player();
        

        public Menu()
        {
            InitializeComponent();
        }

        private void SelectFile_btn_Click(object sender, EventArgs e)
        {//wybieramy plik z muzyka
            try
            {
                openFileDialog.ShowDialog();
                path = openFileDialog.FileName;
            }
            catch(Exception ex) {MessageBox.Show(ex.ToString(), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);}
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            if(PlaySound_rbtn.Checked)
            {
                soundPlayer.PlaySound(path);
            }
            else if(WMP_rbtn.Checked)
            {
                soundPlayer.PlayWindowsMediaPlayer(path);
            }
            else if(DirectSound_rbnt.Checked)
            {
                soundPlayer.PlayDirectSound(path);
            }
        }

        private void Stop_btn_Click(object sender, EventArgs e)
        {
            if (PlaySound_rbtn.Checked)
            {
                soundPlayer.StopSound();
            }
            else if(WMP_rbtn.Checked)
            {
                soundPlayer.StopWindowsMediaPlayer();
            }
            else if (DirectSound_rbnt.Checked)
            {
                soundPlayer.StopDirectSound();
            }
        }

        private void Pause_btn_Click(object sender, EventArgs e)
        {
            if(WMP_rbtn.Checked)
            {
                soundPlayer.PauseWindowsMediaPlayer();
            }
        }
    }
}
