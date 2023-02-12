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
    public partial class InsertRezultate : Form
    {
        public InsertRezultate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //insert
        {
            SqlConnection con = new SqlConnection("Data Source=TUDORLAPTOP\\SQLEXPRESS;Initial Catalog=Laborator_analize;Integrated Security=True");
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select ProbaID from Probe where CodProba = @cp", con);
            cmd1.Parameters.AddWithValue("@cp", textBox1.Text);
            int probid = (int)cmd1.ExecuteScalar();
            SqlCommand cmd2 = new SqlCommand("select BuletinID from Buletine where ProbaID = @pid", con);
            cmd2.Parameters.AddWithValue("@pid", probid);
            int bulid = (int)cmd2.ExecuteScalar();

            SqlCommand cmd3 = new SqlCommand("insert into Rezultate(AnalizaID, Rezultat, BuletinID) " +
                                             "values (1, @rez3, @bul)", con);
            cmd3.Parameters.AddWithValue("@rez3", textBox2.Text);
            cmd3.Parameters.AddWithValue("bul", bulid);
            cmd3.ExecuteNonQuery();

            SqlCommand cmd4 = new SqlCommand("insert into Rezultate(AnalizaID, Rezultat, BuletinID) " +
                                             "values (2, @rez4, @bul)", con);
            cmd4.Parameters.AddWithValue("@rez4", textBox3.Text);
            cmd4.Parameters.AddWithValue("bul", bulid);
            cmd4.ExecuteNonQuery();

            SqlCommand cmd5 = new SqlCommand("insert into Rezultate(AnalizaID, Rezultat, BuletinID) " +
                                             "values (3, @rez5, @bul)", con);
            cmd5.Parameters.AddWithValue("@rez5", textBox4.Text);
            cmd5.Parameters.AddWithValue("bul", bulid);
            cmd5.ExecuteNonQuery();

            SqlCommand cmd6 = new SqlCommand("insert into Rezultate(AnalizaID, Rezultat, BuletinID) " +
                                             "values (4, @rez6, @bul)", con);
            cmd6.Parameters.AddWithValue("@rez6", textBox5.Text);
            cmd6.Parameters.AddWithValue("bul", bulid);
            cmd6.ExecuteNonQuery();

            SqlCommand cmd7 = new SqlCommand("insert into Rezultate(AnalizaID, Rezultat, BuletinID) " +
                                             "values (5, @rez7, @bul)", con);
            cmd7.Parameters.AddWithValue("@rez7", textBox6.Text);
            cmd7.Parameters.AddWithValue("bul", bulid);
            cmd7.ExecuteNonQuery();

            SqlCommand cmd8 = new SqlCommand("insert into Rezultate(AnalizaID, Rezultat, BuletinID) " +
                                             "values (6, @rez8, @bul)", con);
            cmd8.Parameters.AddWithValue("@rez8", textBox7.Text);
            cmd8.Parameters.AddWithValue("bul", bulid);
            cmd8.ExecuteNonQuery();

            SqlCommand cmd9 = new SqlCommand("insert into Rezultate(AnalizaID, Rezultat, BuletinID) " +
                                             "values (7, @rez9, @bul)", con);
            cmd9.Parameters.AddWithValue("@rez9", textBox8.Text);
            cmd9.Parameters.AddWithValue("bul", bulid);
            cmd9.ExecuteNonQuery();

            SqlCommand cmd10 = new SqlCommand("insert into Rezultate(AnalizaID, Rezultat, BuletinID) " +
                                             "values (8, @rez10, @bul)", con);
            cmd10.Parameters.AddWithValue("@rez10", textBox9.Text);
            cmd10.Parameters.AddWithValue("bul", bulid);
            cmd10.ExecuteNonQuery();

            SqlCommand cmd11 = new SqlCommand("insert into Rezultate(AnalizaID, Rezultat, BuletinID) " +
                                             "values (9, @rez11, @bul)", con);
            cmd11.Parameters.AddWithValue("@rez11", textBox10.Text);
            cmd11.Parameters.AddWithValue("bul", bulid);
            cmd11.ExecuteNonQuery();

            SqlCommand cmd12 = new SqlCommand("insert into Rezultate(AnalizaID, Rezultat, BuletinID) " +
                                             "values (10, @rez12, @bul)", con);
            cmd12.Parameters.AddWithValue("@rez12", textBox11.Text);
            cmd12.Parameters.AddWithValue("bul", bulid);
            cmd12.ExecuteNonQuery();

            SqlCommand cmd13 = new SqlCommand("insert into Rezultate(AnalizaID, Rezultat, BuletinID) " +
                                             "values (11, @rez13, @bul)", con);
            cmd13.Parameters.AddWithValue("@rez13", textBox12.Text);
            cmd13.Parameters.AddWithValue("bul", bulid);
            cmd13.ExecuteNonQuery();

            SqlCommand cmd14 = new SqlCommand("insert into Rezultate(AnalizaID, Rezultat, BuletinID) " +
                                             "values (12, @rez14, @bul)", con);
            cmd14.Parameters.AddWithValue("@rez14", textBox13.Text);
            cmd14.Parameters.AddWithValue("bul", bulid);
            cmd14.ExecuteNonQuery();

            SqlCommand cmd15 = new SqlCommand("insert into Rezultate(AnalizaID, Rezultat, BuletinID) " +
                                             "values (13, @rez15, @bul)", con);
            cmd15.Parameters.AddWithValue("@rez15", textBox14.Text);
            cmd15.Parameters.AddWithValue("bul", bulid);
            cmd15.ExecuteNonQuery();

            SqlCommand cmd16 = new SqlCommand("insert into Rezultate(AnalizaID, Rezultat, BuletinID) " +
                                             "values (14, @rez16, @bul)", con);
            cmd16.Parameters.AddWithValue("@rez16", textBox15.Text);
            cmd16.Parameters.AddWithValue("bul", bulid);
            cmd16.ExecuteNonQuery();

            SqlCommand cmd17 = new SqlCommand("insert into Rezultate(AnalizaID, Rezultat, BuletinID) " +
                                             "values (15, @rez17, @bul)", con);
            cmd17.Parameters.AddWithValue("@rez17", textBox16.Text);
            cmd17.Parameters.AddWithValue("bul", bulid);
            cmd17.ExecuteNonQuery();

            SqlCommand cmd18 = new SqlCommand("insert into Rezultate(AnalizaID, Rezultat, BuletinID) " +
                                             "values (16, @rez18, @bul)", con);
            cmd18.Parameters.AddWithValue("@rez18", textBox17.Text);
            cmd18.Parameters.AddWithValue("bul", bulid);
            cmd18.ExecuteNonQuery();

            con.Close();
        }

        private void button6_Click(object sender, EventArgs e) //delete
        {
            SqlConnection con = new SqlConnection("Data Source=TUDORLAPTOP\\SQLEXPRESS;Initial Catalog=Laborator_analize;Integrated Security=True");
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select ProbaID from Probe where CodProba = @cp", con);
            cmd1.Parameters.AddWithValue("@cp", textBox1.Text);
            int probid = (int)cmd1.ExecuteScalar();
            SqlCommand cmd2 = new SqlCommand("select BuletinID from Buletine where ProbaID = @pid", con);
            cmd2.Parameters.AddWithValue("@pid", probid);
            int bulid = (int)cmd2.ExecuteScalar();
            SqlCommand del = new SqlCommand("delete from Rezultate where BuletinID = @bul", con);
            del.Parameters.AddWithValue("@bul", bulid);
            del.ExecuteNonQuery();
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e) //update
        {
            SqlConnection con = new SqlConnection("Data Source=TUDORLAPTOP\\SQLEXPRESS;Initial Catalog=Laborator_analize;Integrated Security=True");
            con.Open();
            SqlCommand findpid = new SqlCommand("select ProbaID from Probe where CodProba = @cp", con);
            findpid.Parameters.AddWithValue("@cp", textBox1.Text);
            int probid = (int)findpid.ExecuteScalar();
            SqlCommand findbid = new SqlCommand("select BuletinID from Buletine where ProbaID = @pid", con);
            findbid.Parameters.AddWithValue("@pid", probid);
            int bulid = (int)findbid.ExecuteScalar();

            SqlCommand cmd2 = new SqlCommand("update Rezultate " +
                                             "set Rezultat = @rez " +
                                             "where AnalizaID = 1 and BuletindID = @bid", con);
            cmd2.Parameters.AddWithValue("@rez", textBox2.Text);
            cmd2.Parameters.AddWithValue("@bid", bulid);
            cmd2.ExecuteNonQuery();

            SqlCommand cmd3 = new SqlCommand("update Rezultate " +
                                             "set Rezultat = @rez " +
                                             "where AnalizaID = 2 and BuletindID = @bid", con);
            cmd3.Parameters.AddWithValue("@rez", textBox3.Text);
            cmd3.Parameters.AddWithValue("@bid", bulid);
            cmd3.ExecuteNonQuery();

            SqlCommand cmd4 = new SqlCommand("update Rezultate " +
                                             "set Rezultat = @rez " +
                                             "where AnalizaID = 3 and BuletindID = @bid", con);
            cmd4.Parameters.AddWithValue("@rez", textBox4.Text);
            cmd4.Parameters.AddWithValue("@bid", bulid);
            cmd4.ExecuteNonQuery();

            SqlCommand cmd5 = new SqlCommand("update Rezultate " +
                                             "set Rezultat = @rez " +
                                             "where AnalizaID = 4 and BuletindID = @bid", con);
            cmd5.Parameters.AddWithValue("@rez", textBox5.Text);
            cmd5.Parameters.AddWithValue("@bid", bulid);
            cmd5.ExecuteNonQuery();

            SqlCommand cmd6 = new SqlCommand("update Rezultate " +
                                             "set Rezultat = @rez " +
                                             "where AnalizaID = 5 and BuletindID = @bid", con);
            cmd6.Parameters.AddWithValue("@rez", textBox6.Text);
            cmd6.Parameters.AddWithValue("@bid", bulid);
            cmd6.ExecuteNonQuery();

            SqlCommand cmd7 = new SqlCommand("update Rezultate " +
                                             "set Rezultat = @rez " +
                                             "where AnalizaID = 6 and BuletindID = @bid", con);
            cmd7.Parameters.AddWithValue("@rez", textBox7.Text);
            cmd7.Parameters.AddWithValue("@bid", bulid);
            cmd7.ExecuteNonQuery();

            SqlCommand cmd8 = new SqlCommand("update Rezultate " +
                                             "set Rezultat = @rez " +
                                             "where AnalizaID = 7 and BuletindID = @bid", con);
            cmd8.Parameters.AddWithValue("@rez", textBox8.Text);
            cmd8.Parameters.AddWithValue("@bid", bulid);
            cmd8.ExecuteNonQuery();

            SqlCommand cmd9 = new SqlCommand("update Rezultate " +
                                             "set Rezultat = @rez " +
                                             "where AnalizaID = 8 and BuletindID = @bid", con);
            cmd9.Parameters.AddWithValue("@rez", textBox9.Text);
            cmd9.Parameters.AddWithValue("@bid", bulid);
            cmd9.ExecuteNonQuery();

            SqlCommand cmd10 = new SqlCommand("update Rezultate " +
                                             "set Rezultat = @rez " +
                                             "where AnalizaID = 9 and BuletindID = @bid", con);
            cmd10.Parameters.AddWithValue("@rez", textBox10.Text);
            cmd10.Parameters.AddWithValue("@bid", bulid);
            cmd10.ExecuteNonQuery();

            SqlCommand cmd11 = new SqlCommand("update Rezultate " +
                                             "set Rezultat = @rez " +
                                             "where AnalizaID = 10 and BuletindID = @bid", con);
            cmd11.Parameters.AddWithValue("@rez", textBox11.Text);
            cmd11.Parameters.AddWithValue("@bid", bulid);
            cmd11.ExecuteNonQuery();

            SqlCommand cmd12 = new SqlCommand("update Rezultate " +
                                             "set Rezultat = @rez " +
                                             "where AnalizaID = 11 and BuletindID = @bid", con);
            cmd12.Parameters.AddWithValue("@rez", textBox12.Text);
            cmd12.Parameters.AddWithValue("@bid", bulid);
            cmd12.ExecuteNonQuery();

            SqlCommand cmd13 = new SqlCommand("update Rezultate " +
                                             "set Rezultat = @rez " +
                                             "where AnalizaID = 12 and BuletindID = @bid", con);
            cmd13.Parameters.AddWithValue("@rez", textBox13.Text);
            cmd13.Parameters.AddWithValue("@bid", bulid);
            cmd13.ExecuteNonQuery();

            SqlCommand cmd14 = new SqlCommand("update Rezultate " +
                                             "set Rezultat = @rez " +
                                             "where AnalizaID = 13 and BuletindID = @bid", con);
            cmd14.Parameters.AddWithValue("@rez", textBox14.Text);
            cmd14.Parameters.AddWithValue("@bid", bulid);
            cmd14.ExecuteNonQuery();

            SqlCommand cmd15 = new SqlCommand("update Rezultate " +
                                             "set Rezultat = @rez " +
                                             "where AnalizaID = 14 and BuletindID = @bid", con);
            cmd15.Parameters.AddWithValue("@rez", textBox15.Text);
            cmd15.Parameters.AddWithValue("@bid", bulid);
            cmd15.ExecuteNonQuery();

            SqlCommand cmd16 = new SqlCommand("update Rezultate " +
                                             "set Rezultat = @rez " +
                                             "where AnalizaID = 15 and BuletindID = @bid", con);
            cmd16.Parameters.AddWithValue("@rez", textBox16.Text);
            cmd16.Parameters.AddWithValue("@bid", bulid);
            cmd16.ExecuteNonQuery();

            SqlCommand cmd17 = new SqlCommand("update Rezultate " +
                                             "set Rezultat = @rez " +
                                             "where AnalizaID = 16 and BuletindID = @bid", con);
            cmd17.Parameters.AddWithValue("@rez", textBox17.Text);
            cmd17.Parameters.AddWithValue("@bid", bulid);
            cmd17.ExecuteNonQuery();

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e) //display all COD PROBA
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
    }
}
