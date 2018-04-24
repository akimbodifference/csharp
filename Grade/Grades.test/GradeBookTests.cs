using System;
using Grade;
using NUnit.Framework;

namespace Grades.test
{
    [TestFixture()]
    public class GradeBookTests
    {
        [Test()]
        public void ComputesHighestGrade()
        {
            GradeBook book=new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(90, result.HighestGrade);
        }
        //compute lowest grade
        [Test()]
        public void ComputesLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(10, result.LowestGrade);
        }

        //compute Average grade
        [Test()]
        public void ComputesAverageGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);


            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(85.166, result.AverageGrade, 0.001);

            //p.s: No need to store the whole digit in gradebook
            //comparing double precision floaitng point 
            //double delta can be 85.16 and double delta will be 0.01

                 

        }
    }
}
