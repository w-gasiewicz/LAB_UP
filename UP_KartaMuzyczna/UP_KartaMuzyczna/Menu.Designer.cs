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
            this.PlaySound_rbtn = new System.Windows.Forms.RadioButton();
            this.WMP_rbtn = new System.Windows.Forms.RadioButton();
            this.SelectFile_btn = new System.Windows.Forms.Button();
            this.Start_btn = new System.Windows.Forms.Button();
            this.WaveOutWrite_rbtn = new System.Windows.Forms.RadioButton();
            this.MCI_rbnt = new System.Windows.Forms.RadioButton();
            this.DirectSound_rbnt = new System.Windows.Forms.RadioButton();
            this.Stop_btn = new System.Windows.Forms.Button();
            this.Pause_btn = new System.Windows.Forms.Button();
            this.selectFileSave_btn = new System.Windows.Forms.Button();
            this.stopSave_btn = new System.Windows.Forms.Button();
            this.loadPath_lbl = new System.Windows.Forms.Label();
            this.startSave_btn = new System.Windows.Forms.Button();
            this.savePath_tbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PlaySound_rbtn
            // 
            this.PlaySound_rbtn.AutoSize = true;
            this.PlaySound_rbtn.Location = new System.Drawing.Point(9, 71);
            this.PlaySound_rbtn.Margin = new System.Windows.Forms.Padding(2);
            this.PlaySound_rbtn.Name = "PlaySound_rbtn";
            this.PlaySound_rbtn.Size = new System.Drawing.Size(76, 17);
            this.PlaySound_rbtn.TabIndex = 0;
            this.PlaySound_rbtn.TabStop = true;
            this.PlaySound_rbtn.Text = "PlaySound";
            this.PlaySound_rbtn.UseVisualStyleBackColor = true;
            // 
            // WMP_rbtn
            // 
            this.WMP_rbtn.AutoSize = true;
            this.WMP_rbtn.Location = new System.Drawing.Point(9, 92);
            this.WMP_rbtn.Margin = new System.Windows.Forms.Padding(2);
            this.WMP_rbtn.Name = "WMP_rbtn";
            this.WMP_rbtn.Size = new System.Drawing.Size(179, 17);
            this.WMP_rbtn.TabIndex = 1;
            this.WMP_rbtn.TabStop = true;
            this.WMP_rbtn.Text = "Windows Media Player (ActiveX)";
            this.WMP_rbtn.UseVisualStyleBackColor = true;
            // 
            // SelectFile_btn
            // 
            this.SelectFile_btn.Location = new System.Drawing.Point(9, 26);
            this.SelectFile_btn.Margin = new System.Windows.Forms.Padding(2);
            this.SelectFile_btn.Name = "SelectFile_btn";
            this.SelectFile_btn.Size = new System.Drawing.Size(104, 41);
            this.SelectFile_btn.TabIndex = 2;
            this.SelectFile_btn.Text = "Wybierz plik dźwiękowy";
            this.SelectFile_btn.UseVisualStyleBackColor = true;
            this.SelectFile_btn.Click += new System.EventHandler(this.SelectFile_btn_Click);
            // 
            // Start_btn
            // 
            this.Start_btn.Location = new System.Drawing.Point(188, 43);
            this.Start_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(104, 41);
            this.Start_btn.TabIndex = 3;
            this.Start_btn.Text = "Start";
            this.Start_btn.UseVisualStyleBackColor = true;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // WaveOutWrite_rbtn
            // 
            this.WaveOutWrite_rbtn.AutoSize = true;
            this.WaveOutWrite_rbtn.Location = new System.Drawing.Point(9, 113);
            this.WaveOutWrite_rbtn.Margin = new System.Windows.Forms.Padding(2);
            this.WaveOutWrite_rbtn.Name = "WaveOutWrite_rbtn";
            this.WaveOutWrite_rbtn.Size = new System.Drawing.Size(96, 17);
            this.WaveOutWrite_rbtn.TabIndex = 4;
            this.WaveOutWrite_rbtn.TabStop = true;
            this.WaveOutWrite_rbtn.Text = "WaveOutWrite";
            this.WaveOutWrite_rbtn.UseVisualStyleBackColor = true;
            // 
            // MCI_rbnt
            // 
            this.MCI_rbnt.AutoSize = true;
            this.MCI_rbnt.Location = new System.Drawing.Point(9, 134);
            this.MCI_rbnt.Margin = new System.Windows.Forms.Padding(2);
            this.MCI_rbnt.Name = "MCI_rbnt";
            this.MCI_rbnt.Size = new System.Drawing.Size(44, 17);
            this.MCI_rbnt.TabIndex = 5;
            this.MCI_rbnt.TabStop = true;
            this.MCI_rbnt.Text = "MCI";
            this.MCI_rbnt.UseVisualStyleBackColor = true;
            // 
            // DirectSound_rbnt
            // 
            this.DirectSound_rbnt.AutoSize = true;
            this.DirectSound_rbnt.Location = new System.Drawing.Point(9, 158);
            this.DirectSound_rbnt.Margin = new System.Windows.Forms.Padding(2);
            this.DirectSound_rbnt.Name = "DirectSound_rbnt";
            this.DirectSound_rbnt.Size = new System.Drawing.Size(87, 17);
            this.DirectSound_rbnt.TabIndex = 6;
            this.DirectSound_rbnt.TabStop = true;
            this.DirectSound_rbnt.Text = "Direct Sound";
            this.DirectSound_rbnt.UseVisualStyleBackColor = true;
            // 
            // Stop_btn
            // 
            this.Stop_btn.Location = new System.Drawing.Point(188, 134);
            this.Stop_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Stop_btn.Name = "Stop_btn";
            this.Stop_btn.Size = new System.Drawing.Size(104, 41);
            this.Stop_btn.TabIndex = 7;
            this.Stop_btn.Text = "Stop";
            this.Stop_btn.UseVisualStyleBackColor = true;
            this.Stop_btn.Click += new System.EventHandler(this.Stop_btn_Click);
            // 
            // Pause_btn
            // 
            this.Pause_btn.Location = new System.Drawing.Point(188, 89);
            this.Pause_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Pause_btn.Name = "Pause_btn";
            this.Pause_btn.Size = new System.Drawing.Size(104, 41);
            this.Pause_btn.TabIndex = 8;
            this.Pause_btn.Text = "Pause";
            this.Pause_btn.UseVisualStyleBackColor = true;
            this.Pause_btn.Click += new System.EventHandler(this.Pause_btn_Click);
            // 
            // selectFileSave_btn
            // 
            this.selectFileSave_btn.Location = new System.Drawing.Point(12, 207);
            this.selectFileSave_btn.Name = "selectFileSave_btn";
            this.selectFileSave_btn.Size = new System.Drawing.Size(75, 23);
            this.selectFileSave_btn.TabIndex = 9;
            this.selectFileSave_btn.Text = "Wybierz";
            this.selectFileSave_btn.UseVisualStyleBackColor = true;
            this.selectFileSave_btn.Click += new System.EventHandler(this.selectFileSave_btn_Click);
            // 
            // stopSave_btn
            // 
            this.stopSave_btn.Location = new System.Drawing.Point(204, 207);
            this.stopSave_btn.Name = "stopSave_btn";
            this.stopSave_btn.Size = new System.Drawing.Size(75, 23);
            this.stopSave_btn.TabIndex = 10;
            this.stopSave_btn.Text = "Stop";
            this.stopSave_btn.UseVisualStyleBackColor = true;
            this.stopSave_btn.Click += new System.EventHandler(this.stopSave_btn_Click);
            // 
            // loadPath_lbl
            // 
            this.loadPath_lbl.AutoSize = true;
            this.loadPath_lbl.Location = new System.Drawing.Point(16, 11);
            this.loadPath_lbl.Name = "loadPath_lbl";
            this.loadPath_lbl.Size = new System.Drawing.Size(0, 13);
            this.loadPath_lbl.TabIndex = 11;
            // 
            // startSave_btn
            // 
            this.startSave_btn.Location = new System.Drawing.Point(107, 207);
            this.startSave_btn.Name = "startSave_btn";
            this.startSave_btn.Size = new System.Drawing.Size(75, 23);
            this.startSave_btn.TabIndex = 13;
            this.startSave_btn.Text = "Start";
            this.startSave_btn.UseVisualStyleBackColor = true;
            this.startSave_btn.Click += new System.EventHandler(this.startSave_btn_Click);
            // 
            // savePath_tbox
            // 
            this.savePath_tbox.Location = new System.Drawing.Point(9, 181);
            this.savePath_tbox.Name = "savePath_tbox";
            this.savePath_tbox.Size = new System.Drawing.Size(283, 20);
            this.savePath_tbox.TabIndex = 14;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 285);
            this.Controls.Add(this.savePath_tbox);
            this.Controls.Add(this.startSave_btn);
            this.Controls.Add(this.loadPath_lbl);
            this.Controls.Add(this.stopSave_btn);
            this.Controls.Add(this.selectFileSave_btn);
            this.Controls.Add(this.Pause_btn);
            this.Controls.Add(this.Stop_btn);
            this.Controls.Add(this.DirectSound_rbnt);
            this.Controls.Add(this.MCI_rbnt);
            this.Controls.Add(this.WaveOutWrite_rbtn);
            this.Controls.Add(this.Start_btn);
            this.Controls.Add(this.SelectFile_btn);
            this.Controls.Add(this.WMP_rbtn);
            this.Controls.Add(this.PlaySound_rbtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton PlaySound_rbtn;
        private System.Windows.Forms.RadioButton WMP_rbtn;
        private System.Windows.Forms.Button SelectFile_btn;
        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.RadioButton WaveOutWrite_rbtn;
        private System.Windows.Forms.RadioButton MCI_rbnt;
        private System.Windows.Forms.RadioButton DirectSound_rbnt;
        private System.Windows.Forms.Button Stop_btn;
        private System.Windows.Forms.Button Pause_btn;
        private System.Windows.Forms.Button selectFileSave_btn;
        private System.Windows.Forms.Button stopSave_btn;
        private System.Windows.Forms.Label loadPath_lbl;
        private System.Windows.Forms.Button startSave_btn;
        private System.Windows.Forms.TextBox savePath_tbox;
    }
}

