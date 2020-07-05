using System.Windows.Forms;
using System.Drawing;
using SpotifyAPI.Web;
using System;

namespace SpotifyPrinter
{
    public partial class PlaylistUserControl : UserControl
    {
        #region Properties
        private Color defaultColor;
        private Color selectedColor = Color.Aqua;

        public readonly FullPlaylist Playlist;

        public bool IsSelected
        {
            get { return BackColor == selectedColor; }
            set
            {
                BackColor = value ? selectedColor : defaultColor;
            }
        }
        #endregion

        public PlaylistUserControl(FullPlaylist playlist)
        {
            InitializeComponent();
            defaultColor = BackColor;

            Playlist = playlist;
            title.Text = playlist.Name;
            desc.Text = playlist.Uri;

            Click += (sender, e) => IsSelected = !IsSelected;
            deleteButton.Click += (sender, e) => remove.Invoke(this);
        }

        #region Events
        private event Action<PlaylistUserControl> remove;

        public event Action<PlaylistUserControl> Remove
        {
            add { remove += value; }
            remove { remove -= value; }
        }
        #endregion

        public static implicit operator FullPlaylist(PlaylistUserControl control) => control.Playlist;
    }
}
