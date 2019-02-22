using System;
using System.Collections.Generic;
using System.IO;
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
            string pathString = @"C:\Lab3\assa\new2\move.txt"; //new string variable that contains directory path
            Console.WriteLine("Path to my file: {0}\n", pathString); //writes on console a message and directory path 

            if (!File.Exists(pathString)) //condition for existense of a file
            {
                using (FileStream fs = File.Create(pathString)) //METHOD OF CREATING A FILE
                {
                    for (byte i = 0; i < 100; i++)// we give a size 
                    {
                        fs.WriteByte(i); //and write bytes by looping 
                    }
                }
            }
        }




        public static void CopyFile()
        {
            string sourcePath = @"C:\Lab3\assa\new2\move.txt"; //a variable that contains path of the file
            string finalPath = @"C:\Lab3\assa\new1\move.txt"; // a variable for giving final path
            File.Copy(sourcePath, finalPath, true); //copy the file from the source path to final path 
        }

        public static void DeleteFile()
        {
            
                    File.Delete(@"C:\Lab3\assa\new2\move.txt"); //then try to delete
               
        }
    }
}