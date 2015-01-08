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

namespace Adonet
{
    public partial class AnaForm : Form
    {
        public SqlConnection Baglanti;
        public AnaForm()
        {
            InitializeComponent();
        }


        void BaglantiAc()
        {
            try
            {

                if (Baglanti.State == ConnectionState.Closed)
                {
                    Baglanti.Open();
                }

            }
            catch(Exception){}
        }


        void BaglantiKapat()
        {
            Baglanti.Close();
        
        }



        void Baglan()
        {
       
         Baglanti = new SqlConnection("Data Source=BEGÜMBILGINCAN;Initial Catalog=ders_test;User Id=sa;Password=1234;Integrated Security=true");
        
         }
            


        void Listele2()
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM uyeler", Baglanti);
            SqlDataReader rd = komut.ExecuteReader();

            while (rd.Read())
            {
                int i = Liste.Items.Count;

                Liste.Items.Add(rd["Isim"].ToString());
                Liste.Items[i].SubItems.Add(rd["TCKimlik"].ToString());
                Liste.Items[i].SubItems.Add(rd["Telefon"].ToString());
                Liste.Items[i].SubItems.Add(rd["Eposta"].ToString());
            
            
            }
        }


        void Listele()
        {
            BaglantiAc();
            SqlCommand komut = new SqlCommand("Select * From uyeler", Baglanti);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable veriler = new DataTable();
            adp.Fill(veriler);

            if (veriler.Rows.Count > 0)
            {
                for (int i = 0; i < veriler.Rows.Count; i++)
                {
                    Liste.Items.Add(veriler.Rows[i]["İsim"].ToString());
                    Liste.Items[i].SubItems.Add(veriler.Rows[i]["TCKimlik"].ToString());
                    Liste.Items[i].SubItems.Add(veriler.Rows[i]["Telefon"].ToString());
                    Liste.Items[i].SubItems.Add(veriler.Rows[i]["Eposta"].ToString());

                }
                    
            }
                
BaglantiKapat();
        }
    
        

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            Baglan();
            BaglantiAc();
            //Listele();
            Listele2();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
       

       
