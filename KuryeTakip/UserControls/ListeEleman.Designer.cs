namespace KuryeTakip.UserControls
{
    partial class ListeEleman
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeEleman));
            this.imgResim = new System.Windows.Forms.PictureBox();
            this.lblSirketAdi = new System.Windows.Forms.Label();
            this.lblSehir = new System.Windows.Forms.Label();
            this.rtngPuan = new Bunifu.Framework.UI.BunifuRating();
            this.imgQRCode = new System.Windows.Forms.PictureBox();
            this.btnHaritada = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnDetayli = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // imgResim
            // 
            this.imgResim.Image = ((System.Drawing.Image)(resources.GetObject("imgResim.Image")));
            this.imgResim.Location = new System.Drawing.Point(4, 4);
            this.imgResim.Name = "imgResim";
            this.imgResim.Size = new System.Drawing.Size(272, 284);
            this.imgResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgResim.TabIndex = 0;
            this.imgResim.TabStop = false;
            // 
            // lblSirketAdi
            // 
            this.lblSirketAdi.AutoSize = true;
            this.lblSirketAdi.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lblSirketAdi.Location = new System.Drawing.Point(282, 17);
            this.lblSirketAdi.Name = "lblSirketAdi";
            this.lblSirketAdi.Size = new System.Drawing.Size(101, 24);
            this.lblSirketAdi.TabIndex = 1;
            this.lblSirketAdi.Text = "Şirket Adı";
            // 
            // lblSehir
            // 
            this.lblSehir.AutoSize = true;
            this.lblSehir.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lblSehir.Location = new System.Drawing.Point(282, 59);
            this.lblSehir.Name = "lblSehir";
            this.lblSehir.Size = new System.Drawing.Size(56, 24);
            this.lblSehir.TabIndex = 2;
            this.lblSehir.Text = "Şehir";
            // 
            // rtngPuan
            // 
            this.rtngPuan.BackColor = System.Drawing.Color.Transparent;
            this.rtngPuan.ForeColor = System.Drawing.Color.Gold;
            this.rtngPuan.Location = new System.Drawing.Point(361, 188);
            this.rtngPuan.Name = "rtngPuan";
            this.rtngPuan.Size = new System.Drawing.Size(175, 34);
            this.rtngPuan.TabIndex = 3;
            this.rtngPuan.Value = 0;
            // 
            // imgQRCode
            // 
            this.imgQRCode.Location = new System.Drawing.Point(640, 3);
            this.imgQRCode.Name = "imgQRCode";
            this.imgQRCode.Size = new System.Drawing.Size(144, 138);
            this.imgQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgQRCode.TabIndex = 4;
            this.imgQRCode.TabStop = false;
            // 
            // btnHaritada
            // 
            this.btnHaritada.BackColor = System.Drawing.Color.Gray;
            this.btnHaritada.color = System.Drawing.Color.Gray;
            this.btnHaritada.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnHaritada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHaritada.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnHaritada.ForeColor = System.Drawing.Color.White;
            this.btnHaritada.Image = ((System.Drawing.Image)(resources.GetObject("btnHaritada.Image")));
            this.btnHaritada.ImagePosition = 20;
            this.btnHaritada.ImageZoom = 50;
            this.btnHaritada.LabelPosition = 41;
            this.btnHaritada.LabelText = "Haritada Gör";
            this.btnHaritada.Location = new System.Drawing.Point(640, 150);
            this.btnHaritada.Margin = new System.Windows.Forms.Padding(6);
            this.btnHaritada.Name = "btnHaritada";
            this.btnHaritada.Size = new System.Drawing.Size(144, 138);
            this.btnHaritada.TabIndex = 5;
            this.btnHaritada.Click += new System.EventHandler(this.btnHaritada_Click);
            // 
            // btnDetayli
            // 
            this.btnDetayli.ActiveBorderThickness = 1;
            this.btnDetayli.ActiveCornerRadius = 20;
            this.btnDetayli.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDetayli.ActiveForecolor = System.Drawing.Color.White;
            this.btnDetayli.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDetayli.BackColor = System.Drawing.SystemColors.Control;
            this.btnDetayli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDetayli.BackgroundImage")));
            this.btnDetayli.ButtonText = "Detaylı Gör";
            this.btnDetayli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetayli.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetayli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDetayli.IdleBorderThickness = 1;
            this.btnDetayli.IdleCornerRadius = 20;
            this.btnDetayli.IdleFillColor = System.Drawing.Color.White;
            this.btnDetayli.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDetayli.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDetayli.Location = new System.Drawing.Point(284, 234);
            this.btnDetayli.Margin = new System.Windows.Forms.Padding(5);
            this.btnDetayli.Name = "btnDetayli";
            this.btnDetayli.Size = new System.Drawing.Size(345, 54);
            this.btnDetayli.TabIndex = 6;
            this.btnDetayli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDetayli.Click += new System.EventHandler(this.btnDetayli_Click);
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lblTelefon.Location = new System.Drawing.Point(282, 101);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(85, 24);
            this.lblTelefon.TabIndex = 7;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.Location = new System.Drawing.Point(283, 150);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(42, 17);
            this.lblAdres.TabIndex = 8;
            this.lblAdres.Text = "Adres";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lblPuan.Location = new System.Drawing.Point(282, 192);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(79, 24);
            this.lblPuan.TabIndex = 9;
            this.lblPuan.Text = "Puan : ";
            // 
            // ListeEleman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.btnDetayli);
            this.Controls.Add(this.btnHaritada);
            this.Controls.Add(this.imgQRCode);
            this.Controls.Add(this.rtngPuan);
            this.Controls.Add(this.lblSehir);
            this.Controls.Add(this.lblSirketAdi);
            this.Controls.Add(this.imgResim);
            this.Name = "ListeEleman";
            this.Size = new System.Drawing.Size(797, 298);
            ((System.ComponentModel.ISupportInitialize)(this.imgResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPuan;
        public System.Windows.Forms.Label lblSirketAdi;
        public System.Windows.Forms.Label lblSehir;
        public Bunifu.Framework.UI.BunifuRating rtngPuan;
        public System.Windows.Forms.PictureBox imgQRCode;
        public Bunifu.Framework.UI.BunifuTileButton btnHaritada;
        public Bunifu.Framework.UI.BunifuThinButton2 btnDetayli;
        public System.Windows.Forms.Label lblTelefon;
        public System.Windows.Forms.Label lblAdres;
        public System.Windows.Forms.PictureBox imgResim;
    }
}
