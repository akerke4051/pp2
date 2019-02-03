using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student A = new Student("Aigerim", "18BD110864"); //create Student A with keyword "new" with given name and id number
            Console.WriteLine(A.getname()); //returns name of student A and display this name to the console
            Console.WriteLine(A.getid());//returns id of student A and display this id to the console
            Console.ReadKey(); //pausing after execution of the program
        }
    }

    public class Student //create public class Student so anyone can have an access
    {
        private String name;// creating private name type of string
        private String id;// creating private id with string type
        private int yearOfStudy;// creating private yearOfStudy of type integer

        public Student(String name, String id) //creating an constructor with two parameters name and id of Student
        {
            this.name = name;//given name shows the input parameter
            this.id = id;//
            this.yearOfStudy = 0;//at the beginning equal to 0
        }

        public String getname()//returns the first parameter of the constructor Student
        {
            return this.name;
        }
        public String getid()//returns the second parameter of the constructor Student
        {
            return this.id;
        }
        public void setname()//changes this name to the new name
        {
            this.name = name;
        }
        public void setid()//changes this id to the new id
        {
            this.id = id;
        }

        public void incrementOfYear()//increments the year of study
        {
            this.yearOfStudy++;
        }
    }
}