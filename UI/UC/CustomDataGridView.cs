using Guna.UI2.WinForms;
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



    [DefaultEvent(nameof(CellClick))]
    public partial class CustomDataGridView : UserControl
    {
        public CustomDataGridView()
        {
            InitializeComponent();

        }

        public Guna2DataGridView DataGridView
        {
            get => myDataGridView;
        }


        [Browsable(true)]
        public List<string> ColumnHeaderTexts
        {
            get
            {
                List<string> headerTexts = new List<string>();

                foreach (DataGridViewColumn column in myDataGridView.Columns)
                {
                    headerTexts.Add(column.HeaderText);
                }
                return headerTexts;
            }

            set
            {
                int len = value.Count;

                if (myDataGridView.Columns.Count != len) return;

                for (int i = 0; i < len; ++i)
                {
                    myDataGridView.Columns[i].HeaderText = value[i];
                }
                
            }
        }


        [Browsable(true)]
        public object DataSource
        {
            get => myDataGridView.DataSource;
            set => myDataGridView.DataSource = value;
        }


        [Browsable(true)]
        public event EventHandler CellClick;

        protected virtual void OnCustomCellClick(EventArgs e)
        {
            CellClick?.Invoke(this, e);
        }

        private void myDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            OnCustomCellClick(EventArgs.Empty);
        }
    }
}
