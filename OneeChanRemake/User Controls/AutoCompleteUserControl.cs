using OneeChanRemake.FormControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneeChanRemake.Forms
{
    public partial class AutoCompletePanelUserControl : UserControl
    {
        public Point Initiallocation;

        public AutoCompletePanelUserControl()
        {
            InitializeComponent();

        }

        private void AutoCompleteListBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == KeyInput.EnterCommand)
            {
                AutoCompleteControler.ExecuteSelectedItem();
                return;
            }

            TerminalControl.TerminalLine.Text += e.KeyChar;
            TerminalControl.TerminalLine.Focus();
            TerminalControl.TerminalLine.Select(TerminalControl.Length, TerminalControl.Length );
        }
        private void AutoCompletePanelUserControl_LocationChanged(object sender, EventArgs e)
        {
            if(Initiallocation.IsEmpty)
                Initiallocation = Location;
        }
    }
}
