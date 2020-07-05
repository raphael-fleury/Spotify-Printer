using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpotifyAPI.Web;

namespace SpotifyPrinter
{
    public partial class AuthenticationForm : Form
    {
        public AuthenticationForm()
        {
            InitializeComponent();
        }

        private void AuthenticationForm_Shown(object sender, EventArgs e)
        {
            errorLabel.Text = "";
            textBox.Text = "";
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            var client = new SpotifyClient(textBox.Text);

            try
            {
                var testOperation = client.Playlists.Get("16wsvPYpJg1dmLhz0XTOmX");
                Task.WaitAll(testOperation);

                AuthSuccess(client);
            }
            catch { AuthFail(); }
        }

        private void AuthFail() => errorLabel.Text = "Fail. ";

        private void AuthSuccess(SpotifyClient client)
        {
            Hide();
            Program.Client = client;
            var mainForm = new MainForm();
            mainForm.Closed += (s, args) => Close();
            mainForm.Show();
        }
    }
}
