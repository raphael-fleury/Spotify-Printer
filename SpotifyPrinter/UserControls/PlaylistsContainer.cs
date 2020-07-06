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
        public ActionsUserControl ControlsBoard { get; set; }

        public List<FullPlaylist> selectedPlaylists =>
            panel.Controls.Cast<PlaylistUserControl>()
            .Where(c => c.IsSelected)
            .Select(c => c.Playlist)
            .ToList();
        #endregion

        public PlaylistsContainer()
        {
            InitializeComponent();
            panel_Resize(this, EventArgs.Empty);
        }

        #region Public Operations
        public void Clear() => panel.Controls.Clear();

        public void AddPlaylist(string playlistUri)
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
            display.Remove += (c) => ControlsBoard.Refresh(selectedPlaylists);
            display.ToggleSelect += (control, value) => Display_Click(GetControlIndex(control));
        }

        public void RemovePlaylist(PlaylistUserControl control)
        {
            panel.Controls.Remove(control);
        }

        public int GetControlIndex(PlaylistUserControl control)
        {
            return panel.Controls.GetChildIndex(control);
        }
        #endregion

        private void Display_Click(int index)
        {
            var list = panel.Controls.Cast<PlaylistUserControl>().ToList();

            if (ModifierKeys == Keys.Shift) // if shift is pressed
            {
                if (PlaylistUserControl.LastSelected == null)
                    ((PlaylistUserControl)panel.Controls[0]).IsSelected = true;
                        
                int otherIndex = panel.Controls.GetChildIndex(PlaylistUserControl.LastSelected);
                foreach (var control in list)
                {
                    int i = GetControlIndex(control);
                    if ((i > otherIndex && i < index) || (i > index && i < otherIndex))
                        control.IsSelected = true;
                }
            }
            else if (ModifierKeys == Keys.None) // if control is not pressed
            {
                for (int i = 0; i < list.Count; i++)
                {
                    list[i].IsSelected = i == index;
                }
            }
                
            ControlsBoard.Refresh(selectedPlaylists);
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
