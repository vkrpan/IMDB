
namespace PresentationLayer
{
    partial class RateAMovieForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RateAMovieForm));
            this.MovieTitleLabel = new System.Windows.Forms.Label();
            this.MoviePictureBox = new System.Windows.Forms.PictureBox();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StarPictureBox = new System.Windows.Forms.PictureBox();
            this.imdbRatingLabel = new System.Windows.Forms.Label();
            this.IMDbVotesPanel = new System.Windows.Forms.Panel();
            this.imdbVotesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextLabel = new System.Windows.Forms.Label();
            this.labelOcj = new System.Windows.Forms.Label();
            this.UserOcjpanel = new System.Windows.Forms.Panel();
            this.InputOcjTextBox = new System.Windows.Forms.TextBox();
            this.StarPictureBox2 = new System.Windows.Forms.PictureBox();
            this.UnosOcjButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StarPictureBox)).BeginInit();
            this.IMDbVotesPanel.SuspendLayout();
            this.UserOcjpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StarPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MovieTitleLabel
            // 
            this.MovieTitleLabel.AutoSize = true;
            this.MovieTitleLabel.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(197)))), ((int)(((byte)(32)))));
            this.MovieTitleLabel.Location = new System.Drawing.Point(40, 27);
            this.MovieTitleLabel.Name = "MovieTitleLabel";
            this.MovieTitleLabel.Size = new System.Drawing.Size(269, 43);
            this.MovieTitleLabel.TabIndex = 1;
            this.MovieTitleLabel.Tag = "";
            this.MovieTitleLabel.Text = "Naslov koji je duzi";
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
            this.MoviePictureBox.TabIndex = 3;
            this.MoviePictureBox.TabStop = false;
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DurationLabel.ForeColor = System.Drawing.Color.White;
            this.DurationLabel.Location = new System.Drawing.Point(111, 101);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(78, 18);
            this.DurationLabel.TabIndex = 12;
            this.DurationLabel.Text = "Duration";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearLabel.ForeColor = System.Drawing.Color.White;
            this.YearLabel.Location = new System.Drawing.Point(40, 101);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(44, 18);
            this.YearLabel.TabIndex = 11;
            this.YearLabel.Text = "Year";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreLabel.ForeColor = System.Drawing.Color.White;
            this.GenreLabel.Location = new System.Drawing.Point(292, 100);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(56, 19);
            this.GenreLabel.TabIndex = 13;
            this.GenreLabel.Text = "Genre";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.StarPictureBox);
            this.panel1.Controls.Add(this.imdbRatingLabel);
            this.panel1.Location = new System.Drawing.Point(48, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 45);
            this.panel1.TabIndex = 22;
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
            this.IMDbVotesPanel.Location = new System.Drawing.Point(48, 252);
            this.IMDbVotesPanel.Name = "IMDbVotesPanel";
            this.IMDbVotesPanel.Size = new System.Drawing.Size(333, 41);
            this.IMDbVotesPanel.TabIndex = 21;
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
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLabel.ForeColor = System.Drawing.Color.White;
            this.TextLabel.Location = new System.Drawing.Point(42, 328);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(380, 33);
            this.TextLabel.TabIndex = 23;
            this.TextLabel.Text = "Unesite vašu ocjenu za film";
            // 
            // labelOcj
            // 
            this.labelOcj.AutoSize = true;
            this.labelOcj.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOcj.ForeColor = System.Drawing.Color.White;
            this.labelOcj.Location = new System.Drawing.Point(78, 22);
            this.labelOcj.Name = "labelOcj";
            this.labelOcj.Size = new System.Drawing.Size(51, 29);
            this.labelOcj.TabIndex = 24;
            this.labelOcj.Text = "/10";
            // 
            // UserOcjpanel
            // 
            this.UserOcjpanel.Controls.Add(this.InputOcjTextBox);
            this.UserOcjpanel.Controls.Add(this.StarPictureBox2);
            this.UserOcjpanel.Controls.Add(this.labelOcj);
            this.UserOcjpanel.Location = new System.Drawing.Point(92, 435);
            this.UserOcjpanel.Name = "UserOcjpanel";
            this.UserOcjpanel.Size = new System.Drawing.Size(193, 66);
            this.UserOcjpanel.TabIndex = 25;
            // 
            // InputOcjTextBox
            // 
            this.InputOcjTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.InputOcjTextBox.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputOcjTextBox.ForeColor = System.Drawing.Color.White;
            this.InputOcjTextBox.Location = new System.Drawing.Point(19, 22);
            this.InputOcjTextBox.Name = "InputOcjTextBox";
            this.InputOcjTextBox.Size = new System.Drawing.Size(57, 32);
            this.InputOcjTextBox.TabIndex = 27;
            // 
            // StarPictureBox2
            // 
            this.StarPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.StarPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("StarPictureBox2.Image")));
            this.StarPictureBox2.Location = new System.Drawing.Point(135, 19);
            this.StarPictureBox2.Name = "StarPictureBox2";
            this.StarPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.StarPictureBox2.TabIndex = 26;
            this.StarPictureBox2.TabStop = false;
            // 
            // UnosOcjButton
            // 
            this.UnosOcjButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.UnosOcjButton.FlatAppearance.BorderSize = 4;
            this.UnosOcjButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnosOcjButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnosOcjButton.ForeColor = System.Drawing.Color.White;
            this.UnosOcjButton.Location = new System.Drawing.Point(400, 447);
            this.UnosOcjButton.Name = "UnosOcjButton";
            this.UnosOcjButton.Size = new System.Drawing.Size(134, 43);
            this.UnosOcjButton.TabIndex = 26;
            this.UnosOcjButton.Text = "Unesi ocjenu";
            this.UnosOcjButton.UseVisualStyleBackColor = true;
            this.UnosOcjButton.Click += new System.EventHandler(this.UnosOcjButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.Color.White;
            this.infoLabel.Location = new System.Drawing.Point(58, 378);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(281, 19);
            this.infoLabel.TabIndex = 27;
            this.infoLabel.Text = "Ocjena mora bit u rasponu od 1do 10";
            // 
            // RateAMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(957, 562);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.UnosOcjButton);
            this.Controls.Add(this.UserOcjpanel);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.IMDbVotesPanel);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.DurationLabel);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.MoviePictureBox);
            this.Controls.Add(this.MovieTitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RateAMovieForm";
            this.Text = "RateAMovieForm";
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StarPictureBox)).EndInit();
            this.IMDbVotesPanel.ResumeLayout(false);
            this.IMDbVotesPanel.PerformLayout();
            this.UserOcjpanel.ResumeLayout(false);
            this.UserOcjpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StarPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MovieTitleLabel;
        private System.Windows.Forms.PictureBox MoviePictureBox;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox StarPictureBox;
        private System.Windows.Forms.Label imdbRatingLabel;
        private System.Windows.Forms.Panel IMDbVotesPanel;
        private System.Windows.Forms.Label imdbVotesLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.Label labelOcj;
        private System.Windows.Forms.Panel UserOcjpanel;
        private System.Windows.Forms.TextBox InputOcjTextBox;
        private System.Windows.Forms.PictureBox StarPictureBox2;
        private System.Windows.Forms.Button UnosOcjButton;
        private System.Windows.Forms.Label infoLabel;
    }
}