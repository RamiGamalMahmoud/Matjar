namespace UserControls
{
    partial class UC_NewProduct
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
            this.label11 = new System.Windows.Forms.Label();
            this.combo_units = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.combo_products_names = new System.Windows.Forms.ComboBox();
            this.combo_categories_names = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.text_purchasing_price = new System.Windows.Forms.TextBox();
            this.text_selling_price = new System.Windows.Forms.TextBox();
            this.text_profit_margin = new System.Windows.Forms.TextBox();
            this.text_amount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_new_product = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.Color.Teal;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.Transparent;
            this.btn_save.Location = new System.Drawing.Point(14, 259);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(81, 40);
            this.btn_save.TabIndex = 21;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(236, 40);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(125, 30);
            this.label11.TabIndex = 17;
            this.label11.Text = "القسم";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // combo_units
            // 
            this.combo_units.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_units.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_units.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_units.FormattingEnabled = true;
            this.combo_units.Location = new System.Drawing.Point(236, 143);
            this.combo_units.Name = "combo_units";
            this.combo_units.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_units.Size = new System.Drawing.Size(122, 32);
            this.combo_units.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(236, 110);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label14.Size = new System.Drawing.Size(122, 30);
            this.label14.TabIndex = 18;
            this.label14.Text = "الوحدة";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // combo_products_names
            // 
            this.combo_products_names.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_products_names.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_products_names.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_products_names.FormattingEnabled = true;
            this.combo_products_names.Location = new System.Drawing.Point(10, 73);
            this.combo_products_names.Name = "combo_products_names";
            this.combo_products_names.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_products_names.Size = new System.Drawing.Size(220, 30);
            this.combo_products_names.TabIndex = 15;
            // 
            // combo_categories_names
            // 
            this.combo_categories_names.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_categories_names.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_categories_names.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_categories_names.FormattingEnabled = true;
            this.combo_categories_names.Location = new System.Drawing.Point(236, 73);
            this.combo_categories_names.Name = "combo_categories_names";
            this.combo_categories_names.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_categories_names.Size = new System.Drawing.Size(125, 32);
            this.combo_categories_names.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 40);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(220, 30);
            this.label12.TabIndex = 20;
            this.label12.Text = "اسم الصنف";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_purchasing_price
            // 
            this.text_purchasing_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.text_purchasing_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_purchasing_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_purchasing_price.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_purchasing_price.Location = new System.Drawing.Point(187, 221);
            this.text_purchasing_price.Name = "text_purchasing_price";
            this.text_purchasing_price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_purchasing_price.Size = new System.Drawing.Size(81, 32);
            this.text_purchasing_price.TabIndex = 22;
            this.text_purchasing_price.Text = "0.0";
            this.text_purchasing_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_selling_price
            // 
            this.text_selling_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.text_selling_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_selling_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_selling_price.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_selling_price.Location = new System.Drawing.Point(101, 221);
            this.text_selling_price.Name = "text_selling_price";
            this.text_selling_price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_selling_price.Size = new System.Drawing.Size(81, 32);
            this.text_selling_price.TabIndex = 22;
            this.text_selling_price.Text = "0.0";
            this.text_selling_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_profit_margin
            // 
            this.text_profit_margin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.text_profit_margin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_profit_margin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_profit_margin.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_profit_margin.Location = new System.Drawing.Point(14, 221);
            this.text_profit_margin.Name = "text_profit_margin";
            this.text_profit_margin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_profit_margin.Size = new System.Drawing.Size(81, 32);
            this.text_profit_margin.TabIndex = 22;
            this.text_profit_margin.Text = "0.0";
            this.text_profit_margin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_amount
            // 
            this.text_amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.text_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_amount.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_amount.Location = new System.Drawing.Point(274, 221);
            this.text_amount.Name = "text_amount";
            this.text_amount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_amount.Size = new System.Drawing.Size(81, 32);
            this.text_amount.TabIndex = 22;
            this.text_amount.Text = "0.0";
            this.text_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 188);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(84, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "سعر التكفقة";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 188);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(84, 30);
            this.label2.TabIndex = 18;
            this.label2.Text = "سعر البيع";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 188);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(84, 30);
            this.label3.TabIndex = 18;
            this.label3.Text = "هامش الربح";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(271, 188);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(84, 30);
            this.label4.TabIndex = 18;
            this.label4.Text = "الكمية";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_new_product
            // 
            this.lbl_new_product.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lbl_new_product.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_new_product.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_new_product.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_new_product.Location = new System.Drawing.Point(0, 0);
            this.lbl_new_product.Name = "lbl_new_product";
            this.lbl_new_product.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_new_product.Size = new System.Drawing.Size(372, 40);
            this.lbl_new_product.TabIndex = 23;
            this.lbl_new_product.Text = "اضافة وحدة الى صنف";
            this.lbl_new_product.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_NewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_new_product);
            this.Controls.Add(this.text_amount);
            this.Controls.Add(this.text_profit_margin);
            this.Controls.Add(this.text_selling_price);
            this.Controls.Add(this.text_purchasing_price);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.combo_units);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.combo_products_names);
            this.Controls.Add(this.combo_categories_names);
            this.Controls.Add(this.label12);
            this.Name = "UC_NewProduct";
            this.Size = new System.Drawing.Size(372, 309);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox combo_units;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox combo_products_names;
        private System.Windows.Forms.ComboBox combo_categories_names;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox text_purchasing_price;
        private System.Windows.Forms.TextBox text_selling_price;
        private System.Windows.Forms.TextBox text_profit_margin;
        private System.Windows.Forms.TextBox text_amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_new_product;

    }
}
