namespace SalesOrderForm
{
    partial class Form1
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
            this.search_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UoMEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarehouseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TaxDate = new System.Windows.Forms.TextBox();
            this.DocDueDate = new System.Windows.Forms.TextBox();
            this.DocDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DocNum = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SalesPersonCode = new System.Windows.Forms.TextBox();
            this.CardCode = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(144, 12);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 0;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCode,
            this.UoMEntry,
            this.Quantity,
            this.UnitPrice,
            this.DiscountPercent,
            this.WarehouseCode,
            this.LineTotal});
            this.dataGridView1.Location = new System.Drawing.Point(12, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(647, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // ItemCode
            // 
            this.ItemCode.HeaderText = "Item Code";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.Width = 74;
            // 
            // UoMEntry
            // 
            this.UoMEntry.HeaderText = "UoM Entry";
            this.UoMEntry.Name = "UoMEntry";
            this.UoMEntry.Width = 76;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 71;
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Width = 72;
            // 
            // DiscountPercent
            // 
            this.DiscountPercent.HeaderText = "Discount Percent";
            this.DiscountPercent.Name = "DiscountPercent";
            this.DiscountPercent.Width = 105;
            // 
            // WarehouseCode
            // 
            this.WarehouseCode.HeaderText = "Warehouse Code";
            this.WarehouseCode.Name = "WarehouseCode";
            this.WarehouseCode.Width = 105;
            // 
            // LineTotal
            // 
            this.LineTotal.HeaderText = "Line Total";
            this.LineTotal.Name = "LineTotal";
            this.LineTotal.Width = 73;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Document Entry";
            this.textBox1.Enter += new System.EventHandler(this.RemoveText);
            this.textBox1.Leave += new System.EventHandler(this.addText);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TaxDate);
            this.groupBox1.Controls.Add(this.DocDueDate);
            this.groupBox1.Controls.Add(this.DocDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DocNum);
            this.groupBox1.Location = new System.Drawing.Point(459, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 123);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Document";
            // 
            // TaxDate
            // 
            this.TaxDate.Location = new System.Drawing.Point(94, 97);
            this.TaxDate.Name = "TaxDate";
            this.TaxDate.Size = new System.Drawing.Size(100, 20);
            this.TaxDate.TabIndex = 10;
            // 
            // DocDueDate
            // 
            this.DocDueDate.Location = new System.Drawing.Point(94, 72);
            this.DocDueDate.Name = "DocDueDate";
            this.DocDueDate.Size = new System.Drawing.Size(100, 20);
            this.DocDueDate.TabIndex = 9;
            // 
            // DocDate
            // 
            this.DocDate.Location = new System.Drawing.Point(94, 46);
            this.DocDate.Name = "DocDate";
            this.DocDate.Size = new System.Drawing.Size(100, 20);
            this.DocDate.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Document Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Delivery Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Posting Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Doc Number";
            // 
            // DocNum
            // 
            this.DocNum.Location = new System.Drawing.Point(94, 20);
            this.DocNum.Name = "DocNum";
            this.DocNum.Size = new System.Drawing.Size(100, 20);
            this.DocNum.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.SalesPersonCode);
            this.groupBox2.Controls.Add(this.CardCode);
            this.groupBox2.Location = new System.Drawing.Point(239, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 123);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Business Partner";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sales Person Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Customer Code";
            // 
            // SalesPersonCode
            // 
            this.SalesPersonCode.Location = new System.Drawing.Point(107, 46);
            this.SalesPersonCode.Name = "SalesPersonCode";
            this.SalesPersonCode.Size = new System.Drawing.Size(100, 20);
            this.SalesPersonCode.TabIndex = 5;
            // 
            // CardCode
            // 
            this.CardCode.Location = new System.Drawing.Point(107, 20);
            this.CardCode.Name = "CardCode";
            this.CardCode.Size = new System.Drawing.Size(100, 20);
            this.CardCode.TabIndex = 8;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(584, 330);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 5;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 365);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DocNum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SalesPersonCode;
        private System.Windows.Forms.TextBox CardCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn UoMEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarehouseCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineTotal;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox DocDueDate;
        private System.Windows.Forms.TextBox DocDate;
        private System.Windows.Forms.TextBox TaxDate;
    }
}

