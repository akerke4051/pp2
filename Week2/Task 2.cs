using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader sr = new StreamReader(@"C:\lab2\1\input.txt"); //reads stream from the given path file
            String s = sr.ReadToEnd();
            string[] arr=Console.ReadLine().Split()
                string primenum = "";
                foreach(string a in arr)
            {
                for (int j=2;j<=int.Parse(a)
                    {
                    if()
                }
            }
            sr.Close();  //it closes the stream

            StreamWriter sw = new StreamWriter(@"C:\lab2\1\output.txt"); //preparing a stream to save in new file
            sw.WriteLine(primenum); //write a line consisted of prime numbers 
            sw.Close(); //close the stream 
        }
    }
}