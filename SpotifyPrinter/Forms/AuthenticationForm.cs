using SpotifyPrinter.Services;
using System;
using System.Windows.Forms;

namespace SpotifyPrinter
{
    public partial class AuthenticationForm : Form
    {
        public AuthenticationForm() => InitializeComponent();

        private void AuthenticationForm_Shown(object sender, EventArgs e)
        {
            errorLabel.Text = "";
            textBox.Text = "";
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                authButton_Click(this, EventArgs.Empty);
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            if (Spotify.TryAuthenticate(textBox.Text))
                AuthSuccess();
            else
                AuthFail();
        }

        private void AuthFail() => errorLabel.Text = "Fail. ";

        private void AuthSuccess()
        {
            Properties.Settings.Default.Token = textBox.Text;
            Properties.Settings.Default.Save();

            Hide();
        }
    }
}
