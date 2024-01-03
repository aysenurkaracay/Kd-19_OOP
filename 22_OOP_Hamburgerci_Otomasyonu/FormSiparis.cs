using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22_OOP_Hamburgerci_Otomasyonu
{
    public partial class FormSiparis : Form
    {
        public FormSiparis()
        {
            InitializeComponent();
        }
        public static List<Siparis> tumSiparisler = new List<Siparis>();
        public static List<Siparis> mevcutSiparisler = new List<Siparis>();
        public static List<Menu> menuler = new List<Menu>()
        {
            new Menu(){ MenuAdi="Big King",Fiyati=150},
            new Menu(){ MenuAdi="Double King Chicken",Fiyati=135.50M},
            new Menu(){ MenuAdi="Steakhouse",Fiyati=195.50M},
            new Menu(){ MenuAdi="Whooper",Fiyati=165.00M},
            new Menu(){ MenuAdi="Whooper Jr.",Fiyati=95.00M},
            new Menu(){ MenuAdi="Chicken Royal",Fiyati=145.75M},
        };
        public static List<EkstraMalzeme> ekstralar = new List<EkstraMalzeme>()
        {
            new EkstraMalzeme(){EkstraAdi="Ketçap",Fiyati=0.50M},
            new EkstraMalzeme(){EkstraAdi="Mayonez",Fiyati=0.75M},
            new EkstraMalzeme(){EkstraAdi="Hardal",Fiyati=0.95M},
            new EkstraMalzeme(){EkstraAdi="BBQ",Fiyati=1.00M},
            new EkstraMalzeme(){EkstraAdi="Ranch",Fiyati=1.00M}
        };

        private void FormSiparis_Load(object sender, EventArgs e)
        {
            foreach (Menu item in menuler)
            {
                cmbMenuler.Items.Add(item);
            }
            cmbMenuler.SelectedIndex = 0;
            rdbKucuk.Checked = true;
            foreach (EkstraMalzeme item in ekstralar)
            {
                flpEkstraMalzemeler.Controls.Add(new CheckBox() { Text = item.EkstraAdi, Tag = item });
            }
            foreach (Siparis item in mevcutSiparisler)
            {
                lstSiparisler.Items.Add(item);
            }
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis yeniSiparis = new Siparis();
            yeniSiparis.SeciliMenu = (Menu)cmbMenuler.SelectedItem;
            if (rdbKucuk.Checked) yeniSiparis.Boyut = Boyut.Küçük;
            else if (rdbOrta.Checked) yeniSiparis.Boyut = Boyut.Orta;
            else
                yeniSiparis.Boyut = Boyut.Büyük;
            foreach (CheckBox item in flpEkstraMalzemeler.Controls)
            {
                if (item.Checked)
                {
                    yeniSiparis.EkstraMalzemeler.Add((EkstraMalzeme)item.Tag);
                }
            }
            yeniSiparis.Adet = Convert.ToInt16(nmrAdet.Value);
            yeniSiparis.Hesapla();
            mevcutSiparisler.Add(yeniSiparis);
            tumSiparisler.Add(yeniSiparis);
            lstSiparisler.Items.Add(yeniSiparis);
            TutarHesapla();
        }

        private decimal TutarHesapla()
        {
            decimal tutar = 0;
            for (int i = 0; i < lstSiparisler.Items.Count; i++)
            {
                Siparis gelenSiparis = (Siparis)lstSiparisler.Items[i];
                tutar += gelenSiparis.ToplamTutar;
            }
            lblToplamTutar.Text = tutar.ToString("C2");
            return tutar;
        }

        private void btnSiparisTamamla_Click(object sender, EventArgs e)
        {
          DialogResult result=  MessageBox.Show($"Toplam Sipariş Tutarı {TutarHesapla().ToString("C2")} \n Siparişi tamamlamak ister misiniz?","Sipariş Bilgisi",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                lstSiparisler.Items.Clear();
                mevcutSiparisler.Clear();
                TutarHesapla();
                MessageBox.Show("Siparişiniz tamamlandı");
            }
            else
            {
                MessageBox.Show("İptal Edildi");
            }
        }
    }
}
