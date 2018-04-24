using System;

namespace Grade
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            //create two gradebooks
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1 = new GradeBook();
            g1.Name = "Ikram's grade book";
            Console.WriteLine(g2.Name);

            //two  variables pointing to same gradebook
                

            //GradeBook book=new GradeBook();

            //book.AddGrade(91);
            //book.AddGrade(89.5f);
            //book.AddGrade(75);

            //GradeStatistics stats = book.ComputeStatistics();

            //Console.WriteLine("Average Grade is " + stats.AverageGrade);
            //Console.WriteLine("Highest Grade is " + stats.HighestGrade);
            //Console.WriteLine("Lowest Grade is " + stats.LowestGrade);


            //Reference to book

            //GradeBook book2 = book;

            //book2.AddGrade(75);



        }
    }


}
