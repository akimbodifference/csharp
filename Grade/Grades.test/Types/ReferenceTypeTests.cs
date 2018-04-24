using System;
using Grade;
using NUnit.Framework;
namespace Grades.test.Types
{
    [TestFixture]  //this is an attribute
    public class ReferenceTypeTests
    {    

        //Immutability-> can't change 
        [Test ()]
        public void AddDaysToDateTime(){
            DateTime date = new DateTime(2017, 12,28);
            date=date.AddDays(1);

            Assert.AreEqual(29, date.Day);
        }
        //passing param in ref type and value type
        //value type passing param
        [Test()]
        public void ValueTypePassByValue()
        {
            int x = 46;
            IncrementNumber(x);

            Assert.AreEqual(46,x);

        }
        private void IncrementNumber(int number)
        {
             number+= 1;
        }

        //ref type passing param
        [Test()]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAName(book2);
            Assert.AreEqual("A GradeBook", book1.Name);
        }
        //lets call a methd and does not have a test attribute 
        //hence testrunner wont run it
        private void GiveBookAName(GradeBook book)
        {
            book.Name = "A GradeBook";
        }


        //enum
         [Test ()]
        public void StringComparisons()
        {
            string name1 = "Ikram";
            string name2 = "ikram";

            bool result = String.Equals(name1, name2,StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);


        }

        //value types
        [Test()]
        public void IntVariablesHoldAValue(){
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x1, x2);

        }


        //tetsing reference types to comprehend

        [Test()]  //this is an attribute
        public void GradeBookvariablesHoldAReference()

        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1 = new GradeBook();
            g1.Name = "Ikram's grade book";
            Assert.AreNotEqual(g1.Name, g2.Name);
        }
    }
}