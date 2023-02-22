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
    public partial class Spisak_Pasa : Form
    {
        public Spisak_Pasa()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {//prebrojava koliko redova imamo u LW (List view-u)
            label1.Text = label1.Text + listView1.Items.Count;
            label2.Text = label2.Text + listView1.Items.Count;
            SqlConnection conn = DBUtils.getConnection();
            SqlCommand command = new SqlCommand("SELECT KategorijaID,PasID FROM Rezultat", conn);
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listView1.Columns.Add("KategorijaID", 150);
                    listView1.Columns.Add("PasID", 150);
                    //filllw uvek pocinje od 0 zato sto je niz
                    filllw(reader[0].ToString(), reader[1].ToString());
                }
                conn.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
        //puni listview
        public void filllw(string KategorijaID, string PasID)
        {
            string[] row = { KategorijaID, PasID };
            ListViewItem viewItem = new ListViewItem(row);
            listView1.Items.Add(viewItem);
        }

        private void Button2_Click(object sender, EventArgs e)
        {//povratak na prvu formu
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}