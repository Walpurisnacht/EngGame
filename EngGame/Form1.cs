using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Media;

namespace EngGame
{
    public partial class MainForm : Form
    {
        private PrivateFontCollection pfc = new PrivateFontCollection();
        private SoundPlayer _player;
        private StringFormat _format = new StringFormat();
        #region ToolTips
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Application.Exit();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void InitCustomFont()
        {
            int _fontlength = Properties.Resources.UTM_KARATE.Length;
            byte[] _fontdata = Properties.Resources.UTM_KARATE;

            System.IntPtr _data = Marshal.AllocCoTaskMem(_fontlength);

            Marshal.Copy(_fontdata, 0, _data, _fontlength);

            pfc.AddMemoryFont(_data, _fontlength);

            _fontlength = Properties.Resources.UTM_Cookies.Length;
            _fontdata = Properties.Resources.UTM_Cookies;
            _data = Marshal.AllocCoTaskMem(_fontlength);
            Marshal.Copy(_fontdata, 0, _data, _fontlength);

            pfc.AddMemoryFont(_data, _fontlength);

            _fontlength = Properties.Resources.UTM_NGHA_01.Length;
            _fontdata = Properties.Resources.UTM_NGHA_01;
            _data = Marshal.AllocCoTaskMem(_fontlength);
            Marshal.Copy(_fontdata, 0, _data, _fontlength);

            pfc.AddMemoryFont(_data, _fontlength);

            Marshal.FreeCoTaskMem(_data);
            //MessageBox.Show(pfc.Families[0].Name + pfc.Families[1].Name + pfc.Families[2].Name); //Cookies Karate NH1
            //Application.Exit();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                // Activate double buffering at the form level.  All child controls will be double buffered as well.
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED
                return cp;
            }
        } 
        #endregion
        public MainForm()
        {
            InitCustomFont();
            InitializeComponent();
        }
        #region Main Events
        private void Screen_Load(object sender, EventArgs e)
        {
            Form f = (Form) sender;

            _GrabWord.SizeMode = PictureBoxSizeMode.Zoom;
            _GrabWord.Image = Properties.Resources.game_gw_noglow;

            _player = new SoundPlayer(Properties.Resources.aud_main);
            _player.PlayLooping();
        }
        private void Form_Paint(object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        //g.TranslateTransform(Screen.PrimaryScreen.Bounds.Width / 2, 0);
        //var f = new Font((FontFamily)pfc.Families[0],_Title.Font.Size);
        
        _format.LineAlignment = StringAlignment.Center;
        _format.Alignment = StringAlignment.Center;

        FontFamily ff = pfc.Families[0];
        using (Font f = new Font(ff,50))
        {           
            g.DrawString("English Playground Z", f, Brushes.LightSlateGray, new PointF(Screen.PrimaryScreen.Bounds.Width / 2 + 3, Screen.PrimaryScreen.Bounds.Height / 10 + 3), _format);
            g.DrawString("English Playground Z", f , new TextureBrush(Properties.Resources.texture_glass), new PointF(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 10),_format);
        }
    }

    private void GW_Enter(object sender, EventArgs e)
    {
        PictureBox _tmp = (PictureBox)sender;
        _tmp.Image = Properties.Resources.game_gw_glow;
        Cursor = Cursors.Hand;
    }

    private void GW_Leave(object sender, EventArgs e)
    {
        PictureBox _tmp = (PictureBox)sender;
        _tmp.Image = Properties.Resources.game_gw_noglow;
        Cursor = Cursors.Default;
    }
    
    private void GW_Click(object sender, EventArgs e)
    {
        GrabTheWordForm _GWform = new GrabTheWordForm(_player);
        _GWform.Show();
        this.Close();
    }
    #endregion
    }
    public partial class SelectButton : Button
    {
        public bool Checked { get; set; }
    }
    public partial class SelectPictureBox : PictureBox
    {
        public bool Checked { get; set; }
    }
    public class GrabWordData
    {
        public string Name { get; set; }
        public string Link { get; set; }
    }
    public partial class GrabTheWordForm : Form
    {
        private Size _boxsize = new Size(Screen.PrimaryScreen.Bounds.Height / 3, Screen.PrimaryScreen.Bounds.Height / 3);
        private Size _buttonsize = new Size(Screen.PrimaryScreen.Bounds.Width / 5, Screen.PrimaryScreen.Bounds.Height / 10);
        private Font _deffont = new Font("Times New Roman", 20f);
        private int dist;
        private int bdist;

        private ArrayList _gwdata = new ArrayList();
        private List<GrabWordData> _gwrnd = new List<GrabWordData>();
        private List<String> _gwlabel = new List<String>();
        private int _cnt;
        private PrivateFontCollection pfc = new PrivateFontCollection();
        private StringFormat _format = new StringFormat();
        private SoundPlayer _player;
        private List<SelectButton> _blist = new List<SelectButton>();
        private Queue<SelectPictureBox> _pqueue = new Queue<SelectPictureBox>();
        
        private String _cur;
        private int _curpts;
        #region ToolTips
        private void Data_Import()
        {
            try
            {
                StreamReader _tr = new StreamReader(@"Dictionary\vocabulary.input");

                while (!_tr.EndOfStream)
                {
                    string _tmp = _tr.ReadLine();
                    string[] _split;
                    _split = _tmp.Split('|');

                    GrabWordData _gwtmp = new GrabWordData();
                    _gwtmp.Name = _split[0];
                    _gwtmp.Link = _split[1];

                    _gwdata.Add(_gwtmp);
                }


                //MessageBox.Show(_gwdata.Count.ToString()); //input count
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
            finally
            { } //MessageBox.Show("Import completed!"); }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Application.Exit();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void InitCustomFont()
        {
            int _fontlength = Properties.Resources.UTM_KARATE.Length;
            byte[] _fontdata = Properties.Resources.UTM_KARATE;

            System.IntPtr _data = Marshal.AllocCoTaskMem(_fontlength);

            Marshal.Copy(_fontdata, 0, _data, _fontlength);

            pfc.AddMemoryFont(_data, _fontlength);

            _fontlength = Properties.Resources.UTM_Cookies.Length;
            _fontdata = Properties.Resources.UTM_Cookies;
            _data = Marshal.AllocCoTaskMem(_fontlength);
            Marshal.Copy(_fontdata, 0, _data, _fontlength);

            pfc.AddMemoryFont(_data, _fontlength);

            _fontlength = Properties.Resources.UTM_NGHA_01.Length;
            _fontdata = Properties.Resources.UTM_NGHA_01;
            _data = Marshal.AllocCoTaskMem(_fontlength);
            Marshal.Copy(_fontdata, 0, _data, _fontlength);

            pfc.AddMemoryFont(_data, _fontlength);

            Marshal.FreeCoTaskMem(_data);
            //MessageBox.Show(pfc.Families[0].Name + pfc.Families[1].Name + pfc.Families[2].Name); //DS Cookies Karate
            //Application.Exit();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                // Activate double buffering at the form level.  All child controls will be double buffered as well.
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED
                return cp;
            }
        }
        private void AllRandomQuestion()
        {
            Random r = new Random();
            while (_gwrnd.Count != _gwdata.Count)
            {
                int n = r.Next(_gwdata.Count);
                if (!_gwrnd.Contains(_gwdata[n])) _gwrnd.Add((GrabWordData)_gwdata[n]);
            }
        }
        private void ReloadButton()
        {
            foreach (SelectButton k in _blist)
            { 
                k.BackgroundImage = Properties.Resources.button_yellow;
                k.Checked = false;
            }
        }
        private void ResetPictureBox()
        {
            _Frame_1.Location = new Point(-_boxsize.Width, Screen.PrimaryScreen.Bounds.Height / 4);
            _Frame_2.Location = new Point(_Frame_1.Location.X - dist, Screen.PrimaryScreen.Bounds.Height / 4);
            _Frame_3.Location = new Point(_Frame_2.Location.X - dist, Screen.PrimaryScreen.Bounds.Height / 4);
        }
        private void PointUp()
        {
            _curpts = Int32.Parse(_GWScore.Text);
            _ScoreTimer.Start();
        }
        private void InitLabel(int _cnt)
        {
            try
            {
                List<String> _tmp = new List<string>();
                Random r = new Random();
                while (_tmp.Count != 3)
                {
                    int n = r.Next(_cnt, _cnt + 3);
                    if (!_tmp.Contains(_gwrnd[n].Name)) _tmp.Add(_gwrnd[n].Name);
                }
                _Label_1.Text = _tmp[0];
                _Label_2.Text = _tmp[1];
                _Label_3.Text = _tmp[2];
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally
            {
                //MessageBox.Show(_Label_1.Text + _Label_2.Text + _Label_3.Text);
            }
        }
        private void ReloadPictureBox(PictureBox k)
        {
            k.Location = new Point(-_boxsize.Width, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 4);
        }
        #endregion
        public GrabTheWordForm(SoundPlayer _player)
        {
            this._player = _player;
            InitCustomFont();
            InitializeComponent();
        }
        private void GW_Load(object sender, EventArgs e)
        {
            _player = new SoundPlayer(Properties.Resources.aud_grabword);
            _player.PlayLooping();
            Form f = (Form)sender;

            _cnt = 0;

            Data_Import();

            AllRandomQuestion();

            _GWExit.Font = new Font(pfc.Families[1], 12);
            _GWStart.Font = new Font(pfc.Families[1], 12);
            _GWScore.Font = new Font(pfc.Families[2], 30);
            //try {_Label_1.Image = Image.FromFile(@_gwrnd[0].Link);}
            //catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        #region GWExit
        private void GW_Exit(object sender, EventArgs e)
        {
            MainForm _Main = new MainForm();
            _Main.Show();
            this.Close();
        }
        private void GWE_Enter(object sender, EventArgs e)  {Cursor = Cursors.Hand;}
        private void GWE_Leave(object sender, EventArgs e)  {Cursor = Cursors.Default;}
        #endregion
        private void GWS_Enter(object sender, EventArgs e) { Cursor = Cursors.Hand; }
        private void GWS_Leave(object sender, EventArgs e) { Cursor = Cursors.Default; }
        private void GW_Start(object sender, EventArgs e)
        {
            //GrabTheWordForm.ActiveForm.Hide();
            InitLabel(_cnt);
            _GWTimer.Start();
            //MessageBox.Show(_pqueue.Count.ToString());
            #region Test
            _Frame_1.Name = _gwrnd[_cnt].Name;
            _Frame_1.Image = Image.FromFile(@_gwrnd[_cnt++].Link);
            _Frame_2.Name = _gwrnd[_cnt].Name;
            _Frame_2.Image = Image.FromFile(@_gwrnd[_cnt++].Link);
            _Frame_3.Name = _gwrnd[_cnt].Name;
            _Frame_3.Image = Image.FromFile(@_gwrnd[_cnt++].Link);
            //_Label_1.Text = _gwrnd[_cnt].Name;
            //_Label_2.Text = _gwrnd[++_cnt].Name;
            //_Label_3.Text = _gwrnd[++_cnt].Name;
            _cnt++;
            //MessageBox.Show(_cnt.ToString());
            if (_cnt >= 44) 
            { 
                MessageBox.Show("GAME OVER"); 
                _GWTimer.Stop();
                _GWExit.PerformClick();
            }
            #endregion
            _GWTimer.Start();
        }
        private void GW_Tick(object sender, EventArgs e)
        {
            SelectPictureBox _tmp = _pqueue.Peek();
            if (_tmp.Location.X <= //768)
                Screen.PrimaryScreen.Bounds.Width)
            {
                foreach (SelectPictureBox k in _pqueue)
                    k.Location = new Point(k.Location.X + 3, k.Location.Y);
            }
            else
            {
                ReloadPictureBox(_tmp);
                _pqueue.Dequeue();
                _pqueue.Enqueue(_tmp);
            }
        }
        private void GW_Title(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            _format.LineAlignment = StringAlignment.Center;
            _format.Alignment = StringAlignment.Center;

            FontFamily ff = pfc.Families[1];
            using (Font f = new Font(ff, 50))
            {
                g.DrawString("Grab the WORD", f, Brushes.LightSlateGray, new PointF(Screen.PrimaryScreen.Bounds.Width / 2 + 3, Screen.PrimaryScreen.Bounds.Height / 10 + 3), _format);
                g.DrawString("Grab the WORD", f, Brushes.Coral, new PointF(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 10), _format);
            }
        }
        private void GW_Animation(object sender, PaintEventArgs e) //score draw
        {
            Graphics g = e.Graphics;
            
        }
        #region L1
        private void L1_Click(object sender, EventArgs e)
        {
            ReloadButton();
            _Label_1.Checked = !_Label_1.Checked;
            if (_Label_1.Checked) _Label_1.BackgroundImage = Properties.Resources.button_blue;
            _cur = _Label_1.Text;
        }
        private void L1_Enter(object sender, EventArgs e) { Cursor = Cursors.Hand; }
        private void L1_Leave(object sender, EventArgs e) { Cursor = Cursors.Default; }
        #endregion
        #region L2
        private void L2_Click(object sender, EventArgs e)
        {
            ReloadButton();
            _Label_2.Checked = !_Label_2.Checked;
            if (_Label_2.Checked) _Label_2.BackgroundImage = Properties.Resources.button_blue;
            _cur = _Label_2.Text;
        }
        private void L2_Enter(object sender, EventArgs e) { Cursor = Cursors.Hand; }
        private void L2_Leave(object sender, EventArgs e) { Cursor = Cursors.Default; }
        #endregion
        #region L3
        private void L3_Click(object sender, EventArgs e)
        {
            ReloadButton();
            _Label_3.Checked = !_Label_3.Checked;
            if (_Label_3.Checked) _Label_3.BackgroundImage = Properties.Resources.button_blue;
            _cur = _Label_3.Text;
        }
        private void L3_Enter(object sender, EventArgs e) { Cursor = Cursors.Hand; }
        private void L3_Leave(object sender, EventArgs e) { Cursor = Cursors.Default; }
        #endregion
        #region F1
        private void F1_Click(object sender, EventArgs e)
        {
            String _res = "";
            SelectPictureBox _tmp = (SelectPictureBox)sender;
            foreach (SelectButton k in _blist)
            {
                if (k.Checked) { _res = k.Text; break; }
            }
            if (_tmp.Name == _res) { MessageBox.Show("CORRECT"); PointUp(); _GWStart.PerformClick(); }
            else { MessageBox.Show("WRONG!"); _GWStart.PerformClick(); }
            ReloadButton();
        }
        private void F1_Enter(object sender, EventArgs e) { Cursor = Cursors.Hand; }
        private void F1_Leave(object sender, EventArgs e) { Cursor = Cursors.Default; }
        #endregion F1
        #region F2
        private void F2_Click(object sender, EventArgs e)
        {
            //GrabTheWordForm.ActiveForm.Hide();
            String _res = "";
            SelectPictureBox _tmp = (SelectPictureBox)sender;
            foreach (SelectButton k in _blist)
            {
                if (k.Checked) { _res = k.Text; break; }
            }
            if (_tmp.Name == _res) { MessageBox.Show("CORRECT"); PointUp(); _GWStart.PerformClick(); }
            else { MessageBox.Show("WRONG!"); _GWStart.PerformClick(); }
            ReloadButton();
        }
        private void F2_Enter(object sender, EventArgs e) { Cursor = Cursors.Hand; }
        private void F2_Leave(object sender, EventArgs e) { Cursor = Cursors.Default; }
        #endregion F2
        #region F3
        private void F3_Click(object sender, EventArgs e)
        {
            String _res = "";
            SelectPictureBox _tmp = (SelectPictureBox)sender;
            foreach (SelectButton k in _blist)
            {
                if (k.Checked) { _res = k.Text; break; }
            }
            if (_tmp.Name == _res) { MessageBox.Show("CORRECT"); PointUp(); _GWStart.PerformClick(); }
            else { MessageBox.Show("WRONG!"); _GWStart.PerformClick(); }
            ReloadButton();
        }
        private void F3_Enter(object sender, EventArgs e) { Cursor = Cursors.Hand; }
        private void F3_Leave(object sender, EventArgs e) { Cursor = Cursors.Default; }
        #endregion F3
        private void Score_Tick(object sender, EventArgs e)
        {
            _GWScore.Text = (Int32.Parse(_GWScore.Text) + 1).ToString();
            if ((_curpts + 10) == Int32.Parse(_GWScore.Text)) _ScoreTimer.Stop();
        }
    }
}
