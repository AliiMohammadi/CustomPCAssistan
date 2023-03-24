using System;
using System.Windows.Forms;
using System.Drawing;
using Onee_Chan.Classes;

namespace Onee_Chan
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Awake();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            BlurBacGround();
        }
        private void MainFormKeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;

        }
        private void AddClick(object sender, EventArgs e)
        {

        }
        private void Exitlick(object sender, EventArgs e)
        {

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

        void Awake ()
        {
            DoubleBuffered = true;
            InitializeComponent();
        }

        void BlurBacGround()
        {
            BlurMaker.EnableBlur(this);
        }
    }
}
