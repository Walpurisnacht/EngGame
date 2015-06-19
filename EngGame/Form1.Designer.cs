namespace EngGame
{
    partial class MainForm
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
            this._GrabWord = new System.Windows.Forms.PictureBox();
            this._Game2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._GrabWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Game2)).BeginInit();
            this.SuspendLayout();
            // 
            // _GrabWord
            // 
            this._GrabWord.Location = new System.Drawing.Point(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 20, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height * 3 / 7);
            this._GrabWord.Name = "_GrabWord";
            this._GrabWord.Size = new System.Drawing.Size(300, 300);
            this._GrabWord.TabIndex = 0;
            this._GrabWord.TabStop = false;
            this._GrabWord.BackColor = System.Drawing.Color.Transparent;
            this._GrabWord.Click += new System.EventHandler(this.GW_Click);
            this._GrabWord.MouseEnter += new System.EventHandler(this.GW_Enter);
            this._GrabWord.MouseLeave += new System.EventHandler(this.GW_Leave);
            // 
            // _Game2
            // 
            this._Game2.Location = new System.Drawing.Point(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width * 15 / 20, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height * 3 / 7);
            this._Game2.Name = "_Game2";
            this._Game2.Size = new System.Drawing.Size(300, 300);
            this._Game2.TabIndex = 1;
            this._Game2.TabStop = false;
            this._Game2.Hide(); //temp hide
            // 
            // MainForm
            // 

            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1264, 741);
            this.Controls.Add(this._Game2);
            this.Controls.Add(this._GrabWord);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.BackgroundImage = Properties.Resources.bg_main;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Screen_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Paint);
            ((System.ComponentModel.ISupportInitialize)(this._GrabWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Game2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox _GrabWord;
        private System.Windows.Forms.PictureBox _Game2;

    }

    partial class GrabTheWordForm
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
            dist = _boxsize.Width * 5 / 4 + ((System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - 3 * _boxsize.Width) / 3);
            bdist = _buttonsize.Width + ((System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - 3 * _buttonsize.Width) / 3);

            this.DoubleBuffered = true;
            this.AllowTransparency = true;

            this._GWStart = new System.Windows.Forms.Button();
            this._GWExit = new System.Windows.Forms.Button();
            this._Frame_1 = new SelectPictureBox();
            this._Frame_2 = new SelectPictureBox();
            this._Frame_3 = new SelectPictureBox();
            this._Label_1 = new SelectButton();
            this._Label_2 = new SelectButton();
            this._Label_3 = new SelectButton();
            this._GWTimer = new System.Windows.Forms.Timer();
            this._ScoreTimer = new System.Windows.Forms.Timer();
            this._GWScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._Frame_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Frame_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Frame_3)).BeginInit();
            this.SuspendLayout();
            
            //
            // ScoreTimer
            //
            this._ScoreTimer.Interval = 10;
            this._ScoreTimer.Enabled = false;

            //
            // GWTimer
            //
            this._GWTimer.Interval = 5;
            this._GWTimer.Enabled = false;

            //
            // GWStart
            //
            this._GWStart.Location = new System.Drawing.Point(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width * 9 / 10, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 10);
            this._GWStart.Size = new System.Drawing.Size(80, 40);
            this._GWStart.Text = "Start";
            this._GWStart.ForeColor = System.Drawing.Color.Red;

            //
            // GWExit
            //
            this._GWExit.Location = new System.Drawing.Point(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width * 9 / 10, _GWStart.Location.Y + _GWStart.Size.Height + 30);
            this._GWExit.Size = new System.Drawing.Size(80, 40);
            this._GWExit.Text = "Exit";
            this._GWExit.ForeColor = System.Drawing.Color.Red;

            //
            // Label 1
            //
            this._Label_1.Location = new System.Drawing.Point(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width * 7 / 10, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height * 3 / 4);
            this._Label_1.Size = _buttonsize;
            //this._Label_1.Text = "L1";
            this._Label_1.Font = _deffont;
            this._Label_1.BackColor = System.Drawing.Color.Transparent;
            this._Label_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._Label_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._Label_1.BackgroundImage = Properties.Resources.button_yellow;
            this._Label_1.Checked = false;
            

            //
            // Label 2
            //
            this._Label_2.Location = new System.Drawing.Point(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width * 4 / 10, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height * 3 / 4);
            this._Label_2.Size = _buttonsize;
            //this._Label_2.Text = "L2";
            this._Label_2.Font = _deffont;
            this._Label_2.BackColor = System.Drawing.Color.Transparent;
            this._Label_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._Label_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._Label_2.BackgroundImage = Properties.Resources.button_yellow;
            this._Label_2.Checked = false;

            //
            // Label 3
            //
            this._Label_3.Location = new System.Drawing.Point(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 10, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height * 3 / 4);
            this._Label_3.Size = _buttonsize;
            //this._Label_3.Text = "L3";
            this._Label_3.Font = _deffont;
            this._Label_3.BackColor = System.Drawing.Color.Transparent;
            this._Label_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._Label_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._Label_3.BackgroundImage = Properties.Resources.button_yellow;
            this._Label_3.Checked = false;

            //
            //GWScore
            //
            this._GWScore.Size = new System.Drawing.Size(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 7, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 10);
            this._GWScore.Location = new System.Drawing.Point(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2 - this._GWScore.Size.Width / 2, this._Label_3.Location.Y + 100);
            this._GWScore.Text = "0";
            this._GWScore.ForeColor = System.Drawing.Color.Transparent;
            this._GWScore.BackColor = System.Drawing.Color.Gold;
            this._GWScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            //
            // Frame 1
            //
            this._Frame_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._Frame_1.Location = new System.Drawing.Point(- _boxsize.Width
                + 0, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 4);
            //this._Frame_1.Image = Properties.Resources.gw_apple;
            this._Frame_1.Size = _boxsize;
            this._Frame_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._Frame_1.Checked = false;

            //
            // Frame 2
            //
            this._Frame_2.Location = new System.Drawing.Point(this._Frame_1.Location.X - dist, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 4);
            //this._Frame_2.Image = Properties.Resources.gw_ant;
            this._Frame_2.Size = _boxsize;
            this._Frame_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._Frame_2.Checked = false;

            //
            // Frame 3
            //
            this._Frame_3.Location = new System.Drawing.Point(this._Frame_2.Location.X - dist, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 4);
            //this._Frame_3.Image = Properties.Resources.gw_banana;
            this._Frame_3.Size = _boxsize;
            this._Frame_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._Frame_3.Checked = false;

            // 
            // GrabTheWordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1264, 741);
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImage = Properties.Resources.bg_jungle;
            this.DoubleBuffered = true;
            this.Name = "GrabTheWordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GrabTheWordForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.TopMost = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.Controls.Add(_GWStart);
            this.Controls.Add(_GWExit);
            this.Controls.Add(_Frame_1);
            this.Controls.Add(_Frame_2);
            this.Controls.Add(_Frame_3);
            this.Controls.Add(_Label_1);
            this.Controls.Add(_Label_2);
            this.Controls.Add(_Label_3);
            this.Controls.Add(_GWScore);

            //Event
            this._GWStart.Click += new System.EventHandler(GW_Start);
            this._GWStart.MouseEnter += new System.EventHandler(GWS_Enter);
            this._GWStart.MouseLeave += new System.EventHandler(GWS_Leave);

            this._GWExit.Click += new System.EventHandler(GW_Exit);
            this._GWExit.MouseEnter += new System.EventHandler(GWE_Enter);
            this._GWExit.MouseLeave += new System.EventHandler(GWE_Leave);

            this._Label_1.Click += new System.EventHandler(L1_Click);
            this._Label_1.MouseEnter += new System.EventHandler(L1_Enter);
            this._Label_1.MouseLeave += new System.EventHandler(L1_Leave);

            this._Label_2.Click += new System.EventHandler(L2_Click);
            this._Label_2.MouseEnter += new System.EventHandler(L2_Enter);
            this._Label_2.MouseLeave += new System.EventHandler(L2_Leave);

            this._Label_3.Click += new System.EventHandler(L3_Click);
            this._Label_3.MouseEnter += new System.EventHandler(L3_Enter);
            this._Label_3.MouseLeave += new System.EventHandler(L3_Leave);

            this._Frame_1.Click += new System.EventHandler(F1_Click);
            this._Frame_1.MouseEnter += new System.EventHandler(F1_Enter);
            this._Frame_1.MouseLeave += new System.EventHandler(F1_Leave);

            this._Frame_2.Click += new System.EventHandler(F2_Click);
            this._Frame_2.MouseEnter += new System.EventHandler(F2_Enter);
            this._Frame_2.MouseLeave += new System.EventHandler(F2_Leave);

            this._Frame_3.Click += new System.EventHandler(F3_Click);
            this._Frame_3.MouseEnter += new System.EventHandler(F3_Enter);
            this._Frame_3.MouseLeave += new System.EventHandler(F3_Leave);

            this._GWTimer.Tick += new System.EventHandler(GW_Tick);
            this._ScoreTimer.Tick += new System.EventHandler(Score_Tick);

            this.Load += new System.EventHandler(GW_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(GW_Title);
            this.Paint += new System.Windows.Forms.PaintEventHandler(GW_Animation);
            ((System.ComponentModel.ISupportInitialize)(this._Frame_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Frame_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Frame_3)).EndInit();

            this._blist.Add(this._Label_1);
            this._blist.Add(this._Label_2);
            this._blist.Add(this._Label_3);

            this._pqueue.Enqueue(this._Frame_1);
            this._pqueue.Enqueue(this._Frame_2);
            this._pqueue.Enqueue(this._Frame_3);

            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _GWStart;
        private System.Windows.Forms.Button _GWExit;
        private SelectPictureBox _Frame_1;
        private SelectPictureBox _Frame_2;
        private SelectPictureBox _Frame_3;
        private SelectButton _Label_1;
        private SelectButton _Label_2;
        private SelectButton _Label_3;
        private System.Windows.Forms.Timer _GWTimer;
        private System.Windows.Forms.Timer _ScoreTimer;
        private System.Windows.Forms.Label _GWScore;


    }
}

