using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void IzlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //gasimo aplikaciju
            Application.Exit();
        }

        private void PrijavaPasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //kod za prebacivanje na sledecu formu
            //pravimo novi objekat
            Prijava_pasa pp = new Prijava_pasa();
            //prikazujemo novu formu
            pp.Show();
            //skrivamo staru
            this.Hide();
        }

        private void SpisakPasaPoRasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Spisak_Pasa sp = new Spisak_Pasa();
            sp.Show();
            this.Hide();
        }
    }
}
