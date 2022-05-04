using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace PresentationLayer
{
    public partial class LogInForm : Form
    {
        private LoginRepository loginRepository = new LoginRepository();
        public LogInForm()
        {
            InitializeComponent();
            this.Show();
            textBoxPassword.PasswordChar = '*';
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            List<User> Lista = loginRepository.GetUsers();
            bool foundUser = false;
            User korisnik = new User();
            foreach(User k in Lista)
            {
                if(textBoxUserName.Text == k.Username && textBoxPassword.Text== k.Password)
                {
                    foundUser = true;
                    korisnik = k;
                }
            }
            if (foundUser)
            {
                MainMenu pocetak = new MainMenu(korisnik);
                pocetak.Show();
                this.Hide();
                textBoxPassword.Clear();
                textBoxUserName.Clear();
                WarningLabel.Hide();
            }
            else
            {
                WarningLabel.Text = "Niste unijeli točno korisničko ime i lozinku!";
                textBoxUserName.Clear();
                textBoxPassword.Clear();

            }
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            RegistrationForm newRegisterForm = new RegistrationForm();
            newRegisterForm.Show();
        }
    }
}
