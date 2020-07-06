using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpotifyAPI.Web;

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
            if (Program.TryAuthenticate(textBox.Text))
                AuthSuccess();
            else
                AuthFail();
        }

        private void AuthFail() => errorLabel.Text = "Fail. ";

        private void AuthSuccess()
        {
            Hide();
            var mainForm = new MainForm();
            mainForm.Closed += (s, args) => Close();
            mainForm.Show();
        }
    }
}
