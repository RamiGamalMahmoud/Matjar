namespace UserControls
{
    partial class FormAllCategoryProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.lbl_category_name = new System.Windows.Forms.Label();
            this.lbl_search = new System.Windows.Forms.Label();
            this.text_amount = new System.Windows.Forms.TextBox();
            this.text_search = new System.Windows.Forms.TextBox();
            this.combo_category = new System.Windows.Forms.ComboBox();
            this.bth_exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gButton1 = new System.Windows.Forms.Button();
            this.lbl_total_label = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.pnl_bell = new System.Windows.Forms.Panel();
            this.dgv_bill = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBillAmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_change = new System.Windows.Forms.Label();
            this.text_paid = new System.Windows.Forms.TextBox();
            this.pnl_all_products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_all_products)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_bell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bill)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_all_products
            // 
            this.pnl_all_products.Controls.Add(this.dgv_all_products);
            this.pnl_all_products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_all_products.Location = new System.Drawing.Point(507, 84);
            this.pnl_all_products.Name = "pnl_all_products";
            this.pnl_all_products.Size = new System.Drawing.Size(743, 539);
            this.pnl_all_products.TabIndex = 16;
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
            this.dgv_all_products.Size = new System.Drawing.Size(743, 539);
            this.dgv_all_products.TabIndex = 3;
            this.dgv_all_products.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_all_products_CellClick);
            this.dgv_all_products.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_all_products_CellDoubleClick);
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
            this.clmn_category_name.Width = 150;
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Controls.Add(this.lbl_amount);
            this.panel2.Controls.Add(this.lbl_category_name);
            this.panel2.Controls.Add(this.lbl_search);
            this.panel2.Controls.Add(this.text_amount);
            this.panel2.Controls.Add(this.text_search);
            this.panel2.Controls.Add(this.combo_category);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(507, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(743, 84);
            this.panel2.TabIndex = 16;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.Transparent;
            this.btn_save.Location = new System.Drawing.Point(62, 46);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(61, 32);
            this.btn_save.TabIndex = 15;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_amount
            // 
            this.lbl_amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_amount.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amount.Location = new System.Drawing.Point(129, 13);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_amount.Size = new System.Drawing.Size(85, 30);
            this.lbl_amount.TabIndex = 12;
            this.lbl_amount.Text = "الكمية";
            this.lbl_amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_category_name
            // 
            this.lbl_category_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_category_name.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category_name.Location = new System.Drawing.Point(465, 13);
            this.lbl_category_name.Name = "lbl_category_name";
            this.lbl_category_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_category_name.Size = new System.Drawing.Size(245, 30);
            this.lbl_category_name.TabIndex = 12;
            this.lbl_category_name.Text = "اختيار القسم";
            this.lbl_category_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_search
            // 
            this.lbl_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_search.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search.Location = new System.Drawing.Point(217, 13);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_search.Size = new System.Drawing.Size(245, 30);
            this.lbl_search.TabIndex = 12;
            this.lbl_search.Text = "بحث باسم الصنف";
            this.lbl_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_amount
            // 
            this.text_amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.text_amount.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.text_amount.Location = new System.Drawing.Point(129, 46);
            this.text_amount.Name = "text_amount";
            this.text_amount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_amount.Size = new System.Drawing.Size(82, 32);
            this.text_amount.TabIndex = 2;
            this.text_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_amount.TextChanged += new System.EventHandler(this.text_amount_TextChanged);
            this.text_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_amount_KeyDown);
            // 
            // text_search
            // 
            this.text_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.text_search.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.text_search.Location = new System.Drawing.Point(217, 46);
            this.text_search.Name = "text_search";
            this.text_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_search.Size = new System.Drawing.Size(242, 32);
            this.text_search.TabIndex = 1;
            this.text_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_search.TextChanged += new System.EventHandler(this.text_search_TextChanged);
            this.text_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_search_KeyDown);
            // 
            // combo_category
            // 
            this.combo_category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_category.BackColor = System.Drawing.Color.White;
            this.combo_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_category.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_category.ForeColor = System.Drawing.Color.Black;
            this.combo_category.FormattingEnabled = true;
            this.combo_category.Location = new System.Drawing.Point(465, 46);
            this.combo_category.MaxDropDownItems = 20;
            this.combo_category.Name = "combo_category";
            this.combo_category.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_category.Size = new System.Drawing.Size(242, 32);
            this.combo_category.TabIndex = 0;
            this.combo_category.TabStop = false;
            // 
            // bth_exit
            // 
            this.bth_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bth_exit.BackColor = System.Drawing.Color.Tomato;
            this.bth_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bth_exit.FlatAppearance.BorderSize = 0;
            this.bth_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bth_exit.Font = new System.Drawing.Font("Arial", 16F);
            this.bth_exit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bth_exit.Location = new System.Drawing.Point(63, 5);
            this.bth_exit.Name = "bth_exit";
            this.bth_exit.Size = new System.Drawing.Size(145, 37);
            this.bth_exit.TabIndex = 17;
            this.bth_exit.Text = "خروج";
            this.bth_exit.UseVisualStyleBackColor = false;
            this.bth_exit.Click += new System.EventHandler(this.bth_exit_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gButton1);
            this.panel1.Controls.Add(this.bth_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 573);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 48);
            this.panel1.TabIndex = 17;
            // 
            // gButton1
            // 
            this.gButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gButton1.BackColor = System.Drawing.Color.Tomato;
            this.gButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.gButton1.FlatAppearance.BorderSize = 0;
            this.gButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gButton1.Font = new System.Drawing.Font("Arial", 16F);
            this.gButton1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gButton1.Location = new System.Drawing.Point(295, 5);
            this.gButton1.Name = "gButton1";
            this.gButton1.Size = new System.Drawing.Size(145, 37);
            this.gButton1.TabIndex = 17;
            this.gButton1.Text = "خروج";
            this.gButton1.UseVisualStyleBackColor = false;
            this.gButton1.Click += new System.EventHandler(this.bth_exit_Click);
            // 
            // lbl_total_label
            // 
            this.lbl_total_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_total_label.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_label.Location = new System.Drawing.Point(297, 0);
            this.lbl_total_label.Name = "lbl_total_label";
            this.lbl_total_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_total_label.Size = new System.Drawing.Size(85, 21);
            this.lbl_total_label.TabIndex = 12;
            this.lbl_total_label.Text = "الاجمالي";
            this.lbl_total_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_total
            // 
            this.lbl_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_total.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(298, 21);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_total.Size = new System.Drawing.Size(85, 37);
            this.lbl_total.TabIndex = 12;
            this.lbl_total.Text = "0.0";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_total.TextChanged += new System.EventHandler(this.lbl_total_TextChanged);
            // 
            // pnl_bell
            // 
            this.pnl_bell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_bell.Controls.Add(this.dgv_bill);
            this.pnl_bell.Controls.Add(this.panel3);
            this.pnl_bell.Controls.Add(this.panel1);
            this.pnl_bell.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_bell.Location = new System.Drawing.Point(0, 0);
            this.pnl_bell.Name = "pnl_bell";
            this.pnl_bell.Size = new System.Drawing.Size(507, 623);
            this.pnl_bell.TabIndex = 18;
            // 
            // dgv_bill
            // 
            this.dgv_bill.AllowUserToAddRows = false;
            this.dgv_bill.AllowUserToDeleteRows = false;
            this.dgv_bill.AllowUserToResizeColumns = false;
            this.dgv_bill.AllowUserToResizeRows = false;
            this.dgv_bill.BackgroundColor = System.Drawing.Color.White;
            this.dgv_bill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_bill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_bill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_bill.ColumnHeadersHeight = 40;
            this.dgv_bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_bill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dgvBillAmountColumn,
            this.clmn_total,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_bill.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_bill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_bill.EnableHeadersVisualStyles = false;
            this.dgv_bill.Location = new System.Drawing.Point(0, 59);
            this.dgv_bill.Name = "dgv_bill";
            this.dgv_bill.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_bill.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_bill.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_bill.RowHeadersVisible = false;
            this.dgv_bill.RowHeadersWidth = 30;
            this.dgv_bill.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_bill.RowTemplate.Height = 40;
            this.dgv_bill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_bill.Size = new System.Drawing.Size(505, 514);
            this.dgv_bill.TabIndex = 16;
            this.dgv_bill.TabStop = false;
            this.dgv_bill.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bill_CellValueChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "حذف";
            this.Column1.Name = "Column1";
            this.Column1.Width = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "category_name";
            this.dataGridViewTextBoxColumn1.HeaderText = "القسم";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "product_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "كود الصنف";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "product_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "اسم الصنف";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "unit_name";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn4.HeaderText = "الوحدة";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "selling_price";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn5.HeaderText = "السعر";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 75;
            // 
            // dgvBillAmountColumn
            // 
            this.dgvBillAmountColumn.DataPropertyName = "amount";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.NullValue = null;
            this.dgvBillAmountColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvBillAmountColumn.HeaderText = "الكمية";
            this.dgvBillAmountColumn.Name = "dgvBillAmountColumn";
            this.dgvBillAmountColumn.Width = 50;
            // 
            // clmn_total
            // 
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmn_total.DefaultCellStyle = dataGridViewCellStyle12;
            this.clmn_total.HeaderText = "الاجمالي";
            this.clmn_total.Name = "clmn_total";
            this.clmn_total.Width = 75;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "category_id";
            this.dataGridViewTextBoxColumn7.HeaderText = "category_id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "unit_id";
            this.dataGridViewTextBoxColumn8.HeaderText = "unit_id";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lbl_total_label);
            this.panel3.Controls.Add(this.lbl_change);
            this.panel3.Controls.Add(this.lbl_total);
            this.panel3.Controls.Add(this.text_paid);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(505, 59);
            this.panel3.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "الباقي";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "المدفوع";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_change
            // 
            this.lbl_change.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_change.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_change.Location = new System.Drawing.Point(119, 21);
            this.lbl_change.Name = "lbl_change";
            this.lbl_change.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_change.Size = new System.Drawing.Size(85, 37);
            this.lbl_change.TabIndex = 12;
            this.lbl_change.Text = "0.0";
            this.lbl_change.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_change.TextChanged += new System.EventHandler(this.lbl_change_TextChanged);
            // 
            // text_paid
            // 
            this.text_paid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.text_paid.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.text_paid.Location = new System.Drawing.Point(210, 21);
            this.text_paid.Name = "text_paid";
            this.text_paid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_paid.Size = new System.Drawing.Size(82, 32);
            this.text_paid.TabIndex = 1;
            this.text_paid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_paid.TextChanged += new System.EventHandler(this.text_paid_TextChanged);
            // 
            // FormAllCategoryProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bth_exit;
            this.ClientSize = new System.Drawing.Size(1250, 623);
            this.Controls.Add(this.pnl_all_products);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_bell);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAllCategoryProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAllCategoryProducts";
            this.Load += new System.EventHandler(this.FormAllCategoryProducts_Load);
            this.pnl_all_products.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_all_products)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnl_bell.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bill)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_all_products;
        private System.Windows.Forms.DataGridView dgv_all_products;
        private System.Windows.Forms.Button bth_exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox combo_category;
        private System.Windows.Forms.TextBox text_search;
        private System.Windows.Forms.TextBox text_amount;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.Label lbl_category_name;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel pnl_bell;
        private System.Windows.Forms.DataGridView dgv_bill;
        private System.Windows.Forms.Button gButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_category_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn selling_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_category_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBillAmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label lbl_total_label;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_change;
        private System.Windows.Forms.TextBox text_paid;
    }
}