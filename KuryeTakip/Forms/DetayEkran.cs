using KuryeTakip.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuryeTakip.Forms
{
    public partial class DetayEkran : Form
    {
        public DetayEkran()
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

        SqlConnection sqlBağ = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=|DataDirectory|KuryeVT.mdf;");
        SqlCommand sqlKomutu;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        } //ÇIKIŞ

        private void DetayEkran_Load(object sender, EventArgs e)
        {
            if (sqlBağ.State == System.Data.ConnectionState.Closed)
                sqlBağ.Open();

            BilgileriGetir();

            YorumYükle();
            
            if (sqlBağ.State == System.Data.ConnectionState.Open)
                sqlBağ.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                if (sqlBağ.State == System.Data.ConnectionState.Closed)
                    sqlBağ.Open();

                YorumYükle();

                if (sqlBağ.State == System.Data.ConnectionState.Open)
                    sqlBağ.Close();
            }
        }

        private void btnYorumuGönder_Click(object sender, EventArgs e)
        {
            if (sqlBağ.State == System.Data.ConnectionState.Closed)
                sqlBağ.Open();

            YorumEkle();

            if (sqlBağ.State == System.Data.ConnectionState.Open)
                sqlBağ.Close();
        }

        private void YorumYükle()
        {
            pnlYorumlar.Controls.Clear();

            sqlKomutu = new SqlCommand("SELECT * FROM Yorumlar WHERE Sirket_ID = @Id", sqlBağ);
            sqlKomutu.Parameters.AddWithValue(@"Id", this.Tag);
            SqlDataReader drv2 = sqlKomutu.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(drv2);

            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                YorumSatir yS = new YorumSatir();
                yS.lblAciklama.Text = dt2.Rows[i]["Aciklama"].ToString();
                yS.lblAd.Text = dt2.Rows[i]["Ad"].ToString();
                yS.lblSoyad.Text = dt2.Rows[i]["Soyad"].ToString();
                yS.lblBaslik.Text = dt2.Rows[i]["Baslik"].ToString();
                yS.lblTarih.Text = (dt2.Rows[i]["Tarih"]).ToString();
                yS.rtngPuan.Value = int.Parse(dt2.Rows[i]["Puan"].ToString());
                pnlYorumlar.Controls.Add(yS);
                pnlYorumlar.Controls.Add(new Bunifu.Framework.UI.BunifuSeparator() { Width = 800 });
            }
        }

        private void YorumEkle()
        {
            sqlKomutu = new SqlCommand("INSERT INTO [Yorumlar] VALUES(@Baslik, @Aciklama, @Ad, @Soyad, @Tarih, @Puan, @Sirket_ID)", sqlBağ);
            sqlKomutu.Parameters.AddWithValue(@"Baslik", txtBaslik.Text);
            sqlKomutu.Parameters.AddWithValue(@"Aciklama", txtYorum.Text);
            sqlKomutu.Parameters.AddWithValue(@"Ad", txtAd.Text);
            sqlKomutu.Parameters.AddWithValue(@"Soyad", txtSoyad.Text);
            sqlKomutu.Parameters.AddWithValue(@"Tarih", DateTime.Now);
            sqlKomutu.Parameters.AddWithValue(@"Puan", rtngPuanYorum.Value);
            sqlKomutu.Parameters.AddWithValue(@"Sirket_ID", this.Tag);
            sqlKomutu.ExecuteNonQuery();
            MessageBox.Show("Yorumunuz Eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtAd.Text = "";
            txtBaslik.Text = "";
            txtYorum.Text = "";
            txtSoyad.Text = "";
            rtngPuanYorum.Value = 0;
            BilgileriGetir();
        }

        private void BilgileriGetir()
        {
            sqlKomutu = new SqlCommand("SELECT s.Resim,s.Aciklama,s.Sirket_Adi,s.Calisma_Saat_Bas,s.Calisma_Saat_Bit,s.Motorlu_Kurye,s.Web_Site,s.Ucakli_Kurye,s.Adres,s2.Sehir_Adi,s.Telefon,s.KonumX,s.KonumY FROM Sirketler s INNER JOIN Sehirler s2 ON s.SehirID = s2.ID WHERE s.ID = @Id", sqlBağ);
            sqlKomutu.Parameters.AddWithValue(@"Id", this.Tag);
            SqlDataReader drv = sqlKomutu.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(drv);

            sqlKomutu = new SqlCommand("SELECT AVG(y.Puan) as [Puan],s.ID FROM Sirketler s INNER JOIN Yorumlar y ON s.ID = y.Sirket_Id GROUP BY s.ID", sqlBağ);
            SqlDataReader drv2 = sqlKomutu.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(drv2);

            lblAdres.Text = dt.Rows[0]["Adres"].ToString();
            lblCalisma.Text = dt.Rows[0]["Calisma_Saat_Bas"].ToString() + " : " + dt.Rows[0]["Calisma_Saat_Bit"].ToString();
            if (dt.Rows[0]["Motorlu_Kurye"].ToString() == "True")
            {
                chckMotorlu.Checked = true;
            }
            if (dt.Rows[0]["Ucakli_Kurye"].ToString() == "True")
            {
                chckUcakli.Checked = true;
            }
            lblSirketAdi.Text = dt.Rows[0]["Sirket_Adi"].ToString();
            lblSehir.Text = dt.Rows[0]["Sehir_Adi"].ToString();
            lblTelefon.Text = dt.Rows[0]["Telefon"].ToString();
            lblWebSite.Text = dt.Rows[0]["Web_Site"].ToString();
            MemoryStream ms = new MemoryStream((byte[])dt.Rows[0]["Resim"]);
            imgResim.Image = Image.FromStream(ms);

            try
            {
                rtngPuanGöster.Value = int.Parse(dt2.Rows[0]["Puan"].ToString());
            }
            catch (Exception)
            {
            }
        }

    }
}
