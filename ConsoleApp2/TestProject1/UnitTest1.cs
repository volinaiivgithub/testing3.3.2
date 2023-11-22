using ConsoleApp2;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCollection()
        {
            List<char> list1 = new List<char>() { 'A', 'B', 'C' };
            List<char> list2 = new List<char>() { 'A', 'B', 'C' };

            CollectionAssert.AreEqual(list1, list2);
        }

        [TestMethod]
        public void TestCollection2()
        {
            List<char> list1 = new List<char>() { 'C', 'B', 'A' };
            List<char> list2 = new List<char>() { 'A', 'B', 'C' };

            CollectionAssert.AreEqual(list1, list2);
        }

        [TestMethod]
        public void TestCalculatePrecent()
        {
            double newNumber = 47;
            double oldNumber = 23;

            double delta = newNumber - oldNumber;
            double result_here = (delta / oldNumber) * 100;

            double result_in_method = new Class1().CalculateDelta(oldNumber, newNumber);

            Assert.AreEqual(result_here, result_in_method);
        }
    }
}