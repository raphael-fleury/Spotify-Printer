using SpotifyPrinter.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SpotifyPrinter.UserControls
{
    public partial class ActionsUserControl : UserControl
    {
        public static ActionsUserControl Instance { get; private set; }

        public ActionsUserControl()
        {
            InitializeComponent();
            Instance = this;
            Reload();

            chooseFolderButton.Click += (x, y) => Playlists.ChooseFolder();
            toTxtButton.Click += (x, y) => Playlists.SaveToTXT();
        }

        public void Reload()
        {
            var playlists = PlaylistsContainer.Instance.SelectedPlaylists;
            label.Text = playlists.Count + " playlists selected.";
            toTxtButton.Enabled = playlists.Count > 0;
            toJsonButton.Enabled = playlists.Count > 0;
        }

        private void ActionsUserControl_Resize(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
                control.Location = new Point(Size.Width / 2 - control.Size.Width / 2, control.Location.Y);
        }
    }
}
