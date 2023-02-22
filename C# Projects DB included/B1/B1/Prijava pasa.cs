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

namespace B1
{
    public partial class Prijava_pasa : Form
    {
        public Prijava_pasa()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void RadioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            //kada korisnik klikne na upisi comboBox se otkljucava i moze da se menja vrednost unutar CB(ComboBox-a).
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            //stavljamo vrednost CB na pocetnu
            /*
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            */
            button1.Enabled = true;
            button2.Enabled = false;
        }
        private void RadioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;/*
            comboBox1.SelectedIndex = 1;
            comboBox2.SelectedIndex = 1;
            comboBox3.SelectedIndex = 1;*/
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //unos u bazu
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("PasID", comboBox1.SelectedValue);
            parameters.Add("IzlozbaID", comboBox2.SelectedValue);
            parameters.Add("KategorijaID", comboBox3.SelectedValue);
            parameters.Add("Rezultat", 0);
            DBUtils.newTableRecord("dbo.Rezultat", parameters);
            MessageBox.Show("Uspesno ste uneli Rezultat!");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //brisanje iz baze
            SqlConnection conn = DBUtils.getConnection();
            SqlCommand command = new SqlCommand("DELETE FROM Rezultat WHERE PasID= '" + comboBox1.SelectedValue + "'", conn);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Rezultat je uspesno obrisan!");
                conn.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void Prijava_pasa_Load(object sender, EventArgs e)
        {

        }
    }
}
