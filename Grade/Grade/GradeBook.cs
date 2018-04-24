using System;
using System.Collections.Generic;

namespace Grade
{
    public class GradeBook
    {   
        public GradeBook()
        {
            grades= new List<float>();
        }


        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            // whats the highest grade i have seen so far


            float sum = 0;

            foreach(float grade in grades)
            {    //one way, also math 
                //if(grade>stats.HighestGrade)
                //{
                //    stats.HighestGrade = grade;
                //}
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);

                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);

                //sum = sum + grade;
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }



        public void AddGrade(float grade)  //this is a method
        {
            grades.Add(grade); //this is a field called grades

        }


        //ability to have a name

        //public class starts with Caps
        //private class starts with small letter

        public string Name;

        private List<float> grades;  //lowercase due to private
        
    }
}
