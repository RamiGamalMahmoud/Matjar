namespace UserControls
{
    partial class UC_NewCategory
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_new_category = new System.Windows.Forms.TextBox();
            this.combo_existed_categories = new System.Windows.Forms.ComboBox();
            this.lbl_new_category = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.Color.Green;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.Transparent;
            this.btn_save.Location = new System.Drawing.Point(7, 130);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(90, 40);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(187, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "القسم الجديد";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 59);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(167, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "الاقسام الموجودة";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_new_category
            // 
            this.text_new_category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.text_new_category.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_new_category.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_new_category.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_new_category.Location = new System.Drawing.Point(7, 92);
            this.text_new_category.Name = "text_new_category";
            this.text_new_category.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_new_category.Size = new System.Drawing.Size(187, 32);
            this.text_new_category.TabIndex = 11;
            this.text_new_category.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // combo_existed_categories
            // 
            this.combo_existed_categories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_existed_categories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_existed_categories.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_existed_categories.FormattingEnabled = true;
            this.combo_existed_categories.Location = new System.Drawing.Point(200, 92);
            this.combo_existed_categories.Name = "combo_existed_categories";
            this.combo_existed_categories.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_existed_categories.Size = new System.Drawing.Size(167, 32);
            this.combo_existed_categories.TabIndex = 10;
            // 
            // lbl_new_category
            // 
            this.lbl_new_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_new_category.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_new_category.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_new_category.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_new_category.Location = new System.Drawing.Point(0, 0);
            this.lbl_new_category.Name = "lbl_new_category";
            this.lbl_new_category.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_new_category.Size = new System.Drawing.Size(374, 40);
            this.lbl_new_category.TabIndex = 15;
            this.lbl_new_category.Text = "اضافة قسم";
            this.lbl_new_category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_NewCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_new_category);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_new_category);
            this.Controls.Add(this.combo_existed_categories);
            this.Name = "UC_NewCategory";
            this.Size = new System.Drawing.Size(374, 174);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_new_category;
        private System.Windows.Forms.ComboBox combo_existed_categories;
        private System.Windows.Forms.Label lbl_new_category;
    }
}
