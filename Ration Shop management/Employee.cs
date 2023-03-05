using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ration_Shop_management
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\anike\OneDrive\Documents\rationshopdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void fillcombo()
        {
            //This method will bind the combobox with the database
            conn.Open();
            SqlCommand cmd = new SqlCommand("select ");
            conn.Close();
        }
        private void GetData()
        {
            conn.Open();
            string query = "select * from EmployeeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EmpDGV.DataSource = ds.Tables[0];
            conn.Close();
        }
        private void Employee_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = EmpDGV.Rows[EmpDGV.CurrentRow.Index].Cells[0].Value.ToString();
            txtName.Text = EmpDGV.Rows[EmpDGV.CurrentRow.Index].Cells[1].Value.ToString();
            txtAge.Text = EmpDGV.Rows[EmpDGV.CurrentRow.Index].Cells[2].Value.ToString();
            txtPhone.Text = EmpDGV.Rows[EmpDGV.CurrentRow.Index].Cells[3].Value.ToString();
            txtUser.Text = EmpDGV.Rows[EmpDGV.CurrentRow.Index].Cells[4].Value.ToString();
            txtPass.Text = EmpDGV.Rows[EmpDGV.CurrentRow.Index].Cells[5].Value.ToString();
            genderBox.Text = EmpDGV.Rows[EmpDGV.CurrentRow.Index].Cells[6].Value.ToString();
        }

        private void Button7_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ProductForm prod = new ProductForm();
            prod.Show();
            this.Hide();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Customers cust = new Customers();
            cust.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Customers cust = new Customers();
            cust.Show();
            this.Hide();
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "insert into EmployeeTbl values(" + txtId.Text + ",'" + txtName.Text + "','" + txtAge.Text + "','" + txtPhone.Text + "','" + txtUser.Text + "','" + txtPass.Text + "','" + genderBox.Text + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Added Successfully");
                conn.Close();
                GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "" || txtName.Text == "" || txtAge.Text == "" || genderBox.Text == "" || txtPhone.Text == "" || txtPass.Text == "" || txtUser.Text == "")
                {
                    MessageBox.Show("Fill all information");
                }
                else
                {
                    conn.Open();
                    string query = "update EmployeeTbl set EmpName='" + txtName.Text + "',EmpAge='" + txtAge.Text + "',EmpPhone='" + txtPhone.Text + "',EmpGender='" + genderBox.Text + "',EmpPass='" + txtPass.Text + "',EmpUser='" + txtUser.Text + "' where EmpId=" + txtId.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee details updated");
                    conn.Close();
                    GetData();
                    GetData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {


                if (txtId.Text == "")
                {
                    MessageBox.Show("Select the Employee to delete");
                }
                else
                {
                    conn.Open();
                    string query = "delete from EmployeeTbl where EmpId=" + txtId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee deleted successfully");
                    conn.Close();
                    GetData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
