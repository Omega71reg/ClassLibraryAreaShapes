using ClassLibraryAreaShapes;
namespace MyAreaTest
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Constructor_ValidParameters_CreatesTriangle()
        {
            // Arrange
            double A = 3;
            double B = 4;
            double C = 5;

            // Act
            Triangle triangle = new Triangle(A, B, C);

            // Assert
            Assert.AreEqual(A, triangle.A);
            Assert.AreEqual(B, triangle.B);
            Assert.AreEqual(C, triangle.C);
        }

        [TestMethod]
        [DataRow(-3, 4, 5)]
        [DataRow(3, -4, 5)]
        [DataRow(3, 4, -5)]
        [DataRow(0, 4, 5)]
        [DataRow(3, 0, 5)]
        [DataRow(3, 4, 0)]
        public void Constructor_InvalidParameters_ThrowsArgumentException(double A, double B, double C)
        {
            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Triangle(A, B, C));
        }

        [TestMethod]
        public void A_SetValidValue_ChangesA()
        {
            // Arrange
            double originalA = 3;
            double newA = 6;
            Triangle triangle = new Triangle(originalA, 4, 5);

            // Act
            triangle.A = newA;

            // Assert
            Assert.AreEqual(newA, triangle.A);
        }

        [TestMethod]
        public void B_SetValidValue_ChangesB()
        {
            // Arrange
            double originalB = 4;
            double newB = 7;
            Triangle triangle = new Triangle(3, originalB, 5);

            // Act
            triangle.B = newB;

            // Assert
            Assert.AreEqual(newB, triangle.B);
        }

        [TestMethod]
        public void C_SetValidValue_ChangesC()
        {
            // Arrange
            double originalC = 5;
            double newC = 9;
            Triangle triangle = new Triangle(3, 4, originalC);

            // Act
            triangle.C = newC;

            // Assert
            Assert.AreEqual(newC, triangle.C);
        }

        [TestMethod]
        public void GetArea_ReturnsCorrectArea()
        {
            // Arrange
            double A = 3;
            double B = 4;
            double C = 5;
            Triangle triangle = new Triangle(A, B, C);
            double expectedArea = 6;

            // Act
            double area = triangle.Area();

            // Assert
            Assert.AreEqual(expectedArea, area);
        }
    }
}