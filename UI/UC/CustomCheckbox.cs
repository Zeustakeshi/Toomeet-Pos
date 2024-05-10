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

    [DefaultEvent(nameof(CheckedChanged))]
    public partial class CustomCheckbox : UserControl
    {
        [Browsable(true)]
        public string LabelText
        {
            get => label.Text;
            set => label.Text = value; 
        }

        [Browsable(true)]
        public bool Checked 
        {
            get => checkBox.Checked;
            set => checkBox.Checked = value;
        }



        public CustomCheckbox()
        {
            InitializeComponent();
        }


        [Browsable(true)]
        public event EventHandler CheckedChanged
        {
            add => checkBox.CheckedChanged += value;
            remove => checkBox.CheckedChanged -= value;
        }

        private void label_Click(object sender, EventArgs e)
        {
            checkBox.Checked = !checkBox.Checked;
        }
    }
}
