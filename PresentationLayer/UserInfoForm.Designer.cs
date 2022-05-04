
namespace PresentationLayer
{
    partial class UserInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInfoForm));
            this.UkFavoritaLabel = new System.Windows.Forms.Label();
            this.UkOcjFilmovaLabel = new System.Windows.Forms.Label();
            this.LabelIme = new System.Windows.Forms.Label();
            this.LabelPrezime = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.ProsjecnaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UkFavoritaLabel
            // 
            this.UkFavoritaLabel.AutoSize = true;
            this.UkFavoritaLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UkFavoritaLabel.ForeColor = System.Drawing.Color.White;
            this.UkFavoritaLabel.Location = new System.Drawing.Point(49, 269);
            this.UkFavoritaLabel.Name = "UkFavoritaLabel";
            this.UkFavoritaLabel.Size = new System.Drawing.Size(409, 25);
            this.UkFavoritaLabel.TabIndex = 0;
            this.UkFavoritaLabel.Text = "Ukupno filmova spremljeno u favorite: ";
            // 
            // UkOcjFilmovaLabel
            // 
            this.UkOcjFilmovaLabel.AutoSize = true;
            this.UkOcjFilmovaLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UkOcjFilmovaLabel.ForeColor = System.Drawing.Color.White;
            this.UkOcjFilmovaLabel.Location = new System.Drawing.Point(49, 323);
            this.UkOcjFilmovaLabel.Name = "UkOcjFilmovaLabel";
            this.UkOcjFilmovaLabel.Size = new System.Drawing.Size(199, 25);
            this.UkOcjFilmovaLabel.TabIndex = 1;
            this.UkOcjFilmovaLabel.Text = "Od toga ocjenjeni:";
            // 
            // LabelIme
            // 
            this.LabelIme.AutoSize = true;
            this.LabelIme.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIme.ForeColor = System.Drawing.Color.White;
            this.LabelIme.Location = new System.Drawing.Point(49, 40);
            this.LabelIme.Name = "LabelIme";
            this.LabelIme.Size = new System.Drawing.Size(65, 25);
            this.LabelIme.TabIndex = 2;
            this.LabelIme.Text = "Ime: ";
            this.LabelIme.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelPrezime
            // 
            this.LabelPrezime.AutoSize = true;
            this.LabelPrezime.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrezime.ForeColor = System.Drawing.Color.White;
            this.LabelPrezime.Location = new System.Drawing.Point(49, 89);
            this.LabelPrezime.Name = "LabelPrezime";
            this.LabelPrezime.Size = new System.Drawing.Size(105, 25);
            this.LabelPrezime.TabIndex = 3;
            this.LabelPrezime.Text = "Prezime:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.Color.White;
            this.EmailLabel.Location = new System.Drawing.Point(49, 160);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(85, 25);
            this.EmailLabel.TabIndex = 4;
            this.EmailLabel.Text = "Email: ";
            // 
            // ProsjecnaLabel
            // 
            this.ProsjecnaLabel.AutoSize = true;
            this.ProsjecnaLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProsjecnaLabel.ForeColor = System.Drawing.Color.White;
            this.ProsjecnaLabel.Location = new System.Drawing.Point(38, 383);
            this.ProsjecnaLabel.Name = "ProsjecnaLabel";
            this.ProsjecnaLabel.Size = new System.Drawing.Size(455, 25);
            this.ProsjecnaLabel.TabIndex = 5;
            this.ProsjecnaLabel.Text = "Prosječna ocjena vaših ocjenjenih filmova: ";
            // 
            // UserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(954, 561);
            this.Controls.Add(this.ProsjecnaLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.LabelPrezime);
            this.Controls.Add(this.LabelIme);
            this.Controls.Add(this.UkOcjFilmovaLabel);
            this.Controls.Add(this.UkFavoritaLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserInfoForm";
            this.Text = "UserInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UkFavoritaLabel;
        private System.Windows.Forms.Label UkOcjFilmovaLabel;
        private System.Windows.Forms.Label LabelIme;
        private System.Windows.Forms.Label LabelPrezime;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label ProsjecnaLabel;
    }
}