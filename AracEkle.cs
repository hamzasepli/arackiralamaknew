using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace arackiralamak
{
    public partial class AracEkle : Form
    {
        public AracEkle()
        {
            InitializeComponent();
        }

        private string baglantiCumlesi = @"Data Source=YAĞMUR\SQLEXPRESS;Initial Catalog=HamzaAracKiralama;Integrated Security=True";
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbxMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMarka.SelectedIndex == 0)
            {
                cbxSeri.Items.Clear();
                cbxSeri.Text = "";
                cbxSeri.Items.Add("Q9");
                cbxSeri.Items.Add("Q7");
                cbxSeri.Items.Add("A5");
                cbxSeri.Items.Add("A3");

            }
            else if (cbxMarka.SelectedIndex == 1)
            {

                cbxSeri.Items.Clear();
                cbxSeri.Text = "";
                cbxSeri.Items.Add("F30");
                cbxSeri.Items.Add("E30");
                cbxSeri.Items.Add("520i");

            }
            else if (cbxMarka.SelectedIndex == 2)
            {

                cbxSeri.Items.Clear();
                cbxSeri.Text = "";
                cbxSeri.Items.Add("E200");
                cbxSeri.Items.Add("C200");
                cbxSeri.Items.Add("g63");
            }
            else if (cbxMarka.SelectedIndex == 3)
            {

                cbxSeri.Items.Clear();
                cbxSeri.Text = "";
                cbxSeri.Items.Add("Omoda 5");
                cbxSeri.Items.Add("Tiggo 7");
                cbxSeri.Items.Add("Tiggo 8");
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Insert Into Araclar values (@Plaka,@Marka,@Seri,@Model,@Renk,@Kilometre,@Yakit,@Ucret,@Durum)";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);

            komut.Parameters.AddWithValue("@plaka", txtPlaka.Text);
            komut.Parameters.AddWithValue("@marka", cbxMarka.SelectedItem);
            komut.Parameters.AddWithValue("@Seri", cbxSeri.SelectedItem);
            komut.Parameters.AddWithValue("@Model", txtModel.Text);
            komut.Parameters.AddWithValue("@Renk", txtRenk.Text);
            komut.Parameters.AddWithValue("@Kilometre", txtKm.Text);
            komut.Parameters.AddWithValue("@Yakit", cbxYakit.SelectedItem);
            komut.Parameters.AddWithValue("@Ucret", txtUcret.Text);
            komut.Parameters.AddWithValue("@Durum", cbxDurum.SelectedItem);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Araç Kaydı Başarılı");
        }

        private void AracEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
