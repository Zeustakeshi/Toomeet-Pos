using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toomeet_Pos.DAL.Interfaces;

namespace Toomeet_Pos.UI.Forms
{
    public partial class FrmLoading : Form
    {

        private readonly IDataAccessLayer _dataAccess;
        private int _totalSteps;
        private int _completedSteps;

        public FrmLoading()
        {
            InitializeComponent();
            _dataAccess = Program.GetService<IDataAccessLayer>();
        }

        private async void FrmLoading_Load(object sender, EventArgs e)
        {
            _totalSteps = 100;
            _completedSteps = 0;
            progressBar.Maximum = 10;
            progressBar.Value = 0;
            timer.Interval = 1000; // 1s
            progressBar.Minimum = 0;
            timer.Start();

            if (await Task.Run(() => _dataAccess.TestConnect()))
            {
                timer.Stop();
                progressBar.Value = progressBar.Maximum;
                FrmLogin frmLogin = new FrmLogin();
                Hide();
                frmLogin.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Error connecting to database", "Database_connect_error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            _completedSteps++;
            UpdateProgressBar();
        }

        private void UpdateProgressBar()
        {
            int progressValue = (int)(((double)_completedSteps / _totalSteps) * 100);
            progressBar.Value = Math.Min(progressBar.Maximum - 1, progressValue);

            if (progressBar.Value == progressBar.Maximum / 4)
            {
                lbLoadingStatus.Text = "Chuẩn bị cửa hàng";
            }

            if (progressBar.Value == progressBar.Maximum / 3)
            {
                lbLoadingStatus.Text = "Đang khởi tạo người dùng";
            }


            if (progressBar.Value == progressBar.Maximum / 2)
            {
                lbLoadingStatus.Text = "Đang kết nối cơ sở dữ liệu";
            }

        }
    }
}
