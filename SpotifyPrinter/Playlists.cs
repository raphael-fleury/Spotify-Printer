using SpotifyAPI.Web;
using SpotifyPrinter.UserControls;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SpotifyPrinter
{
    public static class Playlists
    {
        private static StringCollection collection =>
            Properties.Settings.Default.Playlists;

        public static IReadOnlyList<string> Collection =>
            collection.Cast<string>().ToList();

        public static FullPlaylist Get(string uri) =>
            Spotify.Client.Playlists.Get(uri).Result;

        public static void Add(string uri)
        {
            uri = uri.Replace("spotify:playlist:", "");

            if (Collection.Contains(uri))
                return;

            try { var playlist = Spotify.Client.Playlists.Get(uri).Result; }
            catch { return; }

            collection.Add(uri);
            Properties.Settings.Default.Save();

            PlaylistsContainer.Instance.Reload();
        }

        public static void Remove(string uri)
        {
            collection.Remove(uri);
            Properties.Settings.Default.Save();
        }

        public static void SaveToTXT()
        {
            var path = ChoosePath();

            if (!Directory.Exists(path))
                return;

            foreach (var playlist in PlaylistsContainer.Instance.SelectedPlaylists)
            {
                string fileName = path + @"\" + $"{playlist.Name}.txt";
                string content = playlist.Name + ", by: " + (playlist.Owner.DisplayName ?? playlist.Owner.Id) + "\n";

                foreach (var item in playlist.Tracks.Items)
                {
                    FullTrack track = (FullTrack)item.Track;

                    //content += track.IsLocal ? "[Local] " : $"[Uri: {track.Uri}] ";
                    content += $"\n[Added at {item.AddedAt.ToString()} by {item.AddedBy.Id}] ";

                    for (int i = 0; i < track.Artists.Count; i++)
                    {
                        if (!track.Name.Contains(track.Artists[i].Name))
                        {
                            if (i > 0)
                                content += ", ";
                            content += track.Artists[i].Name;
                        }
                    }
                    if (track.Artists.Where(a => a.Name != "").ToArray().Length > 0)
                        content += " - ";

                    content += track.Name;
                }

                File.WriteAllText(fileName, content);
            }
        }

        public static string ChoosePath()
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    return dialog.SelectedPath;
                }
            }

            return "";
        }
    }
}
