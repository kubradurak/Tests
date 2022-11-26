using Calculator;

namespace Test.Calculator
{
    [TestClass]
    public class Test_BasicOperation
    {
        [TestMethod]
        public void Test_Sum()
        {
            BasicOperations basicOperations = new BasicOperations();
            var result = basicOperations.Sum(10,10);
            //Assert.AreEqual(result,30);
            Assert.AreEqual(result, 20);
        }
        [TestMethod]
        public void Test_Subtraction()
        {
            BasicOperations basicOperations = new BasicOperations();
            var result = basicOperations.Subtraction(4, 10);
            Assert.AreEqual(result, -6);
        }
        [TestMethod]
        public void Test_Division()
        {
            BasicOperations basicOperations = new BasicOperations();
            var result = basicOperations.Division("8", "0");
            //Assert.AreEqual(result,30);
            Assert.AreEqual(result, "Division of 0 by zero.");
        }
        [TestMethod]
        public void Test_Multiplication()
        {
            BasicOperations basicOperations = new BasicOperations();
            var result = basicOperations.Multiplication(5, 0);
            Assert.AreEqual(result, 0);
        }

    }
}