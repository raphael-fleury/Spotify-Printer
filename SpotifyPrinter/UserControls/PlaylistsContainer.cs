using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpotifyAPI.Web;

namespace SpotifyPrinter.UserControls
{
    public partial class PlaylistsContainer : UserControl
    {
        #region Properties
        public static PlaylistsContainer Instance { get; private set; }

        public ActionsUserControl ControlsBoard { get; set; }

        public List<PlaylistUserControl> PlaylistControls =>
            panel.Controls.Cast<PlaylistUserControl>().ToList();

        public List<FullPlaylist> SelectedPlaylists =>
            PlaylistControls
            .Where(c => c.IsSelected)
            .Select(c => c.Playlist)
            .ToList();
        #endregion

        #region Constructor
        public PlaylistsContainer()
        {
            InitializeComponent();
            Instance = this;
            panel_Resize(this, EventArgs.Empty);
        }
        #endregion

        #region Public Operations
        public void Clear() => panel.Controls.Clear();

        public void AddPlaylist(string playlistUri)
        {

            LoadPlaylists();
        }

        public void RemovePlaylist(PlaylistUserControl control)
        {

            panel.Controls.Remove(control);
        }

        public void LoadPlaylist(string playlistUri)
        {
            FullPlaylist playlist;
            string uri = playlistUri.Replace("spotify:playlist:", "");

            try { playlist = Program.Client.Playlists.Get(uri).Result; }
            catch { return; }

            var display = new PlaylistUserControl(playlist);
            display.Width = panel.Width / panel.ColumnCount;
            display.Height = panel.Height / panel.RowCount;
            panel.Controls.Add(display);

            display.Remove += RemovePlaylist;
            display.Remove += (c) => ControlsBoard.Refresh(SelectedPlaylists);
            display.ToggleSelect += Click_Playlist;
        }

        public void LoadPlaylists()
        {
            string[] playlistsUri = { "4eLslb9s9PXmkr8mOgfrXF", "6mtC5TuWGII11896qYKvsb", "6mtC5TuWGII11896qYKvsb", "6mtC5TuWGII11896qYKvsb", "6mtC5TuWGII11896qYKvsb" };
            Clear();

            foreach (string uri in playlistsUri)
            {
                LoadPlaylist(uri);
            }
        }
        #endregion

        public int GetControlIndex(PlaylistUserControl control)
        {
            return panel.Controls.GetChildIndex(control);
        }

        private void Click_Playlist(PlaylistUserControl control, bool value)
        {
            

            ControlsBoard.Refresh(SelectedPlaylists);
        }

        private void panel_Resize(object sender, EventArgs e)
        {
            panel.ColumnCount = Math.Max(panel.Width /
                PlaylistUserControl.MinimumWidth, 1);
            panel.RowCount = Math.Max(panel.Height /
                PlaylistUserControl.MinimumHeight, 1);
        }
    }
}
