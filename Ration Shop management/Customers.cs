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

namespace Ration_Shop_management
{
    public partial class Customers : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\anike\OneDrive\Documents\rationshopdb.mdf;Integrated Security=True;Connect Timeout=30");
        public Customers()
        {
            InitializeComponent();
        }


        private void GetData()
        {
            conn.Open();
            string query = "select * from CustomerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CustDGV.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void MaskedTextBox10_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            try
            {
               conn.Open();
               string query = "insert into CustomerTbl values(" + txtCardNo.Text + ",'" + txtName.Text + "','" + txtAge.Text + "','" + txtPhone.Text + "','" + txtAdhaar.Text + "','" + txtIncome.Text + "','"+listMembers.Text+ "','" + txtCardType.Text + "')";
               SqlCommand cmd = new SqlCommand(query, conn);
               cmd.ExecuteNonQuery();
               MessageBox.Show("Customer Added Successfully");
               conn.Close();
               GetData();
                txtCardNo.Text = "";
                txtName.Text = "";
                txtAge.Text = "";
                txtPhone.Text = "";
                txtAdhaar.Text = "";
                txtIncome.Text = "";
                listMembers.Text = "";
                txtCardType.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
            this.Hide();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            ProductForm prod = new ProductForm();
            prod.Show();
            this.Hide();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void CustDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCardNo.Text = CustDGV.Rows[CustDGV.CurrentRow.Index].Cells[0].Value.ToString();
            txtName.Text = CustDGV.Rows[CustDGV.CurrentRow.Index].Cells[1].Value.ToString();
            txtAge.Text = CustDGV.Rows[CustDGV.CurrentRow.Index].Cells[2].Value.ToString();
            txtPhone.Text = CustDGV.Rows[CustDGV.CurrentRow.Index].Cells[3].Value.ToString();
            txtAdhaar.Text = CustDGV.Rows[CustDGV.CurrentRow.Index].Cells[4].Value.ToString();
            txtIncome.Text = CustDGV.Rows[CustDGV.CurrentRow.Index].Cells[5].Value.ToString();
            listMembers.Text = CustDGV.Rows[CustDGV.CurrentRow.Index].Cells[6].Value.ToString();
            txtCardType.Text = CustDGV.Rows[CustDGV.CurrentRow.Index].Cells[7].Value.ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {


                if (txtCardNo.Text == "")
                {
                    MessageBox.Show("Select the Product to delete");
                }
                else
                {
                    conn.Open();
                    string query = "delete from CustomerTbl where cardno=" + txtCardNo.Text + "";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product deleted successfully");
                    conn.Close();
                    GetData();
                    txtCardNo.Text = "";
                    txtName.Text = "";
                    txtAge.Text = "";
                    txtPhone.Text = "";
                    txtAdhaar.Text = "";
                    txtIncome.Text = "";
                    listMembers.Text = "";
                    txtCardType.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCardNo.Text == "" || txtName.Text == "" || txtAge.Text == "" || txtAdhaar.Text == "" || txtPhone.Text == "")
                {
                    MessageBox.Show("Fill all information");
                }
                else
                {
                    conn.Open();
                    string query = "update CustomerTbl set CustName='" + txtName.Text + "',CustAge='" + txtAge.Text + "',CustPhone='" + txtPhone.Text + "',CustAdhaar='" + txtAdhaar.Text + "',CustIncome='" + txtIncome.Text + "',CustMembers='" + listMembers.Text + "',CardType='" + txtCardType.Text + "' where cardno=" + txtCardNo.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer details updated");
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

