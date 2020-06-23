using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void authButton_Click(object sender, EventArgs e)
        {
            var client = new SpotifyClient(textBox.Text);

            if (client == null)
                AuthFail();
            else
                AuthSuccess();
        }

        private void AuthFail()
        {
            label.ForeColor = Color.Red;
            label.Text = "Fail.";
        }

        private void AuthSuccess()
        {
            Hide();
            var mainForm = new MainForm();
            mainForm.Closed += (s, args) => Close();
            mainForm.Show();
        }
    }
}
