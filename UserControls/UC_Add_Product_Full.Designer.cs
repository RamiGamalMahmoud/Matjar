namespace UserControls
{
    partial class UC_Add_Product_Full
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_existing_products = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasing_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selling_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profit_margin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_add_product_main = new System.Windows.Forms.Panel();
            this.pnl_add_product_controls = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_add_new_product_name = new System.Windows.Forms.Button();
            this.btn_new_product_save = new System.Windows.Forms.Button();
            this.lbl_add_new_product_name = new System.Windows.Forms.Label();
            this.combo_existed_products_names = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.combo_categories = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.text_new_product_name = new System.Windows.Forms.TextBox();
            this.text_amount = new System.Windows.Forms.TextBox();
            this.text_profit_margin = new System.Windows.Forms.TextBox();
            this.text_selling_price = new System.Windows.Forms.TextBox();
            this.text_purchasing_price = new System.Windows.Forms.TextBox();
            this.combo_units = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pnl_info_main = new System.Windows.Forms.Panel();
            this.dgv_info = new System.Windows.Forms.DataGridView();
            this.info_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.base_unit_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.base_unit_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub_unit_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub_unit_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub_unit_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub_unit_is_purchaseable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnl_info_controls = new System.Windows.Forms.Panel();
            this.btn_info_save = new System.Windows.Forms.Button();
            this.text_contents_amount = new System.Windows.Forms.TextBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.combo_is_purchaseable = new System.Windows.Forms.ComboBox();
            this.combo_sub_units = new System.Windows.Forms.ComboBox();
            this.combo_base_units = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_info_id = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_existing_products)).BeginInit();
            this.pnl_add_product_main.SuspendLayout();
            this.pnl_add_product_controls.SuspendLayout();
            this.pnl_info_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).BeginInit();
            this.pnl_info_controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_existing_products
            // 
            this.dgv_existing_products.AllowUserToAddRows = false;
            this.dgv_existing_products.AllowUserToDeleteRows = false;
            this.dgv_existing_products.AllowUserToResizeColumns = false;
            this.dgv_existing_products.AllowUserToResizeRows = false;
            this.dgv_existing_products.BackgroundColor = System.Drawing.Color.White;
            this.dgv_existing_products.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_existing_products.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(221)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_existing_products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_existing_products.ColumnHeadersHeight = 40;
            this.dgv_existing_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_existing_products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.unit,
            this.dataGridViewTextBoxColumn2,
            this.purchasing_price,
            this.selling_price,
            this.profit_margin});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(81)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_existing_products.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_existing_products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_existing_products.EnableHeadersVisualStyles = false;
            this.dgv_existing_products.Location = new System.Drawing.Point(0, 145);
            this.dgv_existing_products.Name = "dgv_existing_products";
            this.dgv_existing_products.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(221)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_existing_products.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_existing_products.RowHeadersWidth = 30;
            this.dgv_existing_products.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_existing_products.RowTemplate.Height = 30;
            this.dgv_existing_products.Size = new System.Drawing.Size(588, 230);
            this.dgv_existing_products.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "product_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "كود المنتج";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // unit
            // 
            this.unit.DataPropertyName = "unit";
            this.unit.HeaderText = "الوحدة";
            this.unit.Name = "unit";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "amount";
            this.dataGridViewTextBoxColumn2.HeaderText = "الكمية";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // purchasing_price
            // 
            this.purchasing_price.DataPropertyName = "purchasing_price";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.purchasing_price.DefaultCellStyle = dataGridViewCellStyle2;
            this.purchasing_price.HeaderText = "سعر الشراء";
            this.purchasing_price.Name = "purchasing_price";
            this.purchasing_price.ReadOnly = true;
            // 
            // selling_price
            // 
            this.selling_price.DataPropertyName = "selling_price";
            dataGridViewCellStyle3.Format = "N2";
            this.selling_price.DefaultCellStyle = dataGridViewCellStyle3;
            this.selling_price.HeaderText = "سعر البيع";
            this.selling_price.Name = "selling_price";
            this.selling_price.ReadOnly = true;
            // 
            // profit_margin
            // 
            this.profit_margin.DataPropertyName = "profit_margin";
            dataGridViewCellStyle4.Format = "N2";
            this.profit_margin.DefaultCellStyle = dataGridViewCellStyle4;
            this.profit_margin.HeaderText = "هامش الربح";
            this.profit_margin.Name = "profit_margin";
            this.profit_margin.ReadOnly = true;
            // 
            // pnl_add_product_main
            // 
            this.pnl_add_product_main.Controls.Add(this.dgv_existing_products);
            this.pnl_add_product_main.Controls.Add(this.pnl_add_product_controls);
            this.pnl_add_product_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_add_product_main.Location = new System.Drawing.Point(0, 0);
            this.pnl_add_product_main.Name = "pnl_add_product_main";
            this.pnl_add_product_main.Size = new System.Drawing.Size(588, 375);
            this.pnl_add_product_main.TabIndex = 47;
            // 
            // pnl_add_product_controls
            // 
            this.pnl_add_product_controls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnl_add_product_controls.Controls.Add(this.btn_back);
            this.pnl_add_product_controls.Controls.Add(this.btn_add_new_product_name);
            this.pnl_add_product_controls.Controls.Add(this.btn_new_product_save);
            this.pnl_add_product_controls.Controls.Add(this.lbl_add_new_product_name);
            this.pnl_add_product_controls.Controls.Add(this.combo_existed_products_names);
            this.pnl_add_product_controls.Controls.Add(this.label10);
            this.pnl_add_product_controls.Controls.Add(this.combo_categories);
            this.pnl_add_product_controls.Controls.Add(this.label9);
            this.pnl_add_product_controls.Controls.Add(this.text_new_product_name);
            this.pnl_add_product_controls.Controls.Add(this.text_amount);
            this.pnl_add_product_controls.Controls.Add(this.text_profit_margin);
            this.pnl_add_product_controls.Controls.Add(this.text_selling_price);
            this.pnl_add_product_controls.Controls.Add(this.text_purchasing_price);
            this.pnl_add_product_controls.Controls.Add(this.combo_units);
            this.pnl_add_product_controls.Controls.Add(this.label4);
            this.pnl_add_product_controls.Controls.Add(this.label3);
            this.pnl_add_product_controls.Controls.Add(this.label2);
            this.pnl_add_product_controls.Controls.Add(this.label1);
            this.pnl_add_product_controls.Controls.Add(this.label14);
            this.pnl_add_product_controls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_add_product_controls.Location = new System.Drawing.Point(0, 0);
            this.pnl_add_product_controls.Name = "pnl_add_product_controls";
            this.pnl_add_product_controls.Size = new System.Drawing.Size(588, 145);
            this.pnl_add_product_controls.TabIndex = 0;
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(10, 30);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(53, 30);
            this.btn_back.TabIndex = 41;
            this.btn_back.Text = "رجوع";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Visible = false;
            this.btn_back.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_add_new_product_name
            // 
            this.btn_add_new_product_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_new_product_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_add_new_product_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_new_product_name.FlatAppearance.BorderSize = 0;
            this.btn_add_new_product_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_new_product_name.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_new_product_name.ForeColor = System.Drawing.Color.Transparent;
            this.btn_add_new_product_name.Location = new System.Drawing.Point(64, 30);
            this.btn_add_new_product_name.Name = "btn_add_new_product_name";
            this.btn_add_new_product_name.Size = new System.Drawing.Size(125, 30);
            this.btn_add_new_product_name.TabIndex = 41;
            this.btn_add_new_product_name.Text = "اضافة صنف جديد";
            this.btn_add_new_product_name.UseVisualStyleBackColor = false;
            this.btn_add_new_product_name.Click += new System.EventHandler(this.btn_add_new_product_name_Click);
            // 
            // btn_new_product_save
            // 
            this.btn_new_product_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_new_product_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_new_product_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new_product_save.FlatAppearance.BorderSize = 0;
            this.btn_new_product_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new_product_save.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_product_save.ForeColor = System.Drawing.Color.Transparent;
            this.btn_new_product_save.Location = new System.Drawing.Point(35, 96);
            this.btn_new_product_save.Name = "btn_new_product_save";
            this.btn_new_product_save.Size = new System.Drawing.Size(60, 30);
            this.btn_new_product_save.TabIndex = 7;
            this.btn_new_product_save.Text = "حفظ";
            this.btn_new_product_save.UseVisualStyleBackColor = false;
            // 
            // lbl_add_new_product_name
            // 
            this.lbl_add_new_product_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_add_new_product_name.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_add_new_product_name.Location = new System.Drawing.Point(64, 7);
            this.lbl_add_new_product_name.Name = "lbl_add_new_product_name";
            this.lbl_add_new_product_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_add_new_product_name.Size = new System.Drawing.Size(125, 15);
            this.lbl_add_new_product_name.TabIndex = 37;
            this.lbl_add_new_product_name.Text = "الصنف الجديد";
            this.lbl_add_new_product_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_add_new_product_name.Visible = false;
            // 
            // combo_existed_products_names
            // 
            this.combo_existed_products_names.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_existed_products_names.BackColor = System.Drawing.Color.White;
            this.combo_existed_products_names.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_existed_products_names.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_existed_products_names.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_existed_products_names.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            this.combo_existed_products_names.FormattingEnabled = true;
            this.combo_existed_products_names.Location = new System.Drawing.Point(196, 30);
            this.combo_existed_products_names.Name = "combo_existed_products_names";
            this.combo_existed_products_names.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_existed_products_names.Size = new System.Drawing.Size(230, 30);
            this.combo_existed_products_names.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(196, 7);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(230, 15);
            this.label10.TabIndex = 38;
            this.label10.Text = "الاصناف الموجودة";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // combo_categories
            // 
            this.combo_categories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_categories.BackColor = System.Drawing.Color.White;
            this.combo_categories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_categories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_categories.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_categories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            this.combo_categories.FormattingEnabled = true;
            this.combo_categories.Location = new System.Drawing.Point(432, 30);
            this.combo_categories.Name = "combo_categories";
            this.combo_categories.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_categories.Size = new System.Drawing.Size(141, 30);
            this.combo_categories.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(432, 7);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(141, 15);
            this.label9.TabIndex = 39;
            this.label9.Text = "القسم";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_new_product_name
            // 
            this.text_new_product_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.text_new_product_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_new_product_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_new_product_name.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_new_product_name.Location = new System.Drawing.Point(64, 30);
            this.text_new_product_name.Name = "text_new_product_name";
            this.text_new_product_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_new_product_name.Size = new System.Drawing.Size(125, 27);
            this.text_new_product_name.TabIndex = 36;
            this.text_new_product_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_new_product_name.Visible = false;
            // 
            // text_amount
            // 
            this.text_amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.text_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_amount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_amount.Location = new System.Drawing.Point(365, 99);
            this.text_amount.Name = "text_amount";
            this.text_amount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_amount.Size = new System.Drawing.Size(81, 26);
            this.text_amount.TabIndex = 3;
            this.text_amount.Text = "0.0";
            this.text_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_amount.Click += new System.EventHandler(this.TextBoxFocused);
            this.text_amount.Enter += new System.EventHandler(this.TextBoxFocused);
            // 
            // text_profit_margin
            // 
            this.text_profit_margin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.text_profit_margin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_profit_margin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_profit_margin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_profit_margin.Location = new System.Drawing.Point(105, 99);
            this.text_profit_margin.Name = "text_profit_margin";
            this.text_profit_margin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_profit_margin.Size = new System.Drawing.Size(81, 26);
            this.text_profit_margin.TabIndex = 6;
            this.text_profit_margin.Text = "0.0";
            this.text_profit_margin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_profit_margin.Click += new System.EventHandler(this.TextBoxFocused);
            this.text_profit_margin.Enter += new System.EventHandler(this.TextBoxFocused);
            // 
            // text_selling_price
            // 
            this.text_selling_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.text_selling_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_selling_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_selling_price.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_selling_price.Location = new System.Drawing.Point(192, 99);
            this.text_selling_price.Name = "text_selling_price";
            this.text_selling_price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_selling_price.Size = new System.Drawing.Size(81, 26);
            this.text_selling_price.TabIndex = 5;
            this.text_selling_price.Text = "0.0";
            this.text_selling_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_selling_price.Click += new System.EventHandler(this.TextBoxFocused);
            this.text_selling_price.TextChanged += new System.EventHandler(this.Text_selling_price_TextChanged);
            this.text_selling_price.Enter += new System.EventHandler(this.TextBoxFocused);
            // 
            // text_purchasing_price
            // 
            this.text_purchasing_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.text_purchasing_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_purchasing_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_purchasing_price.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_purchasing_price.Location = new System.Drawing.Point(278, 99);
            this.text_purchasing_price.Name = "text_purchasing_price";
            this.text_purchasing_price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_purchasing_price.Size = new System.Drawing.Size(81, 26);
            this.text_purchasing_price.TabIndex = 4;
            this.text_purchasing_price.Text = "0.0";
            this.text_purchasing_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_purchasing_price.Click += new System.EventHandler(this.TextBoxFocused);
            this.text_purchasing_price.TextChanged += new System.EventHandler(this.Text_purchasing_price_TextChanged);
            this.text_purchasing_price.Enter += new System.EventHandler(this.TextBoxFocused);
            // 
            // combo_units
            // 
            this.combo_units.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_units.BackColor = System.Drawing.Color.White;
            this.combo_units.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_units.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_units.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_units.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            this.combo_units.FormattingEnabled = true;
            this.combo_units.Location = new System.Drawing.Point(458, 96);
            this.combo_units.Name = "combo_units";
            this.combo_units.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_units.Size = new System.Drawing.Size(122, 32);
            this.combo_units.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(365, 64);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(84, 30);
            this.label4.TabIndex = 24;
            this.label4.Text = "الكمية";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 64);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(84, 30);
            this.label3.TabIndex = 25;
            this.label3.Text = "هامش الربح";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 64);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(84, 30);
            this.label2.TabIndex = 26;
            this.label2.Text = "سعر البيع";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 64);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(84, 30);
            this.label1.TabIndex = 27;
            this.label1.Text = "سعر التكفقة";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(461, 63);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label14.Size = new System.Drawing.Size(122, 30);
            this.label14.TabIndex = 28;
            this.label14.Text = "الوحدة";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_info_main
            // 
            this.pnl_info_main.Controls.Add(this.dgv_info);
            this.pnl_info_main.Controls.Add(this.panel7);
            this.pnl_info_main.Controls.Add(this.panel6);
            this.pnl_info_main.Controls.Add(this.pnl_info_controls);
            this.pnl_info_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_info_main.Location = new System.Drawing.Point(0, 375);
            this.pnl_info_main.Name = "pnl_info_main";
            this.pnl_info_main.Size = new System.Drawing.Size(588, 375);
            this.pnl_info_main.TabIndex = 48;
            // 
            // dgv_info
            // 
            this.dgv_info.AllowUserToAddRows = false;
            this.dgv_info.AllowUserToDeleteRows = false;
            this.dgv_info.AllowUserToResizeColumns = false;
            this.dgv_info.AllowUserToResizeRows = false;
            this.dgv_info.BackgroundColor = System.Drawing.Color.White;
            this.dgv_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_info.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(221)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_info.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_info.ColumnHeadersHeight = 40;
            this.dgv_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.info_id,
            this.base_unit_name,
            this.base_unit_id,
            this.sub_unit_name,
            this.sub_unit_id,
            this.sub_unit_count,
            this.sub_unit_is_purchaseable});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(81)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_info.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_info.EnableHeadersVisualStyles = false;
            this.dgv_info.Location = new System.Drawing.Point(50, 127);
            this.dgv_info.Name = "dgv_info";
            this.dgv_info.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(221)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_info.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_info.RowHeadersWidth = 30;
            this.dgv_info.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_info.RowTemplate.Height = 30;
            this.dgv_info.Size = new System.Drawing.Size(482, 248);
            this.dgv_info.TabIndex = 0;
            this.dgv_info.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_info_RowHeaderMouseDoubleClick);
            // 
            // info_id
            // 
            this.info_id.DataPropertyName = "info_id";
            this.info_id.HeaderText = "info_id";
            this.info_id.Name = "info_id";
            this.info_id.ReadOnly = true;
            this.info_id.Visible = false;
            this.info_id.Width = 50;
            // 
            // base_unit_name
            // 
            this.base_unit_name.DataPropertyName = "base_unit_name";
            this.base_unit_name.HeaderText = "الوحدة الاساسية";
            this.base_unit_name.Name = "base_unit_name";
            this.base_unit_name.ReadOnly = true;
            this.base_unit_name.Width = 120;
            // 
            // base_unit_id
            // 
            this.base_unit_id.DataPropertyName = "base_unit_id";
            this.base_unit_id.HeaderText = "كود الوحدة الاساسية";
            this.base_unit_id.Name = "base_unit_id";
            this.base_unit_id.ReadOnly = true;
            this.base_unit_id.Visible = false;
            // 
            // sub_unit_name
            // 
            this.sub_unit_name.DataPropertyName = "sub_unit_name";
            this.sub_unit_name.HeaderText = "الوحدة الفرعية";
            this.sub_unit_name.Name = "sub_unit_name";
            this.sub_unit_name.ReadOnly = true;
            this.sub_unit_name.Width = 120;
            // 
            // sub_unit_id
            // 
            this.sub_unit_id.DataPropertyName = "sub_unit_id";
            this.sub_unit_id.HeaderText = "كود الوحدة الفرعية";
            this.sub_unit_id.Name = "sub_unit_id";
            this.sub_unit_id.ReadOnly = true;
            this.sub_unit_id.Visible = false;
            // 
            // sub_unit_count
            // 
            this.sub_unit_count.DataPropertyName = "sub_unit_count";
            this.sub_unit_count.HeaderText = "العدد";
            this.sub_unit_count.Name = "sub_unit_count";
            this.sub_unit_count.ReadOnly = true;
            // 
            // sub_unit_is_purchaseable
            // 
            this.sub_unit_is_purchaseable.DataPropertyName = "sub_unit_is_purchaseable";
            this.sub_unit_is_purchaseable.HeaderText = "الوحدة الفرعية قابلة للشراء";
            this.sub_unit_is_purchaseable.Name = "sub_unit_is_purchaseable";
            this.sub_unit_is_purchaseable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sub_unit_is_purchaseable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 127);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(50, 248);
            this.panel7.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(532, 127);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(56, 248);
            this.panel6.TabIndex = 1;
            // 
            // pnl_info_controls
            // 
            this.pnl_info_controls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnl_info_controls.Controls.Add(this.btn_info_save);
            this.pnl_info_controls.Controls.Add(this.text_contents_amount);
            this.pnl_info_controls.Controls.Add(this.btn_edit);
            this.pnl_info_controls.Controls.Add(this.combo_is_purchaseable);
            this.pnl_info_controls.Controls.Add(this.combo_sub_units);
            this.pnl_info_controls.Controls.Add(this.combo_base_units);
            this.pnl_info_controls.Controls.Add(this.label18);
            this.pnl_info_controls.Controls.Add(this.label5);
            this.pnl_info_controls.Controls.Add(this.lbl_info_id);
            this.pnl_info_controls.Controls.Add(this.label21);
            this.pnl_info_controls.Controls.Add(this.label19);
            this.pnl_info_controls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_info_controls.Location = new System.Drawing.Point(0, 0);
            this.pnl_info_controls.Name = "pnl_info_controls";
            this.pnl_info_controls.Size = new System.Drawing.Size(588, 127);
            this.pnl_info_controls.TabIndex = 0;
            // 
            // btn_info_save
            // 
            this.btn_info_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_info_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_info_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_info_save.FlatAppearance.BorderSize = 0;
            this.btn_info_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_info_save.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_info_save.ForeColor = System.Drawing.Color.Transparent;
            this.btn_info_save.Location = new System.Drawing.Point(294, 83);
            this.btn_info_save.Name = "btn_info_save";
            this.btn_info_save.Size = new System.Drawing.Size(60, 30);
            this.btn_info_save.TabIndex = 5;
            this.btn_info_save.Text = "حفظ";
            this.btn_info_save.UseVisualStyleBackColor = false;
            // 
            // text_contents_amount
            // 
            this.text_contents_amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.text_contents_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_contents_amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_contents_amount.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_contents_amount.Location = new System.Drawing.Point(40, 39);
            this.text_contents_amount.Name = "text_contents_amount";
            this.text_contents_amount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_contents_amount.Size = new System.Drawing.Size(81, 32);
            this.text_contents_amount.TabIndex = 4;
            this.text_contents_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_contents_amount.Click += new System.EventHandler(this.TextBoxFocused);
            this.text_contents_amount.Enter += new System.EventHandler(this.TextBoxFocused);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.Black;
            this.btn_edit.Location = new System.Drawing.Point(228, 83);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(60, 30);
            this.btn_edit.TabIndex = 6;
            this.btn_edit.Text = "تعديل";
            this.btn_edit.UseVisualStyleBackColor = false;
            // 
            // combo_is_purchaseable
            // 
            this.combo_is_purchaseable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_is_purchaseable.BackColor = System.Drawing.Color.White;
            this.combo_is_purchaseable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_is_purchaseable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_is_purchaseable.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_is_purchaseable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            this.combo_is_purchaseable.FormattingEnabled = true;
            this.combo_is_purchaseable.Items.AddRange(new object[] {
            "نعم",
            "لا"});
            this.combo_is_purchaseable.Location = new System.Drawing.Point(127, 37);
            this.combo_is_purchaseable.Name = "combo_is_purchaseable";
            this.combo_is_purchaseable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_is_purchaseable.Size = new System.Drawing.Size(156, 32);
            this.combo_is_purchaseable.TabIndex = 3;
            // 
            // combo_sub_units
            // 
            this.combo_sub_units.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_sub_units.BackColor = System.Drawing.Color.White;
            this.combo_sub_units.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_sub_units.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_sub_units.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_sub_units.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            this.combo_sub_units.FormattingEnabled = true;
            this.combo_sub_units.Location = new System.Drawing.Point(289, 38);
            this.combo_sub_units.Name = "combo_sub_units";
            this.combo_sub_units.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_sub_units.Size = new System.Drawing.Size(125, 32);
            this.combo_sub_units.TabIndex = 2;
            // 
            // combo_base_units
            // 
            this.combo_base_units.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_base_units.BackColor = System.Drawing.Color.White;
            this.combo_base_units.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_base_units.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_base_units.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_base_units.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            this.combo_base_units.FormattingEnabled = true;
            this.combo_base_units.Location = new System.Drawing.Point(420, 38);
            this.combo_base_units.Name = "combo_base_units";
            this.combo_base_units.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_base_units.Size = new System.Drawing.Size(125, 32);
            this.combo_base_units.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(420, 5);
            this.label18.Name = "label18";
            this.label18.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label18.Size = new System.Drawing.Size(128, 32);
            this.label18.TabIndex = 30;
            this.label18.Text = "الوحدة الاساسية";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 4);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(159, 32);
            this.label5.TabIndex = 31;
            this.label5.Text = "الوحدة الفرعية قابلة للشراء ؟";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_info_id
            // 
            this.lbl_info_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_info_id.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_info_id.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info_id.Location = new System.Drawing.Point(10, 39);
            this.lbl_info_id.Name = "lbl_info_id";
            this.lbl_info_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_info_id.Size = new System.Drawing.Size(18, 23);
            this.lbl_info_id.TabIndex = 32;
            this.lbl_info_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(43, 6);
            this.label21.Name = "label21";
            this.label21.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label21.Size = new System.Drawing.Size(81, 32);
            this.label21.TabIndex = 33;
            this.label21.Text = "العدد";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(289, 5);
            this.label19.Name = "label19";
            this.label19.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label19.Size = new System.Drawing.Size(128, 32);
            this.label19.TabIndex = 34;
            this.label19.Text = "الوحدة الفرعية";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_Add_Product_Full
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_info_main);
            this.Controls.Add(this.pnl_add_product_main);
            this.Name = "UC_Add_Product_Full";
            this.Size = new System.Drawing.Size(588, 750);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_existing_products)).EndInit();
            this.pnl_add_product_main.ResumeLayout(false);
            this.pnl_add_product_controls.ResumeLayout(false);
            this.pnl_add_product_controls.PerformLayout();
            this.pnl_info_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).EndInit();
            this.pnl_info_controls.ResumeLayout(false);
            this.pnl_info_controls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_existing_products;
        private System.Windows.Forms.Panel pnl_add_product_main;
        private System.Windows.Forms.Panel pnl_add_product_controls;
        private System.Windows.Forms.TextBox text_amount;
        private System.Windows.Forms.TextBox text_profit_margin;
        private System.Windows.Forms.TextBox text_selling_price;
        private System.Windows.Forms.TextBox text_purchasing_price;
        private System.Windows.Forms.ComboBox combo_units;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_info_main;
        private System.Windows.Forms.Panel pnl_info_controls;
        private System.Windows.Forms.DataGridView dgv_info;
        private System.Windows.Forms.DataGridViewTextBoxColumn info_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn base_unit_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn base_unit_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub_unit_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub_unit_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub_unit_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub_unit_is_purchaseable;
        private System.Windows.Forms.Button btn_new_product_save;
        private System.Windows.Forms.Label lbl_add_new_product_name;
        private System.Windows.Forms.ComboBox combo_existed_products_names;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox combo_categories;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox text_new_product_name;
        private System.Windows.Forms.TextBox text_contents_amount;
        private System.Windows.Forms.ComboBox combo_is_purchaseable;
        private System.Windows.Forms.ComboBox combo_sub_units;
        private System.Windows.Forms.ComboBox combo_base_units;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_info_id;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btn_add_new_product_name;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_info_save;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasing_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn selling_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn profit_margin;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
    }
}
