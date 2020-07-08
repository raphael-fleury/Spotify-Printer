using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpotifyAPI.Web;

namespace SpotifyPrinter
{
    static class Program
    {
        public static SpotifyClient Client { get; set; }

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string token = "BQD3BzVmHT7EF18y94axex6OtQkmPBftXebFz94jsH5GXeyY4y0uwFN8ddGuocdtg-LfU7IxhGLNH9EI9HZG3Vj8DL_DpB2O9TxkQEofcYjp55hTGlTwPVs_byjM-QXkGkZcSqy9A4WCdT0mxUuK3GEM1cRs5jU";
            Application.Run(TryAuthenticate(token) ? (Form)new MainForm() : new AuthenticationForm());
        }

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
