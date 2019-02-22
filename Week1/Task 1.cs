using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args) //function to print prime numbers and its  count
        {
           
            int mm = 0; //counter of prime numbers in an array
            int n = Convert.ToInt32(Console.ReadLine()); //converts string to integer and reads input(number of elements in an array)
            string[] arr = Console.ReadLine().Split(); //reads as an elements of an array splitted by the space
            for (int i = 0; i < n; i++) //get each value of the array
            {
                int m = 0; //counter for dividers of particular element of an array, it's needed to identify whether the number is prime or not 
                for (int j = 2; j <= int.Parse(arr[i]); j++)  //second array is called until the each element of array that is converted from string to int
                {
                    if (int.Parse(arr[i]) % j == 0) //it recognises whether the dividers of the number is only one or no
                    {
                        m++; // if divider of an element is only one, then it counts
                    }
                }
                if (m == 1) //if divider of an element is equal to one, it means that it's prime number
                {
                    mm++; //so here it finds out count of prime numbers in an array
                }

            }

            Console.WriteLine(mm); //output cnt of prime numbers in an array


            for (int i = 0; i < n; i++) //here it is again run over to show prime elements 
            {
                int m = 0; //here we equate number of dividers of each element to 0

                for (int j = 2; j <= int.Parse(arr[i]); j++) //we again run over second array 
                {
                    if (int.Parse(arr[i]) % j == 0)  //if i's element divided by second array element j's is equal to 0
                    {
                        m++; //then count these dividers 
                    }
                }

                if (m == 1) //if number of dividers is equal to 1, then it means that it's prime number
                {
                    Console.Write(int.Parse(arr[i])); //outputs prime elements after parsing 
                    Console.Write(" "); //to make space between elements
                }


            }

            Console.ReadKey(); //halt the program execution until pressing key


        }
    }
}