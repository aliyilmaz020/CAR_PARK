using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAR_PARK
{
    public partial class frmAraçOtoparkÇıkışı : Form
    {
        public frmAraçOtoparkÇıkışı()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=araç_otopark;Integrated Security=True");

        

        private void frmAraçOtoparkÇıkışı_Load(object sender, EventArgs e)
        {
            DoluYerler();
            Plakalar();
            timer1.Enabled = true;
        }

        private void Plakalar()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from araç_otopark_kaydı", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboPlaka.Items.Add(read["plaka"].ToString());
            }
            baglanti.Close();
        }

        private void DoluYerler()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from araçdurumu WHERE durumu='DOLU'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboParkYeri.Items.Add(read["parkyeri"].ToString());
            }
            baglanti.Close();
        }

        private void comboPlaka_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from araç_otopark_kaydı WHERE plaka='"+comboPlaka.SelectedItem+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtParkYeri.Text = read["parkyeri"].ToString(); 
            }
            baglanti.Close();
        }

        private void comboParkYeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from araç_otopark_kaydı WHERE parkyeri='" + comboParkYeri.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtParkYeri2.Text = read["parkyeri"].ToString();
                txtTc.Text = read["tc"].ToString();
                txtAd.Text = read["ad"].ToString();
                txtSoyad.Text = read["soyad"].ToString();
                txtMarka.Text = read["marka"].ToString();
                txtSeri.Text = read["seri"].ToString();
                txtPlaka.Text = read["plaka"].ToString();
                lblGelişTarihi.Text = read["tarih"].ToString();
            }
            baglanti.Close();
            DateTime geliş, çıkış;
            geliş = DateTime.Parse(lblGelişTarihi.Text);
            çıkış = DateTime.Parse(lblÇıkışTarihi.Text);
            TimeSpan fark;
            fark = çıkış - geliş;
            lblSüre.Text=fark.TotalHours.ToString("0.00");
           
            lblToplamTutar.Text= (double.Parse(lblSüre.Text)*(0.75)).ToString("0.00");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblÇıkışTarihi.Text=DateTime.Now.ToString();
        }

        private void btnAraçÇıkışı_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM araç_otopark_kaydı where plaka='"+txtPlaka.Text+"'", baglanti);
            komut.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand("UPDATE araçdurumu set durumu='BOŞ' where parkyeri='" + txtParkYeri2.Text + "'", baglanti);
            komut2.ExecuteNonQuery();
            SqlCommand komut3 = new SqlCommand("INSERT INTO satis(parkyeri,plaka,geliş_tarihi,çıkış_tarihi,süre,tutar) values(@parkyeri,@plaka,@geliş_tarihi,@çıkış_tarihi,@süre,@tutar)", baglanti);
            
            komut3.Parameters.AddWithValue("@parkyeri",txtParkYeri2.Text);
            komut3.Parameters.AddWithValue("@plaka", txtPlaka.Text);
            komut3.Parameters.AddWithValue("@geliş_tarihi", lblGelişTarihi.Text);
            komut3.Parameters.AddWithValue("@çıkış_tarihi", lblÇıkışTarihi.Text);
            komut3.Parameters.AddWithValue("@süre", double.Parse(lblSüre.Text));
            komut3.Parameters.AddWithValue("@tutar", double.Parse(lblToplamTutar.Text));

            komut3.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Araç çıkışı yapıldı.");
           
            foreach(Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                    txtParkYeri.Text = "";
                    comboParkYeri.Text = "";
                    comboPlaka.Text = "";
                }
            }
            comboPlaka.Items.Clear();
            comboParkYeri.Items.Clear();
            DoluYerler();
            Plakalar();
        }
    }
}
