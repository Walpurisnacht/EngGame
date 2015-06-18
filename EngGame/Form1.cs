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
    public partial class Form1 : Form
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

            Marshal.FreeCoTaskMem(_data);
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
        public Form1()
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
        Form2 _GWform = new Form2(_player);
        _GWform.Show();
        this.Close();
    }
    private void GW_Paint(object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        //g.TranslateTransform(Screen.PrimaryScreen.Bounds.Width / 2, 0);
        //var f = new Font((FontFamily)pfc.Families[0],_Title.Font.Size);

        _format.LineAlignment = StringAlignment.Center;
        _format.Alignment = StringAlignment.Center;

        FontFamily ff = pfc.Families[0];
        using (Font f = new Font(ff, 50))
        {
            g.DrawString("Grab the word", f, Brushes.LightSlateGray, new PointF(Screen.PrimaryScreen.Bounds.Width / 2 + 3, Screen.PrimaryScreen.Bounds.Height / 10 + 3), _format);
            g.DrawString("Grab the word", f, Brushes.White, new PointF(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 10), _format);
        }
    }
    #endregion
    }
    public partial class SelectButton : System.Windows.Forms.Button
    {
        public bool Checked;
    }
    public class GrabWordData
    {
        public string Name { get; set; }
        public string Link { get; set; }
    }
    public partial class Form2 : Form
    {
        private ArrayList _gwdata = new ArrayList();
        private List<GrabWordData> _gwrnd = new List<GrabWordData>();
        private PrivateFontCollection pfc = new PrivateFontCollection();
        private StringFormat _format = new StringFormat();
        private SoundPlayer _player;
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

            Marshal.FreeCoTaskMem(_data);
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
            while (_gwrnd.Count != 30)
            {
                int n = r.Next(_gwdata.Count);
                if (!_gwrnd.Contains(_gwdata[n])) _gwrnd.Add((GrabWordData)_gwdata[n]);
            }
        }

        #endregion
        public Form2(SoundPlayer _player)
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

            Data_Import();

            AllRandomQuestion();

            FontFamily ff = pfc.Families[pfc.Families.Length-1];
            _GWExit.Font = new Font(ff, 15);
            //try {_Label_1.Image = Image.FromFile(@_gwrnd[0].Link);}
            //catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            

        }
        private void GW_Exit(object sender, EventArgs e)
        {
            Form1 _Main = new Form1();
            _Main.Show();
            this.Close();
        }
        private void GWE_Enter(object sender, EventArgs e)  {Cursor = Cursors.Hand;}
        private void GWE_Leave(object sender, EventArgs e)  {Cursor = Cursors.Default;}
        private void GW_Title(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            _format.LineAlignment = StringAlignment.Center;
            _format.Alignment = StringAlignment.Center;

            FontFamily ff = pfc.Families[0];
            using (Font f = new Font(ff, 50))
            {
                g.DrawString("Grab the WORD", f, Brushes.LightSlateGray, new PointF(Screen.PrimaryScreen.Bounds.Width / 2 + 3, Screen.PrimaryScreen.Bounds.Height / 10 + 3), _format);
                g.DrawString("Grab the WORD", f, Brushes.Coral, new PointF(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 10), _format);
            }
        }
        private void GW_Animation(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

        }

    }
}
