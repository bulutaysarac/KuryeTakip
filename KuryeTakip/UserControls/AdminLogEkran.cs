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

namespace KuryeTakip.UserControls
{
    public partial class AdminLogEkran : UserControl
    {
        public AdminLogEkran()
        {
            InitializeComponent();
        }

        SqlConnection sqlBağ = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=|DataDirectory|KuryeVT.mdf;");
        SqlCommand sqlKomutu;

        private void AdminLogEkran_Load(object sender, EventArgs e)
        {
            if (sqlBağ.State == System.Data.ConnectionState.Closed)
                sqlBağ.Open();

            sqlKomutu = new SqlCommand("SELECT a.Kullanici_Adi,al.Tarih,al.Aciklama FROM Admin_Log al INNER JOIN Adminler a ON al.Admin_ID = a.ID", sqlBağ);
            SqlDataReader drv = sqlKomutu.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(drv);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                txtLog.AppendText(dt.Rows[i]["Tarih"].ToString() + "\t");
                txtLog.AppendText(dt.Rows[i]["Kullanici_Adi"].ToString() + "\n");
                txtLog.AppendText(dt.Rows[i]["Aciklama"].ToString());
                txtLog.AppendText("\n\n");
            }
            if (sqlBağ.State == ConnectionState.Open)
                sqlBağ.Close();
        }
    }
}
