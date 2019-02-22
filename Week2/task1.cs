using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray(); //a method "ToCharArray" converts a string to character array
            Array.Reverse(charArray); //it reverses sequence of array elements 
            return new string(charArray); //returns reversed character array
        }
        static void Main(string[] args) //since it's static, we can call the function without instance of class, here a runtime state the execution.
        {
            FileStream fs = new FileStream(@"C:\lab2\abba.txt", FileMode.Open, FileAccess.ReadWrite);//it opens Filestream of shown path with the specified mode and gets acces to read or write on document
            StreamReader sr = new StreamReader(fs);  //Initializes a new sample of the StreamReader
            string st1 = sr.ReadLine(); //reads the string 
            string st2 = Reverse(st1); //reverses the string

            if (st1 == st2)//if initial string and reversed strings are the same
                Console.WriteLine("Yes"); //shows message "Yes"
            else Console.WriteLine("No"); // else shows "No"

            Console.ReadKey(); //halt the program execution until pressing key
        }
    }
}