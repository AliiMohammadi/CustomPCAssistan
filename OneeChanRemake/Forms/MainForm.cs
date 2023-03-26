using System;
using System.Windows.Forms;
using System.Drawing;
using Onee_Chan.Classes;
using OneeChanRemake.FormControl;

namespace OneeChanRemake
{
    public partial class MainForm : Form
    {
        public static MainForm mainform;

        public MainForm()
        {
            Awake();
            Application.CommandExcuter.AddCommand("Musics", @"D:\Media\music",Strucures.CommandTypes.Address);

        }

        private void FormLoad(object sender, EventArgs e)
        {
            BlurBacGround();
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
            DoubleBuffered = true;
            InitializeComponent();
            mainform = this;
            TerminalControl.TerminalLine = TerminalLine;
        }

        void BlurBacGround()
        {
            BlurMaker.EnableBlur(this);
        }

    }
}
