using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Toomeet_Pos.Uitls
{
    public class Util
    {
        public static string ReplaceVietnameseWithEnglish(string str)
        {
            str = str.Replace("A", "A")
                     .Replace("Á", "A")
                     .Replace("À", "A")
                     .Replace("Ã", "A")
                     .Replace("Ạ", "A")
                     .Replace("Â", "A")
                     .Replace("Ấ", "A")
                     .Replace("Ầ", "A")
                     .Replace("Ẫ", "A")
                     .Replace("Ậ", "A")
                     .Replace("Ă", "A")
                     .Replace("Ắ", "A")
                     .Replace("Ằ", "A")
                     .Replace("Ẵ", "A")
                     .Replace("Ặ", "A")
                     .Replace("à", "a")
                     .Replace("á", "a")
                     .Replace("ạ", "a")
                     .Replace("ả", "a")
                     .Replace("ã", "a")
                     .Replace("â", "a")
                     .Replace("ầ", "a")
                     .Replace("ấ", "a")
                     .Replace("ậ", "a")
                     .Replace("ẩ", "a")
                     .Replace("ẫ", "a")
                     .Replace("ă", "a")
                     .Replace("ằ", "a")
                     .Replace("ắ", "a")
                     .Replace("ặ", "a")
                     .Replace("ẳ", "a")
                     .Replace("ẵ", "a")
                     .Replace("E", "E")
                     .Replace("É", "E")
                     .Replace("È", "E")
                     .Replace("Ẽ", "E")
                     .Replace("Ẹ", "E")
                     .Replace("Ê", "E")
                     .Replace("Ế", "E")
                     .Replace("Ề", "E")
                     .Replace("Ễ", "E")
                     .Replace("Ệ", "E")
                     .Replace("è", "e")
                     .Replace("é", "e")
                     .Replace("ẹ", "e")
                     .Replace("ẻ", "e")
                     .Replace("ẽ", "e")
                     .Replace("ê", "e")
                     .Replace("ề", "e")
                     .Replace("ế", "e")
                     .Replace("ệ", "e")
                     .Replace("ể", "e")
                     .Replace("ễ", "e")
                     .Replace("I", "I")
                     .Replace("Í", "I")
                     .Replace("Ì", "I")
                     .Replace("Ĩ", "I")
                     .Replace("Ị", "I")
                     .Replace("ì", "i")
                     .Replace("í", "i")
                     .Replace("ị", "i")
                     .Replace("ỉ", "i")
                     .Replace("ĩ", "i")
                     .Replace("O", "O")
                     .Replace("Ó", "O")
                     .Replace("Ò", "O")
                     .Replace("Õ", "O")
                     .Replace("Ọ", "O")
                     .Replace("Ô", "O")
                     .Replace("Ố", "O")
                     .Replace("Ồ", "O")
                     .Replace("Ỗ", "O")
                     .Replace("Ộ", "O")
                     .Replace("Ơ", "O")
                     .Replace("Ớ", "O")
                     .Replace("Ờ", "O")
                     .Replace("Ỡ", "O")
                     .Replace("Ợ", "O")
                     .Replace("ò", "o")
                     .Replace("ó", "o")
                     .Replace("ọ", "o")
                     .Replace("ỏ", "o")
                     .Replace("õ", "o")
                     .Replace("ô", "o")
                     .Replace("ồ", "o")
                     .Replace("ố", "o")
                     .Replace("ộ", "o")
                     .Replace("ổ", "o")
                     .Replace("ỗ", "o")
                     .Replace("ơ", "o")
                     .Replace("ờ", "o")
                     .Replace("ớ", "o")
                     .Replace("ợ", "o")
                     .Replace("ở", "o")
                     .Replace("ỡ", "o")
                     .Replace("U", "U")
                     .Replace("Ú", "U")
                     .Replace("Ù", "U")
                     .Replace("Ũ", "U")
                     .Replace("Ụ", "U")
                     .Replace("Ư", "U")
                     .Replace("Ứ", "U")
                     .Replace("Ừ", "U")
                     .Replace("Ữ", "U")
                     .Replace("Ự", "U")
                     .Replace("ù", "u")
                     .Replace("ú", "u")
                     .Replace("ụ", "u")
                     .Replace("ủ", "u")
                     .Replace("ũ", "u")
                     .Replace("ư", "u")
                     .Replace("ừ", "u")
                     .Replace("ứ", "u")
                     .Replace("ự", "u")
                     .Replace("ử", "u")
                     .Replace("ữ", "u")
                     .Replace("Y", "Y")
                     .Replace("Ý", "Y")
                     .Replace("Ỳ", "Y")
                     .Replace("Ỹ", "Y")
                     .Replace("Ỵ", "Y")
                     .Replace("ỳ", "y")
                     .Replace("ý", "y")
                     .Replace("ỵ", "y")
                     .Replace("ỷ", "y")
                     .Replace("ỹ", "y")
                     .Replace("Đ", "D")
                     .Replace("đ", "d")
                     .Replace("\u0300", "")
                     .Replace("\u0301", "")
                     .Replace("\u0303", "")
                     .Replace("\u0309", "")
                     .Replace("\u0323", "")
                     .Replace("\u02C6", "")
                     .Replace("\u0306", "")
                     .Replace("\u031B", "");

            return str;
        }

        public enum Month
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
    }
}
