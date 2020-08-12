using System.Threading.Tasks;

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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip.SuspendLayout();
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
            this.playlistInput.KeyDown += (x, y) => Task.Run(() => playlistInput_KeyDown(x, y));
            // 
            // playlistsContainer
            // 
            this.playlistsContainer.Location = new System.Drawing.Point(14, 47);
            this.playlistsContainer.Name = "playlistsContainer";
            this.playlistsContainer.Size = new System.Drawing.Size(396, 370);
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
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 419);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(424, 22);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "Ronaldo";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.controlsBoard);
            this.Controls.Add(this.playlistsContainer);
            this.Controls.Add(this.playlistInput);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spotify Printer";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox playlistInput;
        private UserControls.PlaylistsContainer playlistsContainer;
        private UserControls.ActionsUserControl controlsBoard;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}