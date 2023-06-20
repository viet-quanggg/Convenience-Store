using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Convenience_Store
{
    public class UtilsMerchandise
    {
        public static bool CheckValidString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please not null !", "Notification", MessageBoxButtons.OK);
                return false;
            }

            bool containsLetter = false;
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    containsLetter = true;
                    break;
                }

                if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
                {
                    return false; // Ký tự không hợp lệ
                }
            }
            // Kiểm tra xem chuỗi có chứa ký tự đặc biệt hay không
            if (!containsLetter)
            {
                return false;
            }

            // Kiểm tra chuỗi có chứa ký tự đặc biệt
            string pattern = @"[~`!@#$%^&*()\-+=\[\]{};:'""<>?/\\|]";
            if (Regex.IsMatch(input, pattern))
            {
                return false; // Chuỗi chứa ký tự đặc biệt
            }

            return true;
        }
        public static bool CheckValidDouble(string input, out double result)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("It's null, please enter double value ", "Notification", MessageBoxButtons.OK);
                result = 0.0; // Giá trị mặc định nếu kiểm tra không thành công
                return false;
            }

            if (double.TryParse(input, out result))
            {
                return true; // Giá trị nhập vào là số và đã được gán vào biến "result"
            }
            else return false;
        }
        public static bool CheckInt(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please not null !", "Notification", MessageBoxButtons.OK);
                return false;
            }
            int result;
            return int.TryParse(input, out result);
        }
        public static bool CheckNumberOnly(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please not null !", "Notification", MessageBoxButtons.OK);
                return false;
            }
            int number;
            return int.TryParse(input, out number);
        }
    }
}
