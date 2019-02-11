using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args) //we need a main method from where a runtime state the execution
        {
            F3(); //call the function
        }

        private static void PrintInfo(FileSystemInfo fsi, int k)

        {
            string line = new string(' ', k); //is needed for putting space before into-folders
            line = line + fsi.Name; // line is equal to spaces written according to level of folder and its name
            Console.WriteLine(line);//shows line 

            if (fsi.GetType() == typeof(DirectoryInfo)) //if type of the object is folder then show the content 
            {
                var items = (fsi as DirectoryInfo).GetFileSystemInfos();
                foreach (var i in items) //loop 
                {
                    PrintInfo(i, k + 5);
                }
            }
        }

        private static void F3()
        {
            var dir = new DirectoryInfo(@"C:\Users\Akerke\Desktop\history");
            PrintInfo(dir, 0);
            Console.ReadKey();
        }
    }
}