namespace KuryeTakip
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSirket = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDiger = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnIstatistik = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdminLog = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelEkran = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.menuPanel.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1073, 24);
            this.panel1.TabIndex = 8;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(498, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Admin Panel";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1050, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.btnSirket);
            this.menuPanel.Controls.Add(this.btnDiger);
            this.menuPanel.Controls.Add(this.btnIstatistik);
            this.menuPanel.Controls.Add(this.btnAdminLog);
            this.menuPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.menuPanel.Location = new System.Drawing.Point(13, 31);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(258, 456);
            this.menuPanel.TabIndex = 9;
            this.menuPanel.WrapContents = false;
            // 
            // btnSirket
            // 
            this.btnSirket.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSirket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSirket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSirket.BorderRadius = 0;
            this.btnSirket.ButtonText = "Şirket Tablosu";
            this.btnSirket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSirket.DisabledColor = System.Drawing.Color.Gray;
            this.btnSirket.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSirket.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSirket.Iconimage")));
            this.btnSirket.Iconimage_right = null;
            this.btnSirket.Iconimage_right_Selected = null;
            this.btnSirket.Iconimage_Selected = null;
            this.btnSirket.IconMarginLeft = 0;
            this.btnSirket.IconMarginRight = 0;
            this.btnSirket.IconRightVisible = true;
            this.btnSirket.IconRightZoom = 0D;
            this.btnSirket.IconVisible = true;
            this.btnSirket.IconZoom = 90D;
            this.btnSirket.IsTab = false;
            this.btnSirket.Location = new System.Drawing.Point(3, 3);
            this.btnSirket.Name = "btnSirket";
            this.btnSirket.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSirket.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSirket.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSirket.selected = false;
            this.btnSirket.Size = new System.Drawing.Size(255, 48);
            this.btnSirket.TabIndex = 0;
            this.btnSirket.Text = "Şirket Tablosu";
            this.btnSirket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSirket.Textcolor = System.Drawing.Color.White;
            this.btnSirket.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSirket.Click += new System.EventHandler(this.btnSirket_Click);
            // 
            // btnDiger
            // 
            this.btnDiger.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDiger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDiger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDiger.BorderRadius = 0;
            this.btnDiger.ButtonText = "Diğer Tablolar";
            this.btnDiger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiger.DisabledColor = System.Drawing.Color.Gray;
            this.btnDiger.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDiger.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDiger.Iconimage")));
            this.btnDiger.Iconimage_right = null;
            this.btnDiger.Iconimage_right_Selected = null;
            this.btnDiger.Iconimage_Selected = null;
            this.btnDiger.IconMarginLeft = 0;
            this.btnDiger.IconMarginRight = 0;
            this.btnDiger.IconRightVisible = true;
            this.btnDiger.IconRightZoom = 0D;
            this.btnDiger.IconVisible = true;
            this.btnDiger.IconZoom = 90D;
            this.btnDiger.IsTab = false;
            this.btnDiger.Location = new System.Drawing.Point(3, 57);
            this.btnDiger.Name = "btnDiger";
            this.btnDiger.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDiger.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDiger.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDiger.selected = false;
            this.btnDiger.Size = new System.Drawing.Size(255, 48);
            this.btnDiger.TabIndex = 3;
            this.btnDiger.Text = "Diğer Tablolar";
            this.btnDiger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiger.Textcolor = System.Drawing.Color.White;
            this.btnDiger.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiger.Click += new System.EventHandler(this.btnDiger_Click);
            // 
            // btnIstatistik
            // 
            this.btnIstatistik.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnIstatistik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIstatistik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIstatistik.BorderRadius = 0;
            this.btnIstatistik.ButtonText = "İstatistik Gör";
            this.btnIstatistik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIstatistik.DisabledColor = System.Drawing.Color.Gray;
            this.btnIstatistik.Iconcolor = System.Drawing.Color.Transparent;
            this.btnIstatistik.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnIstatistik.Iconimage")));
            this.btnIstatistik.Iconimage_right = null;
            this.btnIstatistik.Iconimage_right_Selected = null;
            this.btnIstatistik.Iconimage_Selected = null;
            this.btnIstatistik.IconMarginLeft = 0;
            this.btnIstatistik.IconMarginRight = 0;
            this.btnIstatistik.IconRightVisible = true;
            this.btnIstatistik.IconRightZoom = 0D;
            this.btnIstatistik.IconVisible = true;
            this.btnIstatistik.IconZoom = 90D;
            this.btnIstatistik.IsTab = false;
            this.btnIstatistik.Location = new System.Drawing.Point(3, 111);
            this.btnIstatistik.Name = "btnIstatistik";
            this.btnIstatistik.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIstatistik.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnIstatistik.OnHoverTextColor = System.Drawing.Color.White;
            this.btnIstatistik.selected = false;
            this.btnIstatistik.Size = new System.Drawing.Size(255, 48);
            this.btnIstatistik.TabIndex = 1;
            this.btnIstatistik.Text = "İstatistik Gör";
            this.btnIstatistik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIstatistik.Textcolor = System.Drawing.Color.White;
            this.btnIstatistik.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnAdminLog
            // 
            this.btnAdminLog.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAdminLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdminLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdminLog.BorderRadius = 0;
            this.btnAdminLog.ButtonText = "Admin Log Gör";
            this.btnAdminLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminLog.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdminLog.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdminLog.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAdminLog.Iconimage")));
            this.btnAdminLog.Iconimage_right = null;
            this.btnAdminLog.Iconimage_right_Selected = null;
            this.btnAdminLog.Iconimage_Selected = null;
            this.btnAdminLog.IconMarginLeft = 0;
            this.btnAdminLog.IconMarginRight = 0;
            this.btnAdminLog.IconRightVisible = true;
            this.btnAdminLog.IconRightZoom = 0D;
            this.btnAdminLog.IconVisible = true;
            this.btnAdminLog.IconZoom = 90D;
            this.btnAdminLog.IsTab = false;
            this.btnAdminLog.Location = new System.Drawing.Point(3, 165);
            this.btnAdminLog.Name = "btnAdminLog";
            this.btnAdminLog.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdminLog.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAdminLog.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdminLog.selected = false;
            this.btnAdminLog.Size = new System.Drawing.Size(255, 48);
            this.btnAdminLog.TabIndex = 2;
            this.btnAdminLog.Text = "Admin Log Gör";
            this.btnAdminLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminLog.Textcolor = System.Drawing.Color.White;
            this.btnAdminLog.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminLog.Click += new System.EventHandler(this.btnAdminLog_Click);
            // 
            // panelEkran
            // 
            this.panelEkran.Location = new System.Drawing.Point(278, 31);
            this.panelEkran.Name = "panelEkran";
            this.panelEkran.Size = new System.Drawing.Size(783, 456);
            this.panelEkran.TabIndex = 10;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 499);
            this.Controls.Add(this.panelEkran);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel menuPanel;
        private System.Windows.Forms.Panel panelEkran;
        private Bunifu.Framework.UI.BunifuFlatButton btnSirket;
        private Bunifu.Framework.UI.BunifuFlatButton btnDiger;
        private Bunifu.Framework.UI.BunifuFlatButton btnIstatistik;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdminLog;
    }
}