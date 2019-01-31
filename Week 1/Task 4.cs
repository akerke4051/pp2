using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); //converts string to int and reads the number
            int[,] a = new int[n, n]; //declare two dimensional array a as an integer
            for (int i = 1; i <= n; i++) //run through the rows from 1 to number of elements n
            {
                for (int j = 1; j <= i; j++) //run through the columns that is started from one to actual number of row
                {
         
                    
                    Console.Write("[*]"); //write "[*]"

                }
                Console.WriteLine(); //we need line between 


            }
            Console.ReadKey(); //halt the program execution until pressing key
        }
    }
}
