namespace UserControls
{
    partial class UC_UpdateUnitsContentsInfo
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
            this.dgv_info = new System.Windows.Forms.DataGridView();
            this.info_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.base_unit_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.base_unit_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub_unit_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub_unit_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub_unit_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub_unit_is_purchaseable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combo_products_names = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.combo_base_units = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.text_contents_amount = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.combo_categories = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.combo_sub_units = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_info_add = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_info_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_info.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_info.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_info.EnableHeadersVisualStyles = false;
            this.dgv_info.Location = new System.Drawing.Point(0, 245);
            this.dgv_info.Name = "dgv_info";
            this.dgv_info.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_info.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_info.RowHeadersWidth = 30;
            this.dgv_info.RowTemplate.Height = 30;
            this.dgv_info.Size = new System.Drawing.Size(493, 158);
            this.dgv_info.TabIndex = 30;
            this.dgv_info.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_info_RowHeaderMouseDoubleClick);
            this.dgv_info.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_info_KeyDown);
            this.dgv_info.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgv_info_KeyPress);
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
            // combo_products_names
            // 
            this.combo_products_names.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_products_names.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_products_names.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_products_names.FormattingEnabled = true;
            this.combo_products_names.Location = new System.Drawing.Point(10, 61);
            this.combo_products_names.Name = "combo_products_names";
            this.combo_products_names.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_products_names.Size = new System.Drawing.Size(252, 32);
            this.combo_products_names.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(10, 40);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label17.Size = new System.Drawing.Size(252, 18);
            this.label17.TabIndex = 19;
            this.label17.Text = "اسم الصنف";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(325, 103);
            this.label18.Name = "label18";
            this.label18.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label18.Size = new System.Drawing.Size(128, 15);
            this.label18.TabIndex = 20;
            this.label18.Text = "الوحدة الاساسية";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.Transparent;
            this.btn_save.Location = new System.Drawing.Point(186, 193);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(90, 40);
            this.btn_save.TabIndex = 23;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // combo_base_units
            // 
            this.combo_base_units.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_base_units.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_base_units.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_base_units.FormattingEnabled = true;
            this.combo_base_units.Location = new System.Drawing.Point(325, 121);
            this.combo_base_units.Name = "combo_base_units";
            this.combo_base_units.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_base_units.Size = new System.Drawing.Size(125, 32);
            this.combo_base_units.TabIndex = 27;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(69, 101);
            this.label21.Name = "label21";
            this.label21.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label21.Size = new System.Drawing.Size(81, 17);
            this.label21.TabIndex = 21;
            this.label21.Text = "العدد";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_contents_amount
            // 
            this.text_contents_amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.text_contents_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_contents_amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_contents_amount.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_contents_amount.Location = new System.Drawing.Point(66, 119);
            this.text_contents_amount.Name = "text_contents_amount";
            this.text_contents_amount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_contents_amount.Size = new System.Drawing.Size(81, 32);
            this.text_contents_amount.TabIndex = 29;
            this.text_contents_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(268, 40);
            this.label20.Name = "label20";
            this.label20.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label20.Size = new System.Drawing.Size(216, 18);
            this.label20.TabIndex = 18;
            this.label20.Text = "القسم";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.Black;
            this.btn_edit.Location = new System.Drawing.Point(90, 193);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(90, 40);
            this.btn_edit.TabIndex = 24;
            this.btn_edit.Text = "تعديل";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // combo_categories
            // 
            this.combo_categories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_categories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_categories.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_categories.FormattingEnabled = true;
            this.combo_categories.Location = new System.Drawing.Point(268, 61);
            this.combo_categories.Name = "combo_categories";
            this.combo_categories.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_categories.Size = new System.Drawing.Size(216, 32);
            this.combo_categories.TabIndex = 14;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(175, 103);
            this.label19.Name = "label19";
            this.label19.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label19.Size = new System.Drawing.Size(128, 15);
            this.label19.TabIndex = 22;
            this.label19.Text = "الوحدة الفرعية";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // combo_sub_units
            // 
            this.combo_sub_units.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_sub_units.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_sub_units.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_sub_units.FormattingEnabled = true;
            this.combo_sub_units.Location = new System.Drawing.Point(175, 121);
            this.combo_sub_units.Name = "combo_sub_units";
            this.combo_sub_units.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_sub_units.Size = new System.Drawing.Size(125, 32);
            this.combo_sub_units.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_info_add);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.text_contents_amount);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.combo_sub_units);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.combo_base_units);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.combo_products_names);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_info_id);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.combo_categories);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 245);
            this.panel1.TabIndex = 31;
            // 
            // lbl_info_add
            // 
            this.lbl_info_add.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lbl_info_add.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_info_add.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_info_add.Location = new System.Drawing.Point(0, 0);
            this.lbl_info_add.Name = "lbl_info_add";
            this.lbl_info_add.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_info_add.Size = new System.Drawing.Size(493, 40);
            this.lbl_info_add.TabIndex = 30;
            this.lbl_info_add.Text = "اضافة وحدة الى صنف";
            this.lbl_info_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "نعم",
            "لا"});
            this.comboBox1.Location = new System.Drawing.Point(325, 201);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(156, 32);
            this.comboBox1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 166);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(159, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "الوحدة الفرعية قابلة للشراء ؟";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_info_id
            // 
            this.lbl_info_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_info_id.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_info_id.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info_id.Location = new System.Drawing.Point(20, 111);
            this.lbl_info_id.Name = "lbl_info_id";
            this.lbl_info_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_info_id.Size = new System.Drawing.Size(43, 32);
            this.lbl_info_id.TabIndex = 21;
            this.lbl_info_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_UpdateUnitsContentsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.dgv_info);
            this.Controls.Add(this.panel1);
            this.Name = "UC_UpdateUnitsContentsInfo";
            this.Size = new System.Drawing.Size(493, 403);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox text_contents_amount;
        private System.Windows.Forms.ComboBox combo_sub_units;
        private System.Windows.Forms.ComboBox combo_base_units;
        private System.Windows.Forms.ComboBox combo_products_names;
        private System.Windows.Forms.ComboBox combo_categories;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_info_id;
        private System.Windows.Forms.Label lbl_info_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn info_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn base_unit_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn base_unit_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub_unit_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub_unit_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub_unit_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub_unit_is_purchaseable;
        private System.Windows.Forms.DataGridView dgv_info;
    }
}
