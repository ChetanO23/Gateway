using System;

namespace UnitTestAssignment2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string a = "chetan more";
            Console.WriteLine("----------------------");
            Console.WriteLine("Converted \"" + a + "\" into Uppercase : " + a.ConvertUpper());

            a = "CHETAN MORE";
            Console.WriteLine("-----------------------");
            Console.WriteLine("Converted \"" + a + "\" into Lowercase : " + a.ConvertLower());
            
            a = "chetan more";
            Console.WriteLine("------------------------");
            Console.WriteLine("Converted \"" + a + "\" into Titlecase : " + a.ConvertTitleCase());
            
            a = "chetanmore";
            Console.WriteLine("------------------------");
            Console.WriteLine("Checking if all the character of string are in lower case or not \"" + a + "\" : " + a.IsLower());
            
            a = "chetan more";
            Console.WriteLine("-------------------------");
            Console.WriteLine("Converted \"" + a + "\" into Capitalize : " + a.ConvertCapitalize());
            
            a = "CHETANMORE";
            Console.WriteLine("-------------------------");
            Console.WriteLine("Checking if all the character of string are in upper case or not \"" + a + "\" : " + a.IsUpper());
            
            a = "chetan more";
            Console.WriteLine("-------------------------");
            Console.WriteLine("No of word in \"" + a + "\" : " + a.WordCount());
            
            a = "Chetan More";
            Console.WriteLine("-------------------------");
            Console.WriteLine("After removing last char from string \"" + a + "\" : " + a.RemoveLastCharacter());
            
            string num = "333A";
            
            Console.WriteLine("-------------------------------");
            
            if (num.ValidNumeric() == true)
                Console.WriteLine("\"" + num + "\" is not valid numeric value");
            else
                Console.WriteLine("\"" + num + "\" is not valid numeric value");
            
            Console.WriteLine("--------------------------------------------");
            
            if  (num.StringToNumber() == null)
                Console.WriteLine("\"" + num + "\" can not convert in numeric value");
            else
                Console.WriteLine("\"" + num + "\" numeric value is : " + num.StringToNumber());
            
        }
    }
}
