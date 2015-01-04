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
    public partial class MusteriEkleForm : Form
    {
        SqlConnection baglanti;
        public string odaisim;
        public int odaid, limit;
        public MusteriEkleForm()
        {
            InitializeComponent();
        }

        private void Cikisbuton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MusteriEkleForm_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Data Source=BEGÜMBILGINCAN;Initial Catalog=Otel_Otomasyon;User Id=sa;Password=1234;Integrated Security=true");

            OdaIDBul();
            Musteriler_Bag();
        }

        void OdaIDBul()
        {
            baglanti.Open();
            SqlCommand ekle_komut = new SqlCommand("select ID from Odalar Where Isim = '" + odaisim + "'", baglanti);
            odaid = Convert.ToInt32(ekle_komut.ExecuteScalar());
            baglanti.Close();
        }

        void Kontrol(int limit, int count)
        {
            if (limit == count)
            {
                TcKutu.Enabled = false;
                AdKutu.Enabled = false;
                SoyadKutu.Enabled = false;
                TelefonKutu.Enabled = false;
                CinsiyetKutu.Enabled = false;
                GTime.Enabled = false;
                CTime.Enabled = false;
            }
        }

        private void KaydetButon_Click(object sender, EventArgs e)
        {


            if (limit > EkleListe.Items.Count)
            {
                try
                {

                    if (TcKutu.Text.Trim() != "" && AdKutu.Text.Trim() != "" && SoyadKutu.Text.Trim() != "" && TelefonKutu.Text.Trim() != "" && CinsiyetKutu.Text.Trim() != "")
                    {

                        baglanti.Open();
                        SqlCommand ekle_komut = new SqlCommand("INSERT INTO  Musteriler(TCKimlik, Ad, Soyad, Telefon, Cinsiyet) VALUES('" + TcKutu.Text + "', '" + AdKutu.Text + "', '" + SoyadKutu.Text + "', '" + TelefonKutu.Text + "' , '" + CinsiyetKutu.Text + "') select scope_identity() as mayki", baglanti);
                        int haci = Convert.ToInt32(ekle_komut.ExecuteScalar());
                        MessageBox.Show(haci.ToString());
                        string ifade = "INSERT INTO HangiOdadaKimVar(OdaID, MusteriID, GirisTarihi,CikisTarihi, Durum) VALUES('" + odaid + "','" + haci + "','" + String.Format("{0:yyyy-MM-dd}",GTime.Value) + "', '" + String.Format("{0:yyyy-MM-dd}",CTime.Value) + "','Yuppi')";

                        MessageBox.Show(ifade);
                        SqlCommand ekleme_komut = new SqlCommand("INSERT INTO HangiOdadaKimVar(OdaID, MusteriID, GirisTarihi,CikisTarihi, Durum) VALUES('" + odaid + "','" + haci + "','" + String.Format("{0:yyyy-MM-dd}", GTime.Value) + "', '" + String.Format("{0:yyyy-MM-dd}", CTime.Value) + "','Yuppi')", baglanti);
                        ekleme_komut.ExecuteNonQuery();
                        //MessageBox.Show("begüm");
                        SqlCommand gncelle_komut = new SqlCommand("UPDATE Odalar SET Durum='Dolu' WHERE ID='" + odaid + "'", baglanti);

                        gncelle_komut.ExecuteNonQuery();
                        //MessageBox.Show("begüm2");
                        baglanti.Close();

                        Musteriler_Bag();
                        MessageBox.Show("Kayıt İşlemi Gerçekleşti");
                        for (int i = 0; i < this.Controls.Count; i++)
                        {
                            if (Controls[i] is TextBox) Controls[i].Text = ""; 
                        }
                    }
                    else
                    {

                        MessageBox.Show("Boş Alan Bırakamazsınız");
                    }
                }

                catch (SqlException hata)
                {

                    MessageBox.Show(hata.Message);
                    baglanti.Close();
                }
            }
            else
            {

                MessageBox.Show("Yeni kişi eklenemez");
            }

            Kontrol(limit, EkleListe.Items.Count);


        }

        private void TelefonKutu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TcKutu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void AdKutu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void SoyadKutu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void CinsiyetKutu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void TCLabel_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Musteriler_Bag()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            try
            {
                SqlCommand listeKomutu = new SqlCommand("SELECT * FROM HangiOdadaKimVar as H left join Musteriler as M ON(M.ID = H.MusteriID) where OdaID='" + odaid + "' ", baglanti);
                SqlDataAdapter adp = new SqlDataAdapter(listeKomutu);
                DataTable veriler = new DataTable();
                adp.Fill(veriler);
                EkleListe.Items.Clear();



                if (veriler.Rows.Count > 0)
                {
                    for (int i = 0; i < veriler.Rows.Count; i++)
                    {
                        DataRow satir = veriler.Rows[i];

                        if (satir.RowState != DataRowState.Deleted)
                        {
                            ListViewItem item = new ListViewItem(satir["TCKimlik"].ToString());
                            item.SubItems.Add(satir["Ad"].ToString());
                            item.SubItems.Add(satir["Soyad"].ToString());
                            item.SubItems.Add(satir["Telefon"].ToString());
                            item.SubItems.Add(satir["Cinsiyet"].ToString());
                            item.SubItems.Add(string.Format("{0:yyyy-MM-dd}", satir["GirisTarihi"]));
                            item.SubItems.Add(string.Format("{0:yyyy-MM-dd}", satir["CikisTarihi"]));
                            EkleListe.Items.Add(item);
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SoyadKutu_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AdKutu_TextChanged(object sender, EventArgs e)
        {

        }

        /* public void Guncelle()
         { 
             string isim = OdalarListe.SelectedItems[0].Text;
             string durum = OdalarListe.SelectedItems[0].SubItems[2].Text;
             try
             {
                 if (durum == "Boş")
                 {
                  
                     SqlCommand gncelle_komut = new SqlCommand("UPDATE Odalar SET Durum=@Durum WHERE Isim=@Isim", baglanti);
                     gncelle_komut.Parameters.AddWithValue("@Isim", isim);
                     gncelle_komut.Parameters.AddWithValue("@Durum", "Dolu");
                     gncelle_komutkomut.ExecuteNonQuery();
                     baglanti.Close();
                     MessageBox.Show("Güncellendi.");
                 }
             }

             catch (SqlException hata)
             {
                 MessageBox.Show(hata.Message);
             }

        */
    }


}





