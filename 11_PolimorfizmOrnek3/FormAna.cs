namespace _11_PolimorfizmOrnek3
{
    public partial class FormAna : Form
    {
        public FormAna()
        {
            InitializeComponent();
        }

        private void silindirProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FormSilindir();
            frm.Show();
        }

        private void dörtgenProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDortgen frm = new FormDortgen();
            frm.Show();
        }

        private void küpProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKup frm = new FormKup();
            frm.Show();
        }
    }
}