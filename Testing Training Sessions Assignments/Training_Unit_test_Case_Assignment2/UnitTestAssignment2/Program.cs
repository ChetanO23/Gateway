using System;

namespace UnitTestAssignment2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // convert upper case
            string a = "chetan more";
            Console.WriteLine("----------------------");
            Console.WriteLine("Converted \"" + a + "\" into Uppercase : " + a.ConvertUpper());

            // convert lower case
            a = "CHETAN MORE";
            Console.WriteLine("-----------------------");
            Console.WriteLine("Converted \"" + a + "\" into Lowercase : " + a.ConvertLower());
            
            // convert into title case
            a = "chetan more";
            Console.WriteLine("------------------------");
            Console.WriteLine("Converted \"" + a + "\" into Titlecase : " + a.ConvertTitleCase());
            
            // isLower
            a = "chetanmore";
            Console.WriteLine("------------------------");
            Console.WriteLine("Checking if all the character of string are in lower case or not \"" + a + "\" : " + a.IsLower());
            
            // convert capitalize
            a = "chetan more";
            Console.WriteLine("-------------------------");
            Console.WriteLine("Converted \"" + a + "\" into Capitalize : " + a.ConvertCapitalize());
            
            // isUpper
            a = "CHETANMORE";
            Console.WriteLine("-------------------------");
            Console.WriteLine("Checking if all the character of string are in upper case or not \"" + a + "\" : " + a.IsUpper());
            
            // count number of words
            a = "chetan more";
            Console.WriteLine("-------------------------");
            Console.WriteLine("No of word in \"" + a + "\" : " + a.WordCount());
            
            // remove last character
            a = "Chetan More";
            Console.WriteLine("-------------------------");
            Console.WriteLine("After removing last char from string \"" + a + "\" : " + a.RemoveLastCharacter());

            // numeric valid
            string num = "333A";            
            if (num.ValidNumeric() == true)
                Console.WriteLine("\"" + num + "\" is valid numeric value");
            else
                Console.WriteLine("\"" + num + "\" is not valid numeric value");

            // string to number            
            if  (num.StringToNumber() == null)
                Console.WriteLine("\"" + num + "\" can not convert in numeric value");
            else
                Console.WriteLine("\"" + num + "\" numeric value is : " + num.StringToNumber());

            // inverse string
            string input = "Hello Chetan";
            string output = input.InverseString();
            Console.WriteLine("Inverse operation of :" + input + " : " + output);

            // isNumeric
            input = "23";
            output = input.IsNumeric();
            Console.WriteLine("IsNumeric:" + input + " : " + output);
            
            // isNumeric
            input = "hello chetan";
            output = input.IsNumeric();
            Console.WriteLine("IsNumeric:" + input + " : " +  output);

            // Read Key
            Console.ReadKey();
        }

    }
}
