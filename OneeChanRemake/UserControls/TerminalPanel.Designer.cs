namespace OneeChanRemake.UserControls
{
    partial class TerminalPanel
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
            this.commandline = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // commandline
            // 
            this.commandline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.commandline.BackColor = System.Drawing.Color.Black;
            this.commandline.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandline.ForeColor = System.Drawing.Color.White;
            this.commandline.Location = new System.Drawing.Point(3, 15);
            this.commandline.Name = "commandline";
            this.commandline.Size = new System.Drawing.Size(533, 32);
            this.commandline.TabIndex = 0;
            // 
            // TerminalPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.commandline);
            this.Name = "TerminalPanel";
            this.Size = new System.Drawing.Size(539, 344);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox commandline;
    }
}
