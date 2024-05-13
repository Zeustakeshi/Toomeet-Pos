using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toomeet_Pos.UI.Validations
{

    public interface IBrandValidate
    {
        ValidateResult IsValidName(string name);

        ValidateResult IsValidDescription(string description);
    }
    public class BrandValidate : BaseValidation, IBrandValidate
    {
        public ValidateResult IsValidDescription(string description)
        {
            if (description.Length == 0) return ValidateResult.Success();
            if (description.Length < 5 || description.Length > 500) return ValidateResult.Error("Độ dài mã loại sản phẩm không hợp lệ");
            return ValidateResult.Success();
        }


        public ValidateResult IsValidName(string name)
        {
            if (IsEmptyString(name)) return ValidateResult.Error("Tên loại sản phẩm không được bỏ trống");

            if (name.Length < 5 || name.Length > 500) return ValidateResult.Error("Độ dài tên loại sản phẩm không hợp lệ");

            return ValidateResult.Success();
        }
    }
}
