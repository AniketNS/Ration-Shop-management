namespace Ration_Shop_management
{
    partial class SellingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.Prod1DGV = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ProdPrice = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProdName = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProdId = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Datelbl = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.EmpName = new System.Windows.Forms.Label();
            this.OrderDGV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CustName = new System.Windows.Forms.MaskedTextBox();
            this.CustMember = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CustDGV = new System.Windows.Forms.DataGridView();
            this.rslbl = new System.Windows.Forms.Label();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Prod1DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.rslbl);
            this.panel1.Controls.Add(this.CustDGV);
            this.panel1.Controls.Add(this.CustMember);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.CustName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.OrderDGV);
            this.panel1.Controls.Add(this.EmpName);
            this.panel1.Controls.Add(this.Datelbl);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.Prod1DGV);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.ProdPrice);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ProdName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ProdId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(113, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 682);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Location = new System.Drawing.Point(303, 330);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(92, 36);
            this.button7.TabIndex = 14;
            this.button7.Text = "Refresh";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // Prod1DGV
            // 
            this.Prod1DGV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Prod1DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Prod1DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Prod1DGV.GridColor = System.Drawing.Color.Black;
            this.Prod1DGV.Location = new System.Drawing.Point(370, 417);
            this.Prod1DGV.Name = "Prod1DGV";
            this.Prod1DGV.RowTemplate.Height = 28;
            this.Prod1DGV.Size = new System.Drawing.Size(337, 227);
            this.Prod1DGV.TabIndex = 13;
            this.Prod1DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Prod1DGV_CellContentClick);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(1073, 375);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 36);
            this.button6.TabIndex = 12;
            this.button6.Text = "DELETE";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(943, 375);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 36);
            this.button5.TabIndex = 11;
            this.button5.Text = "UPDATE";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(808, 375);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 36);
            this.button4.TabIndex = 10;
            this.button4.Text = "ADD";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // ProdPrice
            // 
            this.ProdPrice.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdPrice.ForeColor = System.Drawing.SystemColors.MenuText;
            this.ProdPrice.Location = new System.Drawing.Point(154, 278);
            this.ProdPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.Size = new System.Drawing.Size(241, 31);
            this.ProdPrice.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Price";
            // 
            // ProdName
            // 
            this.ProdName.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.ProdName.Location = new System.Drawing.Point(154, 237);
            this.ProdName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(241, 31);
            this.ProdName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // ProdId
            // 
            this.ProdId.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdId.ForeColor = System.Drawing.SystemColors.MenuText;
            this.ProdId.Location = new System.Drawing.Point(154, 114);
            this.ProdId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProdId.Name = "ProdId";
            this.ProdId.Size = new System.Drawing.Size(241, 31);
            this.ProdId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bill ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(474, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ration Allotment";
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelbl.Location = new System.Drawing.Point(991, 13);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(73, 24);
            this.Datelbl.TabIndex = 15;
            this.Datelbl.Text = "DATE";
            this.Datelbl.Click += new System.EventHandler(this.Label6_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1182, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 26);
            this.button3.TabIndex = 4;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // EmpName
            // 
            this.EmpName.AutoSize = true;
            this.EmpName.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpName.Location = new System.Drawing.Point(30, 26);
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(129, 24);
            this.EmpName.TabIndex = 16;
            this.EmpName.Text = "Employee";
            // 
            // OrderDGV
            // 
            this.OrderDGV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.OrderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PName,
            this.Price,
            this.Qty,
            this.Total});
            this.OrderDGV.GridColor = System.Drawing.Color.Black;
            this.OrderDGV.Location = new System.Drawing.Point(593, 116);
            this.OrderDGV.Name = "OrderDGV";
            this.OrderDGV.RowTemplate.Height = 28;
            this.OrderDGV.Size = new System.Drawing.Size(547, 198);
            this.OrderDGV.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(163, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 36);
            this.button1.TabIndex = 19;
            this.button1.Text = "Add Product";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(705, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 22);
            this.label6.TabIndex = 20;
            this.label6.Text = "Total Amount : ";
            // 
            // CustName
            // 
            this.CustName.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.CustName.Location = new System.Drawing.Point(154, 155);
            this.CustName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CustName.Name = "CustName";
            this.CustName.Size = new System.Drawing.Size(241, 31);
            this.CustName.TabIndex = 21;
            // 
            // CustMember
            // 
            this.CustMember.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustMember.ForeColor = System.Drawing.SystemColors.MenuText;
            this.CustMember.Location = new System.Drawing.Point(154, 196);
            this.CustMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CustMember.Name = "CustMember";
            this.CustMember.Size = new System.Drawing.Size(241, 31);
            this.CustMember.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 22);
            this.label7.TabIndex = 22;
            this.label7.Text = "Members";
            // 
            // CustDGV
            // 
            this.CustDGV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.CustDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustDGV.GridColor = System.Drawing.Color.Black;
            this.CustDGV.Location = new System.Drawing.Point(27, 417);
            this.CustDGV.Name = "CustDGV";
            this.CustDGV.RowTemplate.Height = 28;
            this.CustDGV.Size = new System.Drawing.Size(337, 227);
            this.CustDGV.TabIndex = 24;
            this.CustDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // rslbl
            // 
            this.rslbl.AutoSize = true;
            this.rslbl.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rslbl.Location = new System.Drawing.Point(857, 336);
            this.rslbl.Name = "rslbl";
            this.rslbl.Size = new System.Drawing.Size(37, 22);
            this.rslbl.TabIndex = 25;
            this.rslbl.Text = "Rs.";
            // 
            // PName
            // 
            this.PName.HeaderText = "ProdName";
            this.PName.Name = "PName";
            // 
            // Price
            // 
            this.Price.HeaderText = "ProdPrice";
            this.Price.Name = "Price";
            // 
            // Qty
            // 
            this.Qty.HeaderText = "ProdQty";
            this.Qty.Name = "Qty";
            // 
            // Total
            // 
            this.Total.HeaderText = "ProdTotal";
            this.Total.Name = "Total";
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 711);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Prod1DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView Prod1DGV;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MaskedTextBox ProdPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox ProdName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox ProdId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label EmpName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView OrderDGV;
        private System.Windows.Forms.DataGridView CustDGV;
        private System.Windows.Forms.MaskedTextBox CustMember;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox CustName;
        private System.Windows.Forms.Label rslbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}