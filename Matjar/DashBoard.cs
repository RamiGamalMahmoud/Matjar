using System;
using System.Drawing;
using System.Windows.Forms;

namespace Matjar
{
    public partial class DashBoard : Form
    {
        private Button[] buttons;
        private Color BaseColor = Color.FromArgb(54, 79, 107);
        private Color ActiveColor = Color.FromArgb(67, 221, 230);

        public DashBoard()
        {
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            this.buttons = new Button[] { btn_statistics, btn_goods, btn_purchases, btn_daly_sales, btn_new_product };
            //btn_daly_sales.PerformClick();
            btn_purchases.PerformClick();
        }

        private void SetActiveButton(Button activeButton)
        {
            foreach(Button btn in this.buttons)
            {
                btn.BackColor = this.BaseColor;
                btn.ForeColor = Color.White;
            }

            activeButton.BackColor = this.ActiveColor;
            activeButton.ForeColor = this.BaseColor;
        }

        private void btn_goods_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);
            storeUC1.BringToFront();
            storeUC1.Start();
        }
        private void btn_daly_sales_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);
            uC_Sales1.BringToFront();
            uC_Sales1.Start();
        }

        private void btn_purchases_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);
            uC_Purchases1.BringToFront();
            uC_Purchases1.Start();
        }

        private void btn_statistics_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);
            new FormManagement().ShowDialog();
        }

        private void btn_new_product_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);
            new AddUpdateProductForm().Show();
        }
    }
}
