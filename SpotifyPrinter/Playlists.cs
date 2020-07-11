﻿using SpotifyAPI.Web;
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
            string path = Properties.Settings.Default.Folder;

            foreach (var playlist in PlaylistsContainer.Instance.SelectedPlaylists)
            {
                string fileName = path + @"\" + $"{playlist.Name}.txt";
                string content = playlist.Name + ", by: " + (playlist.Owner.DisplayName ?? playlist.Owner.Id) + "\n";

                #region If File Already Exists
                if (Directory.GetFiles(path).Contains(fileName))
                {
                    DialogResult result = MessageBox.Show(
                        "File " + playlist.Name + ".txt already exists. Wants to override?",
                        "File Already Exists",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.No)
                        continue;
                }
                #endregion

                foreach (var item in playlist.Tracks.Items)
                {
                    FullTrack track = (FullTrack)item.Track;

                    //content += track.IsLocal ? "[Local] " : $"[Uri: {track.Uri}] ";
                    content += $"\n[Added at {item.AddedAt} by {item.AddedBy.DisplayName ?? item.AddedBy.Id}] ";

                    #region Artists
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
                    #endregion

                    content += track.Name;
                }

                File.WriteAllText(fileName, content);
            }
        }

        public static string ChooseFolder()
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (Directory.Exists(dialog.SelectedPath))
                    {
                        Properties.Settings.Default.Folder = dialog.SelectedPath;
                        Properties.Settings.Default.Save();

                        return dialog.SelectedPath;
                    }
                }
            }

            return "";
        }
    }
}
