using System.Windows.Forms;

namespace Matjar
{
    public partial class AddUpdateProductForm : Form
    {
        public AddUpdateProductForm()
        {
            this.InitializeComponent();
        }

        public void Start()
        {
            this.Show();
            this.uC_Add_Product_Full1.Start();
        }

    }
}
