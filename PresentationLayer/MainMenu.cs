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
    public partial class MainMenu : Form
    {
        private Button currentButton;
        private Form ActiveForm;
        private LoginRepository loginRepository = new LoginRepository();
        public User oUser;

        public MainMenu(User korisnik)
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            MakeUser(korisnik);
            UserNameLabel.Text ="Dobrodošli  " + loginRepository.GetUsers().Where(x => x.UserID == korisnik.UserID).Select(x => x.Username).FirstOrDefault().ToString();
        }
        private void MakeUser(User userr)
        {
            oUser = userr;
        }

        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton!= (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(222, 182, 32);
                    currentButton.ForeColor = Color.FromArgb(11, 8, 20);
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            }
        }
        private void DisableButton()
        {
            foreach(Control previousButton in SideMenuPanel.Controls)
            {
                if(previousButton.GetType() == typeof(Button))
                {
                    previousButton.BackColor = Color.FromArgb(11, 8, 20);
                    previousButton.ForeColor = Color.Gainsboro;
                    previousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActivateButton(btnSender);
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.ChildFormPanel.Controls.Add(childForm);
            this.ChildFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public void OpenNestedChildForm(Form childForm)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.ChildFormPanel.Controls.Add(childForm);
            this.ChildFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void MovieSearchButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SearchMoviesForm(oUser), sender);
        }

        private void FavoriteButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FavoritesForm(oUser), sender);
        }


        private void LogOutButton_Click(object sender, EventArgs e)
        {
            LogInForm noviLogIn = new LogInForm();
            noviLogIn.Show();
            this.Close();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //LogInForm noviLogIn = new LogInForm();
            //noviLogIn.Show();
        }

        private void UserInfoButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserInfoForm(oUser), sender);
        }
        //public void OtvoriChildFormu(string imdbID)
        //{
        //    OpenNestedChildForm(new MovieDetailsForm(imdbID, userID));
        //}

    }
}
