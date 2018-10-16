using System;
using System.Media;
using System.Windows.Forms;
using WMPLib;
using Microsoft.DirectX.DirectSound;
using AxWMPLib;

namespace UP_KartaMuzyczna
{
    class Player
    {
        #region private data
        private SoundPlayer sPlayer = new SoundPlayer();
        private WindowsMediaPlayer windowsMediaPlayer = new WindowsMediaPlayer();
        private AxWindowsMediaPlayer axWindowsMediaPlayer;
        private Microsoft.DirectX.DirectSound.Buffer directPlayer;
        #endregion

        #region play methods
        public void PlaySound(string path)
        {
            try
            {
                sPlayer = new SoundPlayer(path);
                sPlayer.Play();
            }
            catch(Exception ex) { MessageBox.Show(ex.ToString(), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void PlayWindowsMediaPlayer(string path)
        {
            windowsMediaPlayer.URL = path;
            windowsMediaPlayer.controls.play();
        }

        public void PlayDirectSound(string path)
        {
            Device device = new Device();
            directPlayer = new Microsoft.DirectX.DirectSound.Buffer(@path, device);
            directPlayer.Play(0, BufferPlayFlags.Default);
        }

        public void PlayAxWindowsMediaPlayer(string path)
        {

        }

        #endregion

        #region stop methods
        public void StopSound()
        {
            sPlayer.Stop();
        }
        public void StopWindowsMediaPlayer()
        {
            windowsMediaPlayer.controls.stop(); 
        }

        public void StopDirectSound()
        {
            directPlayer.Stop();
        }

        #endregion

#region pause methods
        public void PauseWindowsMediaPlayer()
        {
            windowsMediaPlayer.controls.pause();
        }
#endregion
    }
}
