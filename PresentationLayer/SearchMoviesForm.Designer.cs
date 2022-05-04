
namespace PresentationLayer
{
    partial class SearchMoviesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchMoviesForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitleInput = new System.Windows.Forms.TextBox();
            this.YearLabel = new System.Windows.Forms.Label();
            this.YearInput = new System.Windows.Forms.TextBox();
            this.IMDbPictureBox = new System.Windows.Forms.PictureBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.dataGridViewSearchedMovies = new System.Windows.Forms.DataGridView();
            this.checkBoxMovies = new System.Windows.Forms.CheckBox();
            this.checkBoxSeries = new System.Windows.Forms.CheckBox();
            this.ButtonLeft = new System.Windows.Forms.Button();
            this.ButtonRight = new System.Windows.Forms.Button();
            this.PageLabel = new System.Windows.Forms.Label();
            this.NemaFilmovaLabel = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.IMDbPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchedMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(73, 16);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(127, 13);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Unesite naslov:";
            // 
            // TitleInput
            // 
            this.TitleInput.Location = new System.Drawing.Point(194, 12);
            this.TitleInput.Name = "TitleInput";
            this.TitleInput.Size = new System.Drawing.Size(378, 20);
            this.TitleInput.TabIndex = 1;
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearLabel.ForeColor = System.Drawing.Color.White;
            this.YearLabel.Location = new System.Drawing.Point(45, 42);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(159, 13);
            this.YearLabel.TabIndex = 2;
            this.YearLabel.Text = "Godina(opcionalno):";
            // 
            // YearInput
            // 
            this.YearInput.Location = new System.Drawing.Point(194, 38);
            this.YearInput.Name = "YearInput";
            this.YearInput.Size = new System.Drawing.Size(378, 20);
            this.YearInput.TabIndex = 3;
            // 
            // IMDbPictureBox
            // 
            this.IMDbPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("IMDbPictureBox.Image")));
            this.IMDbPictureBox.ImageLocation = "";
            this.IMDbPictureBox.Location = new System.Drawing.Point(605, 12);
            this.IMDbPictureBox.Name = "IMDbPictureBox";
            this.IMDbPictureBox.Size = new System.Drawing.Size(160, 80);
            this.IMDbPictureBox.TabIndex = 4;
            this.IMDbPictureBox.TabStop = false;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(199)))), ((int)(((byte)(0)))));
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SearchButton.Location = new System.Drawing.Point(217, 100);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(167, 34);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Pretraga";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // dataGridViewSearchedMovies
            // 
            this.dataGridViewSearchedMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSearchedMovies.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSearchedMovies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSearchedMovies.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(199)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(180)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSearchedMovies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewSearchedMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchedMovies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSearchedMovies.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewSearchedMovies.EnableHeadersVisualStyles = false;
            this.dataGridViewSearchedMovies.Location = new System.Drawing.Point(8, 152);
            this.dataGridViewSearchedMovies.Name = "dataGridViewSearchedMovies";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Marlett", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSearchedMovies.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewSearchedMovies.RowHeadersWidth = 50;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(199)))), ((int)(((byte)(0)))));
            this.dataGridViewSearchedMovies.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewSearchedMovies.RowTemplate.Height = 32;
            this.dataGridViewSearchedMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewSearchedMovies.Size = new System.Drawing.Size(861, 41);
            this.dataGridViewSearchedMovies.TabIndex = 6;
            this.dataGridViewSearchedMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSearchedMovies_CellClick);
            this.dataGridViewSearchedMovies.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewSearchedMovies_DataBindingComplete);
            // 
            // checkBoxMovies
            // 
            this.checkBoxMovies.AutoSize = true;
            this.checkBoxMovies.ForeColor = System.Drawing.Color.White;
            this.checkBoxMovies.Location = new System.Drawing.Point(216, 77);
            this.checkBoxMovies.Name = "checkBoxMovies";
            this.checkBoxMovies.Size = new System.Drawing.Size(58, 17);
            this.checkBoxMovies.TabIndex = 7;
            this.checkBoxMovies.Text = "Filmovi";
            this.checkBoxMovies.UseVisualStyleBackColor = true;
            // 
            // checkBoxSeries
            // 
            this.checkBoxSeries.AutoSize = true;
            this.checkBoxSeries.ForeColor = System.Drawing.Color.White;
            this.checkBoxSeries.Location = new System.Drawing.Point(329, 77);
            this.checkBoxSeries.Name = "checkBoxSeries";
            this.checkBoxSeries.Size = new System.Drawing.Size(52, 17);
            this.checkBoxSeries.TabIndex = 8;
            this.checkBoxSeries.Text = "Serije";
            this.checkBoxSeries.UseVisualStyleBackColor = true;
            // 
            // ButtonLeft
            // 
            this.ButtonLeft.FlatAppearance.BorderSize = 0;
            this.ButtonLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLeft.Image = ((System.Drawing.Image)(resources.GetObject("ButtonLeft.Image")));
            this.ButtonLeft.Location = new System.Drawing.Point(552, 450);
            this.ButtonLeft.Name = "ButtonLeft";
            this.ButtonLeft.Size = new System.Drawing.Size(32, 32);
            this.ButtonLeft.TabIndex = 9;
            this.ButtonLeft.UseVisualStyleBackColor = false;
            this.ButtonLeft.Click += new System.EventHandler(this.ButtonLeft_Click);
            // 
            // ButtonRight
            // 
            this.ButtonRight.FlatAppearance.BorderSize = 0;
            this.ButtonRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRight.Image = ((System.Drawing.Image)(resources.GetObject("ButtonRight.Image")));
            this.ButtonRight.Location = new System.Drawing.Point(674, 450);
            this.ButtonRight.Name = "ButtonRight";
            this.ButtonRight.Size = new System.Drawing.Size(32, 32);
            this.ButtonRight.TabIndex = 10;
            this.ButtonRight.UseVisualStyleBackColor = false;
            this.ButtonRight.Click += new System.EventHandler(this.ButtonRight_Click);
            // 
            // PageLabel
            // 
            this.PageLabel.AutoSize = true;
            this.PageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageLabel.ForeColor = System.Drawing.Color.White;
            this.PageLabel.Location = new System.Drawing.Point(601, 455);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(0, 20);
            this.PageLabel.TabIndex = 11;
            // 
            // NemaFilmovaLabel
            // 
            this.NemaFilmovaLabel.AutoSize = true;
            this.NemaFilmovaLabel.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NemaFilmovaLabel.ForeColor = System.Drawing.Color.White;
            this.NemaFilmovaLabel.Location = new System.Drawing.Point(404, 118);
            this.NemaFilmovaLabel.Name = "NemaFilmovaLabel";
            this.NemaFilmovaLabel.Size = new System.Drawing.Size(151, 15);
            this.NemaFilmovaLabel.TabIndex = 12;
            this.NemaFilmovaLabel.Text = "Year(optional) :";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Title";
            this.Column1.HeaderText = "Naziv";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Year";
            this.Column2.HeaderText = "Godina izdanja";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Type";
            this.Column3.HeaderText = "Tip";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ImdbID";
            this.Column4.HeaderText = "imdb";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ImgUrl";
            this.Column5.HeaderText = "url";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TotalSearches";
            this.Column6.HeaderText = "pretrage";
            this.Column6.Name = "Column6";
            // 
            // SearchMoviesForm
            // 
            this.AcceptButton = this.SearchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(956, 561);
            this.Controls.Add(this.NemaFilmovaLabel);
            this.Controls.Add(this.PageLabel);
            this.Controls.Add(this.ButtonRight);
            this.Controls.Add(this.ButtonLeft);
            this.Controls.Add(this.checkBoxSeries);
            this.Controls.Add(this.checkBoxMovies);
            this.Controls.Add(this.dataGridViewSearchedMovies);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.IMDbPictureBox);
            this.Controls.Add(this.YearInput);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.TitleInput);
            this.Controls.Add(this.TitleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchMoviesForm";
            this.Text = "IMDB";
            ((System.ComponentModel.ISupportInitialize)(this.IMDbPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchedMovies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox TitleInput;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.TextBox YearInput;
        private System.Windows.Forms.PictureBox IMDbPictureBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView dataGridViewSearchedMovies;
        private System.Windows.Forms.CheckBox checkBoxMovies;
        private System.Windows.Forms.CheckBox checkBoxSeries;
        private System.Windows.Forms.Button ButtonLeft;
        private System.Windows.Forms.Button ButtonRight;
        private System.Windows.Forms.Label PageLabel;
        private System.Windows.Forms.Label NemaFilmovaLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

