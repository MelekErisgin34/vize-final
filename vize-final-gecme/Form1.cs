using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vize_final_gecme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vize, final, ortalama;
            vize = Convert.ToDouble(txtVize.Text);
            final = Convert.ToDouble(txtFinal.Text);
            ortalama = (vize * 40 / 100) + (final * 60 / 100);
            lblOrtalama.Text = "Ortalamanız:" + ortalama;
            

            if (ortalama >= 50 && final>=50)
            {
                lblDurum.Text = "Durum:  GEÇTİ";           
            }
            else
            {
                lblDurum.Text = "Ortalamanız:  KALDI";
            }
        }
    }
}
