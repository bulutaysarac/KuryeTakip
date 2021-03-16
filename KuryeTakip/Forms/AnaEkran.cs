using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Device.Location;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode;
using System.Data.SqlClient;
using KuryeTakip.UserControls;
using System.IO;

namespace KuryeTakip
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
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
        ListeEleman lE;
        Image imgResim;
        Image imgResim2;
        QRCodeEncoder code = new QRCodeEncoder();

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            OrtakVeri.ekran = this;
        }

        private void btnHaritada_Click(object sender, EventArgs e)
        {
            KonumEkran knmE = new KonumEkran() { Owner = this };
            knmE.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AcilisEkran aclE = (AcilisEkran)this.Owner;
            aclE.rsmAnimasyon.Visible = false;
            aclE.rsmAnimasyon2.Visible = false;
            aclE.btnAdminGiris.Visible = true;
            aclE.btnNormalGiris.Visible = true;
            aclE.btnAdminGiris.Enabled = true;
            aclE.btnNormalGiris.Enabled = true;
            aclE.Show();
            this.Close();
        } //ÇIKIŞ

        private void btnTumunuListele_Click(object sender, EventArgs e)
        {
            BilgileriGetir();
        }

        private void btnSehireGore_Click(object sender, EventArgs e)
        {
            pnlListe.Controls.Clear();

            if (sqlBağ.State == System.Data.ConnectionState.Closed)
                sqlBağ.Open();

            sqlKomutu = new SqlCommand("SELECT s.ID as [SirketIDD],s.Resim,s.Adres,s2.Sehir_Adi,s.Sirket_Adi,s.Telefon,s.KonumX,s.KonumY FROM Sirketler s INNER JOIN Sehirler s2 ON s.SehirID = s2.ID WHERE s.SehirID = @SehirID", sqlBağ);
            sqlKomutu.Parameters.AddWithValue(@"SehirID", cmbSehir.SelectedIndex + 1);
            SqlDataReader drv = sqlKomutu.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(drv);


            sqlKomutu = new SqlCommand("SELECT AVG(y.Puan) as [Puan],s.ID FROM Sirketler s INNER JOIN Yorumlar y ON s.ID = y.Sirket_Id WHERE s.SehirID = @SehirID GROUP BY s.ID", sqlBağ);
            sqlKomutu.Parameters.AddWithValue(@"SehirID", cmbSehir.SelectedIndex + 1);
            SqlDataReader drv2 = sqlKomutu.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(drv2);


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lE = new ListeEleman();
                lE.lblAdres.Text = dt.Rows[i]["Adres"].ToString();
                lE.lblSehir.Text = dt.Rows[i]["Sehir_Adi"].ToString();
                lE.lblSirketAdi.Text = dt.Rows[i]["Sirket_Adi"].ToString();
                lE.lblTelefon.Text = dt.Rows[i]["Telefon"].ToString();
                imgResim2 = code.Encode("TEL:" + dt.Rows[i]["Telefon"].ToString());
                lE.imgQRCode.Image = imgResim2;
                lE.btnDetayli.Tag = dt.Rows[i]["SirketIDD"].ToString();
                lE.Tag = dt.Rows[i]["KonumX"].ToString() + "|" + dt.Rows[i]["KonumY"].ToString() + "|" + dt.Rows[i]["SirketIDD"].ToString();

                try
                {
                    lE.rtngPuan.Value = int.Parse(dt2.Rows[i]["Puan"].ToString());
                }
                catch (Exception)
                {
                }

                MemoryStream ms = new MemoryStream((byte[])dt.Rows[i]["Resim"]);
                lE.imgResim.Image = Image.FromStream(ms);
                lE.Tag = dt.Rows[i]["KonumX"].ToString() + "|" + dt.Rows[i]["KonumY"].ToString() + "|" + dt.Rows[i]["SirketIDD"].ToString();

                pnlListe.Controls.Add(lE);
                pnlListe.Controls.Add(new Bunifu.Framework.UI.BunifuSeparator() { Width = 800 });
            }

            if (sqlBağ.State == System.Data.ConnectionState.Open)
                sqlBağ.Close();
        }

        public void BilgileriGetir()
        {
            pnlListe.Controls.Clear();


            if (sqlBağ.State == System.Data.ConnectionState.Closed)
                sqlBağ.Open();

            sqlKomutu = new SqlCommand("SELECT s.ID as [SirketIDD],s.Resim,s.Adres,s2.Sehir_Adi,s.Sirket_Adi,s.Telefon,s.KonumX,s.KonumY FROM Sirketler s INNER JOIN Sehirler s2 ON s.SehirID = s2.ID", sqlBağ);
            SqlDataReader drv = sqlKomutu.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(drv);

            sqlKomutu = new SqlCommand("SELECT AVG(y.Puan) as [Puan],s.ID FROM Sirketler s INNER JOIN Yorumlar y ON s.ID = y.Sirket_Id GROUP BY s.ID", sqlBağ);
            SqlDataReader drv2 = sqlKomutu.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(drv2);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lE = new ListeEleman();
                lE.lblAdres.Text = dt.Rows[i]["Adres"].ToString();
                lE.lblSehir.Text = dt.Rows[i]["Sehir_Adi"].ToString();
                lE.lblSirketAdi.Text = dt.Rows[i]["Sirket_Adi"].ToString();
                lE.lblTelefon.Text = dt.Rows[i]["Telefon"].ToString();
                imgResim = code.Encode("TEL:" + dt.Rows[i]["Telefon"].ToString());
                lE.imgQRCode.Image = imgResim;
                lE.btnDetayli.Tag = dt.Rows[i]["SirketIDD"].ToString();

                try
                {
                    lE.rtngPuan.Value = int.Parse(dt2.Rows[i]["Puan"].ToString());
                }
                catch (Exception)
                {
                }

                MemoryStream ms = new MemoryStream((byte[])dt.Rows[i]["Resim"]);
                lE.imgResim.Image = Image.FromStream(ms);
                lE.Tag = dt.Rows[i]["KonumX"].ToString() + "|" + dt.Rows[i]["KonumY"].ToString() + "|" + dt.Rows[i]["SirketIDD"].ToString();
                pnlListe.Controls.Add(lE);
                pnlListe.Controls.Add(new Bunifu.Framework.UI.BunifuSeparator() { Width = 800 });

            }

            if (sqlBağ.State == System.Data.ConnectionState.Open)
                sqlBağ.Close();
        }
    }
}
