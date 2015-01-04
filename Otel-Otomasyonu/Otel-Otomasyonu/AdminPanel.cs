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

namespace Otel_Otomasyonu
{
    
    public partial class AdminPanel : Form
    {
        SqlConnection baglanti;
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Data Source=BEGÜMBILGINCAN;Initial Catalog=Otel_Otomasyon;User Id=sa;Password=1234;Integrated Security=true");
        }

        private void GirisButon_Click(object sender, EventArgs e)
        {
            string vay = KullanıcıKutu.Text.Trim().ToLower();
            string arkadas = ŞifreKutu.Text.Trim().ToLower();

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            if (vay.Length > 0 && arkadas.Length > 0)
            {
                SqlCommand kontrol = new SqlCommand("SELECT * FROM Yetkili WHERE vay='" + vay + "' AND arkadas='" + arkadas + "'", baglanti);
                SqlDataReader rd = kontrol.ExecuteReader();

                if (rd.Read())
                {
                    this.Hide();
                    OtelPanelForm panelformu = new OtelPanelForm();
                    panelformu.Show();
                }
                else
                {
                    MessageBox.Show("Hacı abi naptın ya?");
                    KullanıcıKutu.Clear();
                    ŞifreKutu.Clear();
                }

            }
            else
            {
                MessageBox.Show("Lütfen boş bırakmayın hiç bir kutuyu.");
            }
            baglanti.Close();
            
           
        }

        private void CikisButon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
