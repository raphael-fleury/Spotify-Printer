namespace SpotifyPrinter
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
            this.playlistInput = new System.Windows.Forms.TextBox();
            this.playlistsContainer = new SpotifyPrinter.UserControls.PlaylistsContainer();
            this.actionsUserControl1 = new SpotifyPrinter.Forms.ActionsUserControl();
            this.SuspendLayout();
            // 
            // playlistInput
            // 
            this.playlistInput.Location = new System.Drawing.Point(14, 13);
            this.playlistInput.Name = "playlistInput";
            this.playlistInput.Size = new System.Drawing.Size(349, 20);
            this.playlistInput.TabIndex = 2;
            this.playlistInput.Text = "Insert playlist\'s URI here to add";
            this.playlistInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.playlistInput_KeyDown);
            // 
            // playlistsContainer
            // 
            this.playlistsContainer.Location = new System.Drawing.Point(14, 47);
            this.playlistsContainer.Name = "playlistsContainer";
            this.playlistsContainer.Size = new System.Drawing.Size(349, 391);
            this.playlistsContainer.TabIndex = 3;
            // 
            // actionsUserControl1
            // 
            this.actionsUserControl1.BackColor = System.Drawing.Color.DarkCyan;
            this.actionsUserControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.actionsUserControl1.Location = new System.Drawing.Point(368, 0);
            this.actionsUserControl1.Name = "actionsUserControl1";
            this.actionsUserControl1.Size = new System.Drawing.Size(200, 450);
            this.actionsUserControl1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.actionsUserControl1);
            this.Controls.Add(this.playlistsContainer);
            this.Controls.Add(this.playlistInput);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spotify Printer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox playlistInput;
        private UserControls.PlaylistsContainer playlistsContainer;
        private Forms.ActionsUserControl actionsUserControl1;
    }
}