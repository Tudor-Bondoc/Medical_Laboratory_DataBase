using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bondoc_Tudor_Database_Project
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Pacienti_main pac = new Pacienti_main();
            pac.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            InsertRezultate rez = new InsertRezultate();
            rez.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Laboranti lab = new Laboranti();
            lab.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            GenRez genRez = new GenRez();
            genRez.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            InterogariSimple interogariSimple = new InterogariSimple();
            interogariSimple.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            InformatiiComplexe interogariComplexe = new InformatiiComplexe();
            interogariComplexe.Show();
        }
    }
}
