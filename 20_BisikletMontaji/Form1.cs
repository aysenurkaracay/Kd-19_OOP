namespace _20_BisikletMontaji
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbFren.Items.AddRange(Enum.GetNames<FrenTipi>());
            cmbFren.SelectedIndex = 0;
            cmbkadro.Items.AddRange(Enum.GetNames(typeof(KadroTipi)));
            cmbkadro.SelectedIndex = 0;
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            try
            {
                Bisiklet bisiklet = new Bisiklet()
                {
                    Fren=(FrenTipi)cmbFren.SelectedIndex,
                    Kadro=(KadroTipi)cmbkadro.SelectedIndex,
                    ModelYil=dtModelYil.Value.Year
                };
                txtYas.Text = bisiklet.Yasi.ToString();
                MessageBox.Show(bisiklet.ToString());
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);
            }
        }
        /*
KadroTipi Enum : Alüminyum,Çelik
Fren Tipi Enum: Hidrolik,Mekanik,Kontra
Bisiklet classı:FrenTipi,KadroTipi,Model Yili (1990 dan küçük değer girilirse throw ile yıl ifadesi 1990 ile günümüz yılı arasında olabilir.)
yaş property yil-modelyilindan hesaplanıcak dışarıdan set edilmeyecek.


*/
    }
}