using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toomeet_Pos.UI.UC
{

    [DefaultEvent(nameof(ProductSearchItemClick))]
    public partial class ProductSearchItem : UserControl
    {
        public static int DefaultHeight = 74;

        public ProductSearchItem()
        {
            InitializeComponent();
            Height = DefaultHeight;
        }


        private void ProducSearchItem_Load(object sender, EventArgs e)
        {

        }

        [Browsable(true)]
        public string ProductNameText
        {
            get => lbProductName.Text;
            set => lbProductName.Text = value;
        }

        [Browsable(true)]
        public string ProductCategoryText
        {
            get => lbProductCategory.Text;
            set => lbProductCategory.Text = value;
        }

       
        [Browsable(true)]
        public Image ProductImage
        {
            get => image.Image;
            set => image.Image = value; 
        }

        [Browsable(true)]
        public event EventHandler ProductSearchItemClick;

        protected virtual void OnProductSearchItemClick(EventArgs e)
        {
            ProductSearchItemClick?.Invoke(this, e);
        }

        private void ProducSearchItem_Click(object sender, EventArgs e)
        {
            OnProductSearchItemClick(EventArgs.Empty);
        }
    }
}
