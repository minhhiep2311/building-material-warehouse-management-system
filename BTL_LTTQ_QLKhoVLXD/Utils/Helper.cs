using System.Text.RegularExpressions;

namespace BTL_LTTQ_QLKhoVLXD.Utils
{
    internal class Helper
    {
        public class RegexValidate
        {
            public static bool Name(string str)
            {
                return Regex.Match(RemoveAccent(str), @"^[a-zA-Z]+((['. -][a-zA-Z ])?[a-zA-Z]*)*$", RegexOptions.IgnoreCase).Success;
            }

            public static bool PhoneNumber(string str)
            {
                return Regex.Match(str, @"^[+]?(\([0-9]{1,3}\))?[-\s\./0-9]{9,12}$").Success;
            }

            private static string RemoveAccent(string str)
            {
                if (str == null)
                    return null;

                str = Regex.Replace(str, @"à|á|ạ|ả|ã|â|ầ|ấ|ậ|ẩ|ẫ|ă|ằ|ắ|ặ|ẳ|ẵ", "a");
                str = Regex.Replace(str, @"è|é|ẹ|ẻ|ẽ|ê|ề|ế|ệ|ể|ễ", "e");
                str = Regex.Replace(str, @"ì|í|ị|ỉ|ĩ", "i");
                str = Regex.Replace(str, @"ò|ó|ọ|ỏ|õ|ô|ồ|ố|ộ|ổ|ỗ|ơ|ờ|ớ|ợ|ở|ỡ", "o");
                str = Regex.Replace(str, @"ù|ú|ụ|ủ|ũ|ư|ừ|ứ|ự|ử|ữ", "u");
                str = Regex.Replace(str, @"ỳ|ý|ỵ|ỷ|ỹ", "y");
                str = Regex.Replace(str, @"đ/g", "d");

                return str;
            }
        }
    }
}
