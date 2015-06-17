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
            this._GrabWord.Location = new System.Drawing.Point(94, 263);
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
            this._Game2.Location = new System.Drawing.Point(882, 263);
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
            this._GWExit = new System.Windows.Forms.Button();

            this.SuspendLayout();
            //
            // GWExit
            //
            this._GWExit.Location = new System.Drawing.Point(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width * 9 / 10, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 10);
            this._GWExit.Size = new System.Drawing.Size(80, 40);
            this._GWExit.Text = "Exit";
            this._GWExit.ForeColor = System.Drawing.Color.Red;

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
            this.Load += new System.EventHandler(GW_Load);
            this._GWExit.Click += new System.EventHandler(GW_Exit);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _GWExit;

    }

}

