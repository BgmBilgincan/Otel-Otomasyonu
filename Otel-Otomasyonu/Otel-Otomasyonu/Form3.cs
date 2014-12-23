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
        }

        private void KaydetButon_Click(object sender, EventArgs e)
        {
             try
            {
                //if (int.TryParse(TCKimlik.Text, out girilen))
                if (TcKutu.Text.Trim() != "" && AdKutu.Text.Trim() != "" && SoyadKutu.Text.Trim() != "" && TelefonKutu.Text.Trim() != "" && CinsiyetKutu.Text.Trim() != "")
                {
                    baglanti.Open();
                    //ekle_komut.Connection = baglanti;
                    SqlCommand ekle_komut = new SqlCommand("INSERT INTO  Musteriler(TCKimlik, Ad, Soyad, Telefon, Cinsiyet) VALUES('" + TcKutu.Text + "', '" + AdKutu.Text + "', '" + SoyadKutu.Text + "', '" + TelefonKutu.Text + "' , '" + CinsiyetKutu.Text  + "')", baglanti);
                    ekle_komut.ExecuteNonQuery();
                    baglanti.Close();

                    
                    MessageBox.Show("Kayıt İşlemi Gerçekleşti");
                    for (int i = 0; i < this.Controls.Count; i++)
                    {
                        if (Controls[i] is TextBox) Controls[i].Text = ""; ;
                    }
                }
                else
                {
                    MessageBox.Show("Boş Alan Bırakamazsınız");
                }
            }

            catch(SqlException hata)
            {

                MessageBox.Show(hata.Message);
                baglanti.Close();
            }

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

       

     

     

    }

}