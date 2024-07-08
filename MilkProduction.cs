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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DairyFarmSystem
{
    public partial class MilkProduction : Form
    {
        public MilkProduction()
        {
            InitializeComponent();
            FillCowId();
            populate();
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

        private void CowIdCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\joudi\OneDrive\Documents\DairyFarmDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void FillCowId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select CowId from CowTbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CowId", typeof(int));
            dt.Load(Rdr);
            CowIdCb.ValueMember = "CowId";
            CowIdCb.DataSource = dt;
            Con.Close();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from  MilkTb";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            MilkDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Clear()
        {
            Cownametb.Text = " ";
            Amt.Text = "";
            noonTb.Text = "";
            PmTb.Text = "";
            TotalTb.Text = "";
            key = 0;

        }
        private void GetCowName()
        {
            Con.Open();
            string query = " Select * from CowTbl  where cowId= " + CowIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Cownametb.Text = dr["CowName"].ToString();

            }

            Con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (CowIdCb.SelectedIndex == -1 || Cownametb.Text == "" || Amt.Text == "" || PmTb.Text == "" || noonTb.Text == "" || TotalTb.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "insert into MilkTb values (" + CowIdCb.SelectedValue.ToString() + ",'" + Cownametb.Text + "'," + Amt.Text + ",'" + noonTb.Text + "','" + PmTb.Text + "'," + TotalTb.Text + ",'" + Date.Value.Date + "')";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Milk Saved Successfully");

                    Con.Close();
                    populate();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void MilkProduction_Load(object sender, EventArgs e)
        {

        }


        private void Cownametb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void CowIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetCowName();
        }

        private void PmTb_MouseUp(object sender, MouseEventArgs e)
        {
        }





        private void TotalTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Amt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show(" Type the information to deleted");

            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "delete from MilkTb where MlId=" + key + " ;";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("oroduct deleted Successfully");

                    Con.Close();
                    populate();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int key = 0;
        private void MilkDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            CowIdCb.Text = MilkDGV.SelectedRows[0].Cells[1].Value.ToString();
            Cownametb.Text = MilkDGV.SelectedRows[0].Cells[2].Value.ToString();
            Amt.Text = MilkDGV.SelectedRows[0].Cells[3].Value.ToString();
            noonTb.Text = MilkDGV.SelectedRows[0].Cells[4].Value.ToString();
            PmTb.Text = MilkDGV.SelectedRows[0].Cells[5].Value.ToString();
            TotalTb.Text = MilkDGV.SelectedRows[0].Cells[6].Value.ToString();
            Date.Text = MilkDGV.SelectedRows[0].Cells[7].Value.ToString();
            if (Cownametb.Text == "")
            {
                key = 0;

            }
            else
            {
                key = Convert.ToInt32(MilkDGV.SelectedRows[0].Cells[0].Value.ToString());

            }

        }

        private void PmTb_TextChanged(object sender, EventArgs e)
        {
            //TotalTb.Text = " " + (Convert.ToInt32(Amt.Text) + Convert.ToInt32(PmTb.Text) + Convert.ToInt32(noonTb.Text));

          //  int total = Convert.ToInt32(Amt.Text) + Convert.ToInt32(PmTb.Text) + Convert.ToInt32(noonTb.Text);
            //TotalTb.Text = " " + total;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CowIdCb.SelectedIndex == -1 || Cownametb.Text == "" || Amt.Text == "" || PmTb.Text == "" || noonTb.Text == "" || TotalTb.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "update MilkTb set  CowName ='" + Cownametb.Text + "',AmMilk=" + Amt.Text + ",NoonMilk=" + noonTb.Text + ",PmMilk=" + PmTb.Text + ",TotalMilk=" + TotalTb.Text + ",DateProd='" + Date.Value + "'where MlId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("prouduct Update Successfully");

                    Con.Close();
                    populate();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PmTb_Leave(object sender, EventArgs e)
        {
            int total = Convert.ToInt32(Amt.Text) + Convert.ToInt32(PmTb.Text) + Convert.ToInt32(noonTb.Text);
            TotalTb.Text = " " + total;
        }
    }
}



