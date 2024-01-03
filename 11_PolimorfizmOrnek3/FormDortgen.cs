using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_PolimorfizmOrnek3
{
    public partial class FormDortgen : Form
    {
        public FormDortgen()
        {
            InitializeComponent();
        }
        List<ProfilDortgen> dlist = new List<ProfilDortgen>();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            ProfilDortgen dortgen = new ProfilDortgen();
            dortgen.Id = Convert.ToInt16(txtId.Text);
            dortgen.UrunAd = txtAd.Text;
            dortgen.Yukseklik = Convert.ToDecimal(txtYukseklik.Text);
            dortgen.UzunKenar = Convert.ToDecimal(txtUzunKenar.Text);
            dortgen.KisaKenar = Convert.ToDecimal(txtkisaKenar.Text);
            dlist.Add(dortgen);
            Listele();
            Temizle();
        }

        private void Temizle()
        {
            foreach (Control item in this.Controls)
            {

                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Clear();
                }
            }
        }

        private void Listele()
        {
            lstUrun.Items.Clear();
            foreach (var item in dlist)
            {
                lstUrun.Items.Add(item);
            }
            dtUrunler.DataSource = null;
            dtUrunler.DataSource = dlist;
        }
        ProfilDortgen secilenUrun;
        private void lstUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrun.SelectedIndex != -1)
            {
                secilenUrun = (ProfilDortgen)lstUrun.SelectedItem;
                txtId.Text = secilenUrun.Id.ToString();
                txtAd.Text = secilenUrun.UrunAd;
                txtkisaKenar.Text = secilenUrun.KisaKenar.ToString();
                txtUzunKenar.Text = secilenUrun.UzunKenar.ToString();
                txtYukseklik.Text = secilenUrun.Yukseklik.ToString();
                txtHacim.Text = secilenUrun.GetHacim().ToString();
                txtFire.Text = secilenUrun.Fire().ToString();
                txtTabanalani.Text = secilenUrun.GetTabanAlani().ToString();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            secilenUrun.Id = Convert.ToInt16(txtId.Text);
            secilenUrun.UrunAd = txtAd.Text;
            secilenUrun.UzunKenar = Convert.ToDecimal(txtUzunKenar.Text);
            secilenUrun.KisaKenar = Convert.ToDecimal(txtkisaKenar.Text);
            secilenUrun.Yukseklik = Convert.ToDecimal(txtYukseklik.Text);
            txtHacim.Text = secilenUrun.GetHacim().ToString();
            txtFire.Text = secilenUrun.Fire().ToString();
            txtTabanalani.Text = secilenUrun.GetTabanAlani().ToString();
            Listele();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            dlist.Remove(secilenUrun);
            Listele();
            Temizle();
        }
    }
}
