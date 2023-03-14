namespace Dotnet_tests
{
    [TestClass]
    public class AppTests
    {
        [TestMethod]
        public void MyTestMethod()
        {
            // Arrange
            int a = 10;
            int b = 20;

            // Act
            int result = a + b;

            // Assert
            Assert.AreEqual(result, 30);
        }
        [TestMethod]
        public void MulTest()
        {
            // Arrange
            int a = 10;
            int b = 20;

            // Act
            int result = a * b;

            // Assert
            Assert.AreEqual(result, 200);
        }
    }
}