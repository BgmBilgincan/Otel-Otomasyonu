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
            MusteriEkleForm musterieklemeformu = new MusteriEkleForm();
            musterieklemeformu.Show();
        }
    }
}

