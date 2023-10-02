using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace net_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int dogru, yanlis, sayi;
            double net;
            dogru = Convert.ToInt32(txtDogru.Text);
            yanlis = Convert.ToInt32(txtYanlis.Text);
            sayi = Convert.ToInt32(txtSayi.Text);

            net = (double)dogru-(yanlis/4.0);
            lblNet.Text = "Netleri: " + net.ToString();
            
        }
    }
}
