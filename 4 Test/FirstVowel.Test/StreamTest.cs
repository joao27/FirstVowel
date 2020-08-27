using FirstVowel.Domain.Implementations;
using Xunit;

namespace FirstVowel.Test
{
    public class StreamTest
    {
        [Theory]
        [InlineData("abcd", 'a')]
        [InlineData("w", 'w')]
        public void GetNext_GettingValidInput_ResultInValidOutput(string inserted, char expected)
        {
            // arrange
            var stream = new Stream() { Input = inserted };

            // act

            var result = stream.GetNext();

            // assert
            Assert.True(result == expected);
        }

        [Theory]
        [InlineData("abcd")]
        [InlineData("w")]
        public void HasNext_GettingValidInput_ResultTrueOutput(string inserted)
        {
            // arrange
            var stream = new Stream() { Input = inserted };

            // act

            var result = stream.HasNext();

            // assert
            Assert.True(result);
        }

        [Fact]
        public void HasNext_GettingInvalidInput_ResultFalseOutput()
        {
            // arrange
            var stream = new Stream() { Input = string.Empty };

            // act

            var result = stream.HasNext();

            // assert
            Assert.False(result);
        }
    }
}
