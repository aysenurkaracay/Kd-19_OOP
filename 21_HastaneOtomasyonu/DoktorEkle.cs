using _21_HastaneOtomasyonu.Abstract;
using _21_HastaneOtomasyonu.Concrete;
using _21_HastaneOtomasyonu.Enum_s;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_HastaneOtomasyonu
{
    public partial class DoktorEkle : Form
    {
        public DoktorEkle()
        {
            InitializeComponent();
        }

        private void DoktorEkle_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyet)));
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            IDoktor eklenecekDoktor;
            if (rdbOrtopedi.Checked)
            {
                eklenecekDoktor = new OrtopediDoktor()
                {
                    Ad=txtAd.Text,
                    Soyad=txtSoyad.Text,
                    Maas=Convert.ToInt16(txtMaas.Text),
                    TC=txtTC.Text,
                    AylikNobetSayisi=Convert.ToInt16(txtNobetSaysi.Text),
                    DonerSermayeParasi=Convert.ToInt16(txtdonerSermaye.Text),
                    Birim=Birim.Ortopedi,
                    GunlukHastaSayisi=Convert.ToInt16(txtHastaSayisi.Text),
                    Unvan=txtUnvan.Text,
                    UzmanlikAlani=txtUzmanlik.Text,
                    Yas=Convert.ToInt16(txtYas.Text),
                    Cinsiyet=cmbCinsiyet.SelectedItem.ToString()=="Erkek" ? Cinsiyet.Erkek :Cinsiyet.Kadın
                };
                Form1.hastane.Doktorlar.Add(eklenecekDoktor);
            }
            else if (rdbPsikiyatri.Checked)
            {

                eklenecekDoktor = new PsikiyatriDoktor()
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    Maas = Convert.ToInt16(txtMaas.Text),
                    TC = txtTC.Text,
                    AylikNobetSayisi = Convert.ToInt16(txtNobetSaysi.Text),
                    DonerSermayeParasi = Convert.ToInt16(txtdonerSermaye.Text),
                    Birim = Birim.Psikiyatri,
                    GunlukHastaSayisi = Convert.ToInt16(txtHastaSayisi.Text),
                    Unvan = txtUnvan.Text,
                    UzmanlikAlani = txtUzmanlik.Text,
                    Yas = Convert.ToInt16(txtYas.Text),
                    Cinsiyet = cmbCinsiyet.SelectedItem.ToString() == "Erkek" ? Cinsiyet.Erkek : Cinsiyet.Kadın
                };
                Form1.hastane.Doktorlar.Add(eklenecekDoktor);
            }
            Fonksiyonlar.Temizle(this);
        }
    }
}
