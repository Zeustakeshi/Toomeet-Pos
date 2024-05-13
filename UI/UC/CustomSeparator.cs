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
    public partial class CustomSeparator : UserControl
    {

        [Browsable(true)]
        public string Label {
            get => label.Text;
            set => label.Text = value;
        }

        public CustomSeparator()
        {
            InitializeComponent();
        }
    }
}
