using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UP_KartaMuzyczna
{
    public partial class Menu : Form
    {
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        private string path;
        private Player soundPlayer = new Player();
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

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
        }

        private void Pause_btn_Click(object sender, EventArgs e)
        {
            if(WMP_rbtn.Checked)
            {
                soundPlayer.PauseWindowsMediaPlayer();
            }
        }

        private void StartRecording_btn_Click(object sender, EventArgs e)
        {
            mciSendString("open new Type waveaudio Alias recsound", "", 0, 0);
            mciSendString("record recsound", "", 0, 0);            
        }

        private void StopRecording_btn_Click(object sender, EventArgs e)
        {
            mciSendString("save recsound C:\\Users\\FUJITSU\\Desktop\\record\\result.wav", "", 0, 0);
            mciSendString("close recsound ", "", 0, 0);

        }
    }
}
