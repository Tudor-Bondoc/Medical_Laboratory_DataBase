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
    public partial class Laboranti : Form
    {
        public Laboranti()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //afisati toti laborantii
        {
            SqlConnection con = new SqlConnection("Data Source=TUDORLAPTOP\\SQLEXPRESS;Initial Catalog=Laborator_analize;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select Nume, Prenume, DataNasterii, CNP, Sex, DataAngajarii, " +
                                            "Salariu, Telefon, Email " +
                                            "from Laboranti", con);
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

        private void button5_Click(object sender, EventArgs e) //interogare salariu
        {
            SqlConnection con = new SqlConnection("Data Source=TUDORLAPTOP\\SQLEXPRESS;Initial Catalog=Laborator_analize;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select L.Nume, L.Prenume, count(P.LaborantID) as NrProbe from Laboranti L join Probe P on L.LaborantID = P.LaborantID where L.Salariu < @sal group by L.Nume, L.Prenume having count(P.LaborantID) > @nr", con);
            cmd.Parameters.AddWithValue("@sal", textBox1.Text);
            cmd.Parameters.AddWithValue("@nr", textBox2.Text);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            da.Dispose();
            dataGridView1.DataSource = dt;
        }
    }
}
