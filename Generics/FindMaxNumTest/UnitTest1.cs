using System;
using Generics;
namespace FindMaxNumTest
{
    public class Tests
    {
        FindMaxGeneric<int> intFindMax = new FindMaxGeneric<int>();
        FindMaxGeneric<double> doubleFindMax = new FindMaxGeneric<double>();
        FindMaxGeneric<string> stringFindMax = new FindMaxGeneric<string>();

        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax()
        {
            int result = intFindMax.GenericValue(11, 88, 91);
            Assert.AreEqual(91, result);
            //Assert.Pass();

        }
        //Maximum At Second Position
        [Test]
        public void GivenMaxSecoundNum_WhenAnalysed_ShouldReturnSecoundMax()
        {
            int answer = intFindMax.GenericValue(23, 56, 41);
            Assert.AreEqual(9, answer);
        }
        //Maximum At Third Position
        [Test]
        public void GivenMaxSecoundNum_WhenAnalysed_ShouldReturnThirdMax()
        {
            int answer = intFindMax.GenericValue(23, 41, 56);
            Assert.AreEqual(56, answer);
        }
        //Maximum double At First Position
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturndoubleMax()
        {
            double result = doubleFindMax.GenericValue(65.6, 3.89, 45.9);
            Assert.AreEqual(65.6, result);
            //Assert.Pass();
        }

        //Maximum double At Second Position
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnSecondMax()
        {
            double result = doubleFindMax.GenericValue(78.54, 98.99, 54.78);
            Assert.AreEqual(98.99, result);
            //Assert.Pass();

        }
    }
}