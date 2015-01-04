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

namespace Otel_Otomasyonu
{
    public partial class OdalarForm : Form
    {
        SqlConnection baglanti;
        public OdalarForm()
        {
            InitializeComponent();
        }

        private void OdalarForm_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Data Source=BEGÜMBILGINCAN;Initial Catalog=Otel_Otomasyon;User Id=sa;Password=1234;Integrated Security=true");
            Oda_Liste();
        }
        public void Oda_Liste()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            try
            {
                SqlCommand komut = new SqlCommand("SELECT * FROM Odalar", baglanti);
                SqlDataAdapter adp = new SqlDataAdapter(komut);
                DataTable veriler = new DataTable();
                adp.Fill(veriler);
                OdalarListe.Items.Clear();

                if (veriler.Rows.Count > 0)
                {
                    for (int i = 0; i < veriler.Rows.Count; i++)
                    {
                        DataRow satir = veriler.Rows[i];

                        if (satir.RowState != DataRowState.Deleted)
                        {
                            ListViewItem item = new ListViewItem(satir["Isim"].ToString());
                            item.SubItems.Add(satir["Limit"].ToString());
                            item.SubItems.Add(satir["Durum"].ToString());
                            OdalarListe.Items.Add(item);
                        }
                    }
                }

                else
                    baglanti.Close();
            }
            catch (SqlException hata)
            {
                MessageBox.Show(hata.Message);
                throw;
            }
        }
        private void MEkleButon_Click(object sender, EventArgs e)
        {


            string durum = OdalarListe.SelectedItems[0].SubItems[2].Text;
            string odaisim = OdalarListe.SelectedItems[0].Text;
            string limit = OdalarListe.SelectedItems[0].SubItems[1].Text;
            
            
            if (durum=="Dolu")
            {
                MessageBox.Show("Dolu Durumda Olan Odaya Müşteri Eklenemez");
            }
            else
            {
                MusteriEkleForm musterieklemeformu = new MusteriEkleForm();
                musterieklemeformu.odaisim = odaisim;
                musterieklemeformu.limit = Convert.ToInt32(limit);
                musterieklemeformu.Show();
            }
        }
        private void MKaldırButon_Click(object sender, EventArgs e)
        {
            string isim = OdalarListe.SelectedItems[0].Text;
            string durum = OdalarListe.SelectedItems[0].SubItems[2].Text;
            try
            {
                if (durum == "Boş")
                {
                    MessageBox.Show("Boş Durumda Olan Oda Boşaltılamaz");
                }
                else if (durum == "Dolu")
                {
                    SqlCommand komut = new SqlCommand("UPDATE Odalar SET Durum=@Durum WHERE Isim=@Isim", baglanti);
                    komut.Parameters.AddWithValue("@Isim", isim);
                    komut.Parameters.AddWithValue("@Durum", "Boş");

                    //SqlCommand g_komut = new SqlCommand("UPDATE HangiOdadaKimVar SET Durum=@Durum WHERE Isım=@Isim",baglanti);
                    //g_komut.Parameters.AddWithValue("@Isim", isim);
                    //g_komut.Parameters.AddWithValue("@Durum", "Boş");

                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }
                    //g_komut.ExecuteNonQuery();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    Oda_Liste();

                    MessageBox.Show("Güncellendi.");
                }
            }

            catch (SqlException hata)
            {
                MessageBox.Show(hata.Message);
            }

        }
        private void OdalarListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void OdalarListe_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            try
            {
                string durum = OdalarListe.SelectedItems[0].SubItems[2].Text;
                
            }
            catch (ArgumentOutOfRangeException) { };

        }

        private void OdaIslemLAbel_Click(object sender, EventArgs e)
        {

        }

       /* public void Tablo_Guncelle()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            string isim = OdalarListe.SelectedItems[0].Text;
            string durum = OdalarListe.SelectedItems[0].SubItems[2].Text;

             try
            {
                if (durum == "Boş")
                {
                    MessageBox.Show("Boş Durumda Olan Oda Boşaltılamaz");
                }
                else if (durum == "Dolu")
                {
                    SqlCommand komut = new SqlCommand("UPDATE Odalar SET Durum=@Durum WHERE Isim=@Isim", baglanti);
                    komut.Parameters.AddWithValue("@Isim", isim);
                    komut.Parameters.AddWithValue("@Durum", "Boş");

                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    Oda_Liste();

                    MessageBox.Show("Güncellendi.");
                }
            }

            catch (SqlException hata)
            {
                MessageBox.Show(hata.Message);
          */ 
    }

  }
        
        



    


