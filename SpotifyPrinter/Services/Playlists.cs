using Newtonsoft.Json;
using SpotifyPrinter.Services.Exceptions;
using SpotifyPrinter.UserControls;
using SpotifyTest.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotifyPrinter.Services
{
    public static class Playlists
    {
        #region Properties
        private static string FolderPath 
        {
            get
            {
                var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) +
                @"\SpotifyPrinter\Playlists\";

                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                return path;
            }
        }
        #endregion

        #region Events
        private static Action<string> playlistAdded;
        private static Action<string> playlistRemoved;

        public static event Action<string> PlaylistAdded
        {
            add { playlistAdded += value; }
            remove { playlistAdded -= value; }
        }

        public static event Action<string> PlaylistRemoved
        {
            add { playlistRemoved += value; }
            remove { playlistRemoved -= value; }
        }
        #endregion

        #region Methods

        #region Operations
        public async static Task AddAsync(string uri)
        {
            uri = uri.Replace("spotify:playlist:", "");

            if (IsAdded(uri))
                throw new PlaylistException("Playlist already added.");

            Playlist playlist;
            while (true)
            {
                try
                {
                    playlist = await GetAsync(uri, false);
                    break;
                }
                catch (ClientNotAuthenticatedException)
                {
                    var dialog = new AuthenticationForm();
                    if (dialog.ShowDialog() == DialogResult.Cancel)
                        return;
                }
                catch (Exception e) { throw e; }
            }

            Save(playlist);
            playlistAdded?.Invoke(uri);
        }

        public static void Remove(string uri)
        {
            File.Delete(GetPath(uri));
            playlistRemoved?.Invoke(uri);
        }

        public async static Task<List<Playlist>> GetListAsync()
        {
            var list = new List<Playlist>();
            foreach (string path in Directory.GetFiles(FolderPath))
            {
                string uri = Path.GetFileNameWithoutExtension(path);
                list.Add(await GetAsync(uri, true));
            }

            return list;
        }

        public static void SaveToTXT()
        {
            string path = Properties.Settings.Default.Folder;

            foreach (var playlist in PlaylistsContainer.Instance.SelectedPlaylists)
            {
                string fileName = path + @"\" + $"{playlist.Name}.txt";
                string content = playlist.Name + ", by: " + playlist.Owner + "\n";

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

                foreach (var item in playlist.Tracks)
                {
                    content += "\n" + item;
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
        #endregion

        #region Auxiliar Methods
        private static string GetPath(string uri) => FolderPath + uri.Replace("spotify:playlist:", "") + ".json";
        private static bool IsAdded(string uri) => File.Exists(GetPath(uri));

        private static Playlist Load(string uri)
        {
            if (!IsAdded(uri))
                throw new PlaylistException("Playlist not added.");

            using (var reader = new StreamReader(GetPath(uri)))
            {
                string json = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<Playlist>(json);
            }
        }

        private async static Task<Playlist> GetAsync(string uri, bool loadFromFilesIfNull)
        {
            try { return await Spotify.Client.Playlists.Get(uri); }

            catch (ClientNotAuthenticatedException e)
            {
                if (!loadFromFilesIfNull)
                    throw e;
            }
            catch
            {
                if (!IsAdded(uri) || !loadFromFilesIfNull)
                    throw new PlaylistException("Playlist not found.");
            }

            return Load(uri);
        }

        private static void Save(Playlist playlist)
        {
            string json = JsonConvert.SerializeObject(playlist, Formatting.Indented);
            Console.WriteLine(GetPath(playlist.Uri));
            File.WriteAllText(GetPath(playlist.Uri), json);
        }
        #endregion

        #endregion
    }
}
