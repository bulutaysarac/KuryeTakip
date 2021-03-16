using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuryeTakip
{
    public partial class Sunucu : Form
    {
        public Sunucu()
        {
            InitializeComponent();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    txtIP.Text = address.ToString();
                }
            }
            backgroundWorker1.WorkerSupportsCancellation = true;

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

        private TcpClient client;
        private TcpListener listener;
        public StreamReader STR;
        public StreamWriter STW;
        public string alinan;
        public string sonVeri;

        private void btnSunucuBasla_Click(object sender, EventArgs e)
        {
            listener = new TcpListener(IPAddress.Parse(txtIP.Text), int.Parse(txtPort.Text));
            listener.Start();
            txtLog.Invoke(new MethodInvoker(delegate () { txtLog.AppendText("Server Başlatıldı \n"); }));
            txtLog.Invoke(new MethodInvoker(delegate () { txtLog.AppendText("Bağlantı Bekleniyor \n"); }));

            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                client = listener.AcceptTcpClient();
                txtLog.Invoke(new MethodInvoker(delegate () { txtLog.AppendText("Bağlantı Kuruldu \n"); }));

                STR = new StreamReader(client.GetStream());
                STW = new StreamWriter(client.GetStream());
                STW.AutoFlush = true;
                while (client.Connected)
                {
                    try
                    {
                        alinan = STR.ReadLine();
                        txtLog.Invoke(new MethodInvoker(delegate () { txtLog.AppendText("Alınan Veri : " + alinan + "\n"); }));
                        sonVeri = alinan;
                        alinan = "";
                    }
                    catch (Exception)
                    {
                    }
                }
                backgroundWorker1.CancelAsync();
            }
            catch (Exception)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kapat();
        }

        private void btnSon_Click(object sender, EventArgs e)
        {
            KonumEkran knmE = (KonumEkran)this.Owner;
            knmE.txtGelenKonum.Text = sonVeri;
            Kapat();
        }

        private void Kapat()
        {
            if (listener != null)
                listener.Stop();
            if (client != null)
                client.Close();
            this.Close();
        }
    }
}
