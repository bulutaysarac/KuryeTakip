using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace KuryeTakip.UserControls
{
    public partial class AdminPanelSirket : UserControl
    {
        public AdminPanelSirket()
        {
            InitializeComponent();
        }
        SqlConnection sqlBağ = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=|DataDirectory|KuryeVT.mdf;");
        SqlCommand sqlKomutu;
        int gelenID = 0;

        private void AdminPanelSirket_Load(object sender, EventArgs e)
        {
            Listele();
        }
        int secili;
        private void dgListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secili = dgListe.SelectedCells[0].RowIndex;
            chckUcak.Checked = false;
            chckMotor.Checked = false;

            gelenID = int.Parse(dgListe.Rows[secili].Cells[0].Value.ToString());
            cmbSehir1.SelectedIndex = int.Parse(dgListe.Rows[secili].Cells[1].Value.ToString()) - 1;
            txtSirketAdi.Text = dgListe.Rows[secili].Cells[2].Value.ToString();
            txtAciklama.Text = dgListe.Rows[secili].Cells[3].Value.ToString();
            txtAdres.Text = dgListe.Rows[secili].Cells[4].Value.ToString();
            txtTelefon.Text = dgListe.Rows[secili].Cells[5].Value.ToString();
            txtWebSite.Text = dgListe.Rows[secili].Cells[6].Value.ToString();
            txtKonumX.Text = dgListe.Rows[secili].Cells[7].Value.ToString();
            txtKonumY.Text = dgListe.Rows[secili].Cells[8].Value.ToString();
            if (dgListe.Rows[secili].Cells[9].Value.ToString() == "True")
            {
                chckUcak.Checked = true;
            }
            if (dgListe.Rows[secili].Cells[10].Value.ToString() == "True")
            {
                chckMotor.Checked = true;
            }
            txtCalismaBasla.Text = dgListe.Rows[secili].Cells[11].Value.ToString();
            txtCalismaBit.Text = dgListe.Rows[secili].Cells[12].Value.ToString();

            if (sqlBağ.State == System.Data.ConnectionState.Closed)
                sqlBağ.Open();

            sqlKomutu = new SqlCommand("SELECT Resim FROM Sirketler WHERE ID=@ID", sqlBağ);
            sqlKomutu.Parameters.AddWithValue(@"ID", gelenID);
            SqlDataReader drv = sqlKomutu.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(drv);

            if (sqlBağ.State == System.Data.ConnectionState.Open)
                sqlBağ.Close();


            MemoryStream ms = new MemoryStream((byte[])dt.Rows[0]["Resim"]);
            pictureBox1.Image = Image.FromStream(ms);


        }

        public byte[] ImageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
        }

        private void btnSirketEkle_Click(object sender, EventArgs e)
        {
            if (sqlBağ.State == System.Data.ConnectionState.Closed)
                sqlBağ.Open();

            sqlKomutu = new SqlCommand("INSERT INTO Sirketler VALUES(@SehirID,@Sirket_Adi,@Aciklama,@Adres,@Telefon,@WebSite,@KonumX,@KonumY,@Ucakli_Kurye,@Motorlu_Kurye,@Calisma_Saat_Bas,@Calisma_Saat_Bit,@Resim)", sqlBağ);
            sqlKomutu.Parameters.AddWithValue(@"SehirID", cmbSehir.SelectedIndex + 1);
            sqlKomutu.Parameters.AddWithValue(@"Sirket_Adi", txtSirketAdi2.Text);
            sqlKomutu.Parameters.AddWithValue(@"Aciklama", txtAciklama2.Text);
            sqlKomutu.Parameters.AddWithValue(@"Adres", txtAdres2.Text);
            sqlKomutu.Parameters.AddWithValue(@"Telefon", txtTelefon2.Text);
            sqlKomutu.Parameters.AddWithValue(@"WebSite", txtWebSite2.Text);
            sqlKomutu.Parameters.AddWithValue(@"KonumX", txtKonumX2.Text);
            sqlKomutu.Parameters.AddWithValue(@"KonumY", txtKonumY2.Text);
            sqlKomutu.Parameters.AddWithValue(@"Ucakli_Kurye", chckUcak2.Checked);
            sqlKomutu.Parameters.AddWithValue(@"Motorlu_Kurye", chckMotor2.Checked);
            sqlKomutu.Parameters.AddWithValue(@"Calisma_Saat_Bas", txtCalismaBasla2.Text);
            sqlKomutu.Parameters.AddWithValue(@"Calisma_Saat_Bit", txtCalismaBit2.Text);
            sqlKomutu.Parameters.AddWithValue(@"Resim", ImageToByteArray(imgResim));
            sqlKomutu.ExecuteNonQuery();
            MessageBox.Show("Şirket Eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);


            LogYaz("Şirket Ekleme İşlemi Yaptı.", OrtakVeri.AdminID);


            if (sqlBağ.State == System.Data.ConnectionState.Open)
                sqlBağ.Close();


            Listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (sqlBağ.State == System.Data.ConnectionState.Closed)
                sqlBağ.Open();

            sqlKomutu = new SqlCommand("UPDATE Sirketler SET SehirID = @SehirID,Sirket_Adi = @Sirket_Adi,Aciklama = @Aciklama,Adres = @Adres,Telefon = @Telefon,Web_Site = @WebSite,KonumX = @KonumX,KonumY = @KonumY,Ucakli_Kurye = @Ucakli_Kurye,Motorlu_Kurye = @Motorlu_Kurye,Calisma_Saat_Bas = @Calisma_Saat_Bas,Calisma_Saat_Bit = @Calisma_Saat_Bit,Resim = @Resim WHERE ID = @ID", sqlBağ);
            sqlKomutu.Parameters.AddWithValue(@"SehirID", cmbSehir1.SelectedIndex + 1);
            sqlKomutu.Parameters.AddWithValue(@"Sirket_Adi", txtSirketAdi.Text);
            sqlKomutu.Parameters.AddWithValue(@"Aciklama", txtAciklama.Text);
            sqlKomutu.Parameters.AddWithValue(@"Adres", txtAdres.Text);
            sqlKomutu.Parameters.AddWithValue(@"Telefon", txtTelefon.Text);
            sqlKomutu.Parameters.AddWithValue(@"WebSite", txtWebSite.Text);
            sqlKomutu.Parameters.AddWithValue(@"KonumX", txtKonumX.Text);
            sqlKomutu.Parameters.AddWithValue(@"KonumY", txtKonumY.Text);
            sqlKomutu.Parameters.AddWithValue(@"Ucakli_Kurye", chckUcak.Checked);
            sqlKomutu.Parameters.AddWithValue(@"Motorlu_Kurye", chckMotor.Checked);
            sqlKomutu.Parameters.AddWithValue(@"Calisma_Saat_Bas", txtCalismaBasla.Text);
            sqlKomutu.Parameters.AddWithValue(@"Calisma_Saat_Bit", txtCalismaBit.Text);
            sqlKomutu.Parameters.AddWithValue(@"Resim", ImageToByteArray(imgResim));
            sqlKomutu.Parameters.AddWithValue(@"ID", gelenID);
            sqlKomutu.ExecuteNonQuery();
            MessageBox.Show("Şirket Düzenlendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);



            LogYaz("Şirket Düzenleme İşlemi Yaptı.Şirket ID:" + gelenID.ToString(), OrtakVeri.AdminID);



            if (sqlBağ.State == System.Data.ConnectionState.Open)
                sqlBağ.Close();


            Listele();
        }

        private void LogYaz(string Aciklama, int AdminID)
        {
            sqlKomutu = new SqlCommand("INSERT INTO [Admin_Log] VALUES(@AdminID, @Tarih, @Aciklama)", sqlBağ);
            sqlKomutu.Parameters.AddWithValue(@"AdminID", AdminID);
            sqlKomutu.Parameters.AddWithValue(@"Tarih", DateTime.Now);
            sqlKomutu.Parameters.AddWithValue(@"Aciklama", Aciklama);
            sqlKomutu.ExecuteNonQuery();
        }

        private void Listele()
        {
            if (sqlBağ.State == System.Data.ConnectionState.Closed)
                sqlBağ.Open();

            sqlKomutu = new SqlCommand("SELECT * FROM Sirketler", sqlBağ);
            SqlDataReader drv = sqlKomutu.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(drv);
            dgListe.DataSource = dt.DefaultView;


            if (sqlBağ.State == System.Data.ConnectionState.Open)
                sqlBağ.Close();
        }
        Image imgResim;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Title = "Resim Dosyası",
                Filter = "Tüm Dosyalar|*jpeg;*png;*jpg"
            };
            ofd.ShowDialog();
            if (ofd.FileName != "")
            {
                imgResim = new Bitmap(ofd.FileName);
            }
            pictureBox1.Image = imgResim;
        }

        private void btnSec2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Title = "Resim Dosyası",
                Filter = "Tüm Dosyalar|*jpeg;*png;*jpg"
            };
            ofd.ShowDialog();
            if (ofd.FileName != "")
            {
                imgResim = new Bitmap(ofd.FileName);
            }
            pictureBox2.Image = imgResim;
        }
    }
}
