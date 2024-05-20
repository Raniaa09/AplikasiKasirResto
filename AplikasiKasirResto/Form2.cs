using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiKasirResto
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double bpDonat, bpPancake, bpBrownis, bplemonTea, bpmineralWater, bpMojito, bptotalBiaya, bpUang, bpbiayaPajak, bpKembalian;
            double hargaDn, hargaPc, hargaBw, hargaLt, hargaMw, hargaMt, bptotalPembayaran;

            bpDonat = double.Parse(Donat.Text);
            bpPancake = double.Parse(Pancake.Text);
            bpBrownis = double.Parse(Brownis.Text);
            bplemonTea = double.Parse(lemonTea.Text);
            bpmineralWater = double.Parse(mineralWater.Text);
            bpMojito = double.Parse(numericUpDown1.Text);
            bpUang = double.Parse(Uang.Text);

            hargaDn = bpDonat * 5000;
            hargaPc = bpPancake * 5000;
            hargaBw = bpBrownis * 15000;
            hargaLt = bplemonTea * 7000;
            hargaMw = bpMojito * 4000;
            hargaMt = bpMojito * 8000;

            bptotalPembayaran = hargaDn + hargaPc + hargaBw + hargaLt + hargaMw + hargaMt;
            bpbiayaPajak = bptotalPembayaran * 0.1;

            bptotalBiaya = bptotalPembayaran + bpbiayaPajak;
            bpKembalian = bpUang - bptotalBiaya;

            totalBiaya.Text = "Rp." + bptotalBiaya.ToString("N");
            biayaPajak.Text = "Rp." + bpbiayaPajak.ToString("N");
            totalPembayaran.Text = "Rp." + bptotalPembayaran.ToString("N");
            Kembalian.Text = "Rp." + bpKembalian.ToString("N");
            Uang.Text = "Rp." + bpUang.ToString("N");


            if (bpUang < bptotalPembayaran)
            {
                MessageBox.Show("Mohon membayar sesuai total biaya");
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Donat.Text = "0";
            Pancake.Text = "0";
            Brownis.Text = "0";
            lemonTea.Text = "0";
            mineralWater.Text = "0";
            numericUpDown1.Text = "0";
            Uang.Text = "";
            biayaPajak.Text = "";
            totalPembayaran.Text = "";
            totalBiaya.Text = "";
            Kembalian.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void Kembalian_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double bpDonat, bpPancake, bpBrownis, bplemonTea, bpmineralWater, bpMojito, bpbiayaPajak, bptotalBiaya;
            double hargaDn, hargaPc, hargaBw, hargaLt, hargaMw, hargaMt, bptotalPembayaran;

            bpDonat = double.Parse(Donat.Text);
            bpPancake = double.Parse(Pancake.Text);
            bpBrownis = double.Parse(Brownis.Text);
            bplemonTea = double.Parse(lemonTea.Text);
            bpmineralWater = double.Parse(mineralWater.Text);
            bpMojito = double.Parse(numericUpDown1.Text);

            hargaDn = bpDonat * 5000;
            hargaPc = bpPancake * 5000;
            hargaBw = bpBrownis * 15000;
            hargaLt = bplemonTea * 7000;
            hargaMw = bpMojito * 4000;
            hargaMt = bpMojito * 8000;

            bptotalPembayaran = hargaDn + hargaPc + hargaBw + hargaLt + hargaMw + hargaMt;
            bpbiayaPajak = bptotalPembayaran * 0.1;
            bptotalBiaya = bptotalPembayaran + bpbiayaPajak;

            biayaPajak.Text = "Rp." + bpbiayaPajak.ToString("N");
            totalPembayaran.Text = "Rp." + bptotalPembayaran.ToString("N");
            totalBiaya.Text = "Rp. " + bptotalBiaya.ToString("N");
        }
    }
}
