using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DairyFarmSystem
{
    public partial class Finances : Form
    {
        public Finances()
        {
            InitializeComponent();
            populateExp();
            populateIn();
            FillEmpId();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {



        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {



        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {



        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {



        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {



        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {



        }

        private void label11_Click(object sender, EventArgs e)
        {
            Cows Ob = new Cows();
            Ob.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            CowHealth Ob = new CowHealth();
            Ob.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Breeding Ob = new Breeding();
            Ob.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            MilkSales Ob = new MilkSales();
            Ob.Show();
            this.Hide();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            DashBoard Ob = new DashBoard();
            Ob.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            MilkProuduction Ob = new MilkProuduction();
            Ob.Show();
            this.Hide();
        }


        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\joudi\OneDrive\Documents\DairyFarmDb.mdf;Integrated Security=True;Connect Timeout=30");


        private void populateExp()
        {
            Con.Open();
            string query = "select * from  ExpenditureTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ExpDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void populateIn()
        {
            Con.Open();
            string query = "select * from  IncomeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            InDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void FilterIn()
        {
            Con.Open();
            string query = "select * from  IncomeTbl where IncDate = '" + InDateF.Value.Date + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            InDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void FilterEx()
        {
            Con.Open();
            string query = "select * from  ExpenditureTbl where ExpDate = '" + ExDateF.Value.Date + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ExpDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Finances_Load(object sender, EventArgs e)
        {

        }
        private void ClearEx()
        {

            AmountTb.Text = "";

        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == -1 || AmountTb.Text == "" || Emp.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "insert into ExpenditureTbl values ('" + ExpDate.Value.Date + "','" + comboBox1.SelectedItem.ToString() + "'," + AmountTb.Text + "," + Emp.SelectedValue.ToString() + ")";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Expenditure Saved Successfully");

                    Con.Close();
                    populateExp();
                    ClearEx();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void MilkDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FillEmpId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select EmpId from EmployeeTbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("EmpId", typeof(int));
            dt.Load(Rdr);
            Emp.ValueMember = "EmpId";
            Emp.DataSource = dt;
            Con.Close();
        }
        private void ClearIn()
        {
            InAmo.Text = "";
            comboBox1.SelectedIndex = -1;


        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (IncCb.SelectedIndex == -1 || InAmo.Text == "" || Emp.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "insert into IncomeTbl values ('" + inDate.Value.Date + "','" + IncCb.SelectedItem.ToString() + "'," + InAmo.Text + "," + Emp.SelectedValue.ToString() + ")";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Income Saved Successfully");

                    Con.Close();
                    populateIn();
                    ClearIn();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            FilterIn();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            populateIn();
        }

        private void ExDateF_ValueChanged(object sender, EventArgs e)
        {
            FilterEx();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            populateExp();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


