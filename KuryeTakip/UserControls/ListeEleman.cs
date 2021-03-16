using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using KuryeTakip.Forms;

namespace KuryeTakip.UserControls
{
    public partial class ListeEleman : UserControl
    {
        public ListeEleman()
        {
            InitializeComponent();
        }

        private void btnHaritada_Click(object sender, EventArgs e)
        {
            string[] dizi = this.Tag.ToString().Split('|');
            HaritadaGosterEkran hgE = new HaritadaGosterEkran();
            OrtakVeri.SirketID = int.Parse(dizi[2].ToString());
            hgE.x = double.Parse(dizi[0], System.Globalization.CultureInfo.InvariantCulture);
            hgE.y = double.Parse(dizi[1], System.Globalization.CultureInfo.InvariantCulture);
            hgE.ShowDialog();
            
        }

        private void btnDetayli_Click(object sender, EventArgs e)
        {
            DetayEkran dE = new DetayEkran();
            dE.Tag = btnDetayli.Tag;
            dE.ShowDialog();
            OrtakVeri.ekran.BilgileriGetir();
        }
    }
}
