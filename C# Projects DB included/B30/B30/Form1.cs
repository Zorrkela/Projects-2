using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gostiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unos un = new Unos();
            un.Show();
            this.Hide();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void slobodneSobeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Slobodne_Sobe sb = new Slobodne_Sobe();
            sb.Show();
            this.Hide();
        }

        private void KlikerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kliker kl = new kliker();
            this.Hide();
            kl.Show();
        }
    }
}
