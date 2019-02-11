using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4lab2
{
    class Program
    {

        public static void Main(string[] args)
        {
            CreateFile();//function is created
            CopyFile();//function is created
            DeleteFile();//function is created
        }


        static void CreateFile()
        {
            string pathString = @"C:\task4lab2\first\File.txt"; //new string variable that contains directory path
            Console.WriteLine("Path to my file: {0}\n", pathString); //writes on console a message and directory path 

            if (!System.IO.File.Exists(pathString)) //condition for existense of a file
            {
                using (System.IO.FileStream fs = System.IO.File.Create(pathString)) //METHOD OF CREATING A FILE
                {
                    for (byte i = 0; i < 100; i++)// we give a size 
                    {
                        fs.WriteByte(i); //and write bytes by looping 
                    }
                }
            }
            try
            {
                byte[] readBuffer = System.IO.File.ReadAllBytes(pathString);  
                foreach (byte b in readBuffer) 
                {
                    Console.Write(b + " ");
                }
                Console.WriteLine();
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.Message); //in the case of input output error show message 
            }
            CopyFile();
            System.Console.WriteLine("Press any key to exit."); 
            System.Console.ReadKey(); //exits if any key is pressed 
        }




        public static void CopyFile()
        {
            string sourcePath = @"C:\task4lab2\first\File.txt"; //a variable that contains path of the file
            string finalPath = @"C:\task4lab2\second\File.txt"; // a variable for giving final path
            System.IO.File.Copy(sourcePath, finalPath, true); //copy the file from the source path to final path 
        }

        public static void DeleteFile()
        {
            if (System.IO.File.Exists(@"C:\task4lab2\first\File.txt")) //if the file exists
            {
                try
                {
                    System.IO.File.Delete(@"C:\task4lab2\first\File.txt"); //then try to delete
                }
                catch (System.IO.IOException e)
                {
                    Console.WriteLine(e.Message); //otherwise show an exception
                    return;
                }
            }
        }
    }
}