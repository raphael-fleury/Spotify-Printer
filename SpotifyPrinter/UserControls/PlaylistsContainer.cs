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
        public void AddPlaylist(string uri)
        {
            Playlists.Add(uri);
            Reload();
        }

        public void RemovePlaylist(PlaylistUserControl control)
        {
            Playlists.Remove(control.Playlist.Uri);
            panel.Controls.Remove(control);
        }

        public void Reload()
        {
            panel.Controls.Clear();

            List<PlaylistUserControl> controls = new List<PlaylistUserControl>();
            foreach (string uri in Playlists.List)
            {
                var display = new PlaylistUserControl(Playlists.Get(uri));
                display.Width = panel.Width / panel.ColumnCount;
                display.Height = panel.Height / panel.RowCount;

                display.Remove += RemovePlaylist;
                display.Remove += (c) => ControlsBoard.Refresh(SelectedPlaylists);
                display.ToggleSelect += Click_Playlist;

                controls.Add(display);
            }

            controls.Sort((c1, c2) => c1.CompareTo(c2));
            controls.ForEach(c => panel.Controls.Add(c));
        }

        public int GetControlIndex(PlaylistUserControl control)
        {
            return panel.Controls.GetChildIndex(control);
        }
        #endregion

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
