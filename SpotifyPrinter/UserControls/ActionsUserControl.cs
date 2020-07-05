using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotifyPrinter.Forms
{
    public partial class ActionsUserControl : UserControl
    {
        public ActionsUserControl()
        {
            InitializeComponent();            
        }

        public void Refresh(List<SpotifyAPI.Web.FullPlaylist> playlists)
        {
            label.Text = playlists.Count + " playlists selected.";
        }

        private void ActionsUserControl_Resize(object sender, EventArgs e)
        {
            label.Location = new Point(Size.Width / 2 - label.Size.Width / 2, label.Location.Y);
            toTxtButton.Location = new Point(Size.Width / 2 - toTxtButton.Size.Width / 2, toTxtButton.Location.Y);
            toJsonButton.Location = new Point(Size.Width / 2 - toJsonButton.Size.Width / 2, toJsonButton.Location.Y);
        }
    }
}
