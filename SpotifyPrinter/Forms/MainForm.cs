using SpotifyPrinter.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotifyPrinter
{
    public partial class MainForm : Form
    {
        public MainForm() => InitializeComponent();

        private async Task playlistInput_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine(e.KeyCode);
            if (e.KeyCode == Keys.Enter)
            {
                try { await Playlists.AddAsync(playlistInput.Text); }

                catch (Exception exc)
                {
                    statusLabel.Text = exc.Message; 
                }
            }                
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
