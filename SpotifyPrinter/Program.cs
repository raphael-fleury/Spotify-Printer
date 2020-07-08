using System;
using System.Windows.Forms;

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
            Application.Run(Spotify.TryAuthenticate(token) ? (Form)new MainForm() : new AuthenticationForm());
        }
    }
}
