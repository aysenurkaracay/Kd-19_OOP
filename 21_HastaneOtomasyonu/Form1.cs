using _21_HastaneOtomasyonu.Concrete;
using _21_HastaneOtomasyonu.Enum_s;
using System.Runtime.Serialization.Formatters.Binary;

namespace _21_HastaneOtomasyonu
{
    public partial class Form1 : Form
    {
        public static Hastane hastane;
        public Form1()
        {
            InitializeComponent();
            hastane = new Hastane()
            {
                HastaneAdi = "BilgeAdam",
                CalisanSayisi = 5000,
                GunlukHastaSayisi = 10000,
                YatakliServisSayisi = 300
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstVlist.View = View.Details;
            lstVlist.GridLines = true;
            lstVlist.Columns.Add("Ad", 100);
            lstVlist.Columns.Add("Soyad", 150);
            lstVlist.Columns.Add("TCNo", 100);
            lstVlist.Columns.Add("Maaş", 100);
            lstVlist.Columns.Add("Yaş", 60);
            lstVlist.Columns.Add("Cinsiyet", 80);
            lstVlist.Columns.Add("Günlük Hasta Sayısı", 80);
            lstVlist.Columns.Add("Ünvan", 100);
            lstVlist.Columns.Add("Aylık Nöbet Sayısı", 80);
            lstVlist.Columns.Add("Uzmanlık Alanı", 120);
            lstVlist.Columns.Add("Döner Sermaye Parası", 80);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            OrtopediDoktor ortopediDoktor = new OrtopediDoktor()
            {
                Ad = "Faruk",
                Soyad = "Akpınar",
                Maas = 30000,
                Yas = 35,
                GunlukHastaSayisi = 30,
                Cinsiyet = Cinsiyet.Erkek,
                Unvan = "Doç.",
                AylikNobetSayisi = 2,
                UzmanlikAlani = "Ortopedi",
                DonerSermayeParasi = 26000,
                TC = "45354354"
            };

            OrtopediDoktor ortopediDoktor2 = new OrtopediDoktor()
            {
                Ad = "Ayşe",
                Soyad = "Ölmez",
                Maas = 19000,
                Yas = 29,
                GunlukHastaSayisi = 40,
                Cinsiyet = Cinsiyet.Kadın,
                Unvan = "Uzman.",
                AylikNobetSayisi = 7,
                UzmanlikAlani = "Ortopedi",
                DonerSermayeParasi = 10000,
                TC = "56456656"
            };
            hastane.Doktorlar.Add(ortopediDoktor);
            hastane.Doktorlar.Add(ortopediDoktor2);
            foreach (var item in hastane.Doktorlar)
            {
                ListViewItem lstitem = new ListViewItem();
                lstitem.Text = item.Ad;
                lstitem.SubItems.Add(item.Soyad);
                lstitem.SubItems.Add(item.TC);
                lstitem.SubItems.Add(item.Maas.ToString());
                lstitem.SubItems.Add(item.Yas.ToString());
                lstitem.SubItems.Add(item.Cinsiyet.ToString());
                lstitem.SubItems.Add(item.GunlukHastaSayisi.ToString());
                lstitem.SubItems.Add(item.Unvan);
                lstitem.SubItems.Add(item.AylikNobetSayisi.ToString());
                lstitem.SubItems.Add(item.UzmanlikAlani);
                lstitem.SubItems.Add(item.DonerSermayeParasi.ToString());
                lstVlist.Items.Add(lstitem);
            }
            btnTest.Enabled = false;
            FileStream fs = new FileStream("temp.txt", FileMode.Create);
            BinaryFormatter binary=new BinaryFormatter();
            binary.Serialize(fs, ortopediDoktor2);
            fs.Close();
            //Todo :Dosyaya Ekleme

            FileStream _fs = new FileStream("temp.txt", FileMode.Open);
            BinaryFormatter _binary = new BinaryFormatter();
            OrtopediDoktor doktor = (OrtopediDoktor)_binary.Deserialize(_fs);
            MessageBox.Show($"TcNo {doktor.TC}, baktığı hasta Sayısı {doktor.GunlukHastaSayisi}");
            _fs.Close();
            //MessageBox.Show($"Hastane Adı ={hastane.HastaneAdi} ,Günlük baktığı Hasta Sayısı{hastane.GunlukHastaSayisi}");
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele frm = new Listele();
            frm.Show();
        }

        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            DoktorEkle frm = new DoktorEkle();
            frm.Show();
        }
    }
}