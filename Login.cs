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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\joudi\OneDrive\Documents\DairyFarmDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Enter The UserName and Password");

            }
            else
            {
                if (comboBox1.SelectedIndex > -1)
                {

                    if (comboBox1.SelectedItem.ToString() == "Admin")

                    {
                        if (textBox1.Text == "Admin" && textBox2.Text == "Admin")
                        {
                            Employee prod = new Employee();
                            prod.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If You are the Admin ,Enter the Correct Id and Passsword");

                        }
                    }
                    else
                    {
                        Con.Open();

                        SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) from EmployeeTbl where EmpName = '" + textBox1.Text + "'  and  Emppass = '" + textBox2.Text + "'", Con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            Cows cow = new Cows();
                            cow.Show();
                            this.Hide();

                            Con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Wrong  UserName or Password");
                        }
                        Con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("select a Role");
                }
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}




