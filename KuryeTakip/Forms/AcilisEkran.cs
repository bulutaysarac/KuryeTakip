using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuryeTakip
{

    public partial class AcilisEkran : Form
    {
        public AcilisEkran()
        {
            InitializeComponent();
        }
        SqlConnection sqlBağ = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=|DataDirectory|KuryeVT.mdf;");
        Timer timer1;
        public bool adm = false;
        #region TaşımaBileşeni
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } //ÇIKIŞ

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            timer1 = new Timer() { Interval = 3000 };

            Bunifu.Framework.UI.BunifuTileButton btn = (Bunifu.Framework.UI.BunifuTileButton)sender;
            btn.Visible = false;
            rsmAnimasyon2.Visible = true;
            timer1.Tick += Timer1_Tick;
            timer1.Start();
            btnNormalGiris.Enabled = false;
            adm = true;
        } //Admin Giriş

        private void btnNormalGiris_Click(object sender, EventArgs e)
        {
            timer1 = new Timer() { Interval = 3000 };

            Bunifu.Framework.UI.BunifuTileButton btn = (Bunifu.Framework.UI.BunifuTileButton)sender;
            btn.Visible = false;
            rsmAnimasyon.Visible = true;
            timer1.Tick += Timer1_Tick;
            timer1.Start();
            btnAdminGiris.Enabled = false;
        } //Normal Giriş

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            if (adm)
            {
                AdminGirisEkran adminGiris = new AdminGirisEkran() { Owner = this };
                adminGiris.Show();
                this.Hide();
            }
            else
            {
                AnaEkran ekran = new AnaEkran() { Owner = this };
                ekran.Show();
                this.Hide();
            }
        } //Bekleme Efekti

        private void AcilisEkran_Load(object sender, EventArgs e)
        {
            sqlBağ.Open();//İLK SQL  BAĞLANTISI BURDA BİR DAHAKİ İŞLEMLERDE BEKLEME SÜRESİ FAZLA OLSMASIN DİYE.
            sqlBağ.Close();
        }
    }
}
