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
    public partial class InformatiiComplexe : Form
    {
        public InformatiiComplexe()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=TUDORLAPTOP\\SQLEXPRESS;Initial Catalog=Laborator_analize;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select L.Nume, L.Prenume " +
                                            "from Laboranti L " +
                                            "where L.LaborantID not in " +
                                            "(" +
                                            "select LL.LaborantID " +
                                            "from Laboranti LL inner join Probe P " +
                                            "on LL.LaborantID = P.LaborantID" +
                                            ")", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            da.Dispose();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=TUDORLAPTOP\\SQLEXPRESS;Initial Catalog=Laborator_analize;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select L.Nume, L.Prenume from Laboranti L " +
                                            "order by (" +
                                            "select count(*) " +
                                            "from Probe P where P.LaborantID = L.LaborantID " +
                                            ") desc", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            da.Dispose();
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=TUDORLAPTOP\\SQLEXPRESS;Initial Catalog=Laborator_analize;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select P.Nume, P.Prenume, (" +
                                            "select count(*) from Probe Pr where P.PacientID = Pr.PacientID " +
                                            ") as NrProbe " +
                                            "from Pacienti P", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            da.Dispose();
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=TUDORLAPTOP\\SQLEXPRESS;Initial Catalog=Laborator_analize;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select I.Nume, I.Prenume, I.Salariu " +
                                            "from (" +
                                            "select top 3 L.Nume as Nume, L.Prenume as Prenume, " +
                                            "L.Salariu as Salariu " +
                                            "from Laboranti L " +
                                            "order by L.Salariu desc) as I", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            da.Dispose();
            dataGridView1.DataSource = dt;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.Show();
        }
    }
}
