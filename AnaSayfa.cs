namespace arackiralamak
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent(GetBtnMusterEkle());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMusterEkle_Click(object sender, EventArgs e)
        {
            MusteriEkle musterieklefrm = new MusteriEkle();
            musterieklefrm.Show();
        }

        private void btnMusteriListele_Click(object sender, EventArgs e)
        {

        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            AracEkle araceklefrm = new AracEkle();
            araceklefrm.Show();
        }

        private void btnAracListele_Click(object sender, EventArgs e)
        {
            AracListele araclistelefrm = new AracListele();
            araclistelefrm.Show();
        }

        private void btnSozlesme_Click(object sender, EventArgs e)
        {
            Sozlesme sozlesmeefrm = new Sozlesme();
            sozlesmeefrm.Show();
        }

        private void btnSatislar_Click(object sender, EventArgs e)
        {
           
        }
    }
}