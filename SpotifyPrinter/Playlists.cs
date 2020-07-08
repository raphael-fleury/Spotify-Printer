using SpotifyAPI.Web;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace SpotifyPrinter
{
    public static class Playlists
    {
        public static StringCollection List =>
            Properties.Settings.Default.Playlists;

        public static FullPlaylist Get(string uri) =>
            Spotify.Client.Playlists.Get(uri).Result;

        public static void Add(string uri)
        {
            uri = uri.Replace("spotify:playlist:", "");

            if (List.Contains(uri))
                return;

            try { var playlist = Spotify.Client.Playlists.Get(uri).Result; }
            catch { return; }

            List.Add(uri);
            Properties.Settings.Default.Save();
        }

        public static void Remove(string uri)
        {
            List.Remove(uri);
            Properties.Settings.Default.Save();
        }
    }
}
