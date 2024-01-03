using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_OOP_Hamburgerci_Otomasyonu
{
    public class Siparis
    {
        public Siparis()
        {
            EkstraMalzemeler = new List<EkstraMalzeme>();
        }
        public Menu SeciliMenu { get; set; }
        public Boyut Boyut { get; set; }
        public List<EkstraMalzeme> EkstraMalzemeler { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }
        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SeciliMenu.Fiyati;
            switch (Boyut)
            {
                case Boyut.Orta:
                    ToplamTutar += ToplamTutar * 0.10M;
                    break;
                case Boyut.Büyük:
                    ToplamTutar += ToplamTutar * 0.25M;
                    break;
            }
            foreach (EkstraMalzeme ekstra in EkstraMalzemeler)
            {
                ToplamTutar += ekstra.Fiyati;
            }
            ToplamTutar = ToplamTutar * Adet;
        }
        public override string ToString()
        {
            if(EkstraMalzemeler.Count<1)//EkstraMalzeme yoksa
            {
                return string.Format("{0} Menü X {1} Adet , {2} Boy , Toplam {3}", SeciliMenu.MenuAdi, Adet, Boyut, ToplamTutar.ToString("C2"));
            }
            else
            {
                string eksraMalzemeler = null;
                foreach (EkstraMalzeme ekstra in EkstraMalzemeler)
                {
                    eksraMalzemeler += ekstra.EkstraAdi + ",";
                }
                eksraMalzemeler = eksraMalzemeler.Trim(',');
                return string.Format("{0} Menü X {1} Adet , {2} Boy , {3} Toplam {4} ", SeciliMenu.MenuAdi, Adet, Boyut, eksraMalzemeler, ToplamTutar.ToString("C2"));
            }
        }
    }
}
