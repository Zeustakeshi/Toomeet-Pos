using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toomeet_Pos.UI.UC
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class CustomMenuItemGroup : UserControl
    {

        [Browsable(true)]
        public string LabelText 
        {
            get => customSeparator.Label;
            set => customSeparator.Label = value;


        }

        


        public bool ShowLabel 
        {
            get => customSeparator.Visible;
            set
            {
                if (value)
                {
                    Controls.Add(customSeparator);
                    customSeparator.Visible = true;
                }
                else
                {
                    Controls.Remove(customSeparator);
                    customSeparator.Visible = false;
                }
            }
        }

        public CustomMenuItemGroup()
        {
            InitializeComponent();
        }

        private void CustomMenuItemGroup_Load(object sender, EventArgs e)
        {
            guna2Panel2.BorderThickness = 0;
        }
    }
}
