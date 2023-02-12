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
    public partial class Pacienti_main : Form
    {
        public Pacienti_main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)  //ADD BUTTON
        {
            SqlConnection con = new SqlConnection("Data Source=TUDORLAPTOP\\SQLEXPRESS;Initial Catalog=Laborator_analize;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Pacienti values (@Nume, @Prenume, @Data_nasterii, @Sex, @Cnp, @Tel, @Email)", con);
            cmd.Parameters.AddWithValue("@Nume", textBox1.Text);
            cmd.Parameters.AddWithValue("@Prenume", textBox2.Text);
            cmd.Parameters.AddWithValue("@Data_nasterii", textBox3.Text);
            cmd.Parameters.AddWithValue("@Sex", comboBox1.Text);
            cmd.Parameters.AddWithValue("@Cnp", textBox4.Text);
            cmd.Parameters.AddWithValue("@Tel", textBox5.Text);
            cmd.Parameters.AddWithValue("@Email", textBox6.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Success");
        }

        private void button2_Click(object sender, EventArgs e)  //SEARCH BUTTON
        {
            SqlConnection con = new SqlConnection("Data Source=TUDORLAPTOP\\SQLEXPRESS;Initial Catalog=Laborator_analize;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Pacienti where Nume=@Nume", con);
            cmd.Parameters.AddWithValue("@Nume", textBox7.Text);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            da.Dispose();
            dataGridView1.DataSource = dt;
            //con.Close();
        }

        private void button3_Click(object sender, EventArgs e)  //EXIT BUTTON
        {
            Environment.Exit(1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            //populate the textboxes based on the row selected by the user in the grid view
            textBox1.Text = row.Cells[1].Value.ToString();
            textBox2.Text = row.Cells[2].Value.ToString();
            textBox3.Text = row.Cells[3].Value.ToString();
            comboBox1.Text = row.Cells[4].Value.ToString();
            textBox4.Text = row.Cells[5].Value.ToString();
            textBox5.Text = row.Cells[6].Value.ToString();
            textBox6.Text = row.Cells[7].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)  //UPDATE BUTTON
        {
            SqlConnection con = new SqlConnection("Data Source=TUDORLAPTOP\\SQLEXPRESS;Initial Catalog=Laborator_analize;Integrated Security=True");
            con.Open();
            SqlCommand getId = new SqlCommand("select PacientID from Pacienti where CNP=@Cnp", con);
            getId.Parameters.AddWithValue("@Cnp", textBox4.Text);
            int id = (int)getId.ExecuteScalar();
            SqlCommand update_cmd = new SqlCommand("update Pacienti set Nume=@Nume, Prenume=@Prenume, " +
                                                   "DataNasterii=@Data, Sex=@Sex, Telefon=@Tel, Email=@Mail " +
                                                   "where CNP=@Cnp", con);
            update_cmd.Parameters.AddWithValue("@Nume", textBox1.Text);
            update_cmd.Parameters.AddWithValue("@Prenume", textBox2.Text);
            update_cmd.Parameters.AddWithValue("@Data", textBox3.Text);
            update_cmd.Parameters.AddWithValue("@Sex", comboBox1.Text);
            update_cmd.Parameters.AddWithValue("@Cnp", textBox4.Text);
            update_cmd.Parameters.AddWithValue("@Tel", textBox5.Text);
            update_cmd.Parameters.AddWithValue("@Mail", textBox6.Text);
            update_cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)  //DELETE BUTTON
        {
            SqlConnection con = new SqlConnection("Data Source=TUDORLAPTOP\\SQLEXPRESS;Initial Catalog=Laborator_analize;Integrated Security=True");
            con.Open();
            SqlCommand getId = new SqlCommand("select PacientID from Pacienti where CNP=@Cnp", con);
            getId.Parameters.AddWithValue("@Cnp", textBox4.Text);
            int id = (int)getId.ExecuteScalar();
            SqlCommand delete_cmd = new SqlCommand("delete from Pacienti where PacientID=@Id", con);
            delete_cmd.Parameters.AddWithValue("Id", id);
            delete_cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e) //RETURN TO MENU
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.Show();
        }
    }
}
