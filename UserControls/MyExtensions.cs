using System;
using System.Reflection;
using System.Windows.Forms;


namespace UserControls
{
    public static class MyExtensions
    {
        // Extension method for make DataGridView faster
        public static void DoubleBuffered(this DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }
    }
}
