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

namespace B30
{
    public partial class Slobodne_Sobe : Form
    {
        public Slobodne_Sobe()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
        public void filllw(string SobaID, string TipSobeID, string KategorijaCeneID, string Sprat, string Napomena, string DodaciID)
        {
            string[] row = { SobaID, TipSobeID,KategorijaCeneID , Sprat, Napomena, DodaciID };
            ListViewItem viewItem = new ListViewItem(row);
            listView1.Items.Add(viewItem);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            if (comboBox1.SelectedIndex==0)
            {
                if (comboBox2.SelectedIndex==0)
                {
                    string connectionstring = @"Data Source = DESKTOP-KIAEOL7;initial Catalog=B30;Integrated Security = SSPI;Connect Timeout =30; Encrypt = False;TrustServerCertificate = False;ApplicationIntent =ReadWrite;MultiSubnetFailover = False";
                    SqlConnection conn = new SqlConnection(connectionstring);
                    SqlCommand command = new SqlCommand("SELECT SobaID, TipSobeID, KategorijaCeneID , Sprat, Napomena , DodaciID FROM Soba", conn);
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            listView1.Columns.Add("SobaID", 150);
                            listView1.Columns.Add("TipSobeID", 150);
                            listView1.Columns.Add("KategorijaCeneID", 150);
                            listView1.Columns.Add("Sprat", 150);
                            listView1.Columns.Add("Napomena", 150);
                            listView1.Columns.Add("DodaciID", 150);
                            filllw(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());
                        }
                        conn.Close();
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message);
                    }
                }
            }
            if (comboBox1.SelectedIndex==1)
            {
                string connectionstring = @"Data Source = DESKTOP-KIAEOL7;initial Catalog=B30;Integrated Security = SSPI;Connect Timeout =30; Encrypt = False;TrustServerCertificate = False;ApplicationIntent =ReadWrite;MultiSubnetFailover = False";
                SqlConnection conn = new SqlConnection(connectionstring);
                SqlCommand command = new SqlCommand("SELECT SobaID, TipSobeID, KategorijaCeneID , Sprat, Napomena , DodaciID FROM Soba", conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        listView1.Columns.Add("SobaID", 150);
                        listView1.Columns.Add("TipSobeID", 150);
                        listView1.Columns.Add("KategorijaCeneID", 150);
                        listView1.Columns.Add("Sprat", 150);
                        listView1.Columns.Add("Napomena", 150);
                        listView1.Columns.Add("DodaciID", 150);
                        filllw(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());
                    }
                    conn.Close();
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
            }
            if (comboBox1.SelectedIndex==2)
            {
                string connectionstring = @"Data Source = DESKTOP-KIAEOL7;initial Catalog=B30;Integrated Security = SSPI;Connect Timeout =30; Encrypt = False;TrustServerCertificate = False;ApplicationIntent =ReadWrite;MultiSubnetFailover = False";
                SqlConnection conn = new SqlConnection(connectionstring);
                SqlCommand command = new SqlCommand("SELECT SobaID, TipSobeID, KategorijaCeneID , Sprat, Napomena , DodaciID FROM Soba", conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        listView1.Columns.Add("SobaID", 150);
                        listView1.Columns.Add("TipSobeID", 150);
                        listView1.Columns.Add("KategorijaCeneID", 150);
                        listView1.Columns.Add("Sprat", 150);
                        listView1.Columns.Add("Napomena", 150);
                        listView1.Columns.Add("DodaciID", 150);
                        filllw(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());
                    }
                    conn.Close();
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
            }
        }

        private void Slobodne_Sobe_Load(object sender, EventArgs e)
        {

        }
    }
}
