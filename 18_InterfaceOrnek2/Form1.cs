namespace _18_InterfaceOrnek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<KupKutu> klist = new List<KupKutu>();
        List<DikdortgenKutu> dlist = new List<DikdortgenKutu>();
        private void btnKup_Click(object sender, EventArgs e)
        {
            //    KupKutu k = new KupKutu()
            //    {
            //        id = 1,
            //        UrunAd = "Mukavva Karton",
            //        Yukseklik = 15
            //    };
            //    klist.Add(k);
            //    KupKutu k2 = new KupKutu()
            //    {
            //        id = 2,
            //        UrunAd = "Karton Karton",
            //        Yukseklik = 10
            //    };
            //    klist.Add(k2);
            //    KupKutu k3 = new KupKutu()
            //    {
            //        id = 3,
            //        UrunAd = "Tahta Karton",
            //        Yukseklik = 15
            //    };
            //    klist.Add(k3);
            klist.Clear();
            klist.AddRange(new List<KupKutu>()
            {
                new KupKutu(){
                    id=1,
                    UrunAd = "Mukavva Karton",
                    Yukseklik = 15
                },
                new KupKutu()
                {
                     id = 2,
                    UrunAd = "Karton Karton",
                    Yukseklik = 10

                },
                new KupKutu()
                {
                    id = 3,
                    UrunAd = "Tahta Karton",
                    Yukseklik = 15
                }


            });
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = klist;
        }

        private void btndortgen_Click(object sender, EventArgs e)
        {
            dlist.Clear();
            DikdortgenKutu dikdortgenKutu = new DikdortgenKutu()
            {
                id = 1,
                UrunAd = "Kutu",
                UzunKenar = 12,
                KisaKenar = 7,
                Yukseklik = 5
            };
            dlist.Add(dikdortgenKutu);
            DikdortgenKutu dikdortgenKutu2 = new DikdortgenKutu()
            {
                id = 2,
                UrunAd = "Metal Kutu",
                UzunKenar = 17,
                KisaKenar = 9,
                Yukseklik = 7
            };
            dlist.Add(dikdortgenKutu2);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dlist;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          if( dataGridView1.CurrentRow.DataBoundItem is KupKutu)
            {
                KupKutu k = (KupKutu)dataGridView1.CurrentRow.DataBoundItem;
                int hacim = k.Hacim();
                MessageBox.Show($"Küpün hacmi ={hacim}");
            }
            else
            {
                DikdortgenKutu d = dataGridView1.CurrentRow.DataBoundItem as DikdortgenKutu;
                MessageBox.Show(d.Hacim().ToString());
            }
        }

        /*
         Console Projesi

        2 tane interface olucak

        ----IAraba : marka,model,ModelYili,Sanziman prop. ÖzellikOku adında bir metot olucak
        ----Inumara: int yildiz prop.

        ----Araba sınıfı ikisindende miras alıcak.Model yili 2005ten küçükse default değer 2005 değilse value kullanıcının atadığı değer olucak.
        ---araba clasında yıldız prop. 5ten büyük girildiyse 5 olarak atansın değilse kullanıcının girdiği değer atansın.
        --ÖzellikOku metodunda ise

        Araç Özelliklerimiz : Markası:....... Model ..... Şansızaman Türü:....... Model Yılı: ......... Puanı :.......
         
         
         */

    }
}