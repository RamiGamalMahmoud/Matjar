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
            this.LblDayTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblUnit = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextQuantity = new System.Windows.Forms.TextBox();
            this.ComboProductName = new System.Windows.Forms.ComboBox();
            this.DgvSales = new System.Windows.Forms.DataGridView();
            this.process_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_of_sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSave = new System.Windows.Forms.Button();
            this.pnl_control_btns = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblProductId = new System.Windows.Forms.Label();
            this.LblCategoryId = new System.Windows.Forms.Label();
            this.BtnViewProducts = new System.Windows.Forms.Button();
            this.ComboCategoryName = new System.Windows.Forms.ComboBox();
            this.DatePickerWork_day = new System.Windows.Forms.DateTimePicker();
            this.LblWorkDay = new System.Windows.Forms.Label();
            this.LblClock = new System.Windows.Forms.Label();
            this.pnl_right_border = new System.Windows.Forms.Panel();
            this.dgvDailySalesProperties = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSales)).BeginInit();
            this.pnl_control_btns.SuspendLayout();
            this.panel2.SuspendLayout();
            this.dgvDailySalesProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblDayTotal
            // 
            this.LblDayTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblDayTotal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDayTotal.Location = new System.Drawing.Point(899, 0);
            this.LblDayTotal.Name = "LblDayTotal";
            this.LblDayTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblDayTotal.Size = new System.Drawing.Size(101, 28);
            this.LblDayTotal.TabIndex = 3;
            this.LblDayTotal.Text = "0";
            this.LblDayTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(181, 9);
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
            this.label6.Location = new System.Drawing.Point(315, 9);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(60, 30);
            this.label6.TabIndex = 3;
            this.label6.Text = "الوحدة";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblUnit
            // 
            this.LblUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUnit.BackColor = System.Drawing.Color.White;
            this.LblUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblUnit.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            this.LblUnit.Location = new System.Drawing.Point(315, 48);
            this.LblUnit.Name = "LblUnit";
            this.LblUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblUnit.Size = new System.Drawing.Size(60, 32);
            this.LblUnit.TabIndex = 24;
            this.LblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(413, 13);
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
            this.label5.Location = new System.Drawing.Point(115, 9);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(60, 30);
            this.label5.TabIndex = 3;
            this.label5.Text = "إجمالي";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTotal
            // 
            this.LblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTotal.BackColor = System.Drawing.Color.White;
            this.LblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTotal.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            this.LblTotal.Location = new System.Drawing.Point(115, 48);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblTotal.Size = new System.Drawing.Size(60, 32);
            this.LblTotal.TabIndex = 23;
            this.LblTotal.Text = "0";
            this.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(249, 9);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(60, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "السعر";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPrice
            // 
            this.LblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPrice.BackColor = System.Drawing.Color.White;
            this.LblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblPrice.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            this.LblPrice.Location = new System.Drawing.Point(249, 48);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblPrice.Size = new System.Drawing.Size(60, 32);
            this.LblPrice.TabIndex = 11;
            this.LblPrice.Text = "0";
            this.LblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.LblDayTotal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 756);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 28);
            this.panel1.TabIndex = 8;
            // 
            // TextQuantity
            // 
            this.TextQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextQuantity.BackColor = System.Drawing.Color.White;
            this.TextQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextQuantity.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            this.TextQuantity.Location = new System.Drawing.Point(181, 48);
            this.TextQuantity.Name = "TextQuantity";
            this.TextQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextQuantity.Size = new System.Drawing.Size(60, 32);
            this.TextQuantity.TabIndex = 10;
            this.TextQuantity.Text = "0";
            this.TextQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextQuantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextQuantityMouseClick);
            this.TextQuantity.TextChanged += new System.EventHandler(this.TextQuantityTextChanged);
            this.TextQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextQuantityKeyDown);
            // 
            // ComboProductName
            // 
            this.ComboProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ComboProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboProductName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboProductName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboProductName.ForeColor = System.Drawing.Color.Black;
            this.ComboProductName.FormattingEnabled = true;
            this.ComboProductName.Location = new System.Drawing.Point(413, 45);
            this.ComboProductName.MaxDropDownItems = 20;
            this.ComboProductName.Name = "ComboProductName";
            this.ComboProductName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboProductName.Size = new System.Drawing.Size(243, 32);
            this.ComboProductName.TabIndex = 9;
            // 
            // DgvSales
            // 
            this.DgvSales.AllowUserToAddRows = false;
            this.DgvSales.AllowUserToDeleteRows = false;
            this.DgvSales.AllowUserToResizeColumns = false;
            this.DgvSales.AllowUserToResizeRows = false;
            this.DgvSales.BackgroundColor = System.Drawing.Color.White;
            this.DgvSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvSales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvSales.ColumnHeadersHeight = 50;
            this.DgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.DgvSales.DefaultCellStyle = dataGridViewCellStyle8;
            this.DgvSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvSales.EnableHeadersVisualStyles = false;
            this.DgvSales.Location = new System.Drawing.Point(0, 136);
            this.DgvSales.Name = "DgvSales";
            this.DgvSales.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DgvSales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvSales.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DgvSales.RowHeadersWidth = 30;
            this.DgvSales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvSales.RowTemplate.Height = 30;
            this.DgvSales.Size = new System.Drawing.Size(1000, 620);
            this.DgvSales.TabIndex = 7;
            this.DgvSales.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvSalesCellMouseClicked);
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
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.Transparent;
            this.BtnSave.Location = new System.Drawing.Point(45, 48);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(60, 32);
            this.BtnSave.TabIndex = 12;
            this.BtnSave.Text = "حفظ";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSaveClick);
            // 
            // pnl_control_btns
            // 
            this.pnl_control_btns.Controls.Add(this.panel2);
            this.pnl_control_btns.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_control_btns.Location = new System.Drawing.Point(0, 0);
            this.pnl_control_btns.Name = "pnl_control_btns";
            this.pnl_control_btns.Size = new System.Drawing.Size(1000, 136);
            this.pnl_control_btns.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.LblProductId);
            this.panel2.Controls.Add(this.LblCategoryId);
            this.panel2.Controls.Add(this.BtnViewProducts);
            this.panel2.Controls.Add(this.ComboCategoryName);
            this.panel2.Controls.Add(this.BtnSave);
            this.panel2.Controls.Add(this.DatePickerWork_day);
            this.panel2.Controls.Add(this.ComboProductName);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.TextQuantity);
            this.panel2.Controls.Add(this.LblWorkDay);
            this.panel2.Controls.Add(this.LblPrice);
            this.panel2.Controls.Add(this.LblClock);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.LblUnit);
            this.panel2.Controls.Add(this.LblTotal);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 130);
            this.panel2.TabIndex = 15;
            // 
            // LblProductId
            // 
            this.LblProductId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblProductId.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProductId.Location = new System.Drawing.Point(662, 46);
            this.LblProductId.Name = "LblProductId";
            this.LblProductId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblProductId.Size = new System.Drawing.Size(60, 32);
            this.LblProductId.TabIndex = 28;
            this.LblProductId.Text = "id";
            this.LblProductId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblCategoryId
            // 
            this.LblCategoryId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblCategoryId.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategoryId.Location = new System.Drawing.Point(662, 9);
            this.LblCategoryId.Name = "LblCategoryId";
            this.LblCategoryId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblCategoryId.Size = new System.Drawing.Size(60, 32);
            this.LblCategoryId.TabIndex = 28;
            this.LblCategoryId.Text = "id";
            this.LblCategoryId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnViewProducts
            // 
            this.BtnViewProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnViewProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            this.BtnViewProducts.FlatAppearance.BorderSize = 0;
            this.BtnViewProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnViewProducts.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.BtnViewProducts.ForeColor = System.Drawing.Color.White;
            this.BtnViewProducts.Location = new System.Drawing.Point(413, 81);
            this.BtnViewProducts.Name = "BtnViewProducts";
            this.BtnViewProducts.Size = new System.Drawing.Size(243, 33);
            this.BtnViewProducts.TabIndex = 26;
            this.BtnViewProducts.Text = "عرض المنتجات";
            this.BtnViewProducts.UseVisualStyleBackColor = false;
            this.BtnViewProducts.Click += new System.EventHandler(this.GbtnViewProductsClick);
            // 
            // ComboCategoryName
            // 
            this.ComboCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboCategoryName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ComboCategoryName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCategoryName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboCategoryName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboCategoryName.ForeColor = System.Drawing.Color.Black;
            this.ComboCategoryName.FormattingEnabled = true;
            this.ComboCategoryName.Location = new System.Drawing.Point(413, 9);
            this.ComboCategoryName.MaxDropDownItems = 20;
            this.ComboCategoryName.Name = "ComboCategoryName";
            this.ComboCategoryName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboCategoryName.Size = new System.Drawing.Size(243, 32);
            this.ComboCategoryName.TabIndex = 27;
            // 
            // DatePickerWork_day
            // 
            this.DatePickerWork_day.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DatePickerWork_day.CalendarFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePickerWork_day.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DatePickerWork_day.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DatePickerWork_day.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePickerWork_day.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerWork_day.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DatePickerWork_day.Location = new System.Drawing.Point(760, 85);
            this.DatePickerWork_day.Name = "DatePickerWork_day";
            this.DatePickerWork_day.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatePickerWork_day.RightToLeftLayout = true;
            this.DatePickerWork_day.Size = new System.Drawing.Size(194, 29);
            this.DatePickerWork_day.TabIndex = 25;
            this.DatePickerWork_day.Value = new System.DateTime(2019, 6, 6, 0, 0, 0, 0);
            this.DatePickerWork_day.ValueChanged += new System.EventHandler(this.WorkDayValueChanged);
            // 
            // LblWorkDay
            // 
            this.LblWorkDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblWorkDay.BackColor = System.Drawing.Color.White;
            this.LblWorkDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblWorkDay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWorkDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblWorkDay.Location = new System.Drawing.Point(760, 48);
            this.LblWorkDay.Name = "LblWorkDay";
            this.LblWorkDay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblWorkDay.Size = new System.Drawing.Size(192, 30);
            this.LblWorkDay.TabIndex = 24;
            this.LblWorkDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblClock
            // 
            this.LblClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblClock.BackColor = System.Drawing.Color.White;
            this.LblClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblClock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblClock.Location = new System.Drawing.Point(760, 11);
            this.LblClock.Name = "LblClock";
            this.LblClock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblClock.Size = new System.Drawing.Size(192, 30);
            this.LblClock.TabIndex = 24;
            this.LblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.delete.Click += new System.EventHandler(this.DeleteClicked);
            // 
            // UC_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DgvSales);
            this.Controls.Add(this.pnl_control_btns);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_right_border);
            this.Name = "UC_Sales";
            this.Size = new System.Drawing.Size(1002, 784);
            this.Load += new System.EventHandler(this.UC_DailySales_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSales)).EndInit();
            this.pnl_control_btns.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.dgvDailySalesProperties.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblDayTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblUnit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TextQuantity;
        private System.Windows.Forms.ComboBox ComboProductName;
        private System.Windows.Forms.DataGridView DgvSales;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Panel pnl_control_btns;
        private System.Windows.Forms.Panel pnl_right_border;
        private System.Windows.Forms.ContextMenuStrip dgvDailySalesProperties;
        private System.Windows.Forms.ToolStripMenuItem delete;
        private System.Windows.Forms.Label LblClock;
        private System.Windows.Forms.DateTimePicker DatePickerWork_day;
        private System.Windows.Forms.Label LblWorkDay;
        private System.Windows.Forms.Button BtnViewProducts;
        private System.Windows.Forms.ComboBox ComboCategoryName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblProductId;
        private System.Windows.Forms.Label LblCategoryId;
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
