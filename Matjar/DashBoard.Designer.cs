namespace Matjar
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.pnl_controls_home = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_new_product = new System.Windows.Forms.Button();
            this.btn_daly_sales = new System.Windows.Forms.Button();
            this.btn_statistics = new System.Windows.Forms.Button();
            this.btn_purchases = new System.Windows.Forms.Button();
            this.btn_goods = new System.Windows.Forms.Button();
            this.storeUC1 = new UserControls.StoreUC();
            this.uC_Purchases1 = new UserControls.UC_Purchases();
            this.uC_Sales1 = new UserControls.UC_Sales();
            this.pnl_controls_home.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_controls_home
            // 
            this.pnl_controls_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            this.pnl_controls_home.Controls.Add(this.label5);
            this.pnl_controls_home.Controls.Add(this.btn_new_product);
            this.pnl_controls_home.Controls.Add(this.btn_daly_sales);
            this.pnl_controls_home.Controls.Add(this.btn_statistics);
            this.pnl_controls_home.Controls.Add(this.btn_purchases);
            this.pnl_controls_home.Controls.Add(this.btn_goods);
            this.pnl_controls_home.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_controls_home.Location = new System.Drawing.Point(984, 0);
            this.pnl_controls_home.Name = "pnl_controls_home";
            this.pnl_controls_home.Size = new System.Drawing.Size(200, 758);
            this.pnl_controls_home.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(200, 57);
            this.label5.TabIndex = 11;
            this.label5.Text = "المتجر";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_new_product
            // 
            this.btn_new_product.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_new_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            this.btn_new_product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new_product.FlatAppearance.BorderSize = 0;
            this.btn_new_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new_product.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_product.ForeColor = System.Drawing.Color.White;
            this.btn_new_product.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_new_product.Location = new System.Drawing.Point(6, 195);
            this.btn_new_product.Name = "btn_new_product";
            this.btn_new_product.Size = new System.Drawing.Size(187, 40);
            this.btn_new_product.TabIndex = 22;
            this.btn_new_product.Text = "ادارة المنتجات";
            this.btn_new_product.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_new_product.UseVisualStyleBackColor = false;
            this.btn_new_product.Click += new System.EventHandler(this.btn_new_product_Click);
            // 
            // btn_daly_sales
            // 
            this.btn_daly_sales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_daly_sales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            this.btn_daly_sales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_daly_sales.FlatAppearance.BorderSize = 0;
            this.btn_daly_sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_daly_sales.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_daly_sales.ForeColor = System.Drawing.Color.White;
            this.btn_daly_sales.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_daly_sales.Location = new System.Drawing.Point(6, 60);
            this.btn_daly_sales.Name = "btn_daly_sales";
            this.btn_daly_sales.Size = new System.Drawing.Size(187, 40);
            this.btn_daly_sales.TabIndex = 23;
            this.btn_daly_sales.Text = "مبيعات يويمية";
            this.btn_daly_sales.UseVisualStyleBackColor = false;
            this.btn_daly_sales.Click += new System.EventHandler(this.btn_daly_sales_Click);
            // 
            // btn_statistics
            // 
            this.btn_statistics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_statistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            this.btn_statistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_statistics.FlatAppearance.BorderSize = 0;
            this.btn_statistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_statistics.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_statistics.ForeColor = System.Drawing.Color.White;
            this.btn_statistics.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_statistics.Location = new System.Drawing.Point(6, 149);
            this.btn_statistics.Name = "btn_statistics";
            this.btn_statistics.Size = new System.Drawing.Size(187, 40);
            this.btn_statistics.TabIndex = 22;
            this.btn_statistics.Text = "احصاءات";
            this.btn_statistics.UseVisualStyleBackColor = false;
            this.btn_statistics.Click += new System.EventHandler(this.btn_statistics_Click);
            // 
            // btn_purchases
            // 
            this.btn_purchases.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_purchases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            this.btn_purchases.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_purchases.FlatAppearance.BorderSize = 0;
            this.btn_purchases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_purchases.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_purchases.ForeColor = System.Drawing.Color.White;
            this.btn_purchases.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_purchases.Location = new System.Drawing.Point(6, 106);
            this.btn_purchases.Name = "btn_purchases";
            this.btn_purchases.Size = new System.Drawing.Size(187, 40);
            this.btn_purchases.TabIndex = 22;
            this.btn_purchases.Text = "مشتروات";
            this.btn_purchases.UseVisualStyleBackColor = false;
            this.btn_purchases.Click += new System.EventHandler(this.btn_purchases_Click);
            // 
            // btn_goods
            // 
            this.btn_goods.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_goods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            this.btn_goods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_goods.FlatAppearance.BorderSize = 0;
            this.btn_goods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_goods.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_goods.ForeColor = System.Drawing.Color.White;
            this.btn_goods.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_goods.Location = new System.Drawing.Point(6, 241);
            this.btn_goods.Name = "btn_goods";
            this.btn_goods.Size = new System.Drawing.Size(187, 40);
            this.btn_goods.TabIndex = 22;
            this.btn_goods.Tag = "";
            this.btn_goods.Text = "كل الاصناف";
            this.btn_goods.UseVisualStyleBackColor = false;
            this.btn_goods.Click += new System.EventHandler(this.btn_goods_Click);
            // 
            // storeUC1
            // 
            this.storeUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storeUC1.Location = new System.Drawing.Point(0, 0);
            this.storeUC1.Name = "storeUC1";
            this.storeUC1.Size = new System.Drawing.Size(984, 758);
            this.storeUC1.TabIndex = 3;
            // 
            // uC_Purchases1
            // 
            this.uC_Purchases1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Purchases1.Location = new System.Drawing.Point(0, 0);
            this.uC_Purchases1.Name = "uC_Purchases1";
            this.uC_Purchases1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uC_Purchases1.Size = new System.Drawing.Size(984, 758);
            this.uC_Purchases1.TabIndex = 2;
            // 
            // uC_Sales1
            // 
            this.uC_Sales1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Sales1.LastSerial = 0;
            this.uC_Sales1.Location = new System.Drawing.Point(0, 0);
            this.uC_Sales1.Name = "uC_Sales1";
            this.uC_Sales1.NextProcessId = null;
            this.uC_Sales1.Size = new System.Drawing.Size(984, 758);
            this.uC_Sales1.TabIndex = 1;
            this.uC_Sales1.WorkDay = null;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 758);
            this.Controls.Add(this.storeUC1);
            this.Controls.Add(this.uC_Purchases1);
            this.Controls.Add(this.uC_Sales1);
            this.Controls.Add(this.pnl_controls_home);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matjar 1.0.2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.pnl_controls_home.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_controls_home;
        public System.Windows.Forms.Button btn_new_product;
        public System.Windows.Forms.Button btn_purchases;
        public System.Windows.Forms.Button btn_goods;
        public System.Windows.Forms.Button btn_daly_sales;
        public System.Windows.Forms.Button btn_statistics;
        private System.Windows.Forms.Label label5;
        private UserControls.UC_Sales uC_Sales1;
        private UserControls.UC_Purchases uC_Purchases1;
        private UserControls.StoreUC storeUC1;
    }
}