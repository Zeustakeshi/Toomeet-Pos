using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toomeet_Pos.UI.Forms.Products
{
    public partial class FrmManageProducts : Form
    {
        public FrmManageProducts()
        {
            InitializeComponent();
        }

        private void btnViewProductCategories_Click(object sender, EventArgs e)
        {
            FrmManageProductCategory frmManageProductCategory = new FrmManageProductCategory();
            frmManageProductCategory.ShowDialog();
        }

        private void LoadAllPoducts()
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FrmAddProduct frmAddProduct = new FrmAddProduct();
            frmAddProduct.ShowDialog();

            LoadAllPoducts();
        }
    }
}
