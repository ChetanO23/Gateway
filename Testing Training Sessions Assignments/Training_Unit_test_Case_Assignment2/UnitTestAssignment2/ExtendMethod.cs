using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace UnitTestAssignment2
{
    public static class ExtendMethod
    {
        // this method count the number of words
        public static int WordCount(this string a)
        {
            int b = 0, myWord = 1;
            while (b <= a.Length - 1)
            {
                if (a[b] == ' ' || a[b] == '\n' || a[b] == '\t')
                {
                    myWord++;
                }
                b++;
            }
            return myWord;
        }
       
        // this method convert string into lower case
        public static string ConvertLower(this string a)
        {
            return a.ToLower();
        }

        // this method convert string into upper case
        public static string ConvertUpper(this string a)
        {
            return a.ToUpper();
        }

        // this method checks whether the input string is in lower case or not
        public static bool IsLower(this string a)
        {
            string Mystring = a;
            char[] chars;
            char ch;
            int length = Mystring.Length;
            int cnt;
            int totalcntlower = 0;

            chars = Mystring.ToCharArray(0, length);
            for (cnt = 0; cnt < length; cnt++)
            {
                ch = chars[cnt];
                if (char.IsLower(ch))
                {
                    totalcntlower++;
                }
            }
            if(totalcntlower == length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // this method checks whether the given string is in upper case or not
        public static bool IsUpper(this string a)
        {
            string Mystring = a;
            char[] chars;
            char ch;
            int length = Mystring.Length;
            int cnt;
            int totalcntupper = 0;

            chars = Mystring.ToCharArray(0, length);
            for (cnt = 0; cnt < length; cnt++)
            {
                ch = chars[cnt];
                if (char.IsUpper(ch))
                {
                    totalcntupper++;
                }
            }
            if (totalcntupper == length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // this method convert input string into capitalizes string
        public static string ConvertCapitalize(this string a)
        {
            return char.ToUpper(a[0]) + a.Substring(1);
        }

        // this method converts the input string into title string
        public static string ConvertTitleCase(this string a)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(a);
        }

        // this methods removes the last characted from the input string
        public static string RemoveLastCharacter(this string a)
        {
            return a.Remove(a.Length - 1, 1);
        }

        // this method check Numeric is valid or not
        public static bool ValidNumeric(this string a)
        {
            int number1 = 0;
            return int.TryParse(a, out number1);
        }

        // this method convert input string into number
        public static int? StringToNumber(this string a)
        {
            if (a.ValidNumeric())
            {
                return int.Parse(a);
            }
            else
                return null;
        }



        // this method inverses the input string
        public static string InverseString(this string input)
        {
            string output = "";
            int ascii;
            foreach (char ch in input)
            {
                ascii = (int)ch;
                if (ascii >= 65 && ascii <= 90)
                    ascii += 32;
                else if (ascii >= 97 && ascii <= 122)
                    ascii -= 32;
                output += (char)ascii;
            }
            return output;
        }

        // this method checks whether the given string is an number or not
        public static string IsNumeric(this string input)
        {
            bool isNumeric = true;
            foreach (char ch in input)
            {
                if (ch <= '0' || ch >= '9')
                {
                    isNumeric = false;
                    break;
                }
            }
            return isNumeric ? "yes" : "no";
        }


    }
}
