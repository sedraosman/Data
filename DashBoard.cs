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

namespace DairyFarmSystem
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            Finance();
            Logistic();
            Max_();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {


        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {


        }
        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label14_Click(object sender, EventArgs e)
        {
            MilkSales Ob = new MilkSales();
            Ob.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            CowsHeallth Ob = new CowsHeallth();
            Ob.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Breeding Ob = new Breeding();
            Ob.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Cows Ob = new Cows();
            Ob.Show();
            this.Hide();
        }


        private void label15_Click(object sender, EventArgs e)
        {
            Finances Ob = new Finances();
            Ob.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MilkProduction Ob = new MilkProduction();
            Ob.Show();
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\joudi\OneDrive\Documents\DairyFarmDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void Finance()
        {


            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select sum (incAmt) from IncomeTbl ", Con);
            SqlDataAdapter sda_ = new SqlDataAdapter("Select sum (ExpAmount) from ExpenditureTbl ", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int In, ex;
            double ba;
            In = Convert.ToInt32(dt.Rows[0][0].ToString());
            label26.Text = dt.Rows[0][0].ToString();
            DataTable dt_ = new DataTable();
            sda_.Fill(dt_);
            ex = Convert.ToInt32(dt_.Rows[0][0].ToString());
            ba = In - ex;
            label25.Text = dt_.Rows[0][0].ToString();
            label24.Text = "" + ba;

            Con.Close();

        }
        private void Logistic()
        {


            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count (*) from CowTbl ", Con);
            SqlDataAdapter sda_ = new SqlDataAdapter("Select sum (TotalMilk) from MilkTb ", Con);
            SqlDataAdapter sd_a = new SqlDataAdapter("Select Count (*) from EmployeeTbl ", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            label27.Text = dt.Rows[0][0].ToString();
            DataTable dt_ = new DataTable();
            sda_.Fill(dt_);
            label29.Text = dt_.Rows[0][0].ToString() + "L";
            DataTable d_t = new DataTable();
            sd_a.Fill(d_t);
            label28.Text = d_t.Rows[0][0].ToString() + "  Employee";






            Con.Close();

        }
        private void Max_()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select Max (incAmt) from IncomeTbl ", Con);
            SqlDataAdapter sda_ = new SqlDataAdapter("Select Max (ExpAmount) from ExpenditureTbl ", Con);
            DataTable dt = new DataTable();
            DataTable dt_ = new DataTable();
            sda.Fill(dt);
            sda_.Fill(dt_);
            label23.Text = dt.Rows[0][0].ToString();
            label19.Text = dt_.Rows[0][0].ToString();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
