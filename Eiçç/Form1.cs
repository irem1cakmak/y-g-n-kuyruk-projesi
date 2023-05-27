using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eiçç
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Proses
        {
            public String pros;
            public int oncelik;
            public Proses next;
        }
        public class Yigin
        {
            public Proses bas = null;
            public void push(String pros, int oncelik)
            {
                Proses yeni = new Proses();
                yeni.pros = pros;
                yeni.oncelik = oncelik;
                if (bas == null)
                {
                    bas = yeni;
                }
                else
                {
                    yeni.next = bas;
                    bas = yeni;
                }
            }
            public void yazdır(ListBox list)
            {
                Proses gecici = bas;
                list.Items.Clear();
                while (gecici != null)
                {
                    list.Items.Add(gecici.pros + gecici.oncelik);
                    gecici = gecici.next;
                }
            }
        }
        public class Kuyruk
        {
            public Proses arka_k = null;
            public Proses on_k = null;
            public void enQueue(String pros, int oncelik)
            {
                Proses yeni = new Proses();
                yeni.pros = pros;
                yeni.oncelik = oncelik;
                if (on_k == null)
                {
                    on_k = yeni;
                    arka_k = yeni;
                }
                else
                {
                    arka_k.next = yeni;
                    arka_k = yeni;
                }
            }
            public void oQueue(Proses[] p)
            {
                bool kontrol = false;
                for (int i = 0; i < p.Length; i++)
                {
                    if (p[i] == null)
                    {
                        kontrol = true;
                    }

                }
                if (kontrol == false)
                {
                    for (int i = 0; i < p.Length; i++)
                    {
                        for (int j = 0; j < p.Length - 1; j++)
                        {
                            if (p[j].oncelik < p[j + 1].oncelik)
                            {
                                Proses gecici = p[j];
                                p[j] = p[j + 1];
                                p[j + 1] = gecici;
                            }
                        }
                    }
                    for (int i = 0; i < p.Length; i++)
                    {
                        enQueue(p[i].pros, p[i].oncelik);
                    }
                }

            }
            public void deQueue()
            {
                if (on_k != null)
                {
                    on_k = on_k.next;
                }
                else
                {
                    Console.WriteLine("Eleman yok");
                }
            }
            public void yazdır(TextBox txt)
            {
                Proses gecici = on_k;
                String yaz = "";
                while (gecici != null)
                {
                    yaz += gecici.pros + gecici.oncelik + "\r\n";
                    gecici = gecici.next;
                }
                txt.Text = yaz;
            }

        }
        Kuyruk prosesK = new Kuyruk();
        Kuyruk prosesK1 = new Kuyruk();
        Kuyruk prosesK2 = new Kuyruk();
        Kuyruk prosesK3 = new Kuyruk();
        Yigin prosesY1 = new Yigin();
        Yigin prosesY2 = new Yigin();
        Yigin prosesY3 = new Yigin();
        Random rastgele = new Random();
        private void tmPros1_Tick(object sender, EventArgs e)
        {
            for (int i = 1; i <= trbProses1.Value; i++)
            {
                int oncelik = rastgele.Next(0, 6);
                prosesK1.yazdır(txbPros1);
                prosesK1.enQueue("P1-", oncelik);
            }
        }

        private void btnBaşlat_Click(object sender, EventArgs e)
            {
            tmIşlemci.Start();
            tmEkle.Start();
        }

        private void tmPros1_Tick_1(object sender, EventArgs e)
        {
            for (int i = 1; i <= trbProses1.Value; i++)
            {
                int oncelik = rastgele.Next(0, 6);
                prosesK1.yazdır(txbPros1);
                prosesK1.enQueue("P1-", oncelik);
            }
        }

        private void tmPros2_Tick(object sender, EventArgs e)
        {
            for (int i = 1; i <= trbProses2.Value; i++)
            {
                int oncelik = rastgele.Next(0, 6);
                prosesK2.yazdır(txbPros2);
                prosesK2.enQueue("P2-", oncelik);
            }
        }

        private void tmPros3_Tick(object sender, EventArgs e)
        {
            int oncelik = rastgele.Next(0, 6);
            prosesK3.yazdır(txbPros3);
            prosesK3.enQueue("P3-", oncelik);
        }

        private void tmIşlemci_Tick(object sender, EventArgs e)
        {
            for (int i = 1; i <= trbİşlemci.Value; i++)
            {
                bool kontrol = false;
                if (prosesK.on_k == null)
                {
                    kontrol = true;
                }
                if (kontrol == false)
                {
                    if (prosesK.on_k.pros == "P1-")
                    {
                        prosesY1.push(prosesK.on_k.pros, prosesK.on_k.oncelik);
                    }
                    else if (prosesK.on_k.pros == "P2-")
                    {
                        prosesY2.push(prosesK.on_k.pros, prosesK.on_k.oncelik);
                    }
                    else if (prosesK.on_k.pros == "P3-")
                    {
                        prosesY3.push(prosesK.on_k.pros, prosesK.on_k.oncelik);
                    }
                    prosesK.deQueue();
                }
                Proses gecici = prosesK.on_k;
                String yaz = "";
                while (gecici != null)
                {
                    yaz += gecici.pros + gecici.oncelik + "<--";
                    gecici = gecici.next;
                }
                txbKuyruk.Text = yaz;
            }
        }

        private void tmEkle_Tick(object sender, EventArgs e)
        {
            Proses[] k = new Proses[3];
            k[0] = prosesK1.on_k;
            k[1] = prosesK2.on_k;
            k[2] = prosesK3.on_k;
            prosesK1.deQueue();
            prosesK2.deQueue();
            prosesK3.deQueue();
            prosesK.oQueue(k);
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            tmIşlemci.Stop();
            tmEkle.Stop();
        }

        private void btnGöster_Click(object sender, EventArgs e)
        {
            if (chbPros1.Checked)
            {
                prosesY1.yazdır(lstbP1);
            }
            if (chbPros2.Checked)
            {
                prosesY2.yazdır(lstbP2);
            }
            if (chbPros3.Checked)
            {
                prosesY3.yazdır(lstbP3);
            }
        }
    }
    }



