namespace UP_KartaMuzyczna
{
    partial class Menu
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.PlaySound_rbtn = new System.Windows.Forms.RadioButton();
            this.WMP_rbtn = new System.Windows.Forms.RadioButton();
            this.SelectFile_btn = new System.Windows.Forms.Button();
            this.Start_btn = new System.Windows.Forms.Button();
            this.WaveOutWire_rbtn = new System.Windows.Forms.RadioButton();
            this.MCI_rbnt = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.Stop_btn = new System.Windows.Forms.Button();
            this.Pause_btn = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // PlaySound_rbtn
            // 
            this.PlaySound_rbtn.AutoSize = true;
            this.PlaySound_rbtn.Location = new System.Drawing.Point(12, 68);
            this.PlaySound_rbtn.Name = "PlaySound_rbtn";
            this.PlaySound_rbtn.Size = new System.Drawing.Size(97, 21);
            this.PlaySound_rbtn.TabIndex = 0;
            this.PlaySound_rbtn.TabStop = true;
            this.PlaySound_rbtn.Text = "PlaySound";
            this.PlaySound_rbtn.UseVisualStyleBackColor = true;
            // 
            // WMP_rbtn
            // 
            this.WMP_rbtn.AutoSize = true;
            this.WMP_rbtn.Location = new System.Drawing.Point(12, 95);
            this.WMP_rbtn.Name = "WMP_rbtn";
            this.WMP_rbtn.Size = new System.Drawing.Size(232, 21);
            this.WMP_rbtn.TabIndex = 1;
            this.WMP_rbtn.TabStop = true;
            this.WMP_rbtn.Text = "Windows Media Player (ActiveX)";
            this.WMP_rbtn.UseVisualStyleBackColor = true;
            // 
            // SelectFile_btn
            // 
            this.SelectFile_btn.Location = new System.Drawing.Point(12, 12);
            this.SelectFile_btn.Name = "SelectFile_btn";
            this.SelectFile_btn.Size = new System.Drawing.Size(138, 50);
            this.SelectFile_btn.TabIndex = 2;
            this.SelectFile_btn.Text = "Wybierz plik dźwiękowy";
            this.SelectFile_btn.UseVisualStyleBackColor = true;
            this.SelectFile_btn.Click += new System.EventHandler(this.SelectFile_btn_Click);
            // 
            // Start_btn
            // 
            this.Start_btn.Location = new System.Drawing.Point(250, 53);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(138, 50);
            this.Start_btn.TabIndex = 3;
            this.Start_btn.Text = "Start";
            this.Start_btn.UseVisualStyleBackColor = true;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // WaveOutWire_rbtn
            // 
            this.WaveOutWire_rbtn.AutoSize = true;
            this.WaveOutWire_rbtn.Location = new System.Drawing.Point(12, 122);
            this.WaveOutWire_rbtn.Name = "WaveOutWire_rbtn";
            this.WaveOutWire_rbtn.Size = new System.Drawing.Size(117, 21);
            this.WaveOutWire_rbtn.TabIndex = 4;
            this.WaveOutWire_rbtn.TabStop = true;
            this.WaveOutWire_rbtn.Text = "WaveOutWire";
            this.WaveOutWire_rbtn.UseVisualStyleBackColor = true;
            // 
            // MCI_rbnt
            // 
            this.MCI_rbnt.AutoSize = true;
            this.MCI_rbnt.Location = new System.Drawing.Point(12, 149);
            this.MCI_rbnt.Name = "MCI_rbnt";
            this.MCI_rbnt.Size = new System.Drawing.Size(52, 21);
            this.MCI_rbnt.TabIndex = 5;
            this.MCI_rbnt.TabStop = true;
            this.MCI_rbnt.Text = "MCI";
            this.MCI_rbnt.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(12, 176);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(111, 21);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Direct Sound";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // Stop_btn
            // 
            this.Stop_btn.Location = new System.Drawing.Point(250, 165);
            this.Stop_btn.Name = "Stop_btn";
            this.Stop_btn.Size = new System.Drawing.Size(138, 50);
            this.Stop_btn.TabIndex = 7;
            this.Stop_btn.Text = "Stop";
            this.Stop_btn.UseVisualStyleBackColor = true;
            this.Stop_btn.Click += new System.EventHandler(this.Stop_btn_Click);
            // 
            // Pause_btn
            // 
            this.Pause_btn.Location = new System.Drawing.Point(250, 109);
            this.Pause_btn.Name = "Pause_btn";
            this.Pause_btn.Size = new System.Drawing.Size(138, 50);
            this.Pause_btn.TabIndex = 8;
            this.Pause_btn.Text = "Pause";
            this.Pause_btn.UseVisualStyleBackColor = true;
            this.Pause_btn.Click += new System.EventHandler(this.Pause_btn_Click);
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(12, 221);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(271, 48);
            this.axWindowsMediaPlayer.TabIndex = 9;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 351);
            this.Controls.Add(this.axWindowsMediaPlayer);
            this.Controls.Add(this.Pause_btn);
            this.Controls.Add(this.Stop_btn);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.MCI_rbnt);
            this.Controls.Add(this.WaveOutWire_rbtn);
            this.Controls.Add(this.Start_btn);
            this.Controls.Add(this.SelectFile_btn);
            this.Controls.Add(this.WMP_rbtn);
            this.Controls.Add(this.PlaySound_rbtn);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton PlaySound_rbtn;
        private System.Windows.Forms.RadioButton WMP_rbtn;
        private System.Windows.Forms.Button SelectFile_btn;
        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.RadioButton WaveOutWire_rbtn;
        private System.Windows.Forms.RadioButton MCI_rbnt;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button Stop_btn;
        private System.Windows.Forms.Button Pause_btn;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
    }
}

