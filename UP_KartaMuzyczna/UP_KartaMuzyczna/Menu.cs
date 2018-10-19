using System;
using System.Windows.Forms;

namespace UP_KartaMuzyczna
{
    public partial class Menu : Form
    {
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        private SaveFileDialog saveFileDialog = new SaveFileDialog();
        private string pathLoad, pathSave;
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
                pathLoad = openFileDialog.FileName;
                loadPath_lbl.Text = pathLoad;
            }
            catch(Exception ex) {MessageBox.Show(ex.ToString(), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);}
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            if(PlaySound_rbtn.Checked)
            {
                soundPlayer.PlaySound(pathLoad);
            }
            else if(WMP_rbtn.Checked)
            {
                soundPlayer.PlayWindowsMediaPlayer(pathLoad);
            }
            else if(DirectSound_rbnt.Checked)
            {
                soundPlayer.PlayDirectSound(pathLoad, this.Handle);
            }
            else if(MCI_rbnt.Checked)
            {
                soundPlayer.PlayMCI(pathLoad);
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
            else if (MCI_rbnt.Checked)
            {
                soundPlayer.StopMCI();
            }
        }

        private void Pause_btn_Click(object sender, EventArgs e)
        {
            if(WMP_rbtn.Checked)
            {
                soundPlayer.PauseWindowsMediaPlayer();
            }
        }

        private void startSave_btn_Click(object sender, EventArgs e)
        {
            soundPlayer.StartRecover();
        }

        private void stopSave_btn_Click(object sender, EventArgs e)
        {
            soundPlayer.StopRecover(pathSave);
        }

        private void selectFileSave_btn_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog.ShowDialog();
                saveFileDialog.Filter = "music |*.wav";
                saveFileDialog.DefaultExt = "wav";
                pathSave = saveFileDialog.FileName;
                savePath_tbox.Text = pathSave;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    
    }
}

