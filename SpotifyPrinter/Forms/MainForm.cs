﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotifyPrinter
{
    public partial class MainForm : Form
    {
        List<PlaylistUserControl> playlists = new List<PlaylistUserControl>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadPlaylists();
        }

        private void LoadPlaylists()
        {
            string[] playlistsUri = { "4eLslb9s9PXmkr8mOgfrXF", "6mtC5TuWGII11896qYKvsb", "6mtC5TuWGII11896qYKvsb", "6mtC5TuWGII11896qYKvsb", "6mtC5TuWGII11896qYKvsb" };
            playlistsContainer.Controls.Clear();

            foreach (string uri in playlistsUri)
            {
                playlistsContainer.AddPlaylist(uri);
            }
        }

        private void playlistInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadPlaylists();
            }
        }
    }
}
