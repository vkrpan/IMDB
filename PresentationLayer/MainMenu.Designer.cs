
namespace PresentationLayer
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.SideMenuPanel = new System.Windows.Forms.Panel();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.UserInfoButton = new System.Windows.Forms.Button();
            this.FavoriteButton = new System.Windows.Forms.Button();
            this.MovieSearchButton = new System.Windows.Forms.Button();
            this.UserAccPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ChildFormPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SideMenuPanel.SuspendLayout();
            this.UserAccPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ChildFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // SideMenuPanel
            // 
            this.SideMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.SideMenuPanel.Controls.Add(this.LogOutButton);
            this.SideMenuPanel.Controls.Add(this.UserInfoButton);
            this.SideMenuPanel.Controls.Add(this.FavoriteButton);
            this.SideMenuPanel.Controls.Add(this.MovieSearchButton);
            this.SideMenuPanel.Controls.Add(this.UserAccPanel);
            this.SideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.SideMenuPanel.Margin = new System.Windows.Forms.Padding(4);
            this.SideMenuPanel.Name = "SideMenuPanel";
            this.SideMenuPanel.Size = new System.Drawing.Size(251, 681);
            this.SideMenuPanel.TabIndex = 0;
            // 
            // LogOutButton
            // 
            this.LogOutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogOutButton.FlatAppearance.BorderSize = 0;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.LogOutButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.LogOutButton.Image = ((System.Drawing.Image)(resources.GetObject("LogOutButton.Image")));
            this.LogOutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOutButton.Location = new System.Drawing.Point(0, 495);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(251, 90);
            this.LogOutButton.TabIndex = 5;
            this.LogOutButton.Text = "  Odjava";
            this.LogOutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // UserInfoButton
            // 
            this.UserInfoButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserInfoButton.FlatAppearance.BorderSize = 0;
            this.UserInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.UserInfoButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.UserInfoButton.Image = ((System.Drawing.Image)(resources.GetObject("UserInfoButton.Image")));
            this.UserInfoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserInfoButton.Location = new System.Drawing.Point(0, 405);
            this.UserInfoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserInfoButton.Name = "UserInfoButton";
            this.UserInfoButton.Size = new System.Drawing.Size(251, 90);
            this.UserInfoButton.TabIndex = 4;
            this.UserInfoButton.Text = " Podaci o korisniku";
            this.UserInfoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UserInfoButton.UseVisualStyleBackColor = true;
            this.UserInfoButton.Click += new System.EventHandler(this.UserInfoButton_Click);
            // 
            // FavoriteButton
            // 
            this.FavoriteButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.FavoriteButton.FlatAppearance.BorderSize = 0;
            this.FavoriteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FavoriteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.FavoriteButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.FavoriteButton.Image = ((System.Drawing.Image)(resources.GetObject("FavoriteButton.Image")));
            this.FavoriteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FavoriteButton.Location = new System.Drawing.Point(0, 315);
            this.FavoriteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FavoriteButton.Name = "FavoriteButton";
            this.FavoriteButton.Size = new System.Drawing.Size(251, 90);
            this.FavoriteButton.TabIndex = 2;
            this.FavoriteButton.Text = " Moji favoriti";
            this.FavoriteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FavoriteButton.UseVisualStyleBackColor = true;
            this.FavoriteButton.Click += new System.EventHandler(this.FavoriteButton_Click);
            // 
            // MovieSearchButton
            // 
            this.MovieSearchButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MovieSearchButton.FlatAppearance.BorderSize = 0;
            this.MovieSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MovieSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.MovieSearchButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.MovieSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("MovieSearchButton.Image")));
            this.MovieSearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MovieSearchButton.Location = new System.Drawing.Point(0, 225);
            this.MovieSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MovieSearchButton.Name = "MovieSearchButton";
            this.MovieSearchButton.Size = new System.Drawing.Size(251, 90);
            this.MovieSearchButton.TabIndex = 1;
            this.MovieSearchButton.Text = " Pretraživanje filmova";
            this.MovieSearchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MovieSearchButton.UseVisualStyleBackColor = true;
            this.MovieSearchButton.Click += new System.EventHandler(this.MovieSearchButton_Click);
            // 
            // UserAccPanel
            // 
            this.UserAccPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.UserAccPanel.Controls.Add(this.pictureBox1);
            this.UserAccPanel.Controls.Add(this.UserNameLabel);
            this.UserAccPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserAccPanel.Location = new System.Drawing.Point(0, 0);
            this.UserAccPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserAccPanel.Name = "UserAccPanel";
            this.UserAccPanel.Size = new System.Drawing.Size(251, 225);
            this.UserAccPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(181)))));
            this.UserNameLabel.Location = new System.Drawing.Point(60, 185);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(75, 15);
            this.UserNameLabel.TabIndex = 1;
            this.UserNameLabel.Text = "UserName";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(185)))), ((int)(((byte)(30)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(251, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 40);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(185)))), ((int)(((byte)(30)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(251, 641);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(973, 40);
            this.panel3.TabIndex = 4;
            // 
            // ChildFormPanel
            // 
            this.ChildFormPanel.Controls.Add(this.pictureBox2);
            this.ChildFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildFormPanel.Location = new System.Drawing.Point(251, 40);
            this.ChildFormPanel.Name = "ChildFormPanel";
            this.ChildFormPanel.Size = new System.Drawing.Size(973, 601);
            this.ChildFormPanel.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(219, 185);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(531, 256);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(185)))), ((int)(((byte)(30)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1224, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 641);
            this.panel2.TabIndex = 3;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.ChildFormPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SideMenuPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.SideMenuPanel.ResumeLayout(false);
            this.UserAccPanel.ResumeLayout(false);
            this.UserAccPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ChildFormPanel.ResumeLayout(false);
            this.ChildFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideMenuPanel;
        private System.Windows.Forms.Panel UserAccPanel;
        private System.Windows.Forms.Button FavoriteButton;
        private System.Windows.Forms.Button MovieSearchButton;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button UserInfoButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel ChildFormPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}