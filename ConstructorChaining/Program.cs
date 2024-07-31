using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChaining
{
    internal class Program
    {
        public static void PrintDetails(Student student)
        {
            Console.WriteLine(student.Print());
        }
        static void Main(string[] args)
        {            
            Student student1 = new Student(1,"Ram","Computer");
            Student student2 = new Student(2,"Shyam","Mechanical",16,4);
            Student student3 = new Student(3,"Akshay","IT",6,8);

            PrintDetails(student1);
            PrintDetails(student2);
            PrintDetails(student3);

        }
    }
}
