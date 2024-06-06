using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace arackiralamak
{
    public partial class Sozlesme : Form
    {
        public Sozlesme()
        {
            InitializeComponent();
        }
        private string baglantiCumlesi = @"Data Source=YAĞMUR\SQLEXPRESS;Initial Catalog=HamzaAracKiralama;Integrated Security=True";

        private void Sozlesme_Load(object sender, EventArgs e)
        {

        }

        private void musteriler_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Insert Into Musteriler Values (@Tc_No,@Ad_Soyad,@Telefon_No,@Mail,@Adres)";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);

            komut.Parameters.AddWithValue("Tc_No", txtTcNo.Text);
            komut.Parameters.AddWithValue("Ad_Soyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("Telefon_No", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("Mail", txtEposta.Text);
            komut.Parameters.AddWithValue("Adres", txtAdres.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Başarılı");
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
