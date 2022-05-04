
namespace PresentationLayer
{
    partial class RatedMovieInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RatedMovieInfoForm));
            this.UkOcjLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StarPictureBox = new System.Windows.Forms.PictureBox();
            this.imdbRatingLabel = new System.Windows.Forms.Label();
            this.IMDbVotesPanel = new System.Windows.Forms.Panel();
            this.imdbVotesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.MoviePictureBox = new System.Windows.Forms.PictureBox();
            this.MovieTitleLabel = new System.Windows.Forms.Label();
            this.BrOcjLabel = new System.Windows.Forms.Label();
            this.pictureBoxStar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StarPictureBox)).BeginInit();
            this.IMDbVotesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStar)).BeginInit();
            this.SuspendLayout();
            // 
            // UkOcjLabel
            // 
            this.UkOcjLabel.AutoSize = true;
            this.UkOcjLabel.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UkOcjLabel.ForeColor = System.Drawing.Color.White;
            this.UkOcjLabel.Location = new System.Drawing.Point(23, 305);
            this.UkOcjLabel.Name = "UkOcjLabel";
            this.UkOcjLabel.Size = new System.Drawing.Size(340, 21);
            this.UkOcjLabel.TabIndex = 38;
            this.UkOcjLabel.Text = "Ukupna ocjena svih korisnika za film:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.StarPictureBox);
            this.panel1.Controls.Add(this.imdbRatingLabel);
            this.panel1.Location = new System.Drawing.Point(155, 417);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 45);
            this.panel1.TabIndex = 34;
            // 
            // StarPictureBox
            // 
            this.StarPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.StarPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("StarPictureBox.Image")));
            this.StarPictureBox.Location = new System.Drawing.Point(248, 10);
            this.StarPictureBox.Name = "StarPictureBox";
            this.StarPictureBox.Size = new System.Drawing.Size(32, 32);
            this.StarPictureBox.TabIndex = 15;
            this.StarPictureBox.TabStop = false;
            // 
            // imdbRatingLabel
            // 
            this.imdbRatingLabel.AutoSize = true;
            this.imdbRatingLabel.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imdbRatingLabel.ForeColor = System.Drawing.Color.White;
            this.imdbRatingLabel.Location = new System.Drawing.Point(10, 16);
            this.imdbRatingLabel.Name = "imdbRatingLabel";
            this.imdbRatingLabel.Size = new System.Drawing.Size(123, 23);
            this.imdbRatingLabel.TabIndex = 13;
            this.imdbRatingLabel.Text = "imdbRating";
            // 
            // IMDbVotesPanel
            // 
            this.IMDbVotesPanel.Controls.Add(this.imdbVotesLabel);
            this.IMDbVotesPanel.Controls.Add(this.label1);
            this.IMDbVotesPanel.Location = new System.Drawing.Point(155, 468);
            this.IMDbVotesPanel.Name = "IMDbVotesPanel";
            this.IMDbVotesPanel.Size = new System.Drawing.Size(333, 41);
            this.IMDbVotesPanel.TabIndex = 33;
            // 
            // imdbVotesLabel
            // 
            this.imdbVotesLabel.AutoSize = true;
            this.imdbVotesLabel.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imdbVotesLabel.ForeColor = System.Drawing.Color.White;
            this.imdbVotesLabel.Location = new System.Drawing.Point(150, 14);
            this.imdbVotesLabel.Name = "imdbVotesLabel";
            this.imdbVotesLabel.Size = new System.Drawing.Size(106, 21);
            this.imdbVotesLabel.TabIndex = 14;
            this.imdbVotesLabel.Text = "imdbVotes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Votes on imdb: ";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreLabel.ForeColor = System.Drawing.Color.White;
            this.GenreLabel.Location = new System.Drawing.Point(307, 68);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(56, 19);
            this.GenreLabel.TabIndex = 32;
            this.GenreLabel.Text = "Genre";
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DurationLabel.ForeColor = System.Drawing.Color.White;
            this.DurationLabel.Location = new System.Drawing.Point(177, 69);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(78, 18);
            this.DurationLabel.TabIndex = 31;
            this.DurationLabel.Text = "Duration";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearLabel.ForeColor = System.Drawing.Color.White;
            this.YearLabel.Location = new System.Drawing.Point(30, 69);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(44, 18);
            this.YearLabel.TabIndex = 30;
            this.YearLabel.Text = "Year";
            // 
            // MoviePictureBox
            // 
            this.MoviePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MoviePictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("MoviePictureBox.ErrorImage")));
            this.MoviePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MoviePictureBox.Image")));
            this.MoviePictureBox.Location = new System.Drawing.Point(645, 12);
            this.MoviePictureBox.Name = "MoviePictureBox";
            this.MoviePictureBox.Size = new System.Drawing.Size(300, 450);
            this.MoviePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MoviePictureBox.TabIndex = 29;
            this.MoviePictureBox.TabStop = false;
            // 
            // MovieTitleLabel
            // 
            this.MovieTitleLabel.AutoSize = true;
            this.MovieTitleLabel.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(197)))), ((int)(((byte)(32)))));
            this.MovieTitleLabel.Location = new System.Drawing.Point(12, 12);
            this.MovieTitleLabel.Name = "MovieTitleLabel";
            this.MovieTitleLabel.Size = new System.Drawing.Size(269, 43);
            this.MovieTitleLabel.TabIndex = 28;
            this.MovieTitleLabel.Tag = "";
            this.MovieTitleLabel.Text = "Naslov koji je duzi";
            // 
            // BrOcjLabel
            // 
            this.BrOcjLabel.AutoSize = true;
            this.BrOcjLabel.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrOcjLabel.ForeColor = System.Drawing.Color.White;
            this.BrOcjLabel.Location = new System.Drawing.Point(23, 210);
            this.BrOcjLabel.Name = "BrOcjLabel";
            this.BrOcjLabel.Size = new System.Drawing.Size(340, 21);
            this.BrOcjLabel.TabIndex = 39;
            this.BrOcjLabel.Text = "Ukupna ocjena svih korisnika za film:";
            // 
            // pictureBoxStar
            // 
            this.pictureBoxStar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxStar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStar.Image")));
            this.pictureBoxStar.Location = new System.Drawing.Point(456, 296);
            this.pictureBoxStar.Name = "pictureBoxStar";
            this.pictureBoxStar.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxStar.TabIndex = 40;
            this.pictureBoxStar.TabStop = false;
            // 
            // RatedMovieInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(957, 562);
            this.Controls.Add(this.pictureBoxStar);
            this.Controls.Add(this.UkOcjLabel);
            this.Controls.Add(this.BrOcjLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.IMDbVotesPanel);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.DurationLabel);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.MoviePictureBox);
            this.Controls.Add(this.MovieTitleLabel);
            this.Name = "RatedMovieInfoForm";
            this.Text = "RatedMovieInfoForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StarPictureBox)).EndInit();
            this.IMDbVotesPanel.ResumeLayout(false);
            this.IMDbVotesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UkOcjLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox StarPictureBox;
        private System.Windows.Forms.Label imdbRatingLabel;
        private System.Windows.Forms.Panel IMDbVotesPanel;
        private System.Windows.Forms.Label imdbVotesLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.PictureBox MoviePictureBox;
        private System.Windows.Forms.Label MovieTitleLabel;
        private System.Windows.Forms.Label BrOcjLabel;
        private System.Windows.Forms.PictureBox pictureBoxStar;
    }
}