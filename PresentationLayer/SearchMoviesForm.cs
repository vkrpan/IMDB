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
    public partial class SearchMoviesForm : Form
    {
        private SearchMovieRepository _searchMoviesRepository = new SearchMovieRepository();
        private BindingSource _searchMoviesBindingSource = new BindingSource();
        private User oUser;
        private int PageNumber = 1;
        public SearchMoviesForm(User User)
        {
            InitializeComponent();
            MakeUser(User);
            SearchButton.FlatAppearance.BorderSize = 0;
            dataGridViewSearchedMovies.Hide();
            NemaFilmovaLabel.Hide();
            ButtonLeft.Hide();
            ButtonRight.Hide();
            PageLabel.Hide();
        }
        private void MakeUser(User userid)
        {
            oUser = userid;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            NemaFilmovaLabel.Hide();
            ButtonLeft.Hide();
            ButtonRight.Hide();
            PageLabel.Hide();
            dataGridViewSearchedMovies.Hide();
            PageNumber = 1;
            string Title = TitleInput.Text.ToString();
            string Year = YearInput.Text.ToString();
            string movie = checkBoxMovies.Checked ? "movie" : "";
            string series = checkBoxSeries.Checked ? "series" : "";
            var lista = _searchMoviesRepository.GetMoviesByTitleAndYear(Title, Year, movie, series);
            if (lista.Count == 0)
            {
                NemaFilmovaLabel.Text = "Za unesenu pretragu nisu pronađeni rezultati!";
                NemaFilmovaLabel.Show();
                _searchMoviesBindingSource.DataSource = lista;
                dataGridViewSearchedMovies.DataSource = _searchMoviesBindingSource;
            }
            else if(checkBoxMovies.Checked==false && checkBoxSeries.Checked==false){
                NemaFilmovaLabel.Text = "Morate odabrati kategoriju!";
                NemaFilmovaLabel.Show();

            }
            else
            {
                _searchMoviesBindingSource.DataSource = lista;
                dataGridViewSearchedMovies.DataSource = _searchMoviesBindingSource;
                dataGridViewSearchedMovies.Show();
                dataGridViewSearchedMovies.Columns["Column4"].Visible = false;
                dataGridViewSearchedMovies.Columns["Column5"].Visible = false;
                dataGridViewSearchedMovies.Columns["Column6"].Visible = false;
                PageLabel.Text = PageNumber + "/" + _searchMoviesRepository.GetNumberOfPages(_searchMoviesRepository.GetMoviesByTitleAndYear(Title, Year, movie, series));
                PageLabel.Show();
                ButtonLeft.Show();
                ButtonRight.Show();

            }
        }

        private void dataGridViewSearchedMovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string imdbID = dataGridViewSearchedMovies.Rows[e.RowIndex].Cells[2].Value.ToString();
                MovieDetailsForm drugaForma = new MovieDetailsForm(imdbID, oUser);
                drugaForma.ShowDialog();
            }
        }

        private void dataGridViewSearchedMovies_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewSearchedMovies.AllowUserToAddRows = false;
            var height = 30;
            foreach (DataGridViewRow dr in dataGridViewSearchedMovies.Rows)
            {
                height += dr.Height;
            }
            dataGridViewSearchedMovies.Height = height;
        }

        private void ButtonRight_Click(object sender, EventArgs e)
        {
            if (dataGridViewSearchedMovies.Visible)
            {
                PageNumber++;
                string Title = TitleInput.Text.ToString();
                string Year = YearInput.Text.ToString();
                string movie = checkBoxMovies.Checked ? "movie" : "";
                string series = checkBoxSeries.Checked ? "series" : "";
                _searchMoviesRepository.GetMoviesOnPage(PageNumber, Title, Year, movie, series);
                _searchMoviesBindingSource.DataSource = _searchMoviesRepository.GetMoviesOnPage(PageNumber, Title, Year, movie, series);
                dataGridViewSearchedMovies.DataSource = _searchMoviesBindingSource;
                PageLabel.Text = PageNumber + "/" + _searchMoviesRepository.GetNumberOfPages(_searchMoviesRepository.GetMoviesByTitleAndYear(Title, Year, movie, series));
            }
        }

        private void ButtonLeft_Click(object sender, EventArgs e)
        {
            if (dataGridViewSearchedMovies.Visible)
            {
                if (PageNumber > 1)
                {
                    PageNumber--;
                    string Title = TitleInput.Text.ToString();
                    string Year = YearInput.Text.ToString();
                    string movie = checkBoxMovies.Checked ? "movie" : "";
                    string series = checkBoxSeries.Checked ? "series" : "";
                    _searchMoviesRepository.GetMoviesOnPage(PageNumber, Title, Year, movie, series);
                    _searchMoviesBindingSource.DataSource = _searchMoviesRepository.GetMoviesOnPage(PageNumber, Title, Year, movie, series);
                    dataGridViewSearchedMovies.DataSource = _searchMoviesBindingSource;
                    PageLabel.Text = PageNumber + "/" + _searchMoviesRepository.GetNumberOfPages(_searchMoviesRepository.GetMoviesByTitleAndYear(Title, Year, movie, series));
                }
            }
        }
    }
}
