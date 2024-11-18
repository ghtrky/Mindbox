using FluentAssertions;
using Shapes;

namespace Tests
{
    public class CircleTests
    {
        [Fact]
        public void CircleleIsNotCreatedSuccessfully()
        {
            // Act
            var r = -1;
            Action act = () => new Circle(r);

            // Assert
            act.Should().Throw<ArgumentException>();
        }

        [Fact]
        public void CircleGetAreaShouldBeAsExpected()
        {
            // Arrange
            var r = 3;
            var triangle = new Circle(r);

            // Act
            var actual = Math.Round(triangle.GetArea(), 3);

            // Assert
            actual.Should().Be(28.274);
        }
    }
}
