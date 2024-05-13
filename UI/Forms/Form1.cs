using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toomeet_Pos.Entites;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Toomeet_Pos.UI.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            List<object> dgStaffData = new List<object>();

            for (int i = 0; i < 10; ++i)
            {
                dgStaffData.Add(new
                {
                    Id = i,
                    Photo = "123213",
                    Name = "staff " + i,
                    Phone =  i,
                    Email = 1,
                    Gender = 1,
                    Status = 1,
                    Role = 2,
                    CreatedAt = 1
                });
            }


            dgStaff.DataSource = dgStaffData;

        }
    }
}
