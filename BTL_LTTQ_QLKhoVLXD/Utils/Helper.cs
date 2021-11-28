using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SortOrder = System.Data.SqlClient.SortOrder;

namespace BTL_LTTQ_QLKhoVLXD.Utils
{
    public class Helper
    {
        public class Validate
        {
            public static bool Name(string str)
            {
                return !string.IsNullOrEmpty(str) &&
                    Regex.Match(Normalize.ToLatinText(str), "^[a-zA-Z]+((['. -][a-zA-Z ])?[a-zA-Z]*)*$", RegexOptions.IgnoreCase).Success;
            }

            public static bool PhoneNumber(string str)
            {
                return !string.IsNullOrEmpty(str) &&
                    Regex.Match(str, @"^[+]?(\([0-9]{1,3}\))?[-\s\./0-9]{9,12}$").Success;
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
                if (DateTime.TryParse(a.SubItems[Column].Text, out var dt1) &&
                    DateTime.TryParse(b.SubItems[Column].Text, out var dt2))
                    return CheckInvert(DateTime.Compare(dt1, dt2));

                // Numeric Comparison
                if (decimal.TryParse(a.SubItems[Column].Text, out var n1) &&
                    decimal.TryParse(b.SubItems[Column].Text, out var n2))
                    return CheckInvert(decimal.Compare(n1, n2));

                // ToString Comparison
                return CheckInvert(Comparer.String(
                    a.SubItems[Column].Text,
                    b.SubItems[Column].Text)
                );
            }

            private int CheckInvert(int result)
            {
                if (Order == SortOrder.Descending)
                    result *= -1;
                return result;
            }
        }

        public class Debounce
        {
            private readonly Timer _timer = new Timer();
            private readonly Action _updateAction;
            private bool _canUpdate;
            private bool _needUpdate;

            public Debounce(Action updateAction, int interval = 300, bool startNow = true)
            {
                _updateAction = updateAction;
                _timer.Tick += TimerTick;
                _timer.Interval = interval;
                _needUpdate = startNow;
            }

            public void HandleUpdate()
            {
                if (!_needUpdate)
                    return;

                if (_canUpdate)
                {
                    _canUpdate = false;
                    _updateAction();
                }
                else
                    ResetTimer();
            }

            public void Pause()
            {
                _needUpdate = false;
            }

            public void Continue()
            {
                _needUpdate = true;
            }

            public void Dispose()
            {
                _timer.Stop();
                _timer.Dispose();
            }

            private void ResetTimer()
            {
                _timer.Stop();
                _canUpdate = false;
                _timer.Start();
            }

            private void TimerTick(object sender, EventArgs e)
            {
                _canUpdate = true;
                _timer.Stop();
                _updateAction();
            }
        }

        public class Normalize
        {
            public static string ToNumericPhoneNumber(string phoneNumber)
            {
                return new string(phoneNumber.Where(char.IsDigit).ToArray());
            }

            public static string ToLatinText(string text)
            {
                if (text == null)
                    return null;

                text = Regex.Replace(text, "à|á|ạ|ả|ã|â|ầ|ấ|ậ|ẩ|ẫ|ă|ằ|ắ|ặ|ẳ|ẵ", "a");
                text = Regex.Replace(text, "è|é|ẹ|ẻ|ẽ|ê|ề|ế|ệ|ể|ễ", "e");
                text = Regex.Replace(text, "ì|í|ị|ỉ|ĩ", "i");
                text = Regex.Replace(text, "ò|ó|ọ|ỏ|õ|ô|ồ|ố|ộ|ổ|ỗ|ơ|ờ|ớ|ợ|ở|ỡ", "o");
                text = Regex.Replace(text, "ù|ú|ụ|ủ|ũ|ư|ừ|ứ|ự|ử|ữ", "u");
                text = Regex.Replace(text, "ỳ|ý|ỵ|ỷ|ỹ", "y");
                text = Regex.Replace(text, "đ", "d");

                text = Regex.Replace(text, "À|Á|Ạ|Ả|Ã|Â|Ầ|Ấ|Ậ|Ẩ|Ẫ|Ă|Ằ|Ắ|Ặ|Ẳ|Ẵ", "A");
                text = Regex.Replace(text, "È|É|Ẹ|Ẻ|Ẽ|Ê|Ề|Ế|Ệ|Ể|Ễ", "E");
                text = Regex.Replace(text, "Ì|Í|Ị|Ỉ|Ĩ", "I");
                text = Regex.Replace(text, "Ò|Ó|Ọ|Ỏ|Õ|Ô|Ồ|Ố|Ộ|Ổ|Ỗ|Ơ|Ờ|Ớ|Ợ|Ở|Ỡ", "O");
                text = Regex.Replace(text, "Ù|Ú|Ụ|Ủ|Ũ|Ư|Ừ|Ứ|Ự|Ử|Ữ", "U");
                text = Regex.Replace(text, "Ỳ|Ý|Ỵ|Ỷ|Ỹ", "Y");
                text = Regex.Replace(text, "Đ", "D");

                return text;
            }
        }

        public class Control
        {
            public class Filter
            {
                public static List<CheckBox> GetCheckBoxes(System.Windows.Forms.Control control)
                {
                    return control != null ? control.Controls.OfType<CheckBox>().ToList() : new List<CheckBox>();
                }

                public static List<RadioButton> GetRadioButtons(System.Windows.Forms.Control control)
                {
                    return control != null ? control.Controls.OfType<RadioButton>().ToList() : new List<RadioButton>();
                }
            }

            public static T FirstSelected<T>(List<T> dataList, ListView listView)
            {
                if (listView.SelectedIndices.Count <= 0)
                    return default;

                // Edit only first selected item
                var firstIndex = listView.SelectedIndices[0];
                var firstItem = dataList[firstIndex];

                return firstItem;
            }
        }

        public class Mapper
        {
            public static List<T> MapArrayOfObject<T>(DataTable data, Func<DataRow, T> parser)
            {
                var result = new List<T>();
                for (var i = 0; i < data.Rows.Count; i++)
                    result.Add(parser(data.Rows[i]));
                return result;
            }

            public static List<T> MapArrayOfObjectProperty<T>(DataTable data, string property, Func<object, T> converter)
            {
                var result = new List<T>();
                for (var i = 0; i < data.Rows.Count; i++)
                    result.Add(converter(data.Rows[i][property]));
                return result;
            }
        }

        public class Comparer
        {
            public static int String(string strA, string strB)
            {
                return string.Compare(
                    strA,
                    strB,
                    CultureInfo.CurrentCulture,
                    CompareOptions.IgnoreCase
                );
            }
        }

        public class Matcher
        {
            public static bool Match(string sourceText, string text, bool checkLatinText = true)
            {
                if (!checkLatinText)
                    return CheckMatch(sourceText, text);

                sourceText = Normalize.ToLatinText(sourceText);
                text = Normalize.ToLatinText(text);

                return CheckMatch(sourceText, text);
            }

            public static bool Match(List<string> sourceTextList, string text)
            {
                return string.IsNullOrEmpty(text) ||
                    sourceTextList.FirstOrDefault(p => Normalize.ToNumericPhoneNumber(p)
                       .Contains(Normalize.ToNumericPhoneNumber(text))) != null;
            }

            public static bool Match(DateTime from, DateTime to, DateTime dt)
            {
                return from <= dt && dt <= to;
            }

            private static bool CheckMatch(string sourceText, string text)
            {
                return string.IsNullOrEmpty(text) || sourceText.ToLower().Contains(text.ToLower());
            }
        }

        public class Converter
        {
            public static string ToString(double number)
            {
                return number.ToString("N0");
            }

            public static string ToString(DateTime dateTime)
            {
                return dateTime.ToString("dd/MM/yyyy HH:mm:ss");
            }
        }
    }
}
