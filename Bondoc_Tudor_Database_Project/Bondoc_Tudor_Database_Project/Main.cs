using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bondoc_Tudor_Database_Project
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=TUDORLAPTOP\\SQLEXPRESS;Initial Catalog=Laborator_analize;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Nume, Prenume from Pacienti;", con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            da.Dispose();
            dataGridView1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
