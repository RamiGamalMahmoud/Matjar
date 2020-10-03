namespace UserControls
{
    partial class UC_Sales
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_day_total = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_unit = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.text_quantity = new System.Windows.Forms.TextBox();
            this.combo_product_name = new System.Windows.Forms.ComboBox();
            this.dgv_sales = new System.Windows.Forms.DataGridView();
            this.process_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_of_sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_save = new System.Windows.Forms.Button();
            this.pnl_control_btns = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_product_id = new System.Windows.Forms.Label();
            this.lbl_category_id = new System.Windows.Forms.Label();
            this.gbtn_view_products = new System.Windows.Forms.Button();
            this.combo_category_name = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.date_picker_work_day = new System.Windows.Forms.DateTimePicker();
            this.lbl_work_day = new System.Windows.Forms.Label();
            this.lbl_clock = new System.Windows.Forms.Label();
            this.pnl_right_border = new System.Windows.Forms.Panel();
            this.dgvDailySalesProperties = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sales)).BeginInit();
            this.pnl_control_btns.SuspendLayout();
            this.panel2.SuspendLayout();
            this.dgvDailySalesProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_day_total
            // 
            this.lbl_day_total.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_day_total.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day_total.Location = new System.Drawing.Point(899, 0);
            this.lbl_day_total.Name = "lbl_day_total";
            this.lbl_day_total.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_day_total.Size = new System.Drawing.Size(101, 28);
            this.lbl_day_total.TabIndex = 3;
            this.lbl_day_total.Text = "0";
            this.lbl_day_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(262, 5);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(60, 30);
            this.label9.TabIndex = 3;
            this.label9.Text = "الكمية";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(396, 5);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(60, 30);
            this.label6.TabIndex = 3;
            this.label6.Text = "الوحدة";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_unit
            // 
            this.lbl_unit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_unit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_unit.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_unit.ForeColor = System.Drawing.Color.White;
            this.lbl_unit.Location = new System.Drawing.Point(397, 38);
            this.lbl_unit.Name = "lbl_unit";
            this.lbl_unit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_unit.Size = new System.Drawing.Size(60, 60);
            this.lbl_unit.TabIndex = 24;
            this.lbl_unit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(463, 7);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(246, 30);
            this.label8.TabIndex = 3;
            this.label8.Text = "الصنف";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(196, 5);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(60, 30);
            this.label5.TabIndex = 3;
            this.label5.Text = "إجمالي";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_total
            // 
            this.lbl_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_total.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.White;
            this.lbl_total.Location = new System.Drawing.Point(196, 38);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_total.Size = new System.Drawing.Size(60, 60);
            this.lbl_total.TabIndex = 23;
            this.lbl_total.Text = "0";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(330, 5);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(60, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "السعر";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_price
            // 
            this.lbl_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_price.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.Color.White;
            this.lbl_price.Location = new System.Drawing.Point(331, 38);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_price.Size = new System.Drawing.Size(60, 60);
            this.lbl_price.TabIndex = 11;
            this.lbl_price.Text = "0";
            this.lbl_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lbl_day_total);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 756);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 28);
            this.panel1.TabIndex = 8;
            // 
            // text_quantity
            // 
            this.text_quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.text_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_quantity.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_quantity.Location = new System.Drawing.Point(262, 54);
            this.text_quantity.Name = "text_quantity";
            this.text_quantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_quantity.Size = new System.Drawing.Size(60, 32);
            this.text_quantity.TabIndex = 10;
            this.text_quantity.Text = "0";
            this.text_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_quantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.text_quantity_MouseClick);
            this.text_quantity.TextChanged += new System.EventHandler(this.text_quantity_TextChanged);
            this.text_quantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_quantity_KeyDown);
            // 
            // combo_product_name
            // 
            this.combo_product_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_product_name.BackColor = System.Drawing.Color.White;
            this.combo_product_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_product_name.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_product_name.ForeColor = System.Drawing.Color.Black;
            this.combo_product_name.FormattingEnabled = true;
            this.combo_product_name.Location = new System.Drawing.Point(462, 40);
            this.combo_product_name.MaxDropDownItems = 20;
            this.combo_product_name.Name = "combo_product_name";
            this.combo_product_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_product_name.Size = new System.Drawing.Size(244, 32);
            this.combo_product_name.TabIndex = 9;
            // 
            // dgv_sales
            // 
            this.dgv_sales.AllowUserToAddRows = false;
            this.dgv_sales.AllowUserToDeleteRows = false;
            this.dgv_sales.AllowUserToResizeColumns = false;
            this.dgv_sales.AllowUserToResizeRows = false;
            this.dgv_sales.BackgroundColor = System.Drawing.Color.White;
            this.dgv_sales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_sales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_sales.ColumnHeadersHeight = 50;
            this.dgv_sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_sales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.process_id,
            this.category_name,
            this.product_id,
            this.product_name,
            this.unit_name,
            this.amount,
            this.price,
            this.total,
            this.time_of_sale});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_sales.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_sales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_sales.EnableHeadersVisualStyles = false;
            this.dgv_sales.Location = new System.Drawing.Point(0, 128);
            this.dgv_sales.Name = "dgv_sales";
            this.dgv_sales.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_sales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sales.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_sales.RowHeadersWidth = 30;
            this.dgv_sales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_sales.RowTemplate.Height = 30;
            this.dgv_sales.Size = new System.Drawing.Size(1000, 628);
            this.dgv_sales.TabIndex = 7;
            this.dgv_sales.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_sales_CellMouseClick);
            // 
            // process_id
            // 
            this.process_id.DataPropertyName = "process_id";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.process_id.DefaultCellStyle = dataGridViewCellStyle2;
            this.process_id.HeaderText = "كود العملية";
            this.process_id.Name = "process_id";
            this.process_id.ReadOnly = true;
            this.process_id.Width = 150;
            // 
            // category_name
            // 
            this.category_name.DataPropertyName = "category_name";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_name.DefaultCellStyle = dataGridViewCellStyle3;
            this.category_name.HeaderText = "القسم";
            this.category_name.Name = "category_name";
            this.category_name.ReadOnly = true;
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
            this.product_name.Width = 200;
            // 
            // unit_name
            // 
            this.unit_name.DataPropertyName = "unit_name";
            this.unit_name.HeaderText = "الوحدة";
            this.unit_name.Name = "unit_name";
            this.unit_name.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.DataPropertyName = "amount";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.NullValue = null;
            this.amount.DefaultCellStyle = dataGridViewCellStyle4;
            this.amount.HeaderText = "الكمية";
            this.amount.Name = "amount";
            this.amount.Width = 70;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.price.DefaultCellStyle = dataGridViewCellStyle5;
            this.price.HeaderText = "السعر";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 90;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.total.DefaultCellStyle = dataGridViewCellStyle6;
            this.total.HeaderText = "الإجمالي";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 90;
            // 
            // time_of_sale
            // 
            this.time_of_sale.DataPropertyName = "time_of_sale";
            dataGridViewCellStyle7.Format = "T";
            dataGridViewCellStyle7.NullValue = null;
            this.time_of_sale.DefaultCellStyle = dataGridViewCellStyle7;
            this.time_of_sale.HeaderText = "وقت البيع";
            this.time_of_sale.Name = "time_of_sale";
            this.time_of_sale.ReadOnly = true;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.Transparent;
            this.btn_save.Location = new System.Drawing.Point(130, 38);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(60, 60);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pnl_control_btns
            // 
            this.pnl_control_btns.Controls.Add(this.panel2);
            this.pnl_control_btns.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_control_btns.Location = new System.Drawing.Point(0, 0);
            this.pnl_control_btns.Name = "pnl_control_btns";
            this.pnl_control_btns.Size = new System.Drawing.Size(1000, 128);
            this.pnl_control_btns.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_product_id);
            this.panel2.Controls.Add(this.lbl_category_id);
            this.panel2.Controls.Add(this.gbtn_view_products);
            this.panel2.Controls.Add(this.combo_category_name);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Controls.Add(this.date_picker_work_day);
            this.panel2.Controls.Add(this.combo_product_name);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.text_quantity);
            this.panel2.Controls.Add(this.lbl_work_day);
            this.panel2.Controls.Add(this.lbl_price);
            this.panel2.Controls.Add(this.lbl_clock);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbl_unit);
            this.panel2.Controls.Add(this.lbl_total);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 116);
            this.panel2.TabIndex = 15;
            // 
            // lbl_product_id
            // 
            this.lbl_product_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_product_id.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_id.Location = new System.Drawing.Point(712, 40);
            this.lbl_product_id.Name = "lbl_product_id";
            this.lbl_product_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_product_id.Size = new System.Drawing.Size(60, 32);
            this.lbl_product_id.TabIndex = 28;
            this.lbl_product_id.Text = "id";
            this.lbl_product_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_category_id
            // 
            this.lbl_category_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_category_id.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category_id.Location = new System.Drawing.Point(712, 3);
            this.lbl_category_id.Name = "lbl_category_id";
            this.lbl_category_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_category_id.Size = new System.Drawing.Size(60, 32);
            this.lbl_category_id.TabIndex = 28;
            this.lbl_category_id.Text = "id";
            this.lbl_category_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbtn_view_products
            // 
            this.gbtn_view_products.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbtn_view_products.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbtn_view_products.FlatAppearance.BorderSize = 0;
            this.gbtn_view_products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbtn_view_products.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.gbtn_view_products.Location = new System.Drawing.Point(463, 75);
            this.gbtn_view_products.Name = "gbtn_view_products";
            this.gbtn_view_products.Size = new System.Drawing.Size(243, 33);
            this.gbtn_view_products.TabIndex = 26;
            this.gbtn_view_products.Text = "عرض المنتجات";
            this.gbtn_view_products.UseVisualStyleBackColor = false;
            this.gbtn_view_products.Click += new System.EventHandler(this.gbtn_view_products_Click);
            // 
            // combo_category_name
            // 
            this.combo_category_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_category_name.BackColor = System.Drawing.Color.White;
            this.combo_category_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_category_name.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_category_name.ForeColor = System.Drawing.Color.Black;
            this.combo_category_name.FormattingEnabled = true;
            this.combo_category_name.Location = new System.Drawing.Point(463, 3);
            this.combo_category_name.MaxDropDownItems = 20;
            this.combo_category_name.Name = "combo_category_name";
            this.combo_category_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_category_name.Size = new System.Drawing.Size(243, 32);
            this.combo_category_name.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(64, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "فاتورة";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // date_picker_work_day
            // 
            this.date_picker_work_day.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.date_picker_work_day.CalendarFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_picker_work_day.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.date_picker_work_day.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.date_picker_work_day.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_picker_work_day.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_picker_work_day.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.date_picker_work_day.Location = new System.Drawing.Point(785, 75);
            this.date_picker_work_day.Name = "date_picker_work_day";
            this.date_picker_work_day.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.date_picker_work_day.RightToLeftLayout = true;
            this.date_picker_work_day.Size = new System.Drawing.Size(148, 22);
            this.date_picker_work_day.TabIndex = 25;
            this.date_picker_work_day.Value = new System.DateTime(2019, 6, 6, 0, 0, 0, 0);
            this.date_picker_work_day.ValueChanged += new System.EventHandler(this.workDay_ValueChanged);
            // 
            // lbl_work_day
            // 
            this.lbl_work_day.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_work_day.BackColor = System.Drawing.Color.White;
            this.lbl_work_day.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_work_day.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_work_day.Location = new System.Drawing.Point(785, 42);
            this.lbl_work_day.Name = "lbl_work_day";
            this.lbl_work_day.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_work_day.Size = new System.Drawing.Size(152, 30);
            this.lbl_work_day.TabIndex = 24;
            this.lbl_work_day.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_clock
            // 
            this.lbl_clock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_clock.BackColor = System.Drawing.Color.White;
            this.lbl_clock.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_clock.Location = new System.Drawing.Point(785, 10);
            this.lbl_clock.Name = "lbl_clock";
            this.lbl_clock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_clock.Size = new System.Drawing.Size(152, 30);
            this.lbl_clock.TabIndex = 24;
            this.lbl_clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_right_border
            // 
            this.pnl_right_border.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_right_border.Location = new System.Drawing.Point(1000, 0);
            this.pnl_right_border.Name = "pnl_right_border";
            this.pnl_right_border.Size = new System.Drawing.Size(2, 784);
            this.pnl_right_border.TabIndex = 14;
            // 
            // dgvDailySalesProperties
            // 
            this.dgvDailySalesProperties.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDailySalesProperties.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delete});
            this.dgvDailySalesProperties.Name = "dgvDailySalesProperties";
            this.dgvDailySalesProperties.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvDailySalesProperties.Size = new System.Drawing.Size(101, 26);
            this.dgvDailySalesProperties.Text = "خيارات";
            // 
            // delete
            // 
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(100, 22);
            this.delete.Text = "حذف";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // UC_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_sales);
            this.Controls.Add(this.pnl_control_btns);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_right_border);
            this.Name = "UC_Sales";
            this.Size = new System.Drawing.Size(1002, 784);
            this.Load += new System.EventHandler(this.UC_DailySales_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sales)).EndInit();
            this.pnl_control_btns.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.dgvDailySalesProperties.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_day_total;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_unit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox text_quantity;
        private System.Windows.Forms.ComboBox combo_product_name;
        private System.Windows.Forms.DataGridView dgv_sales;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel pnl_control_btns;
        private System.Windows.Forms.Panel pnl_right_border;
        private System.Windows.Forms.ContextMenuStrip dgvDailySalesProperties;
        private System.Windows.Forms.ToolStripMenuItem delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_clock;
        private System.Windows.Forms.DateTimePicker date_picker_work_day;
        private System.Windows.Forms.Label lbl_work_day;
        private System.Windows.Forms.Button gbtn_view_products;
        private System.Windows.Forms.ComboBox combo_category_name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_product_id;
        private System.Windows.Forms.Label lbl_category_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn process_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_of_sale;
    }
}
