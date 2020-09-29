using System;
using System.Data;
using System.Windows.Forms;

namespace UserControls
{
    public partial class UC_NewUnit : UserControl
    {
        public UC_NewUnit()
        {
            InitializeComponent();
        }

        public void Start(DataTable units_names)
        {
            combo_existed_units.DisplayMember = "unit";
            combo_existed_units.DataSource = units_names;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(text_new_unit_name.Text))
            {
                MessageBox.Show("حقل فارغ", "رسالة خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_new_unit_name.Focus();
                return;
            }

            string sql = string.Format("INSERT INTO units VALUES (NULL, '{0}')", text_new_unit_name.Text);
            DataAccessLayer.DBHandler db = new DataAccessLayer.DBHandler();
            if (db.ExecuteNonQuery(sql) == "Constraint")
            {
                MessageBox.Show("هذا القسم موجود بالفعل !", "رسالة خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_new_unit_name.Focus();
                text_new_unit_name.SelectAll();
                return;
            }
            (new System.Windows.Forms.NotifyIcon()
            {
                Visible = true,
                Icon = System.Drawing.SystemIcons.Information,
                BalloonTipText = "تم الحفظ بنجاح",
            }).ShowBalloonTip(1000);
            OnUnitsUpdated();
        }

        public event EventHandler UnitsUpdated;
        protected virtual void OnUnitsUpdated()
        {
            EventHandler handler = UnitsUpdated;
            if ( handler != null )
            {
                handler(this, EventArgs.Empty);
            }
        }
    }
}
