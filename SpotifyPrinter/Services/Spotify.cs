using SpotifyAPI.Web;
using System.Threading.Tasks;
using SpotifyPrinter.Services.Exceptions;

namespace SpotifyPrinter.Services
{
    public static class Spotify
    {
        #region Properties
        private static SpotifyClient client;

        public static SpotifyClient Client 
        { 
            get
            {
                if (client == null)
                    throw new ClientNotAuthenticatedException("Client not authenticated.");

                return client;
            }
            private set { client = value; }
        }
        #endregion

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
