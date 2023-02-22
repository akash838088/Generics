namespace UnitTest.cs
{
    public class Tests
    {
        FindMaxGeneric<int> intFindMax = new FindMaxGeneric<int>();
        FindMaxGeneric<double> intFindMax = new FindMaxGeneric<double>();
        FindMaxGeneric<string> intFindMax = new FindMaxGeneric<string>();

        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax()

        {
            int result = genericMethodForInt.FindMaximumGeneric(20, 10, 17);
            Assert.AreEqual(20, result);
            //Assert.Pass();

        }
    }
}

 