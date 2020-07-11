using SpotifyAPI.Web;
using System.Linq;

namespace SpotifyPrinter
{
    public static class ExtensionMethods
    {
        public static int CompareTo(this FullPlaylist playlist, FullPlaylist other)
        {
            if (playlist.Name != other.Name)
                return playlist.Name.CompareTo(other.Name);
            else
                return playlist.Uri.CompareTo(other.Uri);
        }
    }
}
