using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{    
    public class Program
    {
        public static void PrintDetails(Person person)
        {
            Console.WriteLine(person);
            double bmiScore1 = person.CalculateBMIScore(person.PersonHeight, person.PersonWeight);
            Console.WriteLine("BMI Score : "+bmiScore1);
            string bodyType = person.BodyTypeBasedOnBMI(bmiScore1);
            Console.WriteLine("Body Type : "+bodyType);
        }
        static void Main(string[] args)
        {
            Person[] person1 = { new Person(1, "Ram", 18),
                                 new Person(2, "Shyam", 20,8,30),
                                 new Person(3,"Sachin",22,4,40),
                                 new Person(4,"Akshay",17,9,45)};

            foreach(Person person2 in person1)
            {
                PrintDetails(person2);
                Console.WriteLine();
            }

            double maximumBMI = 0;
            Person person3 = null;
            foreach(Person person in person1)
            {
                if (person.PersonBMI>maximumBMI)
                {
                    maximumBMI = person.PersonBMI;
                    person3= person;
                }
            }           
            Console.WriteLine("Person Having Maximum BMI : ");
            PrintDetails(person3);
            Console.WriteLine();         

        }
    }
}

