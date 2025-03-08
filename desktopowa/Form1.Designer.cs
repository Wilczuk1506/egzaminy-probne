namespace desktopowa
{
    partial class Form1
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
            this.pic_vinyl = new System.Windows.Forms.PictureBox();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.lb_artist = new System.Windows.Forms.Label();
            this.lb_album = new System.Windows.Forms.Label();
            this.lb_songsNumber = new System.Windows.Forms.Label();
            this.lb_year = new System.Windows.Forms.Label();
            this.lb_downloadNumber = new System.Windows.Forms.Label();
            this.btn_download = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_vinyl)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_vinyl
            // 
            this.pic_vinyl.BackColor = System.Drawing.Color.Transparent;
            this.pic_vinyl.Image = global::desktopowa.Properties.Resources.obraz;
            this.pic_vinyl.Location = new System.Drawing.Point(120, 61);
            this.pic_vinyl.Name = "pic_vinyl";
            this.pic_vinyl.Size = new System.Drawing.Size(200, 200);
            this.pic_vinyl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_vinyl.TabIndex = 2;
            this.pic_vinyl.TabStop = false;
            // 
            // btn_previous
            // 
            this.btn_previous.AutoSize = true;
            this.btn_previous.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_previous.Image = global::desktopowa.Properties.Resources.obraz3;
            this.btn_previous.Location = new System.Drawing.Point(12, 191);
            this.btn_previous.MaximumSize = new System.Drawing.Size(0, 70);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(102, 70);
            this.btn_previous.TabIndex = 1;
            this.btn_previous.UseVisualStyleBackColor = true;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_next
            // 
            this.btn_next.AutoSize = true;
            this.btn_next.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_next.Image = global::desktopowa.Properties.Resources.obraz2;
            this.btn_next.Location = new System.Drawing.Point(909, 191);
            this.btn_next.MaximumSize = new System.Drawing.Size(0, 70);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(102, 70);
            this.btn_next.TabIndex = 0;
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // lb_artist
            // 
            this.lb_artist.AutoSize = true;
            this.lb_artist.BackColor = System.Drawing.Color.Transparent;
            this.lb_artist.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_artist.ForeColor = System.Drawing.Color.White;
            this.lb_artist.Location = new System.Drawing.Point(330, 61);
            this.lb_artist.Name = "lb_artist";
            this.lb_artist.Size = new System.Drawing.Size(185, 76);
            this.lb_artist.TabIndex = 3;
            this.lb_artist.Text = "Artist";
            // 
            // lb_album
            // 
            this.lb_album.AutoSize = true;
            this.lb_album.BackColor = System.Drawing.Color.Transparent;
            this.lb_album.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_album.ForeColor = System.Drawing.Color.White;
            this.lb_album.Location = new System.Drawing.Point(335, 137);
            this.lb_album.Name = "lb_album";
            this.lb_album.Size = new System.Drawing.Size(161, 46);
            this.lb_album.TabIndex = 4;
            this.lb_album.Text = "\"Album\"";
            // 
            // lb_songsNumber
            // 
            this.lb_songsNumber.AutoSize = true;
            this.lb_songsNumber.BackColor = System.Drawing.Color.Transparent;
            this.lb_songsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_songsNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(217)))), ((int)(((byte)(24)))));
            this.lb_songsNumber.Location = new System.Drawing.Point(337, 205);
            this.lb_songsNumber.Name = "lb_songsNumber";
            this.lb_songsNumber.Size = new System.Drawing.Size(187, 31);
            this.lb_songsNumber.TabIndex = 5;
            this.lb_songsNumber.Text = "SongsNumber";
            // 
            // lb_year
            // 
            this.lb_year.AutoSize = true;
            this.lb_year.BackColor = System.Drawing.Color.Transparent;
            this.lb_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_year.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(217)))), ((int)(((byte)(24)))));
            this.lb_year.Location = new System.Drawing.Point(530, 205);
            this.lb_year.Name = "lb_year";
            this.lb_year.Size = new System.Drawing.Size(71, 31);
            this.lb_year.TabIndex = 6;
            this.lb_year.Text = "Year";
            // 
            // lb_downloadNumber
            // 
            this.lb_downloadNumber.AutoSize = true;
            this.lb_downloadNumber.BackColor = System.Drawing.Color.Transparent;
            this.lb_downloadNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_downloadNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(217)))), ((int)(((byte)(24)))));
            this.lb_downloadNumber.Location = new System.Drawing.Point(114, 319);
            this.lb_downloadNumber.Name = "lb_downloadNumber";
            this.lb_downloadNumber.Size = new System.Drawing.Size(231, 31);
            this.lb_downloadNumber.TabIndex = 7;
            this.lb_downloadNumber.Text = "DownloadNumber";
            // 
            // btn_download
            // 
            this.btn_download.AutoSize = true;
            this.btn_download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(217)))), ((int)(((byte)(24)))));
            this.btn_download.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_download.Location = new System.Drawing.Point(274, 319);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(123, 41);
            this.btn_download.TabIndex = 8;
            this.btn_download.Text = "Pobierz";
            this.btn_download.UseVisualStyleBackColor = false;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1023, 450);
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.lb_downloadNumber);
            this.Controls.Add(this.lb_year);
            this.Controls.Add(this.lb_songsNumber);
            this.Controls.Add(this.lb_album);
            this.Controls.Add(this.lb_artist);
            this.Controls.Add(this.pic_vinyl);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.btn_next);
            this.Name = "Form1";
            this.Text = "MojeDźwięki, Wykonał: Ilczuk Wiktor";
            ((System.ComponentModel.ISupportInitialize)(this.pic_vinyl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.PictureBox pic_vinyl;
        private System.Windows.Forms.Label lb_artist;
        private System.Windows.Forms.Label lb_album;
        private System.Windows.Forms.Label lb_songsNumber;
        private System.Windows.Forms.Label lb_year;
        private System.Windows.Forms.Label lb_downloadNumber;
        private System.Windows.Forms.Button btn_download;
    }
}

