using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    /// <summary>
    /// Container for methods
    /// </summary>
    internal class Helper
    {

        /// <summary>
        /// Return a string without last item
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string DeleteLast(string str)
        {
            if (str.Length == 0)
            {
                return string.Empty;
            }

            char[] temp = new char[str.Length - 1];
            for (int i = 0; i < str.Length - 1; i++)
            {
                temp[i] = str[i];
            }
            str = new string(temp);
            return str;
        }

        /// <summary>
        /// Delete first item in input
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string DeleteFirst(string str)
        {
            if (str.Length == 0)
            {
                return string.Empty;
            }

            char[] temp = new char[str.Length-1];
            for (int i = 1; i < str.Length; i++)
            {
                temp[i-1] = str[i];
            }
            str = new string(temp);
            return str;
        }


        /// <summary>
        /// Return a string with result
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Result(string input) 
        {
            if (input == string.Empty)
            {
                return string.Empty;
            }

            string[] digits = null;
            double[] arrDigits = null;

            if (input[0] != '-')
            {
                digits = input.Split('+', '-', '*', '/', '^', '`');
                arrDigits = new double[digits.Length];
                for (int i = 0; i < arrDigits.Length; i++)
                {
                    try
                    {
                        arrDigits[i] = double.Parse(digits[i]);
                    }
                    catch (Exception)
                    {
                        return " 000Invalid input";
                    }

                }
            }
            else if (input[0] == '-') 
            {
                input = DeleteFirst(input);
                digits = input.Split('+', '-', '*', '/', '^', '`');
                arrDigits = new double[digits.Length];

                arrDigits[0] = double.Parse(digits[0]) - 2 * double.Parse(digits[0]);
                for (int i = 1; i < arrDigits.Length; i++)
                {
                    try
                    {
                        arrDigits[i] = double.Parse(digits[i]);
                    }
                    catch (Exception)
                    {
                        return " 123Invalid input";
                    }
                }                
            }



            string sign = string.Empty;
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == '+' || input[i] == '-' || input[i] == '*' || input[i] == '/' || input[i] == '^' || input[i] == '`')
                {
                    sign += input[i];
                }
            }

            for (int i = 0; i < sign.Length; i++)
            {
                if (sign[i] == '^')
                {
                    arrRemove(ref arrDigits, i, "explonation");
                    strRemove(ref sign, i);
                    i--;
                }
                else if (sign[i] == '`')
                {
                    arrRemove(ref arrDigits, i, "ReverseExplonation");
                    strRemove(ref sign, i);
                    i--;
                }
            }
            for (int i = 0; i < sign.Length; i++)
            {
                if (sign[i] == '*')
                {
                    arrRemove(ref arrDigits, i, "multiply");
                    strRemove(ref sign, i);
                    i--;
                }
                else if (sign[i] == '/')
                {
                    arrRemove(ref arrDigits, i, "divide");
                    strRemove(ref sign, i);
                    i--;
                }
            }

            for (int i = 0; i < sign.Length; i++)
            {
                if (sign[i] == '+')
                {
                    arrDigits[0] = arrDigits[0] + arrDigits[i + 1];
                }
                else if (sign[i] == '-')
                {
                    arrDigits[0] = arrDigits[0] - arrDigits[i + 1];
                }
            }

            string answer = Convert.ToString(arrDigits[0]);
            return answer;
        }


        /// <summary>
        /// Remove one item in arrDigits
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="index"></param>
        /// <param name="action"></param>
        static void arrRemove(ref double[] arr, int index, string action)
        {
            double[] newarr = new double[arr.Length - 1];
            for (int i = 0; i < index; i++)
            {
                newarr[i] = arr[i];
            }

            if (action == "multiply")
            {
                newarr[index] = arr[index] * arr[index + 1];
            }

            if (action == "divide")
            {
                try
                {
                    newarr[index] = arr[index] / arr[index + 1];
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot divide by zero");
                }
            }

            if (action == "explonation")
            {
                newarr[index] = Math.Pow(arr[index], arr[index + 1]);
            }
            if (action == "ReverseExplonation")
            {
                newarr[index] = Math.Pow(arr[index], -arr[index + 1]);
            }

            for (int i = index + 1; i < newarr.Length; i++)
            {
                newarr[i] = arr[i + 1];
            }
            arr = newarr;
        }

        /// <summary>
        /// Remove one item in sign
        /// </summary>
        /// <param name="sign"></param>
        /// <param name="index"></param>
        static void strRemove(ref string sign, int index)
        {
            char[] temp = new char[sign.Length - 1];
            for (int i = 0; i < index; i++)
            {
                temp[i] = sign[i];
            }
            for (int i = index; i < temp.Length; i++)
            {
                temp[i] = sign[i + 1];
            }
            sign = new string(temp);
        }
    }
}
