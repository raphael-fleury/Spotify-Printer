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
            this.controlsBoard = new SpotifyPrinter.UserControls.ActionsUserControl();
            this.SuspendLayout();
            // 
            // playlistInput
            // 
            this.playlistInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playlistInput.Location = new System.Drawing.Point(14, 13);
            this.playlistInput.Name = "playlistInput";
            this.playlistInput.Size = new System.Drawing.Size(396, 20);
            this.playlistInput.TabIndex = 2;
            this.playlistInput.Text = "Insert playlist\'s URI here to add";
            this.playlistInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.playlistInput_KeyDown);
            // 
            // playlistsContainer
            // 
            this.playlistsContainer.Location = new System.Drawing.Point(14, 47);
            this.playlistsContainer.Name = "playlistsContainer";
            this.playlistsContainer.Size = new System.Drawing.Size(396, 391);
            this.playlistsContainer.TabIndex = 3;
            // 
            // controlsBoard
            // 
            this.controlsBoard.BackColor = System.Drawing.Color.DarkCyan;
            this.controlsBoard.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlsBoard.Location = new System.Drawing.Point(424, 0);
            this.controlsBoard.MaximumSize = new System.Drawing.Size(250, 0);
            this.controlsBoard.MinimumSize = new System.Drawing.Size(150, 400);
            this.controlsBoard.Name = "controlsBoard";
            this.controlsBoard.Size = new System.Drawing.Size(200, 441);
            this.controlsBoard.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.controlsBoard);
            this.Controls.Add(this.playlistsContainer);
            this.Controls.Add(this.playlistInput);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spotify Printer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox playlistInput;
        private UserControls.PlaylistsContainer playlistsContainer;
        private UserControls.ActionsUserControl controlsBoard;
    }
}