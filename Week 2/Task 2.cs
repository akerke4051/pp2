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
            String s = sr.ReadToEnd(); //stream is readed by the end
            String[] arr = s.Split(); //array elements are seperated by space
            string primenum = ""; //string variable is empty

            foreach (String a in arr) //traversing through an array.
            {
                int m = 0; //here we equate number of dividers of each element to 0

                for (int j = 2; j <= int.Parse(a); j++) //we again run over second array 
                {
                    if (int.Parse(a) % j == 0)  //if i's element divided by second array element j's is equal to 0
                    {
                        m++; //then count these dividers 
                    }

                }
                
                if (m == 1) //if number of dividers is equal to 1, then it means that it's prime number
                {

                    primenum = primenum + int.Parse(a) + " "; //variable primenum is equal to an element of array that is prime
                    
                }

            }
            
            sr.Close();  //it closes the stream

            StreamWriter sw = new StreamWriter(@"C:\lab2\1\output.txt"); //preparing a stream to save in new file
            sw.WriteLine(primenum); //write a line consisted of prime numbers 
            sw.Close(); //close the stream 
        }
    }
}
