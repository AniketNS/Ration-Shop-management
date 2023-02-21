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
        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
