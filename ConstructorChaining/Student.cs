using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChaining
{
    internal class Student
    {
        public int studentId;
        public string studentName;
        public string studentBranch;
        public int studentAge;        
        public float studentHeight;
        public float studentWeight;
        public const int MIN_AGE = 10;
        public const int MIN_HEIGHT = 5;
                
        public Student(int studentId, string studentName, string studentBranch)
        {
            this.studentId = studentId;
            this.studentName = studentName;
            this.studentBranch = studentBranch;  
            if(studentAge<MIN_AGE)
            {
                studentAge = MIN_AGE;
            }
            if (studentHeight < MIN_HEIGHT)
            {
                studentHeight= MIN_HEIGHT;
            }
        }
        public Student(int studentId, string studentName, string studentBranch, int studentAge, float studentHeight) : this(studentId, studentName, studentBranch)
        {
            if (studentAge < MIN_AGE)
                studentAge = MIN_AGE;
            else
                this.studentAge = studentAge;

            if(studentHeight < MIN_HEIGHT)
                studentHeight = MIN_HEIGHT;
            else
                this.studentHeight = studentHeight;
        }
        public string Print()
        {
            return $"Student ID : {studentId}\n" +
                   $"Student Name : {studentName}\n" +
                   $"Student Branch : {studentBranch}\n" +
                   $"Student Age : {studentAge}\n" +
                   $"Student Height : {studentHeight}\n";                   
        }
    }
}
