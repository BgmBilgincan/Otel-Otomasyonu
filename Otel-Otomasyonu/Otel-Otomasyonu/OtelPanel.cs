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
    public partial class OtelPanelForm : Form
    {
        public OtelPanelForm()
        {
            InitializeComponent();
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
           TarihLabel.Text = DateTime.Now.ToShortDateString();
           SaatLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void MusteriButon_Click(object sender, EventArgs e)
        {
            MusteriBilgiForm musteribilgiform = new MusteriBilgiForm();
            musteribilgiform.Show();
        }

        private void OdalarButon_Click(object sender, EventArgs e)
        {
            OdalarForm odalarformu = new OdalarForm();
            odalarformu.Show();
            
        }

        private void SaatLabel_Click(object sender, EventArgs e)
        {

        }

        private void OtelPanelForm_Load(object sender, EventArgs e)
        {
            Timer.Enabled = true;
        }

    }
}
