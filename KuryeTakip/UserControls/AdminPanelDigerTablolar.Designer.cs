namespace KuryeTakip.UserControls
{
    partial class AdminPanelDigerTablolar
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgListe = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.rtngPuan = new Bunifu.Framework.UI.BunifuRating();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListe)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(743, 443);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnKaydet);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.rtngPuan);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dtp1);
            this.tabPage2.Controls.Add(this.txtSoyad);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtAd);
            this.tabPage2.Controls.Add(this.txtAciklama);
            this.tabPage2.Controls.Add(this.txtBaslik);
            this.tabPage2.Controls.Add(this.dgListe);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(735, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Yorumlar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(735, 417);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Adminler";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgListe
            // 
            this.dgListe.AllowUserToAddRows = false;
            this.dgListe.AllowUserToDeleteRows = false;
            this.dgListe.AllowUserToOrderColumns = true;
            this.dgListe.AllowUserToResizeColumns = false;
            this.dgListe.AllowUserToResizeRows = false;
            this.dgListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgListe.Location = new System.Drawing.Point(7, 7);
            this.dgListe.Name = "dgListe";
            this.dgListe.Size = new System.Drawing.Size(722, 167);
            this.dgListe.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Başlık";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Açıklama";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ad";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Soyad";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tarih";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Puan";
            this.Column6.Name = "Column6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ad Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Açıklama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Başlık";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(255, 232);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(115, 20);
            this.txtAd.TabIndex = 9;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(255, 206);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(236, 20);
            this.txtAciklama.TabIndex = 8;
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(255, 180);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(236, 20);
            this.txtBaslik.TabIndex = 7;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(376, 232);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(115, 20);
            this.txtSoyad.TabIndex = 13;
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(255, 259);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(236, 20);
            this.dtp1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tarih";
            // 
            // rtngPuan
            // 
            this.rtngPuan.BackColor = System.Drawing.Color.Transparent;
            this.rtngPuan.ForeColor = System.Drawing.Color.SeaGreen;
            this.rtngPuan.Location = new System.Drawing.Point(255, 285);
            this.rtngPuan.Name = "rtngPuan";
            this.rtngPuan.Size = new System.Drawing.Size(236, 50);
            this.rtngPuan.TabIndex = 16;
            this.rtngPuan.Value = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Puan";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(199, 352);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(292, 23);
            this.btnKaydet.TabIndex = 18;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // AdminPanelDigerTablolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminPanelDigerTablolar";
            this.Size = new System.Drawing.Size(750, 450);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgListe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuRating rtngPuan;
        private System.Windows.Forms.Button btnKaydet;
    }
}
