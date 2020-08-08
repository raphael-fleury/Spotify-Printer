using System;
using System.Collections.Generic;
using SpotifyAPI.Web;

namespace SpotifyTest.Entities
{
    public class Playlist : IComparable
    {
        public string Name { get; set; }
        public string Owner { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Public { get; set; }
        public bool Collaborative { get; set; }
        public string Uri { get; set; }
        public List<PlaylistTrack> Tracks { get; set; }

        #region Constructors
        public Playlist() { }

        public Playlist(FullPlaylist playlist)
        {
            Name = playlist.Name;
            Owner = playlist.Owner.DisplayName ?? playlist.Owner.Id;
            Public = playlist.Public;
            Collaborative = playlist.Collaborative;
            Uri = playlist.Uri;

            Tracks = new List<PlaylistTrack>();
            foreach (var track in playlist.Tracks.Items)
                Tracks.Add(new PlaylistTrack(track));

            Tracks.Sort((t1, t2) => t1.AddedAt.CompareTo(t2.AddedAt));
            CreatedAt = Tracks[0].AddedAt;
        }
        #endregion

        public int CompareTo(object other)
        {
            if (!(other is Playlist) && !(other is FullPlaylist))
                throw new InvalidOperationException("");

            var playlist = (Playlist)other; 
            return CreatedAt.CompareTo(playlist.CreatedAt);
        }

        public override string ToString()
        {
            string text = $"Playlist {Name} - Created At {CreatedAt.ToString()} by {Owner}:\n\n";

            foreach (var track in Tracks)
                text += track.ToString() + "\n";

            return text;
        }

        public static implicit operator Playlist(FullPlaylist playlist) { return new Playlist(playlist); }
    }
}