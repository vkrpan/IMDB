using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace PresentationLayer
{
    public partial class RegistrationForm : Form
    {
        private LoginRepository loginRepository = new LoginRepository();
        public RegistrationForm()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var ime = NameInputTextBox.Text;
            var prezime = SurnameInputTextBox.Text;
            var username = UserNameInputTextBox.Text;
            var email = EmailInputTextBox.Text;
            var pw = PasswordInputTextBox.Text;

            if (username.Length == 0 || pw.Length == 0)
            {
                MessageBox.Show("Niste unijeli minimalne potrebne podatke za stvaranje novog korisnika!", "Registracija", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(loginRepository.CheckUsername(username))
                {
                    MessageBox.Show("Već postoji korisnik sa odabranim korisničkim imenom!", "Registracija", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (loginRepository.CheckEmail(email))
                {
                    MessageBox.Show("Postojeći korisnik se već registrirao s ovom e-mail adresom!", "Registracija", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (pw.Length >= 5)
                    {
                        loginRepository.AddUser(ime, prezime, username, email, pw);
                        MessageBox.Show("Novi korisnik " + username + " je uspješno registriran!", "Registracija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Lozinka mora sadržavati minimalno 5 znakova!", "Registracija", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
