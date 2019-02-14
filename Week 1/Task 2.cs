using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Lab1
{
    class Program
    {
        class Student  // create class Student
        {
            public string name;  //  the name of student 
            public string id;  //  id of student
            private int yearofstudy;  //  year of study
            public Student(string name, string id)  //  create constructer with two parameters
            {
                this.name = name;   //  input name     
                this.id = id;  //  input id        
            }
            public void Increment()  //  method to increment the year of study
            {
                yearofstudy++;
            }
            public int YearofStudy  // method to access private information "yearofstudy"
            {
                get
                {
                    return yearofstudy;
                }
                set
                {
                    yearofstudy = value;
                }
            }
            
        }
        static void Main(string[] args)
        {
            Student s = new Student("Akerke", "18BD110705");  //  create object of class 
            s.YearofStudy = 1;  //  by default year of study is equal to 1
            s.Increment();  //  after increment it is equal to 2
            Console.WriteLine(s.name+" "+s.id+" "+ s.YearofStudy);  //  show name, id and incremented year of study

        }
    }
}