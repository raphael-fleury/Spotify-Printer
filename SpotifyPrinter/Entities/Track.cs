using System.Collections.Generic;
using System.Linq;

namespace SpotifyTest.Entities
{
    public class Track
    {
        public List<string> Artists { get; set; }
        public string Name { get; set; }
        public string Album { get; set; }
        public bool IsLocal { get; set; }
        public string Uri { get; set; }

        #region Constructors
        public Track() { }

        public Track(SpotifyAPI.Web.FullTrack fullTrack)
        {
            Artists = new List<string>();
            foreach (var artist in fullTrack.Artists)
                Artists.Add(artist.Name);

            Name = fullTrack.Name;
            Album = fullTrack.Album.Name;
            IsLocal = fullTrack.IsLocal;
            Uri = fullTrack.Uri;
        }
        #endregion

        public override string ToString()
        {
            string artists = "";

            for (int i = 0; i < Artists.Count; i++)
            {
                if (!Name.Contains(Artists[i]))
                {
                    if (i > 0)
                        artists += ", ";
                    artists += Artists[i];
                }
            }
            if (Artists.Where(a => a != "").ToArray().Length > 0) { artists += " - "; }

            return artists + Name;
        }
    }
}
