using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Toomeet_Pos.UI.Validations
{

    public interface IStoreValidate
    {
        ValidateResult IsValidName(string storeName);

        ValidateResult IsValidAddress(string address);

    }

    public class StoreValidate : BaseValidation, IStoreValidate
    {
        public ValidateResult IsValidName (string storeName)
        {
            if (IsEmptyString(storeName)) return ValidateResult.Error("Tên cửa hàng không được bỏ trống");

            if (storeName.Length > 50 || storeName.Length < 5)
            {
                return ValidateResult.Error("Tên cửa hàng phải lớn hơn 5 và nhỏ hơn 50 kí tự");
            }

            return new ValidateResult(isSuccess: true);
        }

        public ValidateResult IsValidAddress (string address)
        {
            if (address.Length < 10 )
            {
                return ValidateResult.Error("Địa chỉ quá ngắn");
            }

            if (address.Length > 120)
            {
                return ValidateResult.Error("Địa chỉ quá dài");
            }

            return ValidateResult.Success();
        }
    }
}
