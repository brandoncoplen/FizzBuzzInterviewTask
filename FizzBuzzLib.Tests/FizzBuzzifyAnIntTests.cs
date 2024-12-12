namespace FizzBuzzLib.Tests
{
    using FluentAssertions;
    using Xunit;

    public class FizzBuzzifyAnIntTests
    {
        [Fact]
        public void FizzBuzzifyAnInt_WhenPassedAnInt_ReturnsAString()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var result = fizzBuzz.FizzBuzzifyAnInt(1);

            // Assert
            result.Should().BeOfType<string>("because the method is expected to return a string.");
        }

        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(7, "7")]
        public void FizzBuzzifyAnInt_ShouldReturnExpectedResults(int input, string expectedOutput)
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var result = fizzBuzz.FizzBuzzifyAnInt(input);

            // Assert
            result.Should().Be(expectedOutput, $"because {input} should return {expectedOutput}");
        }
    }
}
