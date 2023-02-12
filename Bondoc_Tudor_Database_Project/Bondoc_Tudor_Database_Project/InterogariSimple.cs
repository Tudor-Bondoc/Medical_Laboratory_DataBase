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
    public partial class InterogariSimple : Form
    {
        public InterogariSimple()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=TUDORLAPTOP\\SQLEXPRESS;Initial Catalog=Laborator_analize;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select P.Nume, P.Prenume, PR.DataRecoltarii, L.Nume as NumeLaborant " +
                                            "from Pacienti P join Probe PR " +
                                            "on P.PacientID = PR.PacientID " +
                                            "join Laboranti L " +
                                            "on PR.LaborantID = L.LaborantID " +
                                            "where PR.DataRecoltarii > @date",con);
            cmd.Parameters.AddWithValue("@date", textBox1.Text);
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
            SqlCommand cmd = new SqlCommand("select C.Denumire, count (PC.ProbaID) as NrSolicitari " +
                                            "from Categorii_Analize C join Probe_Categorii PC " +
                                            "on C.CategorieID = PC.CategorieID " +
                                            "group by C.Denumire " +
                                            "order by NrSolicitari desc", con);
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
            SqlCommand cmd = new SqlCommand("select A.Denumire, R.Rezultat, A.IntervalReferintaMin, A.IntervalReferintaMax, P.CodProba " +
                                                "from Rezultate R join Analize A " +
                                                "on R.AnalizaID = A.AnalizaID " +
                                                "join Buletine B on R.BuletinID = B.BuletinID " +
                                                "join Probe P on P.ProbaID = B.ProbaID " +
                                                "where R.Rezultat < A.IntervalReferintaMin or R.Rezultat > A.IntervalReferintaMax", con);
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
