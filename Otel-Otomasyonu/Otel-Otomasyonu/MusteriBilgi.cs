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
using System.Text.RegularExpressions;

namespace Otel_Otomasyonu
{
    public partial class MusteriBilgiForm : Form
    {
        SqlConnection baglanti;
        public MusteriBilgiForm()
        {
            InitializeComponent();
        }

        private void MüşteriBilgiForm_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Data Source=BEGÜMBILGINCAN;Initial Catalog=Otel_Otomasyon;User Id=sa;Password=1234;Integrated Security=true");
            Arama_Kısmı();

        }

        private void AramaKutu_TextChanged(object sender, EventArgs e)
        {
            Arama_Kısmı();

        }

        public void Arama_Kısmı()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            try
            {
                SqlCommand komut = new SqlCommand("SELECT M.TCKimlik, M.Ad+' '+M.Soyad as AdSoyad, H.GirisTarihi, H.CikisTarihi, O.Isim FROM HangiOdadaKimVar as H LEFT JOIN Musteriler as M ON (H.MusteriID = M.ID) LEFT JOIN Odalar as O ON (H.OdaID = O.ID) WHERE M.TCKimlik LIKE '%" + AramaKutu.Text + "%'", baglanti);
                SqlDataAdapter adp = new SqlDataAdapter(komut);
                DataTable veriler = new DataTable();
                adp.Fill(veriler);
                Liste.Items.Clear();

                if (veriler.Rows.Count > 0)
                {
                    for (int i = 0; i < veriler.Rows.Count; i++)
                    {
                        DataRow satir = veriler.Rows[i];

                        if (satir.RowState != DataRowState.Deleted)
                        {
                            ListViewItem item = new ListViewItem(satir["TCKimlik"].ToString());
                            item.SubItems.Add(satir["AdSoyad"].ToString());
                            item.SubItems.Add(String.Format("{0:d}", satir["GirisTarihi"]));
                            item.SubItems.Add(String.Format("{0:d}", satir["CikisTarihi"]));
                            item.SubItems.Add(satir["Isim"].ToString());

                            Liste.Items.Add(item);
                        }
                    }
                }
               
                baglanti.Close();
            }
            catch (SqlException hata)
            {
                MessageBox.Show(hata.Message);
                throw;
            }
        }

        private void AramaKutu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Liste_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
    
        

              
         

