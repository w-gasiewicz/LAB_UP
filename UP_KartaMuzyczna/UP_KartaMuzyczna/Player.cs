using System;
using System.Media;
using System.Windows.Forms;
using WMPLib;

namespace UP_KartaMuzyczna
{
    class Player
    {
        #region private data
        private SoundPlayer sPlayer = new SoundPlayer();
        private WindowsMediaPlayer windowsMediaPlayer = new WindowsMediaPlayer();
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
        #endregion

#region pause methods
        public void PauseWindowsMediaPlayer()
        {
            windowsMediaPlayer.controls.pause();
        }
#endregion
    }
}
