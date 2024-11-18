using FluentAssertions;
using Shapes;

namespace Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(1, -1, 1)]
        [InlineData(3, 8, 12)]
        [InlineData(3, 8, 11)]
        public void TriangleIsNotCreatedSuccessfully(double a, double b, double c)
        {
            // Act
            Action act = () => new Triangle(a, b, c);

            // Assert
            act.Should().Throw<ArgumentException>();
        }

        [Theory]
        [InlineData(3, 11, 12, 16.125)]
        [InlineData(3, 3, 3, 3.897)]
        public void TriangleGetAreaShouldBeAsExpected(double a, double b, double c, double expected)
        {
            // Arrange
            var triangle = new Triangle(a, b, c);

            // Act
            var actual = Math.Round(triangle.GetArea(), 3);

            // Assert
            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData(3, 11, 12, false)]
        [InlineData(4, 3, 5, true)]
        public void TriangleIsRectangularShouldBeAsExpected(double a, double b, double c, bool expected)
        {
            // Arrange
            var triangle = new Triangle(a, b, c);

            // Act
            var actual = triangle.IsRectangular();

            // Assert
            actual.Should().Be(expected);
        }
    }
}