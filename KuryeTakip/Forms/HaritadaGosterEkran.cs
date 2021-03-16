using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuryeTakip.Forms
{
    public partial class HaritadaGosterEkran : Form
    {
        public HaritadaGosterEkran()
        {
            InitializeComponent();
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
        }
        public double x, y;
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
        public GMapMarker marker;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        } //ÇIKIŞ

        private void gMapControl1_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            DetayEkran dE = new DetayEkran() { Tag = OrtakVeri.SirketID };
            dE.ShowDialog();
        } //MARKER CLİCK

        private void HaritadaGosterEkran_Load(object sender, EventArgs e)
        {

            PointLatLng st = new PointLatLng(x, y);
            gMapControl1.Position = st;
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            marker = new GMarkerGoogle(st, GMarkerGoogleType.red_dot);
            marker.ToolTipText = "Detaylı Görmek İçin Tıklayın";
            
            markersOverlay.Markers.Add(marker);

            gMapControl1.Overlays.Add(markersOverlay);
        }
    }
}
