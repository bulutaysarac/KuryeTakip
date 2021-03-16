namespace KuryeTakip
{
    partial class KonumEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KonumEkran));
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKendiKonumum = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.btnSunucu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGelenKonum = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.txtSinir = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(12, 30);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 20;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(802, 526);
            this.gMapControl1.TabIndex = 24;
            this.gMapControl1.Zoom = 16D;
            this.gMapControl1.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gMapControl1_OnMarkerClick);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(9, 597);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Y :  ";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 575);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "X : ";
            // 
            // btnKendiKonumum
            // 
            this.btnKendiKonumum.ActiveBorderThickness = 1;
            this.btnKendiKonumum.ActiveCornerRadius = 20;
            this.btnKendiKonumum.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnKendiKonumum.ActiveForecolor = System.Drawing.Color.White;
            this.btnKendiKonumum.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnKendiKonumum.BackColor = System.Drawing.SystemColors.Control;
            this.btnKendiKonumum.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKendiKonumum.BackgroundImage")));
            this.btnKendiKonumum.ButtonText = "Kendi Konumumdan Bul";
            this.btnKendiKonumum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKendiKonumum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKendiKonumum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnKendiKonumum.IdleBorderThickness = 1;
            this.btnKendiKonumum.IdleCornerRadius = 20;
            this.btnKendiKonumum.IdleFillColor = System.Drawing.Color.White;
            this.btnKendiKonumum.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnKendiKonumum.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnKendiKonumum.Location = new System.Drawing.Point(415, 575);
            this.btnKendiKonumum.Margin = new System.Windows.Forms.Padding(5);
            this.btnKendiKonumum.Name = "btnKendiKonumum";
            this.btnKendiKonumum.Size = new System.Drawing.Size(399, 37);
            this.btnKendiKonumum.TabIndex = 23;
            this.btnKendiKonumum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKendiKonumum.Click += new System.EventHandler(this.btnKendiKonumum_Click);
            // 
            // txtY
            // 
            this.txtY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtY.Location = new System.Drawing.Point(35, 598);
            this.txtY.Name = "txtY";
            this.txtY.ReadOnly = true;
            this.txtY.Size = new System.Drawing.Size(100, 13);
            this.txtY.TabIndex = 32;
            // 
            // txtX
            // 
            this.txtX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtX.Location = new System.Drawing.Point(35, 576);
            this.txtX.Name = "txtX";
            this.txtX.ReadOnly = true;
            this.txtX.Size = new System.Drawing.Size(100, 13);
            this.txtX.TabIndex = 31;
            // 
            // btnSunucu
            // 
            this.btnSunucu.Location = new System.Drawing.Point(415, 620);
            this.btnSunucu.Name = "btnSunucu";
            this.btnSunucu.Size = new System.Drawing.Size(177, 23);
            this.btnSunucu.TabIndex = 34;
            this.btnSunucu.Text = "Konumu Mobilden Al";
            this.btnSunucu.UseVisualStyleBackColor = true;
            this.btnSunucu.Click += new System.EventHandler(this.btnSunucu_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(803, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 24);
            this.panel1.TabIndex = 35;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(371, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kurye Şirket Portal";
            // 
            // txtGelenKonum
            // 
            this.txtGelenKonum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGelenKonum.Location = new System.Drawing.Point(598, 625);
            this.txtGelenKonum.Name = "txtGelenKonum";
            this.txtGelenKonum.ReadOnly = true;
            this.txtGelenKonum.Size = new System.Drawing.Size(156, 13);
            this.txtGelenKonum.TabIndex = 36;
            this.txtGelenKonum.TextChanged += new System.EventHandler(this.txtGelenKonum_TextChanged);
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(760, 620);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(53, 23);
            this.btnBul.TabIndex = 37;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // txtSinir
            // 
            this.txtSinir.Location = new System.Drawing.Point(374, 622);
            this.txtSinir.Name = "txtSinir";
            this.txtSinir.Size = new System.Drawing.Size(31, 20);
            this.txtSinir.TabIndex = 38;
            this.txtSinir.Text = "30";
            // 
            // KonumEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 649);
            this.Controls.Add(this.txtSinir);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.txtGelenKonum);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSunucu);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnKendiKonumum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KonumEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KonumEkran";
            this.Load += new System.EventHandler(this.KonumEkran_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuThinButton2 btnKendiKonumum;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Button btnSunucu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtGelenKonum;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.TextBox txtSinir;
    }
}