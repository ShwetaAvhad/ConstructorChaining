using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    public class Person
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public int PersonAge { get; set; }
        public float PersonHeight { get; set; }
        public float PersonWeight { get; set; }
        public double PersonBMI;
        public const float MIN_HEIGHT = 5;
        public const float MIN_WEIGHT = 50;
        public Person(int personId, string personName, int personAge)
        {
            PersonId = personId;
            PersonName = personName;
            PersonAge = personAge;
            if (PersonHeight < MIN_HEIGHT)
            {
                PersonHeight = MIN_HEIGHT;
            }
            if (PersonWeight < MIN_WEIGHT)
            {
                PersonWeight = MIN_WEIGHT;
            }
        }
        public Person(int personId, string personName, int personAge, float personHeight, float personWeight) 
                    : this(personId, personName, personAge)
        {
            PersonHeight = personHeight;
            PersonWeight = personWeight;
        }
        public double CalculateBMIScore(float personHeight, float personWeight)
        {
            double heightInMeters = personHeight * 0.3048;
            double bmiScore = personWeight / (heightInMeters * heightInMeters);
            PersonBMI = bmiScore;
            return PersonBMI;
        }
        public string BodyTypeBasedOnBMI(double bmiscore)
        {
            string result = "";
            if (bmiscore > 17 && bmiscore< 18.4)
            {
                result="UnderWeight";
            }
            else if (bmiscore > 18.5 && bmiscore < 24.9)
            {
                result="Normal";
            }
            else if (bmiscore > 25 && bmiscore < 29.9)
            {
                result="OverWeight";
            }
            else
            {
                result="Obese";
            }
            return result;
        }
        public override string ToString()
        {
            return $"Person Id : {PersonId}\n" +
                   $"Person Name : {PersonName}\n" +
                   $"Person Age : {PersonAge}\n" +
                   $"Person Height : {PersonHeight}\n" +
                   $"Person Weight : {PersonWeight}";                   
        }
    }
    }
