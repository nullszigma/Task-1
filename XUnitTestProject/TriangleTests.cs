using System;
using TaskProject.Concrete;
using Xunit;

namespace XUnitTestProject
{
    public class TriangleTests
    {
        [Fact]
        public void Ctor_Side_LessThanZero_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 0, -1));
        }


        [Fact]
        public void Ctor_Side_LongerThanSumOfOtherTwoSides_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(3, 4, 10));
        }

        [Fact]
        public void GetArea_A0_B0_C0_Returns_0()
        {
            // Arrange
            var triangle = new Triangle(0, 0, 0);

            // Act
            var area = triangle.GetArea();

            // Assert
            Assert.Equal(0, area);
        }

        [Fact]
        public void GetArea_A3_B4_C5_Returns_6()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var area = triangle.GetArea();

            // Assert
            Assert.Equal(6, area);
        }

        [Fact]
        public void IsRight_A3_B4_C5_Returns_True()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var isRight = triangle.IsRight();

            // Assert
            Assert.True(isRight);
        }

        [Fact]
        public void IsRight_A3_B4_C2_Returns_False()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 2);

            // Act
            var isRight = triangle.IsRight();

            // Assert
            Assert.False(isRight);
        }
    }
}
