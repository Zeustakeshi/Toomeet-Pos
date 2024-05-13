using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Toomeet_Pos.UI.Validations
{

    public interface ICategoryValidate 
    {
        ValidateResult IsValidName(string name);
        ValidateResult IsValidId(string id);

        ValidateResult IsValidDescription (string description);
    }



    public class CategoryValidate : BaseValidation, ICategoryValidate
    {
        public ValidateResult IsValidDescription(string description)
        {
            if (description.Length == 0) return ValidateResult.Success();
            if (description.Length < 5 || description.Length > 500) return ValidateResult.Error("Độ dài mã loại sản phẩm không hợp lệ");
            return ValidateResult.Success();
        }

        public ValidateResult IsValidId(string id)
        {
            if (IsEmptyString(id)) return ValidateResult.Error("Mã loại sản phẩm không được bỏ trống");
            if (id.Length < 5 || id.Length > 500) return ValidateResult.Error("Độ dài mã loại sản phẩm không hợp lệ");
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
