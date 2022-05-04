
namespace PresentationLayer
{
    partial class MovieDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieDetailsForm));
            this.MovieTitleLabel = new System.Windows.Forms.Label();
            this.MoviePictureBox = new System.Windows.Forms.PictureBox();
            this.DirectorsLabel = new System.Windows.Forms.Label();
            this.ActorsLabel = new System.Windows.Forms.Label();
            this.WritersLabel = new System.Windows.Forms.Label();
            this.PlotLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.RatedLabel = new System.Windows.Forms.Label();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.ReleasedLabel = new System.Windows.Forms.Label();
            this.AwardsLabel = new System.Windows.Forms.Label();
            this.imdbRatingLabel = new System.Windows.Forms.Label();
            this.imdbVotesLabel = new System.Windows.Forms.Label();
            this.StarPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FavoriteButton = new System.Windows.Forms.Button();
            this.IMDbVotesPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IMDbIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StarPictureBox)).BeginInit();
            this.IMDbVotesPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MovieTitleLabel
            // 
            this.MovieTitleLabel.AutoSize = true;
            this.MovieTitleLabel.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(197)))), ((int)(((byte)(32)))));
            this.MovieTitleLabel.Location = new System.Drawing.Point(6, 9);
            this.MovieTitleLabel.Name = "MovieTitleLabel";
            this.MovieTitleLabel.Size = new System.Drawing.Size(233, 37);
            this.MovieTitleLabel.TabIndex = 0;
            this.MovieTitleLabel.Tag = "";
            this.MovieTitleLabel.Text = "Naslov koji je duzi";
            // 
            // MoviePictureBox
            // 
            this.MoviePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MoviePictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("MoviePictureBox.ErrorImage")));
            this.MoviePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MoviePictureBox.Image")));
            this.MoviePictureBox.Location = new System.Drawing.Point(650, 5);
            this.MoviePictureBox.Name = "MoviePictureBox";
            this.MoviePictureBox.Size = new System.Drawing.Size(300, 450);
            this.MoviePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MoviePictureBox.TabIndex = 2;
            this.MoviePictureBox.TabStop = false;
            // 
            // DirectorsLabel
            // 
            this.DirectorsLabel.AutoSize = true;
            this.DirectorsLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectorsLabel.ForeColor = System.Drawing.Color.White;
            this.DirectorsLabel.Location = new System.Drawing.Point(12, 388);
            this.DirectorsLabel.Name = "DirectorsLabel";
            this.DirectorsLabel.Size = new System.Drawing.Size(77, 19);
            this.DirectorsLabel.TabIndex = 3;
            this.DirectorsLabel.Text = "Directors";
            // 
            // ActorsLabel
            // 
            this.ActorsLabel.AutoSize = true;
            this.ActorsLabel.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActorsLabel.ForeColor = System.Drawing.Color.White;
            this.ActorsLabel.Location = new System.Drawing.Point(11, 465);
            this.ActorsLabel.Name = "ActorsLabel";
            this.ActorsLabel.Size = new System.Drawing.Size(53, 21);
            this.ActorsLabel.TabIndex = 4;
            this.ActorsLabel.Text = "Stars";
            // 
            // WritersLabel
            // 
            this.WritersLabel.AutoSize = true;
            this.WritersLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WritersLabel.ForeColor = System.Drawing.Color.White;
            this.WritersLabel.Location = new System.Drawing.Point(11, 431);
            this.WritersLabel.Name = "WritersLabel";
            this.WritersLabel.Size = new System.Drawing.Size(64, 19);
            this.WritersLabel.TabIndex = 5;
            this.WritersLabel.Text = "Writers";
            // 
            // PlotLabel
            // 
            this.PlotLabel.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlotLabel.ForeColor = System.Drawing.Color.White;
            this.PlotLabel.Location = new System.Drawing.Point(12, 188);
            this.PlotLabel.Name = "PlotLabel";
            this.PlotLabel.Size = new System.Drawing.Size(607, 136);
            this.PlotLabel.TabIndex = 6;
            this.PlotLabel.Text = "Plot text";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreLabel.ForeColor = System.Drawing.Color.White;
            this.GenreLabel.Location = new System.Drawing.Point(9, 115);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(56, 19);
            this.GenreLabel.TabIndex = 7;
            this.GenreLabel.Text = "Genre";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearLabel.ForeColor = System.Drawing.Color.White;
            this.YearLabel.Location = new System.Drawing.Point(12, 57);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(44, 18);
            this.YearLabel.TabIndex = 8;
            this.YearLabel.Text = "Year";
            // 
            // RatedLabel
            // 
            this.RatedLabel.AutoSize = true;
            this.RatedLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatedLabel.ForeColor = System.Drawing.Color.White;
            this.RatedLabel.Location = new System.Drawing.Point(248, 57);
            this.RatedLabel.Name = "RatedLabel";
            this.RatedLabel.Size = new System.Drawing.Size(56, 18);
            this.RatedLabel.TabIndex = 9;
            this.RatedLabel.Text = "Rated";
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DurationLabel.ForeColor = System.Drawing.Color.White;
            this.DurationLabel.Location = new System.Drawing.Point(141, 57);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(78, 18);
            this.DurationLabel.TabIndex = 10;
            this.DurationLabel.Text = "Duration";
            // 
            // ReleasedLabel
            // 
            this.ReleasedLabel.AutoSize = true;
            this.ReleasedLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReleasedLabel.ForeColor = System.Drawing.Color.White;
            this.ReleasedLabel.Location = new System.Drawing.Point(717, 483);
            this.ReleasedLabel.Name = "ReleasedLabel";
            this.ReleasedLabel.Size = new System.Drawing.Size(76, 19);
            this.ReleasedLabel.TabIndex = 11;
            this.ReleasedLabel.Text = "Released";
            // 
            // AwardsLabel
            // 
            this.AwardsLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AwardsLabel.ForeColor = System.Drawing.Color.White;
            this.AwardsLabel.Location = new System.Drawing.Point(12, 350);
            this.AwardsLabel.Name = "AwardsLabel";
            this.AwardsLabel.Size = new System.Drawing.Size(632, 38);
            this.AwardsLabel.TabIndex = 12;
            this.AwardsLabel.Text = "Awards";
            // 
            // imdbRatingLabel
            // 
            this.imdbRatingLabel.AutoSize = true;
            this.imdbRatingLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imdbRatingLabel.ForeColor = System.Drawing.Color.White;
            this.imdbRatingLabel.Location = new System.Drawing.Point(3, 13);
            this.imdbRatingLabel.Name = "imdbRatingLabel";
            this.imdbRatingLabel.Size = new System.Drawing.Size(129, 25);
            this.imdbRatingLabel.TabIndex = 13;
            this.imdbRatingLabel.Text = "imdbRating";
            // 
            // imdbVotesLabel
            // 
            this.imdbVotesLabel.AutoSize = true;
            this.imdbVotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imdbVotesLabel.ForeColor = System.Drawing.Color.White;
            this.imdbVotesLabel.Location = new System.Drawing.Point(110, 14);
            this.imdbVotesLabel.Name = "imdbVotesLabel";
            this.imdbVotesLabel.Size = new System.Drawing.Size(78, 18);
            this.imdbVotesLabel.TabIndex = 14;
            this.imdbVotesLabel.Text = "imdbVotes";
            // 
            // StarPictureBox
            // 
            this.StarPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.StarPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("StarPictureBox.Image")));
            this.StarPictureBox.Location = new System.Drawing.Point(100, 6);
            this.StarPictureBox.Name = "StarPictureBox";
            this.StarPictureBox.Size = new System.Drawing.Size(32, 32);
            this.StarPictureBox.TabIndex = 15;
            this.StarPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Votes on imdb: ";
            // 
            // FavoriteButton
            // 
            this.FavoriteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(128)))));
            this.FavoriteButton.FlatAppearance.BorderSize = 5;
            this.FavoriteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FavoriteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FavoriteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(199)))), ((int)(((byte)(0)))));
            this.FavoriteButton.Location = new System.Drawing.Point(523, 51);
            this.FavoriteButton.Name = "FavoriteButton";
            this.FavoriteButton.Size = new System.Drawing.Size(121, 32);
            this.FavoriteButton.TabIndex = 17;
            this.FavoriteButton.Text = "Add to favorites";
            this.FavoriteButton.UseVisualStyleBackColor = true;
            this.FavoriteButton.Click += new System.EventHandler(this.FavoriteButton_Click);
            // 
            // IMDbVotesPanel
            // 
            this.IMDbVotesPanel.Controls.Add(this.imdbVotesLabel);
            this.IMDbVotesPanel.Controls.Add(this.label1);
            this.IMDbVotesPanel.Location = new System.Drawing.Point(355, 95);
            this.IMDbVotesPanel.Name = "IMDbVotesPanel";
            this.IMDbVotesPanel.Size = new System.Drawing.Size(191, 41);
            this.IMDbVotesPanel.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.StarPictureBox);
            this.panel1.Controls.Add(this.imdbRatingLabel);
            this.panel1.Location = new System.Drawing.Point(355, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 45);
            this.panel1.TabIndex = 20;
            // 
            // IMDbIDLabel
            // 
            this.IMDbIDLabel.AutoSize = true;
            this.IMDbIDLabel.Location = new System.Drawing.Point(907, 458);
            this.IMDbIDLabel.Name = "IMDbIDLabel";
            this.IMDbIDLabel.Size = new System.Drawing.Size(35, 13);
            this.IMDbIDLabel.TabIndex = 21;
            this.IMDbIDLabel.Text = "label2";
            // 
            // MovieDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(954, 532);
            this.Controls.Add(this.IMDbIDLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.IMDbVotesPanel);
            this.Controls.Add(this.FavoriteButton);
            this.Controls.Add(this.AwardsLabel);
            this.Controls.Add(this.ReleasedLabel);
            this.Controls.Add(this.DurationLabel);
            this.Controls.Add(this.RatedLabel);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.PlotLabel);
            this.Controls.Add(this.WritersLabel);
            this.Controls.Add(this.ActorsLabel);
            this.Controls.Add(this.DirectorsLabel);
            this.Controls.Add(this.MoviePictureBox);
            this.Controls.Add(this.MovieTitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MovieDetailsForm";
            this.Text = "MovieDetails";
            this.Load += new System.EventHandler(this.MovieDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StarPictureBox)).EndInit();
            this.IMDbVotesPanel.ResumeLayout(false);
            this.IMDbVotesPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MovieTitleLabel;
        private System.Windows.Forms.PictureBox MoviePictureBox;
        private System.Windows.Forms.Label DirectorsLabel;
        private System.Windows.Forms.Label ActorsLabel;
        private System.Windows.Forms.Label WritersLabel;
        private System.Windows.Forms.Label PlotLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label RatedLabel;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.Label ReleasedLabel;
        private System.Windows.Forms.Label AwardsLabel;
        private System.Windows.Forms.Label imdbRatingLabel;
        private System.Windows.Forms.Label imdbVotesLabel;
        private System.Windows.Forms.PictureBox StarPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FavoriteButton;
        private System.Windows.Forms.Panel IMDbVotesPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label IMDbIDLabel;
    }
}