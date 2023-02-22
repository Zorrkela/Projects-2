using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace B30
{
    public partial class kliker : Form
    {
        public kliker()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void Kliker_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                Process klik = new Process();
                klik.StartInfo.FileName = @"C:\Users\Nikola\source\repos\Kliker\Kliker\bin\Debug\Kliker.exe";
                klik.EnableRaisingEvents = true;
                klik.Start();
                klik.WaitForExit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
    }
}
