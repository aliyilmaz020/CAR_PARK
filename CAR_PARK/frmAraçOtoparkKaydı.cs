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
    public partial class frmAraçOtoparkKaydı : Form
    {
        public frmAraçOtoparkKaydı()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=arac_otopark;Integrated Security=True");
        ErrorProvider errorProviderTc = new ErrorProvider();
        private void frmAraçOtoparkKaydı_Load(object sender, EventArgs e)
        {
            TCKontrol();
            BoşAraçlar();
            Marka();
        }

        private void TCKontrol()
        {
            if (txtTc.Text.Length != 11)
            {
                errorProviderTc.SetError(txtTc, "T.C. Kimlik Numarası 11 Haneli Olmalıdır");
            }


        }
        private void Marka()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select marka from markabilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboMarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void BoşAraçlar()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *from aracdurumu WHERE durumu='BOŞ'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboParkYeri.Items.Add(read["parkyeri"].ToString());
            }
            baglanti.Close();
        }

        private void btn_İptal(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into " +
                "arac_otopark_kaydi(tc,ad,soyad,telefon,plaka,marka,seri,renk,parkyeri,tarih) " +
                "values(@tc,@ad,@soyad,@telefon,@plaka,@marka,@seri,@renk,@parkyeri,@tarih)", baglanti);
            komut.Parameters.AddWithValue("@tc", txtTc.Text);
            komut.Parameters.AddWithValue("@ad", txtAd.Text);
            komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@plaka", txtPlaka.Text);
            komut.Parameters.AddWithValue("@marka",comboMarka.Text);
            komut.Parameters.AddWithValue("@seri", comboSeri.Text);
            komut.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut.Parameters.AddWithValue("@parkyeri", comboParkYeri.Text);
            komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            
            komut.ExecuteNonQuery();

            if (txtTc.Text.Length != 11)
            {
                MessageBox.Show("11 Haneli Olmalı");
                
            }
            else
            {
                SqlCommand komut2 = new SqlCommand("update aracdurumu set durumu = 'DOLU' where parkyeri='" +
                    comboParkYeri.SelectedItem + "'", baglanti);
                komut2.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Araç Kaydı Oluşturuldu", "Kayıt");
            }

            baglanti.Close();
            comboParkYeri.Items.Clear();
            BoşAraçlar();
            comboMarka.Items.Clear();
            Marka();
            comboSeri.Items.Clear();


            foreach(Control item in grupKişi.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            }
            foreach(Control item in grupAraç.Controls)
            {
                if(item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnMarka_Click(object sender, EventArgs e)
        {
            frmMarka marka= new frmMarka();
            marka.ShowDialog();
        }

        private void btnSeri_Click(object sender, EventArgs e)
        {
            frmSeri seri= new frmSeri();
            seri.ShowDialog();
        }

        private void comboMarka_SelectedIndexChanged(object sender, EventArgs e)
        {

            baglanti.Open();
            comboSeri.Items.Clear();
            SqlCommand komut = new SqlCommand("Select marka,seri from seribilgileri where marka='"+comboMarka.SelectedItem+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboSeri.Items.Add(read["seri"].ToString());
            }
            baglanti.Close();

        }

        
    }
}
