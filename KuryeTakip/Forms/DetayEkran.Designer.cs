namespace KuryeTakip.Forms
{
    partial class DetayEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetayEkran));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.imgResim = new System.Windows.Forms.PictureBox();
            this.lblPuan = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.rtngPuanGöster = new Bunifu.Framework.UI.BunifuRating();
            this.lblSehir = new System.Windows.Forms.Label();
            this.lblSirketAdi = new System.Windows.Forms.Label();
            this.lblWebSite = new System.Windows.Forms.Label();
            this.lblCalisma = new System.Windows.Forms.Label();
            this.pnlOzellikler = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator5 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator6 = new Bunifu.Framework.UI.BunifuSeparator();
            this.chckMotorlu = new System.Windows.Forms.CheckBox();
            this.bunifuSeparator7 = new Bunifu.Framework.UI.BunifuSeparator();
            this.chckUcakli = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlYorumlar = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnYorumuGönder = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtYorum = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtngPuanYorum = new Bunifu.Framework.UI.BunifuRating();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgResim)).BeginInit();
            this.pnlOzellikler.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 24);
            this.panel1.TabIndex = 18;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(364, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Detaylı Gör";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(770, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imgResim
            // 
            this.imgResim.Image = ((System.Drawing.Image)(resources.GetObject("imgResim.Image")));
            this.imgResim.Location = new System.Drawing.Point(12, 30);
            this.imgResim.Name = "imgResim";
            this.imgResim.Size = new System.Drawing.Size(302, 282);
            this.imgResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgResim.TabIndex = 19;
            this.imgResim.TabStop = false;
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lblPuan.Location = new System.Drawing.Point(30, 333);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(79, 24);
            this.lblPuan.TabIndex = 25;
            this.lblPuan.Text = "Puan : ";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.Location = new System.Drawing.Point(8, 87);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(42, 17);
            this.lblAdres.TabIndex = 24;
            this.lblAdres.Text = "Adres";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lblTelefon.Location = new System.Drawing.Point(8, 121);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(85, 24);
            this.lblTelefon.TabIndex = 23;
            this.lblTelefon.Text = "Telefon";
            // 
            // rtngPuanGöster
            // 
            this.rtngPuanGöster.BackColor = System.Drawing.Color.Transparent;
            this.rtngPuanGöster.ForeColor = System.Drawing.Color.Gold;
            this.rtngPuanGöster.Location = new System.Drawing.Point(115, 332);
            this.rtngPuanGöster.Name = "rtngPuanGöster";
            this.rtngPuanGöster.Size = new System.Drawing.Size(170, 28);
            this.rtngPuanGöster.TabIndex = 22;
            this.rtngPuanGöster.Value = 0;
            // 
            // lblSehir
            // 
            this.lblSehir.AutoSize = true;
            this.lblSehir.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lblSehir.Location = new System.Drawing.Point(8, 46);
            this.lblSehir.Name = "lblSehir";
            this.lblSehir.Size = new System.Drawing.Size(56, 24);
            this.lblSehir.TabIndex = 21;
            this.lblSehir.Text = "Şehir";
            // 
            // lblSirketAdi
            // 
            this.lblSirketAdi.AutoSize = true;
            this.lblSirketAdi.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lblSirketAdi.Location = new System.Drawing.Point(8, 5);
            this.lblSirketAdi.Name = "lblSirketAdi";
            this.lblSirketAdi.Size = new System.Drawing.Size(101, 24);
            this.lblSirketAdi.TabIndex = 20;
            this.lblSirketAdi.Text = "Şirket Adı";
            // 
            // lblWebSite
            // 
            this.lblWebSite.AutoSize = true;
            this.lblWebSite.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lblWebSite.Location = new System.Drawing.Point(8, 162);
            this.lblWebSite.Name = "lblWebSite";
            this.lblWebSite.Size = new System.Drawing.Size(97, 24);
            this.lblWebSite.TabIndex = 26;
            this.lblWebSite.Text = "Web Site";
            // 
            // lblCalisma
            // 
            this.lblCalisma.AutoSize = true;
            this.lblCalisma.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lblCalisma.Location = new System.Drawing.Point(8, 203);
            this.lblCalisma.Name = "lblCalisma";
            this.lblCalisma.Size = new System.Drawing.Size(173, 24);
            this.lblCalisma.TabIndex = 27;
            this.lblCalisma.Text = "Çalışma Saatleri";
            // 
            // pnlOzellikler
            // 
            this.pnlOzellikler.Controls.Add(this.lblSirketAdi);
            this.pnlOzellikler.Controls.Add(this.bunifuSeparator1);
            this.pnlOzellikler.Controls.Add(this.lblSehir);
            this.pnlOzellikler.Controls.Add(this.bunifuSeparator2);
            this.pnlOzellikler.Controls.Add(this.lblAdres);
            this.pnlOzellikler.Controls.Add(this.bunifuSeparator3);
            this.pnlOzellikler.Controls.Add(this.lblTelefon);
            this.pnlOzellikler.Controls.Add(this.bunifuSeparator4);
            this.pnlOzellikler.Controls.Add(this.lblWebSite);
            this.pnlOzellikler.Controls.Add(this.bunifuSeparator5);
            this.pnlOzellikler.Controls.Add(this.lblCalisma);
            this.pnlOzellikler.Controls.Add(this.bunifuSeparator6);
            this.pnlOzellikler.Controls.Add(this.chckMotorlu);
            this.pnlOzellikler.Controls.Add(this.bunifuSeparator7);
            this.pnlOzellikler.Controls.Add(this.chckUcakli);
            this.pnlOzellikler.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlOzellikler.Location = new System.Drawing.Point(320, 30);
            this.pnlOzellikler.Name = "pnlOzellikler";
            this.pnlOzellikler.Padding = new System.Windows.Forms.Padding(5);
            this.pnlOzellikler.Size = new System.Drawing.Size(463, 339);
            this.pnlOzellikler.TabIndex = 28;
            this.pnlOzellikler.WrapContents = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(8, 32);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(447, 11);
            this.bunifuSeparator1.TabIndex = 28;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 2;
            this.bunifuSeparator2.Location = new System.Drawing.Point(8, 73);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(447, 11);
            this.bunifuSeparator2.TabIndex = 29;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 2;
            this.bunifuSeparator3.Location = new System.Drawing.Point(8, 107);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(447, 11);
            this.bunifuSeparator3.TabIndex = 30;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator4.LineThickness = 2;
            this.bunifuSeparator4.Location = new System.Drawing.Point(8, 148);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(447, 11);
            this.bunifuSeparator4.TabIndex = 31;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = false;
            // 
            // bunifuSeparator5
            // 
            this.bunifuSeparator5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator5.LineThickness = 2;
            this.bunifuSeparator5.Location = new System.Drawing.Point(8, 189);
            this.bunifuSeparator5.Name = "bunifuSeparator5";
            this.bunifuSeparator5.Size = new System.Drawing.Size(447, 11);
            this.bunifuSeparator5.TabIndex = 32;
            this.bunifuSeparator5.Transparency = 255;
            this.bunifuSeparator5.Vertical = false;
            // 
            // bunifuSeparator6
            // 
            this.bunifuSeparator6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator6.LineThickness = 2;
            this.bunifuSeparator6.Location = new System.Drawing.Point(8, 230);
            this.bunifuSeparator6.Name = "bunifuSeparator6";
            this.bunifuSeparator6.Size = new System.Drawing.Size(447, 11);
            this.bunifuSeparator6.TabIndex = 33;
            this.bunifuSeparator6.Transparency = 255;
            this.bunifuSeparator6.Vertical = false;
            // 
            // chckMotorlu
            // 
            this.chckMotorlu.AutoCheck = false;
            this.chckMotorlu.AutoSize = true;
            this.chckMotorlu.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.chckMotorlu.Location = new System.Drawing.Point(8, 247);
            this.chckMotorlu.Name = "chckMotorlu";
            this.chckMotorlu.Size = new System.Drawing.Size(169, 28);
            this.chckMotorlu.TabIndex = 6;
            this.chckMotorlu.Text = "Motorlu Kurye";
            this.chckMotorlu.UseVisualStyleBackColor = true;
            // 
            // bunifuSeparator7
            // 
            this.bunifuSeparator7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator7.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator7.LineThickness = 2;
            this.bunifuSeparator7.Location = new System.Drawing.Point(8, 281);
            this.bunifuSeparator7.Name = "bunifuSeparator7";
            this.bunifuSeparator7.Size = new System.Drawing.Size(447, 11);
            this.bunifuSeparator7.TabIndex = 36;
            this.bunifuSeparator7.Transparency = 255;
            this.bunifuSeparator7.Vertical = false;
            // 
            // chckUcakli
            // 
            this.chckUcakli.AutoCheck = false;
            this.chckUcakli.AutoSize = true;
            this.chckUcakli.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.chckUcakli.Location = new System.Drawing.Point(8, 298);
            this.chckUcakli.Name = "chckUcakli";
            this.chckUcakli.Size = new System.Drawing.Size(153, 28);
            this.chckUcakli.TabIndex = 7;
            this.chckUcakli.Text = "Uçaklı Kurye";
            this.chckUcakli.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 378);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 273);
            this.tabControl1.TabIndex = 29;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlYorumlar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 247);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Yorumlar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlYorumlar
            // 
            this.pnlYorumlar.AutoScroll = true;
            this.pnlYorumlar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlYorumlar.Location = new System.Drawing.Point(7, 7);
            this.pnlYorumlar.Name = "pnlYorumlar";
            this.pnlYorumlar.Size = new System.Drawing.Size(756, 234);
            this.pnlYorumlar.TabIndex = 0;
            this.pnlYorumlar.WrapContents = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnYorumuGönder);
            this.tabPage2.Controls.Add(this.txtYorum);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.rtngPuanYorum);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtBaslik);
            this.tabPage2.Controls.Add(this.txtSoyad);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtAd);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 247);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Yorum Ekle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnYorumuGönder
            // 
            this.btnYorumuGönder.ActiveBorderThickness = 1;
            this.btnYorumuGönder.ActiveCornerRadius = 20;
            this.btnYorumuGönder.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnYorumuGönder.ActiveForecolor = System.Drawing.Color.White;
            this.btnYorumuGönder.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnYorumuGönder.BackColor = System.Drawing.Color.Transparent;
            this.btnYorumuGönder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYorumuGönder.BackgroundImage")));
            this.btnYorumuGönder.ButtonText = "Yorumu Gönder";
            this.btnYorumuGönder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYorumuGönder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYorumuGönder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnYorumuGönder.IdleBorderThickness = 1;
            this.btnYorumuGönder.IdleCornerRadius = 20;
            this.btnYorumuGönder.IdleFillColor = System.Drawing.Color.White;
            this.btnYorumuGönder.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnYorumuGönder.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnYorumuGönder.Location = new System.Drawing.Point(7, 198);
            this.btnYorumuGönder.Margin = new System.Windows.Forms.Padding(5);
            this.btnYorumuGönder.Name = "btnYorumuGönder";
            this.btnYorumuGönder.Size = new System.Drawing.Size(751, 41);
            this.btnYorumuGönder.TabIndex = 5;
            this.btnYorumuGönder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnYorumuGönder.Click += new System.EventHandler(this.btnYorumuGönder_Click);
            // 
            // txtYorum
            // 
            this.txtYorum.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtYorum.Location = new System.Drawing.Point(99, 84);
            this.txtYorum.Name = "txtYorum";
            this.txtYorum.Size = new System.Drawing.Size(651, 106);
            this.txtYorum.TabIndex = 4;
            this.txtYorum.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label6.Location = new System.Drawing.Point(3, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Yorum : ";
            // 
            // rtngPuanYorum
            // 
            this.rtngPuanYorum.BackColor = System.Drawing.Color.Transparent;
            this.rtngPuanYorum.ForeColor = System.Drawing.Color.SeaGreen;
            this.rtngPuanYorum.Location = new System.Drawing.Point(610, 10);
            this.rtngPuanYorum.Name = "rtngPuanYorum";
            this.rtngPuanYorum.Size = new System.Drawing.Size(140, 30);
            this.rtngPuanYorum.TabIndex = 9;
            this.rtngPuanYorum.Value = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label5.Location = new System.Drawing.Point(542, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Puan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label4.Location = new System.Drawing.Point(14, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Başlık : ";
            // 
            // txtBaslik
            // 
            this.txtBaslik.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtBaslik.Location = new System.Drawing.Point(99, 45);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(651, 33);
            this.txtBaslik.TabIndex = 3;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtSoyad.Location = new System.Drawing.Point(384, 7);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(152, 33);
            this.txtSoyad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label2.Location = new System.Drawing.Point(256, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soyadınız : ";
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtAd.Location = new System.Drawing.Point(99, 6);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(150, 33);
            this.txtAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adınız : ";
            // 
            // DetayEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 663);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnlOzellikler);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.rtngPuanGöster);
            this.Controls.Add(this.imgResim);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetayEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetayEkran";
            this.Load += new System.EventHandler(this.DetayEkran_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgResim)).EndInit();
            this.pnlOzellikler.ResumeLayout(false);
            this.pnlOzellikler.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox imgResim;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblTelefon;
        private Bunifu.Framework.UI.BunifuRating rtngPuanGöster;
        private System.Windows.Forms.Label lblSehir;
        private System.Windows.Forms.Label lblSirketAdi;
        private System.Windows.Forms.Label lblWebSite;
        private System.Windows.Forms.Label lblCalisma;
        private System.Windows.Forms.FlowLayoutPanel pnlOzellikler;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator5;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator6;
        private System.Windows.Forms.CheckBox chckMotorlu;
        private System.Windows.Forms.CheckBox chckUcakli;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBaslik;
        private Bunifu.Framework.UI.BunifuRating rtngPuanYorum;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnYorumuGönder;
        private System.Windows.Forms.RichTextBox txtYorum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel pnlYorumlar;
    }
}