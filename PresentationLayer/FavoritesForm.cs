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
    public partial class FavoritesForm : Form
    {
        private BindingSource _favoritesBindingSource = new BindingSource();
        private FavoriteMovieRepositoryVM _favoritesMoviesRepository = new FavoriteMovieRepositoryVM();
        private User oUser;
        public FavoritesForm(User User)
        {
            InitializeComponent();
            MakeUser(User);
            if (User.Username == "ADMIN")
            {
                FavoriteMoviesDataGridView.Columns["Column8"].Visible = false;
                _favoritesBindingSource.DataSource = _favoritesMoviesRepository.getFavoriteMoviesVM().GroupBy(x => x.IMDbId).Select(x => x.FirstOrDefault()).ToList();
                FavoriteMoviesDataGridView.DataSource = _favoritesBindingSource;
            }
            else
            {
                _favoritesBindingSource.DataSource = _favoritesMoviesRepository.getFavoriteMoviesVM().Where(x => x.UserID == oUser.UserID).OrderBy(x => x.Title).ToList();
                FavoriteMoviesDataGridView.DataSource = _favoritesBindingSource;
            }

            FavoriteMoviesDataGridView.EnableHeadersVisualStyles = false;
            FavoriteMoviesDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            FavoriteMoviesDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(246, 199, 0);
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            FavoriteMoviesDataGridView.AllowUserToAddRows = false;
            var height = 30;
            foreach (DataGridViewRow dr in FavoriteMoviesDataGridView.Rows)
            {
                height += dr.Height;
            }
            FavoriteMoviesDataGridView.Height = height;
            FavoriteMoviesDataGridView.Columns["Column7"].Visible = false;
            FavoriteMoviesDataGridView.Columns["Column4"].Visible = false;
            FavoriteMoviesDataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            FavoriteMoviesDataGridView.Columns[3].Width = 130;
            FavoriteMoviesDataGridView.Columns[4].Width = 250;
            FavoriteMoviesDataGridView.Columns[5].Width = 120;
            FavoriteMoviesDataGridView.Columns[6].Width = 100;
            FavoriteMoviesDataGridView.Columns[2].Width = 160;
            FavoriteMoviesDataGridView.Columns[1].Width = 300;
        }
        private void MakeUser(User User)
        {
            oUser = User;
        }

        private void FavoriteMoviesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string imdbID = FavoriteMoviesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (oUser.Username == "ADMIN")
                {
                    RatedMovieInfoForm adminForma = new RatedMovieInfoForm(oUser, imdbID);
                    adminForma.Show();
                }
                else
                {
                    RateAMovieForm drugaForma = new RateAMovieForm(imdbID, oUser);
                    drugaForma.Show();
                    drugaForma.FormClosed += drugaFormaFormClosed;
                }

            }
        }
        private void drugaFormaFormClosed(Object sender, FormClosedEventArgs e)
        {
            _favoritesBindingSource.DataSource = _favoritesMoviesRepository.getFavoriteMoviesVM().Where(x => x.UserID == oUser.UserID).OrderBy(x => x.Title).ToList();
            FavoriteMoviesDataGridView.DataSource = _favoritesBindingSource;
        }
    }
}
