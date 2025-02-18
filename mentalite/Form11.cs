using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mentalite
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        List<Ogrenciler> ogrenci = new List<Ogrenciler>();
        List<Ogretmenler> ogretmen = new List<Ogretmenler>();
        List<Alanlar> alan = new List<Alanlar>();
        List<Siniflar> sinif = new List<Siniflar>();
        List<Kulupler> kulup = new List<Kulupler>();

        private void Doldur() {

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ogrenci;

            dataGridView2.DataSource = null;
            dataGridView2.DataSource = sinif;

            cmbSinifi.DataSource = null;
            cmbSinifi.DataSource = sinif;
            cmbSinifi.DisplayMember = "sinifAdi";


            dataGridView3.DataSource = null;
            dataGridView3.DataSource = kulup;

            cmbKulup.DataSource = null;
            cmbKulup.DataSource = kulup;
            cmbKulup.DisplayMember = "kulupAdi";

            dataGridView4.DataSource = null;
            dataGridView4.DataSource = alan;

            cmbAlani.DataSource = null;
            cmbAlani.DataSource = alan;
            cmbAlani.DisplayMember = "alanAdi";

            dataGridView5.DataSource = null;
            dataGridView5.DataSource = ogretmen;

            cmbkulupogretmeni.DataSource = null;
            cmbkulupogretmeni.DataSource = ogretmen;
            cmbkulupogretmeni.DisplayMember = "ogretmenAdi";

            cmbsinifogretmeni.DataSource = null;
            cmbsinifogretmeni.DataSource = ogretmen;
            cmbsinifogretmeni.DisplayMember = "ogretmenAdi";





        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenciler og = new Ogrenciler();
            og.adi = txtadi.Text;
            og.tcNo = txtTC.Text;
            og.okulno = int.Parse(txtNo.Text);
            og.cinsiyet = cmbCinsiyet.Text;
            og.sinifi = cmbSinifi.Text;
            og.kulubu = cmbKulup.Text;
            og.alani = cmbAlani.Text;
            ogrenci.Add(og);
            Doldur();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Siniflar siniflar = new Siniflar();
            siniflar.sinifAdi = txtsinifadi.Text;
            siniflar.sinifOgretmeni = cmbsinifogretmeni.Text;
            sinif.Add(siniflar);
            Doldur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kulupler kulupler = new Kulupler();
            kulupler.kulupAdi = txtkulupadi.Text;
            kulupler.kulupOgretmeni = cmbkulupogretmeni.Text;
            kulup.Add(kulupler);
            Doldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Alanlar alanlar = new Alanlar();
            alanlar.alanAdi = txtalanadi.Text;
            alan.Add(alanlar);
            Doldur();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ogretmenler ogretmenler = new Ogretmenler();
            ogretmenler.ogretmenadi = txtogretmenadi.Text;
            ogretmenler.bransi = txtogretmenbransi.Text;
            ogretmen.Add(ogretmenler);
            Doldur();
        }
    }
}
