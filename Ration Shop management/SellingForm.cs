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
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\anike\OneDrive\Documents\rationshopdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            conn.Open();
            string query = "select ProdName,ProdPrice from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            Prod1DGV.DataSource = ds.Tables[0];
            conn.Close();
        }
        private void populate1()
        {
            conn.Open();
            string query = "select CustName,CustMembers from CustomerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CustDGV.DataSource = ds.Tables[0];
            conn.Close();
        }
        private void Label6_Click(object sender, EventArgs e)
        {

        }

       /* 
        private void fillcombo()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select CustName from CustomerTbl",conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustName", typeof(string));
            dt.Load(rdr);
            CustNameCb.ValueMember = "CustName";
            CustNameCb.DataSource = dt;

            conn.Close();
        }
        */
        private void SellingForm_Load(object sender, EventArgs e)
        {
           // fillcombo();
            populate();
            populate1();
        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void Prod1DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdName.Text = Prod1DGV.Rows[Prod1DGV.CurrentRow.Index].Cells[0].Value.ToString();
            ProdPrice.Text = Prod1DGV.Rows[Prod1DGV.CurrentRow.Index].Cells[1].Value.ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            Datelbl.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }
        int Grdtotal = 0;
        private void Button1_Click(object sender, EventArgs e)
        {
            int total;

            if (ProdName.Text == "" || ProdPrice.Text == "")
            {
                MessageBox.Show("You must fill the data before adding");

            }
            else {
               // int n = 0, 
                
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(OrderDGV);
                //newRow.Cells[0].Value = n + 1;
                newRow.Cells[0].Value = ProdName.Text;
                newRow.Cells[1].Value = ProdPrice.Text;
                int wheatTotal = Convert.ToInt32(CustMember.Text) * 5;
                int riceTotal = Convert.ToInt32(CustMember.Text) * 2;
                int sugarTotal = Convert.ToInt32(CustMember.Text);
                if (ProdName.Text == "Wheat")
                {
                    newRow.Cells[2].Value = wheatTotal;
                    total = wheatTotal * Convert.ToInt32(ProdPrice.Text);
                } else if (ProdName.Text == "Rice")
                {
                    newRow.Cells[2].Value = riceTotal;
                    total = riceTotal * Convert.ToInt32(ProdPrice.Text);
                }
                else
                {
                    newRow.Cells[2].Value = sugarTotal;
                    total = sugarTotal * Convert.ToInt32(ProdPrice.Text);
                }
                newRow.Cells[3].Value = total;
                OrderDGV.Rows.Add(newRow);
                Grdtotal = Grdtotal + total;
                rslbl.Text = "Rs. " + Grdtotal;
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustName.Text = CustDGV.Rows[CustDGV.CurrentRow.Index].Cells[0].Value.ToString();
            CustMember.Text = CustDGV.Rows[CustDGV.CurrentRow.Index].Cells[1].Value.ToString();
        }
    }
}
