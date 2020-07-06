using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotifyPrinter.UserControls
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
