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

namespace CAR_PARK
{
    public partial class frmAraçOtoparkYerleri : Form
    {
        public frmAraçOtoparkYerleri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-RRM41TI\\SQLEXPRESS;Initial Catalog=araç_otopark;Integrated Security=True");

        private void frmAraçOtoparkYerleri_Load(object sender, EventArgs e)
        {
            int sayac = 1;
            foreach(Control item in Controls)
            {
                if(item is Button)
                {
                    item.Text = "P-" + sayac;
                    item.Name = "P-" + sayac;
                    sayac++;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
