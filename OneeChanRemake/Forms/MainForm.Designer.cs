namespace OneeChanRemake
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ExitBTN = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Button();
            this.MuteBTN = new System.Windows.Forms.Button();
            this.ListBTN = new System.Windows.Forms.Button();
            this.AddBTN = new System.Windows.Forms.Button();
            this.MinimizeBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddNewBTN = new System.Windows.Forms.Button();
            this.BrowsAddressBTN = new System.Windows.Forms.Button();
            this.NewNameCommand = new System.Windows.Forms.TextBox();
            this.AdressTextBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.CountCommandLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteAllBTN = new System.Windows.Forms.Button();
            this.SearchNameTextBox = new System.Windows.Forms.TextBox();
            this.BookCommandListBox = new System.Windows.Forms.ListBox();
            this.PreviewAddressTextbox = new System.Windows.Forms.TextBox();
            this.DeleteCommandBTN = new System.Windows.Forms.Button();
            this.LogLabel = new System.Windows.Forms.Label();
            this.TerminalLine = new System.Windows.Forms.TextBox();
            this.autoCompletePanel = new OneeChanRemake.Forms.AutoCompletePanelUserControl();
            this.panel1.SuspendLayout();
            this.PanelControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitBTN
            // 
            this.ExitBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBTN.BackColor = System.Drawing.Color.Red;
            this.ExitBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ExitBTN.FlatAppearance.BorderSize = 6;
            this.ExitBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBTN.ForeColor = System.Drawing.Color.White;
            this.ExitBTN.Location = new System.Drawing.Point(524, 12);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(55, 40);
            this.ExitBTN.TabIndex = 3;
            this.ExitBTN.Text = "X";
            this.ExitBTN.UseVisualStyleBackColor = false;
            this.ExitBTN.Click += new System.EventHandler(this.Exitlick);
            // 
            // Info
            // 
            this.Info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Info.BackColor = System.Drawing.Color.Transparent;
            this.Info.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Info.BackgroundImage")));
            this.Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Info.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Info.Location = new System.Drawing.Point(435, 12);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(38, 40);
            this.Info.TabIndex = 9;
            this.Info.UseVisualStyleBackColor = false;
            this.Info.Click += new System.EventHandler(this.InfoClick);
            // 
            // MuteBTN
            // 
            this.MuteBTN.BackColor = System.Drawing.Color.Transparent;
            this.MuteBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MuteBTN.BackgroundImage")));
            this.MuteBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MuteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MuteBTN.Location = new System.Drawing.Point(100, 12);
            this.MuteBTN.Name = "MuteBTN";
            this.MuteBTN.Size = new System.Drawing.Size(38, 40);
            this.MuteBTN.TabIndex = 8;
            this.MuteBTN.UseVisualStyleBackColor = false;
            this.MuteBTN.Click += new System.EventHandler(this.MuteClick);
            // 
            // ListBTN
            // 
            this.ListBTN.BackColor = System.Drawing.Color.Transparent;
            this.ListBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ListBTN.BackgroundImage")));
            this.ListBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ListBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ListBTN.Location = new System.Drawing.Point(56, 12);
            this.ListBTN.Name = "ListBTN";
            this.ListBTN.Size = new System.Drawing.Size(38, 40);
            this.ListBTN.TabIndex = 6;
            this.ListBTN.UseVisualStyleBackColor = false;
            this.ListBTN.Click += new System.EventHandler(this.ListClick);
            // 
            // AddBTN
            // 
            this.AddBTN.BackColor = System.Drawing.Color.Transparent;
            this.AddBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddBTN.BackgroundImage")));
            this.AddBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBTN.Location = new System.Drawing.Point(12, 12);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(38, 40);
            this.AddBTN.TabIndex = 4;
            this.AddBTN.UseVisualStyleBackColor = false;
            this.AddBTN.Click += new System.EventHandler(this.AddClick);
            // 
            // MinimizeBTN
            // 
            this.MinimizeBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeBTN.BackColor = System.Drawing.Color.Yellow;
            this.MinimizeBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinimizeBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.MinimizeBTN.FlatAppearance.BorderSize = 6;
            this.MinimizeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MinimizeBTN.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBTN.ForeColor = System.Drawing.Color.Black;
            this.MinimizeBTN.Location = new System.Drawing.Point(479, 12);
            this.MinimizeBTN.Name = "MinimizeBTN";
            this.MinimizeBTN.Size = new System.Drawing.Size(39, 40);
            this.MinimizeBTN.TabIndex = 10;
            this.MinimizeBTN.Text = "─";
            this.MinimizeBTN.UseVisualStyleBackColor = false;
            this.MinimizeBTN.Click += new System.EventHandler(this.MinimizeClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.autoCompletePanel);
            this.panel1.Controls.Add(this.PanelControl);
            this.panel1.Controls.Add(this.LogLabel);
            this.panel1.Controls.Add(this.TerminalLine);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 521);
            this.panel1.TabIndex = 14;
            // 
            // PanelControl
            // 
            this.PanelControl.Controls.Add(this.tabPage1);
            this.PanelControl.Controls.Add(this.tabPage2);
            this.PanelControl.Controls.Add(this.tabPage3);
            this.PanelControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelControl.ItemSize = new System.Drawing.Size(60, 30);
            this.PanelControl.Location = new System.Drawing.Point(12, 115);
            this.PanelControl.Name = "PanelControl";
            this.PanelControl.SelectedIndex = 0;
            this.PanelControl.Size = new System.Drawing.Size(567, 374);
            this.PanelControl.TabIndex = 2;
            this.PanelControl.SelectedIndexChanged += new System.EventHandler(this.PanelControl_SelectedIndexChanged);
            this.PanelControl.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.PanelControl_ChangeUICues);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(559, 336);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Recents";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.AddNewBTN);
            this.tabPage2.Controls.Add(this.BrowsAddressBTN);
            this.tabPage2.Controls.Add(this.NewNameCommand);
            this.tabPage2.Controls.Add(this.AdressTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(559, 336);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Write the command name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Write the address:";
            // 
            // AddNewBTN
            // 
            this.AddNewBTN.Location = new System.Drawing.Point(385, 247);
            this.AddNewBTN.Name = "AddNewBTN";
            this.AddNewBTN.Size = new System.Drawing.Size(143, 55);
            this.AddNewBTN.TabIndex = 3;
            this.AddNewBTN.Text = "Add";
            this.AddNewBTN.UseVisualStyleBackColor = true;
            this.AddNewBTN.Click += new System.EventHandler(this.AddNewBTN_Click);
            // 
            // BrowsAddressBTN
            // 
            this.BrowsAddressBTN.Location = new System.Drawing.Point(444, 41);
            this.BrowsAddressBTN.Name = "BrowsAddressBTN";
            this.BrowsAddressBTN.Size = new System.Drawing.Size(109, 32);
            this.BrowsAddressBTN.TabIndex = 2;
            this.BrowsAddressBTN.Text = "Browse";
            this.BrowsAddressBTN.UseVisualStyleBackColor = true;
            this.BrowsAddressBTN.Click += new System.EventHandler(this.BrowsAddressBTN_Click);
            // 
            // NewNameCommand
            // 
            this.NewNameCommand.BackColor = System.Drawing.Color.Black;
            this.NewNameCommand.ForeColor = System.Drawing.Color.White;
            this.NewNameCommand.Location = new System.Drawing.Point(6, 112);
            this.NewNameCommand.Name = "NewNameCommand";
            this.NewNameCommand.Size = new System.Drawing.Size(271, 32);
            this.NewNameCommand.TabIndex = 1;
            // 
            // AdressTextBox
            // 
            this.AdressTextBox.BackColor = System.Drawing.Color.Black;
            this.AdressTextBox.ForeColor = System.Drawing.Color.White;
            this.AdressTextBox.Location = new System.Drawing.Point(6, 41);
            this.AdressTextBox.Name = "AdressTextBox";
            this.AdressTextBox.Size = new System.Drawing.Size(432, 32);
            this.AdressTextBox.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.CountCommandLabel);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.DeleteAllBTN);
            this.tabPage3.Controls.Add(this.SearchNameTextBox);
            this.tabPage3.Controls.Add(this.BookCommandListBox);
            this.tabPage3.Controls.Add(this.PreviewAddressTextbox);
            this.tabPage3.Controls.Add(this.DeleteCommandBTN);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(559, 336);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Book";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // CountCommandLabel
            // 
            this.CountCommandLabel.AutoSize = true;
            this.CountCommandLabel.Location = new System.Drawing.Point(378, 31);
            this.CountCommandLabel.Name = "CountCommandLabel";
            this.CountCommandLabel.Size = new System.Drawing.Size(0, 26);
            this.CountCommandLabel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Count:";
            // 
            // DeleteAllBTN
            // 
            this.DeleteAllBTN.Location = new System.Drawing.Point(302, 268);
            this.DeleteAllBTN.Name = "DeleteAllBTN";
            this.DeleteAllBTN.Size = new System.Drawing.Size(254, 52);
            this.DeleteAllBTN.TabIndex = 4;
            this.DeleteAllBTN.Text = "Delete All";
            this.DeleteAllBTN.UseVisualStyleBackColor = true;
            this.DeleteAllBTN.Click += new System.EventHandler(this.DeleteAllBTN_Click);
            // 
            // SearchNameTextBox
            // 
            this.SearchNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SearchNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchNameTextBox.Location = new System.Drawing.Point(302, 60);
            this.SearchNameTextBox.Name = "SearchNameTextBox";
            this.SearchNameTextBox.Size = new System.Drawing.Size(254, 29);
            this.SearchNameTextBox.TabIndex = 3;
            this.SearchNameTextBox.TextChanged += new System.EventHandler(this.SearchNameTextBox_TextChanged);
            this.SearchNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchNameTextBox_KeyPress);
            this.SearchNameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchNameTextBox_KeyUp);
            // 
            // BookCommandListBox
            // 
            this.BookCommandListBox.FormattingEnabled = true;
            this.BookCommandListBox.ItemHeight = 25;
            this.BookCommandListBox.Location = new System.Drawing.Point(3, 29);
            this.BookCommandListBox.Name = "BookCommandListBox";
            this.BookCommandListBox.Size = new System.Drawing.Size(293, 304);
            this.BookCommandListBox.TabIndex = 2;
            this.BookCommandListBox.SelectedIndexChanged += new System.EventHandler(this.BookCommandListBox_SelectedIndexChanged);
            // 
            // PreviewAddressTextbox
            // 
            this.PreviewAddressTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PreviewAddressTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviewAddressTextbox.Location = new System.Drawing.Point(3, 3);
            this.PreviewAddressTextbox.Name = "PreviewAddressTextbox";
            this.PreviewAddressTextbox.ReadOnly = true;
            this.PreviewAddressTextbox.Size = new System.Drawing.Size(553, 23);
            this.PreviewAddressTextbox.TabIndex = 1;
            this.PreviewAddressTextbox.TextChanged += new System.EventHandler(this.PreviewAddressTextbox_TextChanged);
            // 
            // DeleteCommandBTN
            // 
            this.DeleteCommandBTN.Location = new System.Drawing.Point(302, 95);
            this.DeleteCommandBTN.Name = "DeleteCommandBTN";
            this.DeleteCommandBTN.Size = new System.Drawing.Size(254, 52);
            this.DeleteCommandBTN.TabIndex = 0;
            this.DeleteCommandBTN.Text = "Delete";
            this.DeleteCommandBTN.UseVisualStyleBackColor = true;
            this.DeleteCommandBTN.Click += new System.EventHandler(this.DeleteCommandBTN_Click);
            // 
            // LogLabel
            // 
            this.LogLabel.AutoSize = true;
            this.LogLabel.BackColor = System.Drawing.Color.White;
            this.LogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogLabel.ForeColor = System.Drawing.Color.Black;
            this.LogLabel.Location = new System.Drawing.Point(12, 492);
            this.LogLabel.Name = "LogLabel";
            this.LogLabel.Size = new System.Drawing.Size(0, 20);
            this.LogLabel.TabIndex = 1;
            // 
            // TerminalLine
            // 
            this.TerminalLine.BackColor = System.Drawing.Color.Black;
            this.TerminalLine.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TerminalLine.ForeColor = System.Drawing.Color.White;
            this.TerminalLine.Location = new System.Drawing.Point(12, 71);
            this.TerminalLine.Name = "TerminalLine";
            this.TerminalLine.Size = new System.Drawing.Size(567, 38);
            this.TerminalLine.TabIndex = 0;
            this.TerminalLine.TextChanged += new System.EventHandler(this.TerminalLine_TextChanged);
            this.TerminalLine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TerminalLine_KeyDown);
            // 
            // autoCompletePanel
            // 
            this.autoCompletePanel.BackColor = System.Drawing.Color.Transparent;
            this.autoCompletePanel.Location = new System.Drawing.Point(13, 104);
            this.autoCompletePanel.Name = "autoCompletePanel";
            this.autoCompletePanel.Size = new System.Drawing.Size(194, 270);
            this.autoCompletePanel.TabIndex = 8;
            this.autoCompletePanel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.autoCompletePanel_KeyPress);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(591, 521);
            this.ControlBox = false;
            this.Controls.Add(this.MinimizeBTN);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.MuteBTN);
            this.Controls.Add(this.ListBTN);
            this.Controls.Add(this.AddBTN);
            this.Controls.Add(this.ExitBTN);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Onee-Chan";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.FormLoad);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
            this.Resize += new System.EventHandler(this.MainFormResize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button ExitBTN;
        public System.Windows.Forms.Button AddBTN;
        public System.Windows.Forms.Button ListBTN;
        public System.Windows.Forms.Button MuteBTN;
        public System.Windows.Forms.Button Info;
        public System.Windows.Forms.Button MinimizeBTN;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox TerminalLine;
        public System.Windows.Forms.Label LogLabel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TabControl PanelControl;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button AddNewBTN;
        private System.Windows.Forms.Button BrowsAddressBTN;
        public System.Windows.Forms.TextBox NewNameCommand;
        public System.Windows.Forms.TextBox AdressTextBox;
        private System.Windows.Forms.Button DeleteAllBTN;
        private System.Windows.Forms.Button DeleteCommandBTN;
        public System.Windows.Forms.TextBox SearchNameTextBox;
        public System.Windows.Forms.ListBox BookCommandListBox;
        public System.Windows.Forms.TextBox PreviewAddressTextbox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label CountCommandLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public Forms.AutoCompletePanelUserControl autoCompletePanel;
    }
}

