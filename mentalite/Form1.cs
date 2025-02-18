using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        ArrayList kitapList = new ArrayList();
        ArrayList turler = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            Kitaplar kitaplar = new Kitaplar();
            kitaplar.kitapadi = txtkitap.Text;
            kitaplar.kitapyazari = txtyazar.Text;
            kitaplar.sayfasayisi = int.Parse(txtsayfa.Text);
            kitapList.Add(kitaplar);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Doldur();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kitaplar kitaplar = new Kitaplar();
            kitaplar.kitapturu = txtturekle.Text;
            turler.Add(kitaplar.kitapturu);
            Doldur();
        }

        private void Doldur() 
        {
            lstkitap.DataSource = null;
            lstkitap.DataSource = kitapList;
            lstkitap.DisplayMember = "kitapadi";

            listBox2.DataSource = null;
            listBox2.DataSource = turler;
            listBox2.DisplayMember = "kitapadi";

            cTuru.DataSource = null;
            cTuru.DataSource = turler;
            cTuru.DisplayMember = "kitapadi";
        }

        private void cTuru_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
