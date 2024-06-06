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
using System.Security.Cryptography.X509Certificates;

namespace arackiralamak
{
    public partial class AracListele : Form
    {
        public AracListele()
        {
            InitializeComponent();
        }

        private string baglantiCumlesi = @"Data Source=YAĞMUR\SQLEXPRESS;Initial Catalog=HamzaAracKiralama;Integrated Security=True";
        private void AracListele_Load(object sender, EventArgs e)
        {
            Arac_Listele();
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
        public void Arac_Listele()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Select * From Araclar";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Update Araclar set Marka = @marka,Seri=@seri,Model=@Model,Renk=@Renk,Kilometre=@Kilometre,Yakit=@yakitKira_Ucreti=@ucret,Durumu=@durumWhere Plaka=@Plaka";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            komut.Parameters.AddWithValue("@Plaka", txtPlaka.Text);
            komut.Parameters.AddWithValue("@marka", cbxMarka.SelectedItem);
            komut.Parameters.AddWithValue("@seri", cbxSeri.SelectedItem);
            komut.Parameters.AddWithValue("@Model", txtModel.Text);
            komut.Parameters.AddWithValue("@Renk", txtRenk.Text);
            komut.Parameters.AddWithValue("@Kilometre", txtKm.Text);
            komut.Parameters.AddWithValue("@yakit", cbxYakit.SelectedItem);
            komut.Parameters.AddWithValue("@Ucret", txtUcret.Text);
            komut.Parameters.AddWithValue("@Durum", cbxDurum.SelectedItem);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Arac_Listele();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Delete From Araclar where Plaka'" + dataGridView1.CurrentRow.Cells["Plaka"].Value.ToString() + "'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);

            komut.ExecuteNonQuery();
            baglanti.Close();
            Arac_Listele();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPlaka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cbxMarka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cbxSeri.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtModel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtRenk.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtKm.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            cbxYakit.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtUcret.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            cbxDurum.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }
    }
}
