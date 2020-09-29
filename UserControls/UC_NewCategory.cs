using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace UserControls
{
    public partial class UC_NewCategory : UserControl
    {
        public UC_NewCategory()
        {
            InitializeComponent();
        }

        public void Start(DataTable categories)
        {
            this.combo_existed_categories.DisplayMember = "category";
            this.combo_existed_categories.DataSource = categories;
        }



        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(text_new_category.Text))
            {
                MessageBox.Show("حقل فارغ", "رسالة خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_new_category.Focus();
                return;
            }
            string sql = string.Format("INSERT INTO categories VALUES (NULL, '{0}')", 
                text_new_category.Text);
            DataAccessLayer.DBHandler db = new DataAccessLayer.DBHandler();
            if (db.ExecuteNonQuery(sql) == "Constraint")
            {
                MessageBox.Show("هذا القسم موجود بالفعل !", "رسالة خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_new_category.Focus();
                text_new_category.SelectAll();
                return;
            }
            (new System.Windows.Forms.NotifyIcon()
            {
                Visible = true,
                Icon = System.Drawing.SystemIcons.Information,
                BalloonTipText = "تم الحفظ بنجاح",
            }).ShowBalloonTip(1000);

            OnCategoriewUpdated();
        }

        public event EventHandler CategoriesUpdated;
        protected virtual void OnCategoriewUpdated()
        {
            EventHandler handler = CategoriesUpdated;
            if ( handler != null )
            {
                handler(this, EventArgs.Empty);
            }
        }
    }
}
