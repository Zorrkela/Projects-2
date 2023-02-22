using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace B30
{
    public partial class Unos : Form
    {
        public Unos()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Mozete uneti samo brojeve");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("GostID", textBox1.Text);
            parameters.Add("Ime", textBox2.Text);
            parameters.Add("Prezime", textBox3.Text);
            parameters.Add("Adresa", textBox4.Text);
            parameters.Add("Email", textBox5.Text);
            parameters.Add("Telefon", textBox6.Text);
            parameters.Add("DatumRodjenja", DateTime.Parse( maskedTextBox1.Text));
            DBUtils.newTableRecord("dbo.Gost", parameters);
            MessageBox.Show("Uspesno uneti podaci");
            string connectionstring = @"Data Source =DESKTOP-KIAEOL7;initial Catalog=B30;Integrated Security = SSPI;Connect Timeout =30; Encrypt = False;TrustServerCertificate = False;ApplicationIntent =ReadWrite;MultiSubnetFailover = False";
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlCommand command = new SqlCommand("SELECT GostID,Ime,Prezime,Adresa,Email,Telefon,DatumRodjenja FROM Gost", conn);
            listView1.Clear();
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listView1.Columns.Add("GostID", 150);
                    listView1.Columns.Add("Ime", 150);
                    listView1.Columns.Add("Prezime", 150);
                    listView1.Columns.Add("Adresa", 150);
                    listView1.Columns.Add("Email", 150);
                    listView1.Columns.Add("Telefon", 150);
                    listView1.Columns.Add("DatumRodjenja", 150);
                    filllw(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString());
                }
                conn.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source =DESKTOP-KIAEOL7;initial Catalog=B30;Integrated Security = SSPI;Connect Timeout =30; Encrypt = False;TrustServerCertificate = False;ApplicationIntent =ReadWrite;MultiSubnetFailover = False";
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlCommand command = new SqlCommand("DELETE FROM Gost WHERE GostID= '" + textBox1.Text + "'", conn);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Gost je uspesno obrisan!");
                conn.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            SqlCommand command1 = new SqlCommand("SELECT GostID,Ime,Prezime,Adresa,Email,Telefon,DatumRodjenja FROM Gost", conn);
            listView1.Clear();
            try
            {
                conn.Open();
                SqlDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    listView1.Columns.Add("GostID", 150);
                    listView1.Columns.Add("Ime", 150);
                    listView1.Columns.Add("Prezime", 150);
                    listView1.Columns.Add("Adresa", 150);
                    listView1.Columns.Add("Email", 150);
                    listView1.Columns.Add("Telefon", 150);
                    listView1.Columns.Add("DatumRodjenja", 150);
                    filllw(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString());
                }
                conn.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void Unos_Load(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source =DESKTOP-KIAEOL7;initial Catalog=B30;Integrated Security = SSPI;Connect Timeout =30; Encrypt = False;TrustServerCertificate = False;ApplicationIntent =ReadWrite;MultiSubnetFailover = False";
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlCommand command = new SqlCommand("SELECT GostID,Ime,Prezime,Adresa,Email,Telefon,DatumRodjenja FROM Gost", conn);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listView1.Columns.Add("GostID", 150);
                    listView1.Columns.Add("Ime", 150);
                    listView1.Columns.Add("Prezime", 150);
                    listView1.Columns.Add("Adresa", 150);
                    listView1.Columns.Add("Email", 150);
                    listView1.Columns.Add("Telefon", 150);
                    listView1.Columns.Add("DatumRodjenja", 150);
                    filllw(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(),reader[4].ToString(),reader[5].ToString(),reader[6].ToString());
                }
                conn.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
        public void filllw(string GostID, string Ime, string Prezime, string Adresa , string Email , string Telefon, string DatumRodjenja)
        {
            string[] row = { GostID, Ime,Prezime, Adresa,Email,Telefon,DatumRodjenja };
            ListViewItem viewItem = new ListViewItem(row);
            listView1.Items.Add(viewItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source =DESKTOP-KIAEOL7;initial Catalog=B30;Integrated Security = SSPI;Connect Timeout =30; Encrypt = False;TrustServerCertificate = False;ApplicationIntent =ReadWrite;MultiSubnetFailover = False";
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlCommand command = new SqlCommand("UPDATE Gost SET Ime='" + textBox2.Text + "' WHERE GostID = '" + textBox1.Text + "'", conn);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Uspesno izmenjeni podaci!");
                conn.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            
            SqlCommand command1 = new SqlCommand("SELECT GostID,Ime,Prezime,Adresa,Email,Telefon,DatumRodjenja FROM Gost", conn);
            listView1.Clear();
            try
            {
                conn.Open();
                SqlDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    listView1.Columns.Add("GostID", 150);
                    listView1.Columns.Add("Ime", 150);
                    listView1.Columns.Add("Prezime", 150);
                    listView1.Columns.Add("Adresa", 150);
                    listView1.Columns.Add("Email", 150);
                    listView1.Columns.Add("Telefon", 150);
                    listView1.Columns.Add("DatumRodjenja", 150);
                    filllw(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString());
                }
                conn.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
    }
}