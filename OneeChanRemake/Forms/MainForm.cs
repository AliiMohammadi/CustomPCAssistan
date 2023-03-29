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
            AppActions.CloseApp();
        }
        private void ListClick(object sender, EventArgs e)
        {

        }
        private void MuteClick(object sender, EventArgs e)
        {
            AppActions.Mute();
        }
        private void MinimizeClick(object sender, EventArgs e)
        {
            AppActions.MinimizeWindow();
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
            AutoCompleteControler.FillListBox();


        }
        private void TerminalLine_KeyDown(object sender, KeyEventArgs e)
        {
            TerminalControl.KeyPressAction(e);
            AutoCompleteControler.FillListBox();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (autoCompletePanel.AutoCompleteListBox.Focused)
                return base.ProcessCmdKey(ref msg, keyData);

            if (keyData == Keys.Down)
            {
                if (autoCompletePanel.AutoCompleteListBox.Items.Count != 0)
                {
                    autoCompletePanel.AutoCompleteListBox.Focus();
                    autoCompletePanel.AutoCompleteListBox.SetSelected(0, true);

                    return true;
                }
            }
            if(keyData == Keys.Enter)
            {
                AutoCompleteControler.ExecuteSelectedItem(); //اگه ایتمی از لیست انتخواب شده باشد اجراش میکند
            }


            return base.ProcessCmdKey(ref msg, keyData);
        }

        void Awake ()
        {
            mainform = this;

            TerminalControl.TerminalLine = TerminalLine;
            LogLabelControler.Loglabel = LogLabel;
            PanelControlControler.panelControl = PanelControl;
            AutoCompleteControler.autoCompleteUserControl = autoCompletePanel;
            AutoCompleteControler.autoCompleteUserControl.Hide();
        }
        void Start()
        {
            try
            {
                AppActions.SetDefaultCommands();
                Application.Informations.LoadData();

            }
            catch (Exception ex)
            {
                LogLabelControler.PrintError(ex.Message);
            }

            BlurMaker.EnableBlur(this);
            
        }
        void AddSystematicCommands()
        {

        }

        private void BrowsAddressBTN_Click(object sender, EventArgs e)
        {
            PanelControlControler.BrowsAddress();
        }

        private void AddNewBTN_Click(object sender, EventArgs e)
        {
            PanelControlControler.AddNewCommand();
        }

        private void BookCommandListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PanelControlControler.ShowAddressSelectedItem();
        }

        private void SearchNameTextBox_TextChanged(object sender, EventArgs e)
        {
            PanelControlControler.BookCommandPanelRefresh();

        }

        private void PreviewAddressTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void SearchNameTextBox_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void PanelControl_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void PanelControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(PanelControlControler.SelectedPanelIndex == 2)
                PanelControlControler.BookCommandPanelRefresh();
        }

        private void DeleteCommandBTN_Click(object sender, EventArgs e)
        {
            PanelControlControler.DeleteCommand();
        }

        private void DeleteAllBTN_Click(object sender, EventArgs e)
        {
            PanelControlControler.DeleteAllData();
        }

        private void autoCompletePanel_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
