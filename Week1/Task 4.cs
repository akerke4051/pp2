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
           for (int i=1;i<=n;i++)
            {
                for (int j=1;j<=i;j++)
                {
                    Console.WriteLine("[*]");
                }
                Console.WriteLine();
            }
            Console.ReadKey(); //halt the program execution until pressing key
        }
    }
}