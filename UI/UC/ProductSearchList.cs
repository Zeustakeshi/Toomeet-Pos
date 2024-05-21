using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toomeet_Pos.BLL;
using Toomeet_Pos.BLL.Interfaces;
using Toomeet_Pos.Entites.Products;

namespace Toomeet_Pos.UI.UC
{

    [DefaultEvent(nameof(SearchItemClick))]
    public partial class ProductSearchList : UserControl
    {
        public ProductSearchList()
        {
            InitializeComponent();
           
        }



        [Browsable(true)]
        public List<Product> Products
        {
            get => Products;
            set {
                foreach (Product product in value)
                {
                    ProductSearchItem item = new ProductSearchItem();
                    item.Dock = DockStyle.Top;
                    item.ProductCategoryText = product.Category.Name;
                    item.ProductNameText = product.Name;
                    item.ProductImage = ImageService.StaticByteArrayToImage(product.Image);
                    item.ProductSearchItemClick += ProducSearchItem_Click;
                    productContainer.Controls.Add(item);
                }
            }
        }

        
        public int ItemCount { get => Products.Count; }


        [Browsable(true)]
        public event EventHandler SearchItemClick;

        protected virtual void OnProductSearchItemClick(EventArgs e)
        {
            SearchItemClick?.Invoke(this, e);
        }


        private void ProducSearchItem_Click(object sender, EventArgs e)
        {
            OnProductSearchItemClick(EventArgs.Empty);
            Visible = false;
        }

        private void productContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
