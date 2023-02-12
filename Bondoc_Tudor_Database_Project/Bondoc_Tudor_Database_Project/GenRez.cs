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
    public partial class GenRez : Form
    {
        public GenRez()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //generare buletin
        {
            SqlConnection con = new SqlConnection("Data Source=TUDORLAPTOP\\SQLEXPRESS;Initial Catalog=Laborator_analize;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select A.Denumire, R.Rezultat, A.UnitateMasura, A.IntervalReferintaMin, A.IntervalReferintaMax " +
                                            "from Analize A join Rezultate R " +
                                            "on A.AnalizaID = R.AnalizaID " +
                                            "join Buletine B " +
                                            "on R.BuletinID = B.BuletinID " +
                                            "join Probe P " +
                                            "on B.ProbaID = P.ProbaID " +
                                            "where P.CodProba = @cp", con);
            cmd.Parameters.AddWithValue("@cp", textBox1.Text);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            da.Dispose();
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e) //exit button
        {
            Environment.Exit(1);
        }

        private void button4_Click(object sender, EventArgs e) //menu button
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e) //show button
        {

            SqlConnection con = new SqlConnection("Data Source=TUDORLAPTOP\\SQLEXPRESS;Initial Catalog=Laborator_analize;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select PA.Nume, PR.CodProba " +
                                            "from Pacienti PA join Probe PR " +
                                            "on PA.PacientID = PR.PacientID", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            da.Dispose();
            dataGridView2.DataSource = dt;
        }
    }
}
