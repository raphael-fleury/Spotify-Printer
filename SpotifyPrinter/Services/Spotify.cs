using SpotifyAPI.Web;
using System.Threading.Tasks;

namespace SpotifyPrinter.Services
{
    public static class Spotify
    {
        public static SpotifyClient Client { get; set; }

        public static bool TryAuthenticate(string token)
        {
            var client = new SpotifyClient(token);

            try
            {
                var testOperation = client.Playlists.Get("16wsvPYpJg1dmLhz0XTOmX");
                Task.WaitAll(testOperation);

                Client = client;
                return true;
            }
            catch { return false; }
        }
    }
}
