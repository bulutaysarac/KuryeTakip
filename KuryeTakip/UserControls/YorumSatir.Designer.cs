namespace KuryeTakip.UserControls
{
    partial class YorumSatir
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
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.rtngPuan = new Bunifu.Framework.UI.BunifuRating();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.Location = new System.Drawing.Point(3, 42);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(69, 25);
            this.lblBaslik.TabIndex = 2;
            this.lblBaslik.Text = "Başlık";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblAciklama.Location = new System.Drawing.Point(3, 77);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(84, 21);
            this.lblAciklama.TabIndex = 3;
            this.lblAciklama.Text = "Açıklama";
            // 
            // lblAd
            // 
            this.lblAd.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lblAd.Location = new System.Drawing.Point(3, 3);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(149, 24);
            this.lblAd.TabIndex = 4;
            this.lblAd.Text = "Ad";
            // 
            // lblSoyad
            // 
            this.lblSoyad.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lblSoyad.Location = new System.Drawing.Point(158, 3);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(143, 24);
            this.lblSoyad.TabIndex = 5;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(307, 8);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(35, 17);
            this.lblTarih.TabIndex = 6;
            this.lblTarih.Text = "Tarih";
            // 
            // rtngPuan
            // 
            this.rtngPuan.BackColor = System.Drawing.Color.Transparent;
            this.rtngPuan.ForeColor = System.Drawing.Color.SeaGreen;
            this.rtngPuan.Location = new System.Drawing.Point(568, 0);
            this.rtngPuan.Name = "rtngPuan";
            this.rtngPuan.Size = new System.Drawing.Size(156, 32);
            this.rtngPuan.TabIndex = 7;
            this.rtngPuan.Value = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label1.Location = new System.Drawing.Point(500, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Puan";
            // 
            // YorumSatir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtngPuan);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblBaslik);
            this.Name = "YorumSatir";
            this.Size = new System.Drawing.Size(732, 122);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblBaslik;
        public System.Windows.Forms.Label lblAciklama;
        public System.Windows.Forms.Label lblAd;
        public System.Windows.Forms.Label lblSoyad;
        public System.Windows.Forms.Label lblTarih;
        public Bunifu.Framework.UI.BunifuRating rtngPuan;
        public System.Windows.Forms.Label label1;
    }
}
