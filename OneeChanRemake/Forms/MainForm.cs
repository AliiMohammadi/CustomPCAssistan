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
        }

        void Awake ()
        {
            InitializeControlers();
        }
        void Start()
        {
            LoadAppData();
            BlurMaker.EnableBlur(this);
        }
        void InitializeControlers()
        {
            mainform = this;

            TerminalControl.TerminalLine = TerminalLine;
            LogLabelControler.Loglabel = LogLabel;
            PaperPanelControler.panelControl = PaperPanel;
            AutoCompleteControler.autoCompleteUserControl = autoCompletePanel;
            AutoCompleteControler.autoCompleteUserControl.Hide();
        }
        void LoadAppData()
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
        }

        private void START__FormLoad(object sender, EventArgs e)
        {
            Start();
        }
        private void Exitlick(object sender, EventArgs e)
        {
            AppActions.CloseApp();
        }
        private void MuteClick(object sender, EventArgs e)
        {
            AppActions.Mute();
        }
        private void MinimizeClick(object sender, EventArgs e)
        {
            AppActions.MinimizeWindow();
        }
        private void TerminalLine_TextChanged(object sender, EventArgs e)
        {
            AutoCompleteControler.FillListBox();
        }
        private void TerminalLine_KeyDown(object sender, KeyEventArgs e)
        {
            TerminalControl.KeyEntry(e);
            AutoCompleteControler.FillListBox();
        }
        private void BrowsAddressBTN_Click(object sender, EventArgs e)
        {
            PaperPanelControler.AddPanel.BrowsAddress();
        }
        private void AddNewBTN_Click(object sender, EventArgs e)
        {
            PaperPanelControler.AddPanel.AddNewCommand();
        }
        private void BookCommandListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PaperPanelControler.CommandBookPanel.ShowAddressSelectedItem();
        }
        private void SearchNameTextBox_TextChanged(object sender, EventArgs e)
        {
            PaperPanelControler.CommandBookPanel.BookCommandPanelRefresh();
        }
        private void PanelControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(PaperPanelControler.SelectedPanelIndex == 2)
                PaperPanelControler.CommandBookPanel.BookCommandPanelRefresh();
        }
        private void DeleteCommandBTN_Click(object sender, EventArgs e)
        {
            PaperPanelControler.CommandBookPanel.DeleteCommand();
        }
        private void DeleteAllBTN_Click(object sender, EventArgs e)
        {
            PaperPanelControler.CommandBookPanel.DeleteAllCommandData();
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

    }
}
