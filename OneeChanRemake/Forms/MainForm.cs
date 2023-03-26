using System;
using System.Windows.Forms;
using OneeChanRemake.FormControl;

namespace OneeChanRemake
{
    public partial class MainForm : Form
    {
        public static MainForm mainform;

        public MainForm()
        {
            InitializeComponent();

            Awake();

            DoubleBuffered = true;


        }

        private void FormLoad(object sender, EventArgs e)
        {
            Start();
        }
        private void MainFormKeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void AddClick(object sender, EventArgs e)
        {

        }
        private void Exitlick(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void ListClick(object sender, EventArgs e)
        {

        }
        private void MuteClick(object sender, EventArgs e)
        {

        }
        private void MinimizeClick(object sender, EventArgs e)
        {

        }
        private void InfoClick(object sender, EventArgs e)
        {

        }
        private void MainFormResize(object sender, EventArgs e)
        {

        }
        private void MainForm_Activated(object sender, EventArgs e)
        {

        }
        private void TerminalLine_TextChanged(object sender, EventArgs e)
        {


        }
        private void TerminalLine_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;

            if (key == Keys.Enter)
            {
                if (TerminalControl.Length > 0)
                    TerminalControl.Execute();
            }
            else if (key == Keys.Escape)
            {
                TerminalControl.Clear();
            }
        }

        void Awake ()
        {
            mainform = this;
            TerminalControl.TerminalLine = TerminalLine;
            LogLabelControler.Loglabel = LogLabel;
        }
        void Start()
        {
            try
            {
                //Application.CommandExcuter.AddCommand("Musics", @"D:\Media\music");
                //Application.CommandExcuter.AddCommand("Games", @"D:\Games");
                //Application.CommandExcuter.AddCommand("Stronghold", @"D:\Games\Stronghold 2\Stronghold2.exe");
                //Application.Informations.SaveData();
                Application.Informations.LoadData();
            }
            catch (Exception ex)
            {
                LogLabelControler.PrintError(ex.Message);
            }

            BlurMaker.EnableBlur(this);
            
        }

    }
}
