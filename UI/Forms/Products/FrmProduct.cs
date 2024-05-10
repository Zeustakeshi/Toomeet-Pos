using System;
using System.Windows.Forms;
using Toomeet_Pos.BLL.Interfaces;
using Toomeet_Pos.DAL.Interfaces;
using Toomeet_Pos.Entites;

namespace Toomeet_Pos.UI.Forms.Products
{
    public partial class FrmProduct : Form
    {

        private readonly Staff _currentStaff;
        private readonly Store _store;
        private readonly IProductService _productService;
        private readonly IRoleService _roleService;

        public FrmProduct(
            Staff staff, Store store
        )
        {
            InitializeComponent();
            _currentStaff = staff;
            _store = store;
            _productService = Program.GetService<IProductService>();
            _roleService = Program.GetService<IRoleService>();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            CheckCanAddProduct();
            LoadAllProduct();
        }

        private void LoadAllProduct()
        {
            try
            {
                dataGridProducts.DataSource = _productService.GetAllProduct(_store.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckCanAddProduct ()
        {
            if (!_roleService.CanCreateProduct(_currentStaff))
            {
                btnAddProduct.Enabled = false;
                btnAddProduct.Visible = false;
            }
        }

    

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FrmAddProduct frmAddProduct = new FrmAddProduct(_store, _currentStaff);
            frmAddProduct.ShowDialog();
            LoadAllProduct();
        }
    }
}
