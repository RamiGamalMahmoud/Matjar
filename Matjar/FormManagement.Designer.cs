namespace Matjar
{
    partial class FormManagement
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
            this.pnl_container = new System.Windows.Forms.Panel();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.uC_UpdateUnitsContentsInfo1 = new UserControls.UC_UpdateUnitsContentsInfo();
            this.uC_NewProduct1 = new UserControls.UC_NewProduct();
            this.uC_NewProduct_Name1 = new UserControls.UC_NewProduct_Name();
            this.uC_NewUnit1 = new UserControls.UC_NewUnit();
            this.uC_NewCategory1 = new UserControls.UC_NewCategory();
            this.pnl_container.SuspendLayout();
            this.pnl_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_container
            // 
            this.pnl_container.Controls.Add(this.uC_UpdateUnitsContentsInfo1);
            this.pnl_container.Controls.Add(this.uC_NewProduct1);
            this.pnl_container.Controls.Add(this.pnl_top);
            this.pnl_container.Controls.Add(this.pnl_footer);
            this.pnl_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_container.Location = new System.Drawing.Point(0, 0);
            this.pnl_container.Name = "pnl_container";
            this.pnl_container.Size = new System.Drawing.Size(1019, 613);
            this.pnl_container.TabIndex = 16;
            // 
            // pnl_top
            // 
            this.pnl_top.Controls.Add(this.uC_NewProduct_Name1);
            this.pnl_top.Controls.Add(this.uC_NewUnit1);
            this.pnl_top.Controls.Add(this.uC_NewCategory1);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(1019, 174);
            this.pnl_top.TabIndex = 0;
            // 
            // pnl_footer
            // 
            this.pnl_footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnl_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_footer.Location = new System.Drawing.Point(0, 583);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(1019, 30);
            this.pnl_footer.TabIndex = 4;
            // 
            // uC_UpdateUnitsContentsInfo1
            // 
            this.uC_UpdateUnitsContentsInfo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_UpdateUnitsContentsInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_UpdateUnitsContentsInfo1.Location = new System.Drawing.Point(0, 174);
            this.uC_UpdateUnitsContentsInfo1.Name = "uC_UpdateUnitsContentsInfo1";
            this.uC_UpdateUnitsContentsInfo1.Size = new System.Drawing.Size(645, 409);
            this.uC_UpdateUnitsContentsInfo1.TabIndex = 3;
            // 
            // uC_NewProduct1
            // 
            this.uC_NewProduct1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_NewProduct1.Dock = System.Windows.Forms.DockStyle.Right;
            this.uC_NewProduct1.Location = new System.Drawing.Point(645, 174);
            this.uC_NewProduct1.Name = "uC_NewProduct1";
            this.uC_NewProduct1.Size = new System.Drawing.Size(374, 409);
            this.uC_NewProduct1.TabIndex = 2;
            // 
            // uC_NewProduct_Name1
            // 
            this.uC_NewProduct_Name1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_NewProduct_Name1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_NewProduct_Name1.Location = new System.Drawing.Point(0, 0);
            this.uC_NewProduct_Name1.Name = "uC_NewProduct_Name1";
            this.uC_NewProduct_Name1.Size = new System.Drawing.Size(375, 174);
            this.uC_NewProduct_Name1.TabIndex = 2;
            // 
            // uC_NewUnit1
            // 
            this.uC_NewUnit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_NewUnit1.Dock = System.Windows.Forms.DockStyle.Right;
            this.uC_NewUnit1.Location = new System.Drawing.Point(375, 0);
            this.uC_NewUnit1.Name = "uC_NewUnit1";
            this.uC_NewUnit1.Size = new System.Drawing.Size(270, 174);
            this.uC_NewUnit1.TabIndex = 1;
            // 
            // uC_NewCategory1
            // 
            this.uC_NewCategory1.BackColor = System.Drawing.Color.White;
            this.uC_NewCategory1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_NewCategory1.Dock = System.Windows.Forms.DockStyle.Right;
            this.uC_NewCategory1.Location = new System.Drawing.Point(645, 0);
            this.uC_NewCategory1.Name = "uC_NewCategory1";
            this.uC_NewCategory1.Size = new System.Drawing.Size(374, 174);
            this.uC_NewCategory1.TabIndex = 0;
            // 
            // FormManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 613);
            this.Controls.Add(this.pnl_container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormManagement";
            this.Load += new System.EventHandler(this.FormManagement_Load);
            this.pnl_container.ResumeLayout(false);
            this.pnl_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_container;
        private System.Windows.Forms.Panel pnl_top;
        private UserControls.UC_UpdateUnitsContentsInfo uC_UpdateUnitsContentsInfo1;
        private UserControls.UC_NewProduct uC_NewProduct1;
        private UserControls.UC_NewProduct_Name uC_NewProduct_Name1;
        private UserControls.UC_NewUnit uC_NewUnit1;
        private UserControls.UC_NewCategory uC_NewCategory1;
        private System.Windows.Forms.Panel pnl_footer;

    }
}