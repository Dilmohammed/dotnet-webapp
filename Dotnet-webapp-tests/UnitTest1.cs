namespace Dotnet_webapp_tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddTest()
        {
            // Arrange
            int a = 10;
            int b = 20;

            // Act
            int result = a + b;

            // Assert
            Assert.AreEqual(result, 30);
        }
        [Test]
        public void SubTest()
        {
            // Arrange
            int a = 20;
            int b = 10;

            // Act
            int result = a - b;

            // Assert
            Assert.AreEqual(result, 10);
        }
        [Test]
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