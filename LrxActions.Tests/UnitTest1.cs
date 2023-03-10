using LrxActions.Core;

namespace LrxActions.Tests {
    public class UnitTest1 {
        [Fact]
        public void Test1() {
            // Arrange
            var sut = new Class1();

            // Act
            var result = sut.Sum(1, 2);

            // Assert
            Assert.Equal(3, result);
        }
    }
}