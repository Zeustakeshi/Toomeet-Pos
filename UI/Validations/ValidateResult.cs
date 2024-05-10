using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toomeet_Pos.UI.Validations
{
    public class ValidateResult
    {
        public bool IsSuccess { get; set; } = false;
        public bool IsError { get; set; } = false;
        public string ErrorMessage { get; set; } = null;

        public ValidateResult (bool isSuccess)
        {
            IsSuccess = isSuccess;
            IsError = false;
        }

        public ValidateResult (string errorMessage)
        {
            ErrorMessage = errorMessage;
            IsError = true;
            IsSuccess = false;
        }

        public static ValidateResult Success()
        {
            return new ValidateResult(true);
        }

        public static ValidateResult Error (string message)
        {
            return new ValidateResult(message);
        }

    }
}
