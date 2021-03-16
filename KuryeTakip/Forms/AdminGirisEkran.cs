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
    public partial class AdminGirisEkran : Form
    {
        public AdminGirisEkran()
        {
            InitializeComponent();
        }

        #region TaşımaBileşeni

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        Timer timer1;
        SqlConnection sqlBağ = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=|DataDirectory|KuryeVT.mdf;");
        SqlCommand sqlKomutu;

        private void SifreKontrol()
        {
            timer1 = new Timer() { Interval = 3000 };
            timer1.Tick += Timer1_Tick;
            try
            {
                if (sqlBağ.State == System.Data.ConnectionState.Closed)
                    sqlBağ.Open();

                sqlKomutu = new SqlCommand("SELECT * FROM Adminler WHERE Kullanici_Adi = @Kullanici_Adi AND Sifre = @Sifre", sqlBağ);
                sqlKomutu.Parameters.AddWithValue(@"Kullanici_Adi", txtKulAdi.Text);
                sqlKomutu.Parameters.AddWithValue(@"Sifre", txtSifre.Text);
                SqlDataReader drv = sqlKomutu.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(drv);

                if (dt.Rows.Count > 0)
                {
                    timer1.Start();
                    OrtakVeri.AdminID = int.Parse(dt.Rows[0]["ID"].ToString());
                    btnGiris.Visible = false;
                    pictureBox1.Visible = true;
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (sqlBağ.State == System.Data.ConnectionState.Open)
                    sqlBağ.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        } //GİRİŞ SQL SORGU

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            AdminPanel admP = new AdminPanel() { Owner = this };
            admP.Show();
            this.Hide();
        } //GİRİŞ EFEKTİ

        private void button1_Click(object sender, EventArgs e)
        {
            AcilisEkran aclE = (AcilisEkran)this.Owner;
            aclE.rsmAnimasyon.Visible = false;
            aclE.rsmAnimasyon2.Visible = false;
            aclE.btnAdminGiris.Visible = true;
            aclE.btnNormalGiris.Visible = true;
            aclE.btnAdminGiris.Enabled = true;
            aclE.btnNormalGiris.Enabled = true;
            aclE.adm = false;
            aclE.Show();
            this.Close();
        } //ÇIKIŞ

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SifreKontrol();
        } //BTN GİRİŞ

        private void txtSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SifreKontrol();
            }
        } //ENTER İLE GİRİŞ
    }
}
