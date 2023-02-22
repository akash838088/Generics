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
            int result = intFindMax.GenericValue(91, 88, 81);
            Assert.AreEqual(91, result);
            //Assert.Pass();

        }
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnsecondMax()
        {
            int result = intFindMax.GenericValue(99, 56, 35);
            Assert.AreEqual(99, result);
            //Assert.Pass();
        }
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnthirdMax()
        {
            int result = intFindMax.GenericValue(43, 88, 82);
            Assert.AreEqual(88, result);
            //Assert.Pass();

        }

    }
}