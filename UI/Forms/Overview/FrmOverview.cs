using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Toomeet_Pos.BLL.Interfaces;
using Toomeet_Pos.Entites;
using Toomeet_Pos.Entites.orders;
using Toomeet_Pos.Entites.Products;
using Toomeet_Pos.Uitls;

namespace Toomeet_Pos.UI.Forms.Overview
{
    public partial class FrmOverview : Form
    {

        private readonly IStoreService _storeService;
        private readonly IOrderService _orderService;
        private readonly IAuthService _authService;
        private readonly IProductService _productService;

        private Staff _currentStaff;
        private Store _store;

        public FrmOverview()
        {
            InitializeComponent();
            _storeService = Program.GetService<IStoreService>();
            _orderService = Program.GetService<IOrderService>();
            _authService = Program.GetService<IAuthService>();
            _productService = Program.GetService<IProductService>();

            _currentStaff = _authService.GetAuthenticatedStaff();
            _store = _authService.GetStoreInfo();


            guna2CircleProgressBar1.Animated = true;
            guna2CircleProgressBar2.Animated = true;
            guna2CircleProgressBar3.Animated = true;
        }

        private void FrmOverview_Load(object sender, EventArgs e)
        {
            try
            {

                int currentMonth = DateTime.Now.Month;


                double totalRevenue = 0;
                double totalCost = 0;

                for (int month = (int)Util.Month.January; month <= currentMonth; month++)
                {
                    DateTime startOfMonth = new DateTime(DateTime.Now.Year, month, 1);
                    DateTime endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);

                    List<Order> orders = _orderService.GetAllOrderBetweenTime(_store.Id, startOfMonth, endOfMonth);

                    double revenue =  _storeService.GetRevenue(orders);
                    double cost = _storeService.GetCost(orders);

                    totalRevenue += revenue;
                    totalCost += cost;
                    cRevenue.DataPoints.Add("Tháng " + month, revenue);
                    cCost.DataPoints.Add("Tháng " + month, cost);
                }

                lbRevenue.Text = totalRevenue.ToString();

                List<Product> products = _productService.GetAllProduct(_store.Id);

                lbProductS1.Text = products[0]?.Name ?? "None";
                lbProductS2.Text = products[1]?.Name ?? "None";
                lbProductS3.Text = products[2]?.Name ?? "None";


            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.GetBaseException().Message,
                    "Tải doanh thu thất bại",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
