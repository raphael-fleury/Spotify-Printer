using System;
using System.Windows.Forms;
using Spotify = SpotifyPrinter.Services.Spotify;

namespace SpotifyPrinter
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string token = Properties.Settings.Default.Token;

            Spotify.TryAuthenticate(Properties.Settings.Default.Token);
            Application.Run(new MainForm());
        }
    }
}
