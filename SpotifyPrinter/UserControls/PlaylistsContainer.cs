using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SpotifyPrinter.Services;
using SpotifyTest.Entities;
using System.Threading.Tasks;

namespace SpotifyPrinter.UserControls
{
    public partial class PlaylistsContainer : UserControl
    {
        #region Properties
        public static PlaylistsContainer Instance { get; private set; }

        public List<PlaylistUserControl> PlaylistControls =>
            panel.Controls.Cast<PlaylistUserControl>().ToList();

        public List<Playlist> SelectedPlaylists =>
            PlaylistControls
            .Where(c => c.IsSelected)
            .Select(c => c.Playlist)
            .ToList();

        private ActionsUserControl controlsBoard => 
            ActionsUserControl.Instance;
        #endregion

        #region Constructor
        public PlaylistsContainer()
        {
            InitializeComponent();
            Instance = this;
            
            Playlists.PlaylistAdded += (p) => Task.Run(() => ReloadAsync());
            Playlists.PlaylistRemoved += RemovePlaylist;

            Load += (x, y) => Task.Run(() => ReloadAsync());
            Load += panel_Resize;
        }
        #endregion

        public int GetControlIndex(PlaylistUserControl control)
        {
            return panel.Controls.GetChildIndex(control);
        }

        //NOT WORKING WHEN CALLED ASYNC
        private async Task ReloadAsync()
        {
            panel.Controls.Clear();

            List<PlaylistUserControl> controls = new List<PlaylistUserControl>();
            foreach (var playlist in await Playlists.GetListAsync())
            {
                var display = new PlaylistUserControl(playlist);
                display.Width = panel.Width / panel.ColumnCount;
                display.Anchor = AnchorStyles.Top & AnchorStyles.Left;

                display.ToggleSelect += (x, y) => controlsBoard.Reload();

                controls.Add(display);
                Console.WriteLine(display.Location.Y);
            }

            controls.Sort((c1, c2) => c1.CompareTo(c2));
            controls.ForEach(c => panel.Controls.Add(c));
        }

        private void RemovePlaylist(string uri)
        {
            var control = panel.Controls.Cast<PlaylistUserControl>().First(c => c.Playlist.Uri == uri);
            panel.Controls.Remove(control);
            controlsBoard.Reload();
        }

        private void panel_Resize(object sender, EventArgs e)
        {
            panel.ColumnCount = Math.Max(panel.Width /
                PlaylistUserControl.MinimumWidth, 1);
            panel.RowCount = (int)Math.Ceiling((double)panel.Controls.Count / panel.ColumnCount);
            PlaylistControls.ForEach(c => c.Width = panel.Width / panel.ColumnCount);
        }
    }
}
