using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Toomeet_Pos.UI.Validations
{

    public interface IStaffValidate
    {
        ValidateResult IsValidName(string name);
        ValidateResult IsValidEmail(string email);
        ValidateResult IsValidPassword(string password);
        ValidateResult IsValidPhone(string phone);

        ValidateResult IsValidAddress(string address);

        ValidateResult IsValidBirthday(DateTime time);

        ValidateResult IsValidDescription (string description);
    }


    public class StaffValidate : BaseValidation, IStaffValidate
    {

        public ValidateResult IsValidPhone(string phone)
        {
            if (IsEmptyString(phone)) return ValidateResult.Error("Số điện thoại không được bỏ trống.");

            if (phone.Length < 10 || phone.Length > 11 || !phone.StartsWith("09"))
            {
                return ValidateResult.Error("Số điện thoại không hợp lệ");
            }

            return ValidateResult.Success();
        }

        public ValidateResult IsValidName (string name)
        {
            if (IsEmptyString(name)) return ValidateResult.Error("Tên nhân viên không được bỏ trống");

            if (name.Length < 5 || name.Length > 50)
            {
                return ValidateResult.Error("Tên nhân viên có độ dài lớn hơn 5 và nhỏ hơn 50 kí tự");
            }
            return ValidateResult.Success();
        }

        public ValidateResult IsValidEmail(string email)
        {

            if (IsEmptyString(email)) return ValidateResult.Error("Email không được bỏ trống.");

            string regex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Match match = Regex.Match(email, regex);

            if (!match.Success) return ValidateResult.Error("Email không hợp lệ.");

            return ValidateResult.Success();
        }

        public ValidateResult IsValidPassword(string password)
        {
            if (IsEmptyString(password)) return ValidateResult.Error("Mật khẩu không được bỏ trống.");

            Regex hasNumber = new Regex(@"\d"); // Ít nhất một chữ số
            Regex hasUpperChar = new Regex(@"[A-Z]"); // Ít nhất một ký tự viết hoa
            Regex hasMiniMaxChars = new Regex(@"^.{8,50}$"); // Từ 8 đến 50 ký tự
            Regex hasLowerChar = new Regex(@"[a-z]"); // Ít nhất một ký tự viết thường
            Regex hasSymbols = new Regex(@"[!@#$%^&*()_+={}\[\]:;<>,.?\/\\-]");



            if (!hasMiniMaxChars.IsMatch(password))
            {
                return ValidateResult.Error("Mật khẩu phải có ít nhất 8 kí tự và tối đa 50 kí tự");
            }

            if (!hasNumber.IsMatch(password))
            {
                return ValidateResult.Error("Mật khẩu phải có ít nhất 1 kí tự số");
            }

            if (!hasUpperChar.IsMatch(password))
            {
                return ValidateResult.Error("Mật khẩu thiếu kí tự in hoa");
            }

            if (!hasLowerChar.IsMatch(password))
            {
                return ValidateResult.Error("Mật khẩu thiếu kí tự in thường");
            }

            if (!hasSymbols.IsMatch(password))
            {
                return ValidateResult.Error("Mật khẩu phải có ít nhất 1 kí tự đặc biệt");
            }

            return ValidateResult.Success();

        }

        public ValidateResult IsValidAddress(string address)
        {
            if (IsEmptyString(address))
            {
                return ValidateResult.Error("Địa chỉ không được bỏ trống");
            }

            if (address.Length < 5 || address.Length > 100)
            {
                return ValidateResult.Error("Độ dài địa chỉ không hợp lệ");
            } 


            return ValidateResult.Success();
        }

        public ValidateResult IsValidBirthday(DateTime time)
        {
            DateTime today = DateTime.Today;
            int age =    today.Year - time.Year;
            if (time > today.AddYears(-age))
                age--;

            if (age < 18)
            {
                return ValidateResult.Error("Nhân viên chưa đủ 18 tuổi.");
            }

            return ValidateResult.Success();
        }

        public ValidateResult IsValidDescription(string description)
        {
            if (description.Length == 0) return ValidateResult.Success();

            if (description.Length < 5) return ValidateResult.Error("Mô tả quá ngắn");

            if (description.Length > 150) return ValidateResult.Error("Mô tả quá dài");

            return ValidateResult.Success();
        }
    }
}
