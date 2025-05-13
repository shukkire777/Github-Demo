using DemoGithub.Model;
namespace DemoGithub.UnitTest
{
    [TestFixture]
    public class MyModelTests
    {
        [Test]
        public void TestSetValueAndGetValue()
        {
            // Arrange
            IMyModel obj = new MyModel();
            string expectedValue = "My Name";

            // Act
            obj.SetValue(expectedValue);
            string actualValue = obj.GetValue();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void TestGetValueBeforeSetValue()
        {
            // Arrange
            IMyModel obj = new MyModel();

            // Act
            string actualValue = obj.GetValue();

            // Assert
            Assert.IsNull(actualValue);
        }
    }
}