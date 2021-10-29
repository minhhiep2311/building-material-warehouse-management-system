using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SortOrder = System.Data.SqlClient.SortOrder;

namespace BTL_LTTQ_QLKhoVLXD.Utils
{
    internal class Helper
    {
        public class RegexValidate
        {
            public static bool Name(string str)
            {
                return Regex.Match(RemoveAccent(str), "^[a-zA-Z]+((['. -][a-zA-Z ])?[a-zA-Z]*)*$", RegexOptions.IgnoreCase).Success;
            }

            public static bool PhoneNumber(string str)
            {
                return Regex.Match(str, @"^[+]?(\([0-9]{1,3}\))?[-\s\./0-9]{9,12}$").Success;
            }

            private static string RemoveAccent(string str)
            {
                if (str == null)
                    return null;

                str = Regex.Replace(str, "à|á|ạ|ả|ã|â|ầ|ấ|ậ|ẩ|ẫ|ă|ằ|ắ|ặ|ẳ|ẵ", "a");
                str = Regex.Replace(str, "è|é|ẹ|ẻ|ẽ|ê|ề|ế|ệ|ể|ễ", "e");
                str = Regex.Replace(str, "ì|í|ị|ỉ|ĩ", "i");
                str = Regex.Replace(str, "ò|ó|ọ|ỏ|õ|ô|ồ|ố|ộ|ổ|ỗ|ơ|ờ|ớ|ợ|ở|ỡ", "o");
                str = Regex.Replace(str, "ù|ú|ụ|ủ|ũ|ư|ừ|ứ|ự|ử|ữ", "u");
                str = Regex.Replace(str, "ỳ|ý|ỵ|ỷ|ỹ", "y");
                str = Regex.Replace(str, "đ/g", "d");

                return str;
            }
        }

        public class List
        {
            public static bool AreEqual<T>(List<T> l1, List<T> l2)
            {
                var (item1, item2) = Difference(l1, l2);
                return item1.Count == 0 && item2.Count == 0;
            }

            public static Tuple<List<T>, List<T>> Difference<T>(List<T> l1, List<T> l2)
            {
                var firstNotSecond = l1.Except(l2).ToList();
                var secondNotFirst = l2.Except(l1).ToList();
                return Tuple.Create(firstNotSecond, secondNotFirst);
            }
        }

        public class ItemComparer : IComparer
        {
            public int Column { get; set; }
            public SortOrder Order { get; set; }

            public ItemComparer(int columnIndex)
            {
                Column = columnIndex;
                Order = SortOrder.Unspecified;
            }

            public int Compare(object x, object y)
            {
                var a = x as ListViewItem;
                var b = y as ListViewItem;

                if (a == null && b == null) 
                    return CheckInvert(0);
                if (a == null)
                    return CheckInvert(-1);
                if (b == null)
                    return CheckInvert(1);

                // Datetime Comparison
                if (System.DateTime.TryParse(a.SubItems[Column].Text, out var dt1) &&
                    System.DateTime.TryParse(b.SubItems[Column].Text, out var dt2))
                    return CheckInvert(System.DateTime.Compare(dt1, dt2));

                // Numeric Comparison
                if (decimal.TryParse(a.SubItems[Column].Text, out var n1) &&
                    decimal.TryParse(b.SubItems[Column].Text, out var n2))
                    return CheckInvert(decimal.Compare(n1, n2));

                // String Comparison
                return CheckInvert(string.CompareOrdinal(a.SubItems[Column].Text, b.SubItems[Column].Text));

            }

            private int CheckInvert(int result)
            {
                if (Order == SortOrder.Descending)
                    result *= -1;
                return result;
            }
        }

        public class Character
        {
            public static readonly string UpArrow = "▲";
            public static readonly string DownArrow = "▼";
        }

        public class DateTime
        {
            public static readonly string DateFormat = "dd-MM-yyyy";
        }
    }
}
