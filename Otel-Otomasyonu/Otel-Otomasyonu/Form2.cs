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
    public partial class MusteriBilgiForm : Form
    {
        SqlConnection baglanti;
        public MusteriBilgiForm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void MüşteriBilgiForm_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Data Source=FATIMRENER;Initial Catalog=ders;Integrated Security=true");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {





        }
    }
}
