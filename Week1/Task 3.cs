using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 0;
            int n = Convert.ToInt32(Console.ReadLine()); //reads input(number of elements in an array)
            string[] arr = Console.ReadLine().Split(); //reads as an elements of an array until the space
            string[] brr = new string[n * 2]; //new array to dublicate each element, that's why number of elements is twice of the initial array
            for (int i = 0; i < n; i++) //run through the each value of array
            {
                brr[m] = arr[i]; //first we equate brr array to the first arr array
                brr[m + 1] = arr[i]; //here we say that next element of brr array is also equal to present element of arr
                m = m + 2; //then we say that now m is equal to element passes two elements, as two of them we write as an dublicated
            }
            for (int i = 0; i < n * 2; i++) //run through elements of array brr
            {
                Console.Write(int.Parse(brr[i])); //show parsed elements of array brr 
                Console.Write(" "); //to make space between elements
            }
            Console.ReadKey(); //halt the program execution until pressing key

        }
    }
}