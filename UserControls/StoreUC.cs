﻿using DataAccessLayer;
using System.Windows.Forms;
using Repos;


namespace UserControls
{
    public partial class StoreUC : UserControl
    {
        private ProductsRepo repo;
        public StoreUC()
        {
            InitializeComponent();
            dgv_store.DoubleBuffered(true);
            dgv_store.AutoGenerateColumns = false;
        }

        public void Start()
        {
            dgv_store.DataSource = this.repo.GetAllProducts();
            this.repo = new ProductsRepo();
        }
    }
}
