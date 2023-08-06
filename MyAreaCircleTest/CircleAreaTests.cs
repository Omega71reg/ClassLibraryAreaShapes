using ClassLibraryAreaShapes;
namespace MyAreaTest
{
    [TestClass]
    public class CircleAreaTests
    {
        [TestMethod]
        public void CalculateCircleArea_Radius1_ReturnsPi()
        {


            // Arrange
            double radius = 1;
            double expectedArea = Math.PI;

            // Act
            double actualArea = new Circle(radius).Area();

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void CalculateCircleArea_Radius2_Returns4Pi()
        {
            // Arrange
            double radius = 2;
            double expectedArea = 4 * Math.PI;

            // Act
            double actualArea = new Circle(radius).Area();

            //Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void CalculateCircleArea_Radius0_Returns0()
        {
            // Arrange
            double radius = 0;
            double expectedArea = 0;

            // Act
            double actualArea = new Circle(radius).Area();

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void CalculateCircleArea_RadiusNegative_Returns0()
        {

            // Arrange
            double radius = -1;
            double expectedArea = 0;

            // Act
            double actualArea = new Circle(radius).Area();

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }
    }
}