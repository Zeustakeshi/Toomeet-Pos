using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Toomeet_Pos.UI.Validations
{

    public interface IAuthValidate
    {
        ValidateResult IsValidEmail(string email);
        ValidateResult IsValidPhone(string phone);
        ValidateResult IsValidPassword(string password);
        ValidateResult IsValidUsername(string username);
        ValidateResult IsValidStoreName(string storeName);

    }

    public class AuthValidate: BaseValidation, IAuthValidate
    {


        public ValidateResult IsValidEmail (string email)
        {
             
           if (IsEmptyString(email)) return new ValidateResult(errorMessage: "Email không được bỏ trống.");

            string regex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Match match = Regex.Match(email, regex);

            if (!match.Success) return new ValidateResult(errorMessage: "Email không hợp lệ.");

            return new ValidateResult(isSuccess: true);
        }

        public ValidateResult IsValidPhone(string phone)
        {
            if (IsEmptyString(phone)) return new ValidateResult(errorMessage: "Số điện thoại không được bỏ trống.");
            
            if (phone.Length < 10 || phone.Length > 11 || !phone.StartsWith("09"))
            {
                return new ValidateResult(errorMessage: "Số điện thoại không hợp lệ");
            }


            return new ValidateResult(isSuccess: true);
        }

        public ValidateResult IsValidPassword (string password)
        {
            if (IsEmptyString(password)) return new ValidateResult(errorMessage: "Mật khẩu không được bỏ trống.");

            Regex hasNumber = new Regex(@"\d"); // Ít nhất một chữ số
            Regex hasUpperChar = new Regex(@"[A-Z]"); // Ít nhất một ký tự viết hoa
            Regex hasMiniMaxChars = new Regex(@"^.{8,50}$"); // Từ 8 đến 50 ký tự
            Regex hasLowerChar = new Regex(@"[a-z]"); // Ít nhất một ký tự viết thường
            Regex hasSymbols = new Regex(@"[!@#$%^&*()_+={}\[\]:;<>,.?\/\\-]");



            if (!hasMiniMaxChars.IsMatch(password))
            {
                return new ValidateResult(errorMessage: "Mật khẩu phải có ít nhất 8 kí tự và tối đa 50 kí tự");
            }


            if (!hasNumber.IsMatch(password))
            {
                return new ValidateResult(errorMessage: "Mật khẩu phải có ít nhất 1 kí tự số");
            }

            if (!hasUpperChar.IsMatch(password))
            {
                return new ValidateResult(errorMessage: "Mật khẩu thiếu kí tự in hoa");
            }

            if (!hasLowerChar.IsMatch(password))
            {
                return new ValidateResult(errorMessage: "Mật khẩu thiếu kí tự in thường");
            }

            if (!hasSymbols.IsMatch(password))
            {
                return new ValidateResult(errorMessage: "Mật khẩu phải có ít nhất 1 kí tự đặc biệt");
            }

            return new ValidateResult(isSuccess: true);

        }

        public ValidateResult IsValidUsername (string username)
        {

            if (IsEmptyString(username)) return new ValidateResult(errorMessage: "Tên tài khoản không được bỏ trống.");
            ValidateResult validateEmail = IsValidEmail(username);
            ValidateResult validatePhone = IsValidPhone(username);

            if (!validateEmail.IsSuccess && !validatePhone.IsSuccess)
            {
                return new ValidateResult(errorMessage: "Thông tin đăng nhập không hợp lệ");
            }

            return new ValidateResult(isSuccess: true);
        }

        public ValidateResult IsValidStoreName (string storeName)
        {
            if (IsEmptyString(storeName)) return new ValidateResult(errorMessage: "Tên cửa hàng không được bỏ trống");

            if (storeName.Length > 50 || storeName.Length < 5)
            {
                return new ValidateResult(errorMessage: "Tên cửa hàng phải > 5 và < 50 kí tự");
            }

            return new ValidateResult(isSuccess: true);
        }
    }

 
}
