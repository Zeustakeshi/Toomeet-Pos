using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toomeet_Pos.UI.Forms
{
    public partial class FrmForgotPasssword : Form
    {
        public FrmForgotPasssword()
        {
            InitializeComponent();
        }

        private void llbLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();

            Hide();
            frmLogin.ShowDialog();
            Close();
        }
    }
}
