using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SpotifyPrinter
{
    public partial class MainForm : Form
    {
        List<PlaylistUserControl> playlists = new List<PlaylistUserControl>();

        public MainForm()
        {
            InitializeComponent();
            playlistsContainer.ControlsBoard = controlsBoard;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            playlistsContainer.LoadPlaylists();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            controlsBoard.Width = Width / 3;
            playlistInput.Width = (int)Math.Round((Width - controlsBoard.Width) * .9);
            
            playlistsContainer.Width = playlistInput.Width;
            playlistsContainer.Height = (int)Math.Round((Height - playlistInput.Height) * .9);
        }

        private void playlistInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                playlistsContainer.AddPlaylist(playlistInput.Text);
            }
        }
    }
}
