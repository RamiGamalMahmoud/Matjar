namespace UserControls
{
    partial class UC_SearchTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.text_amount = new System.Windows.Forms.TextBox();
            this.pnl_all_products = new System.Windows.Forms.Panel();
            this.dgv_all_products = new System.Windows.Forms.DataGridView();
            this.clmn_category_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selling_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_category_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.pnl_all_products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_all_products)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btn_close);
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Controls.Add(this.lbl_amount);
            this.panel2.Controls.Add(this.text_amount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(698, 84);
            this.panel2.TabIndex = 17;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.Transparent;
            this.btn_save.Location = new System.Drawing.Point(302, 18);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(61, 32);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // lbl_amount
            // 
            this.lbl_amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_amount.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amount.Location = new System.Drawing.Point(457, 18);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_amount.Size = new System.Drawing.Size(85, 30);
            this.lbl_amount.TabIndex = 0;
            this.lbl_amount.Text = "الكمية";
            this.lbl_amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_amount
            // 
            this.text_amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.text_amount.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.text_amount.Location = new System.Drawing.Point(369, 16);
            this.text_amount.Name = "text_amount";
            this.text_amount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_amount.Size = new System.Drawing.Size(82, 32);
            this.text_amount.TabIndex = 1;
            this.text_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_amount_KeyDown);
            // 
            // pnl_all_products
            // 
            this.pnl_all_products.Controls.Add(this.dgv_all_products);
            this.pnl_all_products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_all_products.Location = new System.Drawing.Point(0, 84);
            this.pnl_all_products.Name = "pnl_all_products";
            this.pnl_all_products.Size = new System.Drawing.Size(698, 664);
            this.pnl_all_products.TabIndex = 18;
            // 
            // dgv_all_products
            // 
            this.dgv_all_products.AllowUserToAddRows = false;
            this.dgv_all_products.AllowUserToDeleteRows = false;
            this.dgv_all_products.AllowUserToResizeColumns = false;
            this.dgv_all_products.AllowUserToResizeRows = false;
            this.dgv_all_products.BackgroundColor = System.Drawing.Color.White;
            this.dgv_all_products.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_all_products.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_all_products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_all_products.ColumnHeadersHeight = 40;
            this.dgv_all_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_all_products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmn_category_name,
            this.product_id,
            this.product_name,
            this.unit_name,
            this.selling_price,
            this.amount,
            this.clmn_category_id,
            this.unit_id});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_all_products.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_all_products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_all_products.EnableHeadersVisualStyles = false;
            this.dgv_all_products.Location = new System.Drawing.Point(0, 0);
            this.dgv_all_products.Name = "dgv_all_products";
            this.dgv_all_products.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_all_products.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_all_products.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_all_products.RowHeadersWidth = 30;
            this.dgv_all_products.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_all_products.RowTemplate.Height = 40;
            this.dgv_all_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_all_products.Size = new System.Drawing.Size(698, 664);
            this.dgv_all_products.TabIndex = 0;
            this.dgv_all_products.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_all_products_KeyDown);
            // 
            // clmn_category_name
            // 
            this.clmn_category_name.DataPropertyName = "category_name";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmn_category_name.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmn_category_name.HeaderText = "القسم";
            this.clmn_category_name.Name = "clmn_category_name";
            this.clmn_category_name.ReadOnly = true;
            // 
            // product_id
            // 
            this.product_id.DataPropertyName = "product_id";
            this.product_id.HeaderText = "كود الصنف";
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            // 
            // product_name
            // 
            this.product_name.DataPropertyName = "product_name";
            this.product_name.HeaderText = "اسم الصنف";
            this.product_name.Name = "product_name";
            this.product_name.ReadOnly = true;
            this.product_name.Width = 250;
            // 
            // unit_name
            // 
            this.unit_name.DataPropertyName = "unit_name";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit_name.DefaultCellStyle = dataGridViewCellStyle3;
            this.unit_name.HeaderText = "الوحدة";
            this.unit_name.Name = "unit_name";
            this.unit_name.ReadOnly = true;
            // 
            // selling_price
            // 
            this.selling_price.DataPropertyName = "selling_price";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.selling_price.DefaultCellStyle = dataGridViewCellStyle4;
            this.selling_price.HeaderText = "السعر";
            this.selling_price.Name = "selling_price";
            this.selling_price.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.DataPropertyName = "amount";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.NullValue = null;
            this.amount.DefaultCellStyle = dataGridViewCellStyle5;
            this.amount.HeaderText = "الكمية";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.Visible = false;
            // 
            // clmn_category_id
            // 
            this.clmn_category_id.DataPropertyName = "category_id";
            this.clmn_category_id.HeaderText = "category_id";
            this.clmn_category_id.Name = "clmn_category_id";
            this.clmn_category_id.ReadOnly = true;
            this.clmn_category_id.Visible = false;
            // 
            // unit_id
            // 
            this.unit_id.DataPropertyName = "unit_id";
            this.unit_id.HeaderText = "unit_id";
            this.unit_id.Name = "unit_id";
            this.unit_id.ReadOnly = true;
            this.unit_id.Visible = false;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.Transparent;
            this.btn_close.Location = new System.Drawing.Point(1, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(32, 32);
            this.btn_close.TabIndex = 0;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // UC_SearchTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnl_all_products);
            this.Controls.Add(this.panel2);
            this.Name = "UC_SearchTable";
            this.Size = new System.Drawing.Size(698, 748);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnl_all_products.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_all_products)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.TextBox text_amount;
        private System.Windows.Forms.Panel pnl_all_products;
        private System.Windows.Forms.DataGridView dgv_all_products;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_category_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn selling_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_category_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_id;
        private System.Windows.Forms.Button btn_close;
    }
}
