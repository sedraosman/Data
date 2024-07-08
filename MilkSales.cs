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
using System.Data.SqlClient;
using System.Xml.Linq;

namespace DairyFarmSystem
{
    public partial class MilkSales : Form
    {
        public MilkSales()
        {
            InitializeComponent();
            FillEmpId();
            populate();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
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

        private void label15_Click(object sender, EventArgs e)
        {
            Finances Ob = new Finances();
            Ob.Show();
            this.Hide();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            DashBoard Ob = new DashBoard();
            Ob.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MilkProuduction Ob = new MilkProuduction();
            Ob.Show();
            this.Hide();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\joudi\OneDrive\Documents\DairyFarmDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void FillEmpId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select EmpId from EmployeeTbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("EmpId", typeof(int));
            dt.Load(Rdr);
            EmpIdCb.ValueMember = "EmpId";
            EmpIdCb.DataSource = dt;
            Con.Close();
        }
        private void MilkSales_Load(object sender, EventArgs e)
        {

        }

        private void quantityTb_Leave(object sender, EventArgs e)
        {

            int total = Convert.ToInt32(PriceTb.Text) * Convert.ToInt32(quantityTb.Text);
            TotalTb.Text = " " + total;
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from  MilkSalesTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SalesDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Clear()
        {
            PhoneTb.Text = " ";
            ClienNametTb.Text = " ";
            PriceTb.Text = " ";
            TotalTb.Text = " ";
            quantityTb.Text = " ";
        }
        private void SaveTran_()
        {

            {
                try
                {
                    string Sales = "sales";
                    Con.Open();
                    string Query = "insert into IncomeTbl values ('" + Date.Value.Date + "','" + Sales + "'," + TotalTb.Text + "," + EmpIdCb.SelectedValue.ToString() + ")";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Income Saved Successfully");

                    Con.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (EmpIdCb.SelectedIndex == -1 || PriceTb.Text == "" || ClienNametTb.Text == "" || PhoneTb.Text == "" || quantityTb.Text == "" || TotalTb.Text == "")
            {

            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "insert into MilkSalesTbl values ('" + Date.Value.Date + "'," + PriceTb.Text + ",'" + ClienNametTb.Text + "','" + PhoneTb.Text + "'," + EmpIdCb.SelectedValue.ToString() + "," + quantityTb.Text + "," + TotalTb.Text + ")";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Milk Sold  Successfully");

                    Con.Close();
                    populate();
                    SaveTran_();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void EmpIdCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PriceTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
