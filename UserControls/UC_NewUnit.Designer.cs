namespace UserControls
{
    partial class UC_NewUnit
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
            this.label4 = new System.Windows.Forms.Label();
            this.combo_existed_units = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_new_unit_name = new System.Windows.Forms.TextBox();
            this.lbl_new_unit = new System.Windows.Forms.Label();
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
            this.btn_save.Location = new System.Drawing.Point(12, 122);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(90, 40);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 51);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(125, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "الوحدة الجديدة";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // combo_existed_units
            // 
            this.combo_existed_units.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_existed_units.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_existed_units.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_existed_units.FormattingEnabled = true;
            this.combo_existed_units.Location = new System.Drawing.Point(140, 84);
            this.combo_existed_units.Name = "combo_existed_units";
            this.combo_existed_units.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_existed_units.Size = new System.Drawing.Size(120, 32);
            this.combo_existed_units.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 51);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(120, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "الوحدات الموجودة";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_new_unit_name
            // 
            this.text_new_unit_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.text_new_unit_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_new_unit_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_new_unit_name.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_new_unit_name.Location = new System.Drawing.Point(12, 84);
            this.text_new_unit_name.Name = "text_new_unit_name";
            this.text_new_unit_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_new_unit_name.Size = new System.Drawing.Size(122, 32);
            this.text_new_unit_name.TabIndex = 11;
            this.text_new_unit_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_new_unit
            // 
            this.lbl_new_unit.BackColor = System.Drawing.Color.Chocolate;
            this.lbl_new_unit.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_new_unit.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_new_unit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_new_unit.Location = new System.Drawing.Point(0, 0);
            this.lbl_new_unit.Name = "lbl_new_unit";
            this.lbl_new_unit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_new_unit.Size = new System.Drawing.Size(270, 40);
            this.lbl_new_unit.TabIndex = 15;
            this.lbl_new_unit.Text = "اضافة وحدة";
            this.lbl_new_unit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_NewUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_new_unit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combo_existed_units);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_new_unit_name);
            this.Name = "UC_NewUnit";
            this.Size = new System.Drawing.Size(270, 174);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_existed_units;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_new_unit_name;
        private System.Windows.Forms.Label lbl_new_unit;


    }
}
