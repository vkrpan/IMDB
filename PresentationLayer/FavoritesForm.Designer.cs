
namespace PresentationLayer
{
    partial class FavoritesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavoritesForm));
            this.FavoriteMoviesDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.FavoriteMoviesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FavoriteMoviesDataGridView
            // 
            this.FavoriteMoviesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FavoriteMoviesDataGridView.ColumnHeadersHeight = 27;
            this.FavoriteMoviesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.FavoriteMoviesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column6,
            this.Column3,
            this.Column5,
            this.Column7,
            this.Column8});
            this.FavoriteMoviesDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.FavoriteMoviesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.FavoriteMoviesDataGridView.Name = "FavoriteMoviesDataGridView";
            this.FavoriteMoviesDataGridView.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FavoriteMoviesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.FavoriteMoviesDataGridView.RowHeadersWidth = 50;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(199)))), ((int)(((byte)(0)))));
            this.FavoriteMoviesDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.FavoriteMoviesDataGridView.Size = new System.Drawing.Size(954, 313);
            this.FavoriteMoviesDataGridView.TabIndex = 0;
            this.FavoriteMoviesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FavoriteMoviesDataGridView_CellClick);
            this.FavoriteMoviesDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Title";
            this.Column1.HeaderText = "Naslov";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "IMDbId";
            this.Column4.HeaderText = "imdbID";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Duration";
            this.Column2.HeaderText = "Trajanje";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Year";
            this.Column6.HeaderText = "Godina izdanja";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Genre";
            this.Column3.HeaderText = "Žanr";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Type";
            this.Column5.HeaderText = "Tip";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "UserID";
            this.Column7.HeaderText = "hideUserID";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "UserOcjena";
            this.Column8.HeaderText = "Ocjena";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // FavoritesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(954, 561);
            this.Controls.Add(this.FavoriteMoviesDataGridView);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FavoritesForm";
            this.Text = "FavoritesForm";
            ((System.ComponentModel.ISupportInitialize)(this.FavoriteMoviesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FavoriteMoviesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}