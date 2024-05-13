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

    [DefaultEvent(nameof(ValueChange))]
    public partial class CustomTextBox : UserControl
    {
        

        public CustomTextBox()
        {
            InitializeComponent();
            lbErrorMessage.Text = "";
        }


        [Browsable(true)]
        public string Value
        {
            get => mainTextbox.Text;
            set => mainTextbox.Text = value;
        }

        [Browsable(true)]
        public bool TextAreaMode
        {
            get => mainTextbox.Multiline;
            set => mainTextbox.Multiline = value;
        }


        [Browsable(true)]
        public Size TextBoxSize
        {
            get => mainTextbox.Size;
            set => mainTextbox.Size = value;
        }


        [Browsable(true)]
        public string Label
        {
            get => label.Text;
            set => label.Text = value;
        }

        [Browsable(true)]
        public string TextboxPlaceholder
        {
            get => mainTextbox.PlaceholderText;
            set => mainTextbox.PlaceholderText = value;
        }


        [Browsable(true)]
        public string  ErrorMessage
        {
            get => lbErrorMessage.Text;
            set
            {
                lbErrorMessage.Text = value;
                mainTextbox.Focus();
            }
        }

        [Browsable(true)]
        public bool IsPassword
        {
            get => mainTextbox.UseSystemPasswordChar;
            set
            {
                mainTextbox.UseSystemPasswordChar = value;
                if (value) mainTextbox.PlaceholderText = "●●●●●●●●";
            }
        }

        [Browsable(true)]
        public bool Required { get; set; }



        [Browsable(true)]
        public event EventHandler ValueChange;


        private void mainTextbox_TextChanged(object sender, EventArgs e)
        {
            
            if (Required && mainTextbox.Text.Length <= 0)
            {
                lbErrorMessage.Text = "Trường này không được bỏ trống";
                mainTextbox.Focus();
            }else
            {
                lbErrorMessage.Text = "";
            }


            OnCustomTextChanged(EventArgs.Empty);
        }


        protected virtual void OnCustomTextChanged(EventArgs e)
        {
            ValueChange?.Invoke(this, e);
        }

    }
}
