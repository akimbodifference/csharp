using System;
namespace Grade
{
    public class GradeStatistics
    { 
        public GradeStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;


        }
        //use public access modifier in frnt of these fields to get accessed from 
        //main class

        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;
    }
}
