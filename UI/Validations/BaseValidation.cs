using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toomeet_Pos.UI.Validations
{
    public abstract class BaseValidation
    {
        public bool IsEmptyString (string str)
        {
            return str.Trim() == "" || str.Length == 0;
        }

       
    }
}
