namespace UserControls
{
    partial class UC_Purchases
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_controls = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.combo_monthes = new System.Windows.Forms.ComboBox();
            this.combo_years = new System.Windows.Forms.ComboBox();
            this.combo_category_name = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_unit_id = new System.Windows.Forms.Label();
            this.lbl_category_id = new System.Windows.Forms.Label();
            this.lbl_product_name_id = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_product_name = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_price = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.combo_unit_name = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_quantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_purchases = new System.Windows.Forms.Panel();
            this.dgv_purchases = new System.Windows.Forms.DataGridView();
            this.catogory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_controls.SuspendLayout();
            this.pnl_purchases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_purchases)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_controls
            // 
            this.pnl_controls.Controls.Add(this.dateTimePicker1);
            this.pnl_controls.Controls.Add(this.combo_monthes);
            this.pnl_controls.Controls.Add(this.combo_years);
            this.pnl_controls.Controls.Add(this.combo_category_name);
            this.pnl_controls.Controls.Add(this.btn_save);
            this.pnl_controls.Controls.Add(this.label1);
            this.pnl_controls.Controls.Add(this.lbl_unit_id);
            this.pnl_controls.Controls.Add(this.lbl_category_id);
            this.pnl_controls.Controls.Add(this.lbl_product_name_id);
            this.pnl_controls.Controls.Add(this.lbl_total);
            this.pnl_controls.Controls.Add(this.label2);
            this.pnl_controls.Controls.Add(this.combo_product_name);
            this.pnl_controls.Controls.Add(this.label3);
            this.pnl_controls.Controls.Add(this.text_price);
            this.pnl_controls.Controls.Add(this.label8);
            this.pnl_controls.Controls.Add(this.combo_unit_name);
            this.pnl_controls.Controls.Add(this.label4);
            this.pnl_controls.Controls.Add(this.text_quantity);
            this.pnl_controls.Controls.Add(this.label5);
            this.pnl_controls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_controls.Location = new System.Drawing.Point(0, 0);
            this.pnl_controls.Name = "pnl_controls";
            this.pnl_controls.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnl_controls.Size = new System.Drawing.Size(1005, 115);
            this.pnl_controls.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(70, 79);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(122, 20);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // combo_monthes
            // 
            this.combo_monthes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_monthes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_monthes.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_monthes.FormattingEnabled = true;
            this.combo_monthes.Location = new System.Drawing.Point(239, 72);
            this.combo_monthes.Name = "combo_monthes";
            this.combo_monthes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_monthes.Size = new System.Drawing.Size(100, 32);
            this.combo_monthes.TabIndex = 13;
            this.combo_monthes.SelectedIndexChanged += new System.EventHandler(this.combo_monthes_SelectedIndexChanged);
            // 
            // combo_years
            // 
            this.combo_years.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_years.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_years.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_years.FormattingEnabled = true;
            this.combo_years.Location = new System.Drawing.Point(345, 72);
            this.combo_years.Name = "combo_years";
            this.combo_years.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_years.Size = new System.Drawing.Size(100, 32);
            this.combo_years.TabIndex = 13;
            this.combo_years.SelectedIndexChanged += new System.EventHandler(this.combo_years_SelectedIndexChanged);
            // 
            // combo_category_name
            // 
            this.combo_category_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_category_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_category_name.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_category_name.FormattingEnabled = true;
            this.combo_category_name.Location = new System.Drawing.Point(779, 34);
            this.combo_category_name.Name = "combo_category_name";
            this.combo_category_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_category_name.Size = new System.Drawing.Size(200, 32);
            this.combo_category_name.TabIndex = 0;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.Transparent;
            this.btn_save.Location = new System.Drawing.Point(26, 35);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 30);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(467, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "الوحدة";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_unit_id
            // 
            this.lbl_unit_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_unit_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_unit_id.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_unit_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_unit_id.Location = new System.Drawing.Point(467, 72);
            this.lbl_unit_id.Name = "lbl_unit_id";
            this.lbl_unit_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_unit_id.Size = new System.Drawing.Size(104, 30);
            this.lbl_unit_id.TabIndex = 12;
            this.lbl_unit_id.Text = "0";
            this.lbl_unit_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_category_id
            // 
            this.lbl_category_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_category_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_category_id.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_category_id.Location = new System.Drawing.Point(886, 69);
            this.lbl_category_id.Name = "lbl_category_id";
            this.lbl_category_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_category_id.Size = new System.Drawing.Size(94, 30);
            this.lbl_category_id.TabIndex = 12;
            this.lbl_category_id.Text = "0";
            this.lbl_category_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_product_name_id
            // 
            this.lbl_product_name_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_product_name_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_product_name_id.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_name_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_product_name_id.Location = new System.Drawing.Point(679, 69);
            this.lbl_product_name_id.Name = "lbl_product_name_id";
            this.lbl_product_name_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_product_name_id.Size = new System.Drawing.Size(94, 30);
            this.lbl_product_name_id.TabIndex = 12;
            this.lbl_product_name_id.Text = "0";
            this.lbl_product_name_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_product_name_id.Click += new System.EventHandler(this.lbl_product_name_id_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_total.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.White;
            this.lbl_total.Location = new System.Drawing.Point(132, 35);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_total.Size = new System.Drawing.Size(100, 30);
            this.lbl_total.TabIndex = 12;
            this.lbl_total.Text = "0";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(573, 1);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(200, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "اسم الصنف";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // combo_product_name
            // 
            this.combo_product_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_product_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_product_name.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_product_name.FormattingEnabled = true;
            this.combo_product_name.Location = new System.Drawing.Point(573, 34);
            this.combo_product_name.Name = "combo_product_name";
            this.combo_product_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_product_name.Size = new System.Drawing.Size(200, 32);
            this.combo_product_name.TabIndex = 1;
            this.combo_product_name.SelectedIndexChanged += new System.EventHandler(this.combo_product_name_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(345, 2);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(100, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "الكمية";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_price
            // 
            this.text_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.text_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_price.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_price.Location = new System.Drawing.Point(238, 35);
            this.text_price.Name = "text_price";
            this.text_price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_price.Size = new System.Drawing.Size(100, 32);
            this.text_price.TabIndex = 4;
            this.text_price.Text = "0";
            this.text_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_price.MouseClick += new System.Windows.Forms.MouseEventHandler(this.text_quantity_MouseClick);
            this.text_price.TextChanged += new System.EventHandler(this.calcTotal);
            this.text_price.Enter += new System.EventHandler(this.text_quantity_Enter);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(779, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(200, 30);
            this.label8.TabIndex = 4;
            this.label8.Text = "القسم";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // combo_unit_name
            // 
            this.combo_unit_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_unit_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_unit_name.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_unit_name.FormattingEnabled = true;
            this.combo_unit_name.Location = new System.Drawing.Point(467, 34);
            this.combo_unit_name.Name = "combo_unit_name";
            this.combo_unit_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_unit_name.Size = new System.Drawing.Size(100, 32);
            this.combo_unit_name.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(239, 2);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(100, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "السعر";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_quantity
            // 
            this.text_quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.text_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_quantity.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_quantity.Location = new System.Drawing.Point(345, 35);
            this.text_quantity.Name = "text_quantity";
            this.text_quantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_quantity.Size = new System.Drawing.Size(100, 32);
            this.text_quantity.TabIndex = 3;
            this.text_quantity.Text = "0";
            this.text_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_quantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.text_quantity_MouseClick);
            this.text_quantity.TextChanged += new System.EventHandler(this.calcTotal);
            this.text_quantity.Enter += new System.EventHandler(this.text_quantity_Enter);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(131, 2);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(100, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "اجمالي";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_purchases
            // 
            this.pnl_purchases.Controls.Add(this.dgv_purchases);
            this.pnl_purchases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_purchases.Location = new System.Drawing.Point(0, 115);
            this.pnl_purchases.Name = "pnl_purchases";
            this.pnl_purchases.Size = new System.Drawing.Size(1005, 641);
            this.pnl_purchases.TabIndex = 1;
            // 
            // dgv_purchases
            // 
            this.dgv_purchases.AllowUserToAddRows = false;
            this.dgv_purchases.AllowUserToDeleteRows = false;
            this.dgv_purchases.AllowUserToResizeColumns = false;
            this.dgv_purchases.AllowUserToResizeRows = false;
            this.dgv_purchases.BackgroundColor = System.Drawing.Color.White;
            this.dgv_purchases.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_purchases.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_purchases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_purchases.ColumnHeadersHeight = 40;
            this.dgv_purchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_purchases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.catogory,
            this.Column1,
            this.Column2,
            this.unit_price,
            this.amount,
            this.total,
            this.purchase_date});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_purchases.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_purchases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_purchases.EnableHeadersVisualStyles = false;
            this.dgv_purchases.Location = new System.Drawing.Point(0, 0);
            this.dgv_purchases.Name = "dgv_purchases";
            this.dgv_purchases.ReadOnly = true;
            this.dgv_purchases.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_purchases.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_purchases.RowHeadersWidth = 40;
            this.dgv_purchases.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_purchases.RowTemplate.Height = 30;
            this.dgv_purchases.RowTemplate.ReadOnly = true;
            this.dgv_purchases.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_purchases.Size = new System.Drawing.Size(1005, 641);
            this.dgv_purchases.TabIndex = 0;
            this.dgv_purchases.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_purchases_CellDoubleClick);
            // 
            // catogory
            // 
            this.catogory.DataPropertyName = "category";
            this.catogory.HeaderText = "القسم";
            this.catogory.Name = "catogory";
            this.catogory.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "product_name";
            this.Column1.HeaderText = "اسم الصنف";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "unit";
            this.Column2.HeaderText = "الوحدة";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // unit_price
            // 
            this.unit_price.DataPropertyName = "unit_price";
            this.unit_price.HeaderText = "سعر الوحدة";
            this.unit_price.Name = "unit_price";
            this.unit_price.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.DataPropertyName = "amount";
            this.amount.HeaderText = "الكمية";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "الاجمالي";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // purchase_date
            // 
            this.purchase_date.DataPropertyName = "purchase_date";
            this.purchase_date.HeaderText = "التاريخ";
            this.purchase_date.Name = "purchase_date";
            this.purchase_date.ReadOnly = true;
            // 
            // UC_Purchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_purchases);
            this.Controls.Add(this.pnl_controls);
            this.Name = "UC_Purchases";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1005, 756);
            this.pnl_controls.ResumeLayout(false);
            this.pnl_controls.PerformLayout();
            this.pnl_purchases.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_purchases)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_controls;
        private System.Windows.Forms.ComboBox combo_product_name;
        private System.Windows.Forms.ComboBox combo_category_name;
        private System.Windows.Forms.Panel pnl_purchases;
        private System.Windows.Forms.DataGridView dgv_purchases;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combo_unit_name;
        private System.Windows.Forms.TextBox text_price;
        private System.Windows.Forms.TextBox text_quantity;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridViewTextBoxColumn catogory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_date;
        private System.Windows.Forms.ComboBox combo_monthes;
        private System.Windows.Forms.ComboBox combo_years;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_unit_id;
        private System.Windows.Forms.Label lbl_category_id;
        private System.Windows.Forms.Label lbl_product_name_id;
    }
}
