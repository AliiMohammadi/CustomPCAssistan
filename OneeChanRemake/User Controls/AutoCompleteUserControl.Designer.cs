namespace OneeChanRemake.Forms
{
    partial class AutoCompletePanelUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AutoCompleteListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // AutoCompleteListBox
            // 
            this.AutoCompleteListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AutoCompleteListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AutoCompleteListBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoCompleteListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AutoCompleteListBox.FormattingEnabled = true;
            this.AutoCompleteListBox.ItemHeight = 29;
            this.AutoCompleteListBox.Items.AddRange(new object[] {
            "List",
            "Of",
            "Commands"});
            this.AutoCompleteListBox.Location = new System.Drawing.Point(1, 1);
            this.AutoCompleteListBox.Name = "AutoCompleteListBox";
            this.AutoCompleteListBox.Size = new System.Drawing.Size(194, 265);
            this.AutoCompleteListBox.TabIndex = 16;
            this.AutoCompleteListBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AutoCompleteListBox_KeyPress);
            // 
            // AutoCompletePanelUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.AutoCompleteListBox);
            this.Name = "AutoCompletePanelUserControl";
            this.Size = new System.Drawing.Size(195, 270);
            this.Load += new System.EventHandler(this.AutoCompletePanelUserControl_Load);
            this.LocationChanged += new System.EventHandler(this.AutoCompletePanelUserControl_LocationChanged);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox AutoCompleteListBox;
    }
}
