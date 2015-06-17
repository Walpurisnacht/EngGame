namespace EngGame
{
    partial class Form1
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
            // Form1
            // 

            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1264, 741);
            this.Controls.Add(this._Game2);
            this.Controls.Add(this._GrabWord);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
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

    partial class Form2
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
            System.Drawing.Size _boxsize = new System.Drawing.Size(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 3, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 3);
            System.Drawing.Size _buttonsize = new System.Drawing.Size(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 5, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 10);
            System.Drawing.Font _deffont = new System.Drawing.Font("Times New Roman", 20f);
            int dist = _boxsize.Width + ((System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - 3 * _boxsize.Width) / 3);
            int bdist = _buttonsize.Width + ((System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - 3 * _buttonsize.Width) / 3);

            this.DoubleBuffered = true;

            this._GWExit = new System.Windows.Forms.Button();
            this._Frame_1 = new System.Windows.Forms.PictureBox();
            this._Frame_2 = new System.Windows.Forms.PictureBox();
            this._Frame_3 = new System.Windows.Forms.PictureBox();
            this._Label_1 = new System.Windows.Forms.Button();
            this._Label_2 = new System.Windows.Forms.Button();
            this._Label_3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._Frame_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Frame_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Frame_3)).BeginInit();

            this.SuspendLayout();
            //
            // GWExit
            //
            this._GWExit.Location = new System.Drawing.Point(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width * 9 / 10, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 10);
            this._GWExit.Size = new System.Drawing.Size(80, 40);
            this._GWExit.Text = "Exit";
            this._GWExit.ForeColor = System.Drawing.Color.Red;

            //
            // Label 1
            //
            this._Label_1.Location = new System.Drawing.Point(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - _boxsize.Width, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height * 3 / 4);
            this._Label_1.Size = _buttonsize;
            //this._Label_1.Text = "SAMPLE";
            this._Label_1.Font = _deffont;
            this._Label_1.BackColor = System.Drawing.Color.Transparent;
            this._Label_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            //
            // Label 2
            //
            this._Label_2.Location = new System.Drawing.Point(this._Label_1.Location.X - bdist, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height * 3 / 4);
            this._Label_2.Size = _buttonsize;
            //this._Label_2.Text = "SAMPLE";
            this._Label_2.Font = _deffont;
            this._Label_2.BackColor = System.Drawing.Color.Transparent;
            this._Label_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            //
            // Label 3
            //
            this._Label_3.Location = new System.Drawing.Point(this._Label_2.Location.X - bdist, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height * 3 / 4);
            this._Label_3.Size = _buttonsize;
            //this._Label_3.Text = "SAMPLE";
            this._Label_3.Font = _deffont;
            this._Label_3.BackColor = System.Drawing.Color.Transparent;
            this._Label_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            //
            // Frame 1
            //
            this._Frame_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._Frame_1.Location = new System.Drawing.Point(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - _boxsize.Width, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 4);
            //this._Frame_1.Image = Properties.Resources.gw_apple;
            this._Frame_1.Size = _boxsize;

            //
            // Frame 2
            //
            this._Frame_2.Location = new System.Drawing.Point(this._Frame_1.Location.X - dist, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 4);
            //this._Frame_2.Image = Properties.Resources.gw_ant;
            this._Frame_2.Size = _boxsize;
            this._Frame_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            //
            // Frame 3
            //
            this._Frame_3.Location = new System.Drawing.Point(this._Frame_2.Location.X - dist, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 4);
            //this._Frame_3.Image = Properties.Resources.gw_banana;
            this._Frame_3.Size = _boxsize;
            this._Frame_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            //System.Windows.Forms.MessageBox.Show(_Frame_3.Location.X.ToString());
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1264, 741);
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImage = Properties.Resources.bg_jungle;
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.TopMost = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.Controls.Add(_GWExit);
            this.Controls.Add(_Frame_1);
            this.Controls.Add(_Frame_2);
            this.Controls.Add(_Frame_3);
            this.Controls.Add(_Label_1);
            this.Controls.Add(_Label_2);
            this.Controls.Add(_Label_3);

            this.Load += new System.EventHandler(GW_Load);
            this._GWExit.Click += new System.EventHandler(GW_Exit);
            this._GWExit.MouseEnter += new System.EventHandler(GWE_Enter);
            this._GWExit.MouseLeave += new System.EventHandler(GWE_Leave);
            this.Paint += new System.Windows.Forms.PaintEventHandler(GW_Title);
            ((System.ComponentModel.ISupportInitialize)(this._Frame_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Frame_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Frame_3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _GWExit;
        private System.Windows.Forms.PictureBox _Frame_1;
        private System.Windows.Forms.PictureBox _Frame_2;
        private System.Windows.Forms.PictureBox _Frame_3;
        private System.Windows.Forms.Button _Label_1;
        private System.Windows.Forms.Button _Label_2;
        private System.Windows.Forms.Button _Label_3;


    }

}

