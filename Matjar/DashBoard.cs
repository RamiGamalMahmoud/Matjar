using System;
using System.Drawing;
using System.Windows.Forms;

namespace Matjar
{
    public partial class DashBoard : Form
    {
        private Button[] buttons;

        public DashBoard()
        {
            this.InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            this.buttons = new Button[] { this.btn_statistics, this.btn_goods, this.btn_purchases, this.btn_daly_sales, this.btn_new_product };
            this.btn_daly_sales.PerformClick();
            //this.btn_purchases.PerformClick();
        }

        private void SetActiveButton(Button activeButton)
        {
            foreach (Button btn in this.buttons)
            {
                Console.WriteLine(Properties.Settings.Default["BaseColor"]);
                btn.BackColor = (Color)Properties.Settings.Default["BaseColor"];
                btn.ForeColor = Color.White;
            }

            activeButton.BackColor = (Color)Properties.Settings.Default["ActiveButtonBackColor"];
            activeButton.ForeColor = (Color)Properties.Settings.Default["BaseColor"];
        }

        private void btn_goods_Click(object sender, EventArgs e)
        {
            this.SetActiveButton((Button)sender);
            this.storeUC1.BringToFront();
            this.storeUC1.Start();
        }
        private void btn_daly_sales_Click(object sender, EventArgs e)
        {
            this.SetActiveButton((Button)sender);
            this.uC_Sales1.BringToFront();
            this.uC_Sales1.Start();
        }

        private void btn_purchases_Click(object sender, EventArgs e)
        {
            this.SetActiveButton((Button)sender);
            this.uC_Purchases1.BringToFront();
            this.uC_Purchases1.Start();
        }

        private void btn_new_product_Click(object sender, EventArgs e)
        {
            this.SetActiveButton((Button)sender);

            new AddUpdateProductForm().Start();
        }
    }
}
