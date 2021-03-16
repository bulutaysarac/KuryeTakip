using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using KuryeTakip.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Device.Location;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuryeTakip
{
    public partial class KonumEkran : Form
    {
        public KonumEkran()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            btnBul.Enabled = false;
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


        double x, y;
        GeoCoordinate location;
        GMapMarker isaret;
        GMapOverlay markersOverlay;
        GeoCoordinateWatcher watcher;

        SqlConnection sqlBağ = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=|DataDirectory|KuryeVT.mdf;");
        SqlCommand sqlKomutu;

        private void KonumEkran_Load(object sender, EventArgs e)
        {
            watcher = new GeoCoordinateWatcher();
            watcher.StatusChanged += Watcher_StatusChanged; ;
            watcher.Start();
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
        }

        private void btnKendiKonumum_Click(object sender, EventArgs e)
        {
            try
            {
                gMapControl1.Overlays.Clear();
                txtX.Text = x.ToString();
                txtY.Text = y.ToString();
                PointLatLng st = new PointLatLng(x, y);
                gMapControl1.Position = st;
                GMapOverlay markersOverlay = new GMapOverlay("markers");
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(x, y), GMarkerGoogleType.blue_pushpin);
                marker.ToolTipMode = MarkerTooltipMode.Always;
                marker.ToolTipText = "Buradasınız.";
                markersOverlay.Markers.Add(marker);
                gMapControl1.Overlays.Add(markersOverlay);


                if (sqlBağ.State == System.Data.ConnectionState.Closed)
                    sqlBağ.Open();

                sqlKomutu = new SqlCommand("SELECT s.ID as [SirketIDD],s.Adres,s2.Sehir_Adi,s.Sirket_Adi,s.Telefon,s.KonumX,s.KonumY,AVG(y.Puan) as [Puan] FROM Sirketler s INNER JOIN Sehirler s2 ON s.SehirID = s2.ID INNER JOIN Yorumlar y ON y.Sirket_ID = s.ID GROUP BY s.ID,s.Adres,s2.Sehir_Adi,s.Sirket_Adi,s.Telefon,s.KonumX,s.KonumY", sqlBağ);
                SqlDataReader drv = sqlKomutu.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(drv);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    PointLatLng a = new PointLatLng(double.Parse(dt.Rows[i]["KonumX"].ToString(), CultureInfo.InvariantCulture), double.Parse(dt.Rows[i]["KonumY"].ToString(), CultureInfo.InvariantCulture));
                    var yep = new GeoCoordinate(a.Lat, a.Lng);
                    double sayı = Math.Ceiling(Convert.ToDouble(location.GetDistanceTo(yep)) / 1000);

                    if (sayı < int.Parse(txtSinir.Text))
                    {
                        isaret = new GMarkerGoogle(a, GMarkerGoogleType.blue_small);
                        isaret.ToolTipText = "\n" + dt.Rows[i]["Sirket_Adi"] + "\n\n" + dt.Rows[i]["Telefon"] + "\n\nDetaylı Bilgi için Tıklayınız...";
                        isaret.Tag = dt.Rows[i]["SirketIDD"];
                        isaret.ToolTip = new GMapToolTip(isaret);
                        isaret.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                        markersOverlay.Markers.Add(isaret);
                        gMapControl1.Zoom = 12;
                    }
                }

                if (sqlBağ.State == System.Data.ConnectionState.Open)
                    sqlBağ.Close();
            }
            catch (Exception)
            {
            }
        }

        private void btnSunucu_Click(object sender, EventArgs e)
        {
            Sunucu snc = new Sunucu() { Owner = this };
            snc.ShowDialog();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            gMapControl1.Overlays.Clear();

            string[] konum = txtGelenKonum.Text.Split('|');
            x = double.Parse(konum[0], CultureInfo.InvariantCulture);
            y = double.Parse(konum[1], CultureInfo.InvariantCulture);
            PointLatLng st = new PointLatLng(x, y);
            gMapControl1.Position = st;
            markersOverlay = new GMapOverlay("mobilMark");
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(x, y), GMarkerGoogleType.blue_pushpin);
            marker.ToolTipText = "Buradasınız.";
            markersOverlay.Markers.Add(marker);
            gMapControl1.Overlays.Add(markersOverlay);

            if (sqlBağ.State == System.Data.ConnectionState.Closed)
                sqlBağ.Open();

            sqlKomutu = new SqlCommand("SELECT s.ID as [SirketIDD],s.Adres,s2.Sehir_Adi,s.Sirket_Adi,s.Telefon,s.KonumX,s.KonumY,AVG(y.Puan) as [Puan] FROM Sirketler s INNER JOIN Sehirler s2 ON s.SehirID = s2.ID INNER JOIN Yorumlar y ON y.Sirket_ID = s.ID GROUP BY s.ID,s.Adres,s2.Sehir_Adi,s.Sirket_Adi,s.Telefon,s.KonumX,s.KonumY", sqlBağ);
            SqlDataReader drv = sqlKomutu.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(drv);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PointLatLng a = new PointLatLng(double.Parse(dt.Rows[i]["KonumX"].ToString(), CultureInfo.InvariantCulture), double.Parse(dt.Rows[i]["KonumY"].ToString(), CultureInfo.InvariantCulture));
                var yep = new GeoCoordinate(a.Lat, a.Lng);
                double sayı = Math.Ceiling(Convert.ToDouble(location.GetDistanceTo(yep)) / 1000);

                if (sayı < int.Parse(txtSinir.Text))
                {
                    isaret = new GMarkerGoogle(a, GMarkerGoogleType.blue_small);
                    isaret.ToolTipText = "\n" + dt.Rows[i]["Sirket_Adi"] + "\n\n" + dt.Rows[i]["Telefon"] + "\n\nDetaylı Bilgi için Tıklayınız...";
                    isaret.Tag = dt.Rows[i]["SirketIDD"];
                    isaret.ToolTip = new GMapToolTip(isaret);
                    isaret.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                    markersOverlay.Markers.Add(isaret);
                    gMapControl1.Zoom = 12;
                }
            }

            if (sqlBağ.State == System.Data.ConnectionState.Open)
                sqlBağ.Close();
        }

        private void txtGelenKonum_TextChanged(object sender, EventArgs e)
        {
            if (txtGelenKonum.Text != "")
            {
                btnBul.Enabled = true;
            }
            else
            {
                btnBul.Enabled = false;
            }
        }

        private void gMapControl1_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            DetayEkran dE = new DetayEkran() { Owner = this, Tag = item.Tag };
            dE.ShowDialog();
        }

        private void Watcher_StatusChanged(object sender, GeoPositionStatusChangedEventArgs e)
        {
            location = watcher.Position.Location;
            x = watcher.Position.Location.Latitude;
            y = watcher.Position.Location.Longitude;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        } //ÇIKIŞ

    }
}
