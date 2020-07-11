using System.Windows.Forms;
using System.Drawing;
using System;
using SpotifyPrinter.UserControls;

using FullPlaylist = SpotifyAPI.Web.FullPlaylist;

namespace SpotifyPrinter
{
    public partial class PlaylistUserControl : UserControl
    {
        #region Fields
        public readonly FullPlaylist Playlist;

        private Color defaultColor;
        private Color selectedColor = Color.Aqua;
        #endregion

        #region Properties
        public static int MinimumWidth { get; private set; } = 350;
        public static int MinimumHeight { get; private set; } = 75;
        public static PlaylistUserControl LastSelected { get; private set; }

        public bool IsSelected
        {
            get { return BackColor == selectedColor; }
            set { BackColor = value ? selectedColor : defaultColor; }
        }
        #endregion

        public PlaylistUserControl(FullPlaylist playlist)
        {
            InitializeComponent();

            defaultColor = BackColor;
            MinimumWidth = MinimumSize.Width;
            MinimumHeight = MinimumSize.Height;

            Playlist = playlist;
            title.Text = playlist.Name;
            desc.Text = "URI: " + playlist.Uri.Replace("spotify:playlist:", "");

            deleteButton.Click += (sender, e) => remove.Invoke(this);

            #region Select
            title.Click += PlaylistUserControl_Click;
            desc.Click += PlaylistUserControl_Click;
            picture.Click += PlaylistUserControl_Click;
            #endregion
        }

        #region Events
        private event Action<PlaylistUserControl> remove;
        private event Action<PlaylistUserControl, bool> toggleSelect;

        public event Action<PlaylistUserControl> Remove
        {
            add { remove += value; }
            remove { remove -= value; }
        }

        public event Action<PlaylistUserControl, bool> ToggleSelect
        {
            add { toggleSelect += value; }
            remove { toggleSelect -= value; }
        }
        #endregion

        public int CompareTo(PlaylistUserControl other)
        {
            return Playlist.CompareTo(other.Playlist);
        }

        private void PlaylistUserControl_Resize(object sender, EventArgs e)
        {
            picture.Width = picture.Height;
        }

        private void PlaylistUserControl_Click(object sender, EventArgs e)
        {
            var container = PlaylistsContainer.Instance;
            var controls = container.PlaylistControls;
            int index = container.GetControlIndex(this);

            if ((ModifierKeys & Keys.Shift) != 0)
            {
                if (LastSelected == null)
                    controls[0].IsSelected = true;

                int last = container.GetControlIndex(LastSelected);

                for (int i = 0; i < controls.Count; i++)
                {
                    controls[i].IsSelected = (i >= last && i <= index) || (i >= index && i <= last);
                }

                LastSelected = controls[last];
            }
            else
            {
                LastSelected = this;

                if ((ModifierKeys & Keys.Control) != 0)
                {
                    IsSelected = !IsSelected;
                }                    
                else
                {
                    for (int i = 0; i < controls.Count; i++)
                    {
                        controls[i].IsSelected = i == index;
                    }
                }                
            }

            toggleSelect.Invoke(this, IsSelected);
        }
    }
}
