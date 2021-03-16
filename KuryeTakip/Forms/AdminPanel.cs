using KuryeTakip.UserControls;
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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
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
            AdminGirisEkran sahip = (AdminGirisEkran) this.Owner;
            sahip.btnGiris.Visible = true;
            sahip.pictureBox1.Visible = false;
            sahip.txtSifre.Text = "";
            sahip.Show();
            this.Close();
        } //ÇIKIŞ

        private void btnSirket_Click(object sender, EventArgs e)
        {
            panelEkran.Controls.Clear();
            AdminPanelSirket aps = new AdminPanelSirket();
            panelEkran.Controls.Add(aps);
        }

        private void btnDiger_Click(object sender, EventArgs e)
        {
            panelEkran.Controls.Clear();
            AdminPanelDigerTablolar apdt = new AdminPanelDigerTablolar();
            panelEkran.Controls.Add(apdt);
        }

        private void btnAdminLog_Click(object sender, EventArgs e)
        {
            panelEkran.Controls.Clear();
            AdminLogEkran ale = new AdminLogEkran();
            panelEkran.Controls.Add(ale);
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            LogYaz("Panele Giriş Yaptı", OrtakVeri.AdminID);
        }

        private void LogYaz(string Aciklama, int AdminID)
        {
            if (sqlBağ.State == System.Data.ConnectionState.Closed)
                sqlBağ.Open();

            sqlKomutu = new SqlCommand("INSERT INTO [Admin_Log] VALUES(@AdminID, @Tarih, @Aciklama)", sqlBağ);
            sqlKomutu.Parameters.AddWithValue(@"AdminID", AdminID);
            sqlKomutu.Parameters.AddWithValue(@"Tarih", DateTime.Now);
            sqlKomutu.Parameters.AddWithValue(@"Aciklama", Aciklama);
            sqlKomutu.ExecuteNonQuery();

            if (sqlBağ.State == System.Data.ConnectionState.Open)
                sqlBağ.Close();
        } //HAREKET DÖKÜMÜ İÇİN LOG TUTMA
    }
}
