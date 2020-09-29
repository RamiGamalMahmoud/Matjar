namespace Matjar
{
    partial class AddUpdateProductForm
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
            this.uC_Add_Product_Full1 = new UserControls.UC_Add_Product_Full();
            this.SuspendLayout();
            // 
            // uC_Add_Product_Full1
            // 
            this.uC_Add_Product_Full1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Add_Product_Full1.Location = new System.Drawing.Point(0, 0);
            this.uC_Add_Product_Full1.Name = "uC_Add_Product_Full1";
            this.uC_Add_Product_Full1.Size = new System.Drawing.Size(580, 711);
            this.uC_Add_Product_Full1.TabIndex = 0;
            // 
            // AddUpdateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 711);
            this.Controls.Add(this.uC_Add_Product_Full1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUpdateProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUpdateProductForm";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.UC_Add_Product_Full uC_Add_Product_Full1;
    }
}