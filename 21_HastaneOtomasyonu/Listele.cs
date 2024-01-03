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
    public partial class Listele : Form
    {
        public Listele()
        {
            InitializeComponent();
        }

        private void Listele_Load(object sender, EventArgs e)
        {
            lstvDoktorlar.View = View.Details;
            lstvDoktorlar.GridLines = true;
            lstvDoktorlar.Columns.Add("Ad", 100);
            lstvDoktorlar.Columns.Add("Soyad", 150);
            lstvDoktorlar.Columns.Add("TCNo", 100);
            lstvDoktorlar.Columns.Add("Maaş", 100);
            lstvDoktorlar.Columns.Add("Yaş", 60);
            lstvDoktorlar.Columns.Add("Cinsiyet", 80);
            lstvDoktorlar.Columns.Add("Günlük Hasta Sayısı", 80);
            lstvDoktorlar.Columns.Add("Ünvan", 100);
            lstvDoktorlar.Columns.Add("Aylık Nöbet Sayısı", 80);
            lstvDoktorlar.Columns.Add("Uzmanlık Alanı", 120);
            lstvDoktorlar.Columns.Add("Döner Sermaye Parası", 80);
            foreach (var item in Form1.hastane.Doktorlar)
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
                lstvDoktorlar.Items.Add(lstitem);
            }
        }
    }
}
