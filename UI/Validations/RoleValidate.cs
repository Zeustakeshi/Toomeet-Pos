using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toomeet_Pos.UI.Validations
{

    public interface IRoleValidate
    {
        ValidateResult IsValidRoleName(string name);
        ValidateResult IsValidRoleDescription(string desc);
    }

    public class RoleValidate : BaseValidation, IRoleValidate
    {
        public ValidateResult IsValidRoleDescription(string desc)
        {
            if (desc.Length < 5 || desc.Length > 500) return ValidateResult.Error("Ghi chú không hợp lệ");
            return ValidateResult.Success();
        }

        public ValidateResult IsValidRoleName(string name)
        {
            if (IsEmptyString(name)) return ValidateResult.Error("Tên vai trò không được bỏ trống");

            if (name.Length < 5 || name.Length > 50) return ValidateResult.Error("Tên vai trò không hợp lệ");

            return ValidateResult.Success();
        }
    }
}
