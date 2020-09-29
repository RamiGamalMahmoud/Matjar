namespace UserControls
{
    partial class UC_NewProduct_Name
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
            this.btn_save = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.combo_existed_products_names = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.combo_categories = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.text_new_product_name = new System.Windows.Forms.TextBox();
            this.lbl_new_product_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.Transparent;
            this.btn_save.Location = new System.Drawing.Point(55, 123);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(90, 40);
            this.btn_save.TabIndex = 17;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(247, 106);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(125, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "الصنف الجديد";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // combo_existed_products_names
            // 
            this.combo_existed_products_names.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_existed_products_names.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_existed_products_names.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_existed_products_names.FormattingEnabled = true;
            this.combo_existed_products_names.Location = new System.Drawing.Point(3, 76);
            this.combo_existed_products_names.Name = "combo_existed_products_names";
            this.combo_existed_products_names.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_existed_products_names.Size = new System.Drawing.Size(231, 30);
            this.combo_existed_products_names.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 53);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(231, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "الاصناف الموجودة";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // combo_categories
            // 
            this.combo_categories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_categories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_categories.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_categories.FormattingEnabled = true;
            this.combo_categories.Location = new System.Drawing.Point(247, 76);
            this.combo_categories.Name = "combo_categories";
            this.combo_categories.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_categories.Size = new System.Drawing.Size(125, 30);
            this.combo_categories.TabIndex = 12;
            this.combo_categories.SelectedIndexChanged += new System.EventHandler(this.combo_categories_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(247, 52);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(125, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "القسم";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_new_product_name
            // 
            this.text_new_product_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.text_new_product_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_new_product_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_new_product_name.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_new_product_name.Location = new System.Drawing.Point(247, 131);
            this.text_new_product_name.Name = "text_new_product_name";
            this.text_new_product_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_new_product_name.Size = new System.Drawing.Size(125, 27);
            this.text_new_product_name.TabIndex = 13;
            this.text_new_product_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_new_product_name
            // 
            this.lbl_new_product_name.BackColor = System.Drawing.Color.Teal;
            this.lbl_new_product_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_new_product_name.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_new_product_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_new_product_name.Location = new System.Drawing.Point(0, 0);
            this.lbl_new_product_name.Name = "lbl_new_product_name";
            this.lbl_new_product_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_new_product_name.Size = new System.Drawing.Size(375, 40);
            this.lbl_new_product_name.TabIndex = 18;
            this.lbl_new_product_name.Text = "اضافة صنف";
            this.lbl_new_product_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_NewProduct_Name
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_new_product_name);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.combo_existed_products_names);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.combo_categories);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.text_new_product_name);
            this.Name = "UC_NewProduct_Name";
            this.Size = new System.Drawing.Size(375, 174);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combo_existed_products_names;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox combo_categories;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox text_new_product_name;
        private System.Windows.Forms.Label lbl_new_product_name;
    }
}
