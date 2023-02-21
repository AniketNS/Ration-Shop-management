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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\anike\OneDrive\Documents\rationshopdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            conn.Open();
            string query = "select * from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV.DataSource = ds.Tables[0];
            conn.Close();
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            populate();
        }


        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
            this.Hide();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Customers cust = new Customers();
            cust.Show();
            this.Hide();
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "insert into ProductTbl values(" + ProdId.Text + ",'" + ProdName.Text + "','" + ProdQuantity.Text + "','" + ProdPrice.Text + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully");
                conn.Close();
                populate();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProdId_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ProdDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdId.Text = ProdDGV.Rows[ProdDGV.CurrentRow.Index].Cells[0].Value.ToString();
            ProdName.Text = ProdDGV.Rows[ProdDGV.CurrentRow.Index].Cells[1].Value.ToString();
            ProdQuantity.Text = ProdDGV.Rows[ProdDGV.CurrentRow.Index].Cells[2].Value.ToString();
            ProdPrice.Text = ProdDGV.Rows[ProdDGV.CurrentRow.Index].Cells[3].Value.ToString();

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                
                
                if (ProdId.Text == "")
                {
                    MessageBox.Show("Select the Product to delete");
                }
                else
                {
                    conn.Open();
                    string query = "delete from ProductTbl where Prodid=" + ProdId.Text + "";
                    SqlCommand cmd = new SqlCommand(query,conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product deleted successfully");
                    conn.Close();
                    populate();
                }
                   
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdId.Text == "" || ProdName.Text == "" || ProdQuantity.Text == "" || ProdPrice.Text == "")
                {
                    MessageBox.Show("Fill all information");
                }
                else
                {
                    conn.Open();
                    string query = "update ProductTbl set ProdName='" + ProdName.Text + "',quantity='" + ProdQuantity.Text + "',ProdPrice='" + ProdPrice.Text + "' where Prodid=" + ProdId.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product details updated");
                    conn.Close();
                    populate();
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
