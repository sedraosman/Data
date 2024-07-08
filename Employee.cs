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
using System.Windows.Forms.Design;

namespace DairyFarmSystem
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\joudi\OneDrive\Documents\DairyFarmDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            string query = "select * from  EmployeeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EmployeeDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Clear()
        {
            EmpNameTb.Text = "";
            AdressTb.Text = "";
            GenCb.SelectedIndex = -1;
            PhoneTb.Text = " ";
            key = 0;
            textBox1.Text = " ";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (GenCb.SelectedIndex == -1 || EmpNameTb.Text == " " || PhoneTb.Text == " " || AdressTb.Text == " " || textBox1.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "insert into EmployeeTbl values ('" + EmpNameTb.Text + "','" + DOB.Value.Date + "','" + GenCb.SelectedItem.ToString() + "','" + PhoneTb.Text + "','" + AdressTb.Text + "','" + textBox1.Text + "')";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Saved successfuly ");

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

        private void EmployeeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            GenCb.SelectedItem = EmployeeDGV.SelectedRows[0].Cells[3].Value.ToString();
            DOB.Text = EmployeeDGV.SelectedRows[0].Cells[2].Value.ToString();
            EmpNameTb.Text = EmployeeDGV.SelectedRows[0].Cells[1].Value.ToString();
            AdressTb.Text = EmployeeDGV.SelectedRows[0].Cells[5].Value.ToString();
            PhoneTb.Text = EmployeeDGV.SelectedRows[0].Cells[4].Value.ToString();
            textBox1.Text = EmployeeDGV.SelectedRows[0].Cells[6].Value.ToString();

            if (EmpNameTb.Text == "")
            {
                key = 0;

            }
            else
            {
                key = Convert.ToInt32(EmployeeDGV.SelectedRows[0].Cells[0].Value.ToString());

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select the Employee to be Delete");

            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "delete from EmployeeTbl where EmpId=" + key + " ;";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("employee deleted Successfully");

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

        private void button3_Click(object sender, EventArgs e)
        {
            if (GenCb.SelectedIndex == -1 || EmpNameTb.Text == " " || PhoneTb.Text == " " || AdressTb.Text == " ")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "update EmployeeTbl set  EmpName ='" + EmpNameTb.Text + "',EmpDob ='" + DOB.Value.Date + "',Gender = '" + GenCb.SelectedItem.ToString() + "',Phone='" + PhoneTb.Text + "',Address ='" + AdressTb.Text + "' ,Emppass = '" + textBox1.Text + "'where EmpId = " + key + ";";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Update Successfully");

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

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
