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
        public List<FullPlaylist> selectedPlaylists => 
            panel.Container.Components.Cast<PlaylistUserControl>()
            .Where(c => c.IsSelected)
            .Select(c => c.Playlist)
            .ToList();

        public PlaylistsContainer()
        {
            InitializeComponent();
        }

        public void AddPlaylist(string playlistUri)
        {
            FullPlaylist playlist;

            try { playlist = Program.Client.Playlists.Get(playlistUri).Result; }
            catch { return; }

            var display = new PlaylistUserControl(playlist);
            //panel.Container.Add(display);
            
            display.Remove += RemovePlaylist;
            //display.Click +=
        }

        public void RemovePlaylist(PlaylistUserControl control)
        {
            Container.Remove(control);
        }
    }
}
