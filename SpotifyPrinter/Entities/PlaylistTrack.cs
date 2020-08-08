using System;
using SpotifyAPI.Web;

namespace SpotifyTest.Entities
{
    public class PlaylistTrack
    {
        public Track Track { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedAt { get; set; }

        #region Constructors
        public PlaylistTrack() { }

        public PlaylistTrack(PlaylistTrack<IPlayableItem> item)
        {
            Track = new Track((FullTrack)item.Track);
            AddedBy = item.AddedBy.DisplayName ?? item.AddedBy.Id;
            AddedAt = item.AddedAt ?? DateTime.MinValue;
        }
        #endregion

        public override string ToString()
        {
            string text = Track.IsLocal ? "[Local] " : $"[Uri: {Track.Uri}] ";
            return text += $"Added at {AddedAt.ToString()} by {AddedBy}: " + Track;
        }
    }
}
