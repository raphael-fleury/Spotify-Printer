using SpotifyPrinter.Services;
using System;
using System.Windows.Forms;

namespace SpotifyPrinter
{
    public partial class MainForm : Form
    {
        public MainForm() => InitializeComponent();

        private void MainForm_Load(object sender, EventArgs e)
        {
            playlistsContainer.Reload();
        }

        private void playlistInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Playlists.Add(playlistInput.Text);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            controlsBoard.Width = Width / 3;
            playlistInput.Width = (int)Math.Round((Width - controlsBoard.Width) * .9);
            
            playlistsContainer.Width = playlistInput.Width;
            playlistsContainer.Height = (int)Math.Round((Height - playlistInput.Height) * .9);
        }
    }
}
