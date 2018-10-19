using System;
using System.Media;
using System.Windows.Forms;
using WMPLib;
using Microsoft.DirectX.DirectSound;
using AxWMPLib;
using System.Runtime.InteropServices;





namespace UP_KartaMuzyczna
{
    class Player
    {
        #region private data
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

        [DllImport("winmm.dll")]
        private static extern uint mciSendString(string lpstrCommand, string lpstrReturnString, uint uReturnLength, uint hWndCallback);


        private SoundPlayer sPlayer = new SoundPlayer();
        private WindowsMediaPlayer windowsMediaPlayer = new WindowsMediaPlayer();
        private Microsoft.DirectX.DirectSound.Buffer directSound;
        private Microsoft.DirectX.DirectSound.SecondaryBuffer directSound2;
        
        

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

        public void PlayDirectSound(string path, IntPtr handle)
        {
            Device device = new Device();
            device.SetCooperativeLevel(handle, CooperativeLevel.Priority);

            BufferDescription desc = new BufferDescription();
            desc.ControlEffects = true;
            desc.GlobalFocus = true;
            directSound2 = new SecondaryBuffer(path, desc, device);
            directSound2.Play(0, BufferPlayFlags.Default);

            //directSound = new Microsoft.DirectX.DirectSound.Buffer(path, device);
            //directSound.Play(0, BufferPlayFlags.Default);

        }

        public void PlayMCI(string path)
        {
            mciSendString(@"close ", null, 0, 0);
            mciSendString("open "+ path + " type mpegvideo alias sound ", null, 0, 0);
            mciSendString("play sound", null, 0, 0);
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
            directSound.Stop();
        }

        public void StopMCI()
        {
            mciSendString("stop sound", null, 0, 0);
        }

        #endregion

        #region pause methods
        public void PauseWindowsMediaPlayer()
        {
            windowsMediaPlayer.controls.pause();
        }
        #endregion

        #region recover

        public void StartRecover()
        {
            mciSendString("open new Type waveaudio Alias recsound", "", 0, 0);
            mciSendString("record recsound", "", 0, 0);
        }

        public void StopRecover(string path)
        {
            mciSendString("save recsound " + path, "", 0, 0);
            mciSendString("close recsound ", "", 0, 0);
        }

        #endregion


    }
}
