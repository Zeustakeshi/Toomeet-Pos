using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toomeet_Pos.BLL.Interfaces;
using Toomeet_Pos.Entites;
using Toomeet_Pos.Entites.Products;

namespace Toomeet_Pos.UI.Forms.Products
{
    public partial class FrmAddBrand : Form
    {

        private readonly IBrandService _brandService;
        private readonly Store _store;
        private readonly Staff _currentStaff;

        public FrmAddBrand(Store store, Staff staff)
        {
            InitializeComponent();
            _currentStaff = staff;
            _store = store;
            _brandService = Program.GetService<IBrandService>();
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            try
            {
                Brand newBrand = new Brand()
                {
                    Name = txtBrandName.Text,
                    Description = txtBrandDescription.Text,
                    Store = _store,
                    StoreId = _store.Id
                };

                _brandService.CreateBrand(new DTOs.NewBrandDto()
                {
                    Brand = newBrand,
                    Staff = _currentStaff,
                    Store = _store
                });

                Close();

            }catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message, "Thêm nhãn hiệu thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
