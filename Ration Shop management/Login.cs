using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ration_Shop_management
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void MaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MaskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void Guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPass.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(txtUser.Text=="" || txtPass.Text == "")
            {
                MessageBox.Show("Enter Username and Password");
            }
            else
            {
                if (RoleBox.SelectedIndex > -1)
                {
                    if (RoleBox.SelectedItem.ToString() == "Admin")
                    {
                        if (txtUser.Text == "Admin" && txtPass.Text == "Admin@123")
                        {
                            ProductForm prod = new ProductForm();
                            prod.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If you are Admin, Enter correct password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("You are in Emplyee page");
                    }
                }
                else
                {
                    MessageBox.Show("Select correct Role");
                }
            }
        }
    }
}
