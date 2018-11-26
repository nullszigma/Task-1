using System;
using TaskProject.Concrete;
using Xunit;

namespace XUnitTestProject
{
    public class CircleTests
    {
        [Fact]
        public void Ctor_Radius_LessThanZero_ThrowsArgumentOutOfRangeException()
        {
            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(()=> new Circle(-2));
        }

        [Fact]
        public void GetArea_Radius_0_Returns_0()
        {
            // Arrange
            var circle = new Circle(0);

            // Act
            var area = circle.GetArea();

            // Assert
            Assert.Equal(0, area);
        }

        [Fact]
        public void GetArea_Radius_2_Returns_12_57()
        {
            // Arrange
            var circle = new Circle(2);

            // Act
            var area = circle.GetArea();

            // Assert
            Assert.Equal(12.57, area);
        }
    }
}