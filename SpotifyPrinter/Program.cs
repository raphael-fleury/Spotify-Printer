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

            string token = "BQABOMehZkHvvhxk-ngEmkWFAUdfVukOT74pO3ccf-l6I8TsT7L-QsEjx7ksOpomF9lRRnR02eZC_b4SGzdMwAkLuyeP86CamSkVri3sLjLWHc_0PrUnkoXydUyGcpkSSDTJajMSM35Jybx2v0D0lBffF1moKYQ";
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
