namespace _22_OOP_Hamburgerci_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void ChildForm(Form childForm)
        {
            bool durum = false;
            this.Width = childForm.Width + 30;
            this.Height = childForm.Height + 85;
            foreach (Form form in this.MdiChildren)
            {
                if (form.Text == childForm.Text)
                {
                    durum = true;
                    form.Activate();
                }
                else
                {
                    form.Close();
                }
            }
            if (durum == false)
            {
                childForm.MdiParent = this;
                childForm.Show();
            }

        }

        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new FormSiparis());
        }

        private void siparişBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new FormTumSiparisler());
        }

        private void menüEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new FormMenu());
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new FormEkstra());
        }
    }
}