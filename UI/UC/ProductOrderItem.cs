using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OfficeOpenXml.ExcelErrorValue;

namespace Toomeet_Pos.UI.UC
{

    [DefaultEvent(nameof(OnRemove))]
    public partial class ProductOrderItem : UserControl
    {


        public ProductOrderItem()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        public string UnitOfMeasure
        {
            get => lbUnitOfMeasure.Text;
            set => lbUnitOfMeasure.Text = value;
        }

        [Browsable(true)]
        public event EventHandler OnRemove;

        [Browsable(true)]
        public event EventHandler OnQuantityChange;

        protected virtual void OnCustomBtnRemveClick(EventArgs e)
        {
            OnRemove?.Invoke(this, e);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            OnCustomBtnRemveClick(EventArgs.Empty);
        }

        private void numbericQuantity_ValueChanged(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(numbericQuantity.Value);
            double totalPrice = Price * quantity;
            lbPrice.Text = totalPrice.ToString("N0", new System.Globalization.CultureInfo("vi-VN")) + " VND";
            OnQuantityChange?.Invoke(this,e);
        }


        [Browsable(true)]
        public double Price { get; set; } = 0;


        public double TotalPrice
        {
            get
            {
                int quantity = Convert.ToInt32(numbericQuantity.Value);
                return Price * quantity;
            }
        }

        [Browsable(true)]
        public string SkuCode
        {
            get => lbSkuCode.Text;
            set => lbSkuCode.Text = value;
        }

        [Browsable(true)]
        public string ProductNameLabel
        {
            get => lbProductName.Text;
            set => lbProductName.Text = value;
        }

        [Browsable(true)]
        public string ProductCategoryLabel
        {
            get => lbProductCategory.Text;
            set => lbProductCategory.Text = value;
        }

        [Browsable(true)]
        public int MaxQuantity
        {
            get => Convert.ToInt32(numbericQuantity.Maximum);
            set => numbericQuantity.Maximum = value;
        }

        [Browsable(true)]
        public int MinQuantity
        {
            get => Convert.ToInt32(numbericQuantity.Minimum);
            set => numbericQuantity.Minimum = value;
        }


        [Browsable(true)]
        public int Quantity
        {
            get => Convert.ToInt32(numbericQuantity.Value);
            set
            {
                int quantity = Convert.ToInt32(value);
                double totalPrice = Price * quantity;

                numbericQuantity.Value = quantity;
                lbPrice.Text = totalPrice.ToString("N0", new System.Globalization.CultureInfo("vi-VN")) + " VND";
            }
        }

  
    }
}
