using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SınıfListview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // liste1.Items.Add

        }



        private void Submit_Click(object sender, EventArgs e)
        {
            int satir = liste1.Items.Count;
            liste1.Items.Add(SinifCombobox.Text);
            liste1.Items[satir].SubItems.Add(AdSoyadKutu.Text);
        }

        private void liste1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            
        }

        private void AdSoyadKutu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void TemizleButon_Click(object sender, EventArgs e)
        {
            AdSoyadKutu.Clear();
            liste1.Items.Clear();
        }


    }
}

