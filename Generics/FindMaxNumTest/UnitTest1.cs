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

    }
}