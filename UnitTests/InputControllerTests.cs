using NLP_KarakterdenNumarayaDonusum.Controllers;
using Xunit;

namespace NLP_KarakterdenNumarayaDonusum.Tests
{
    public class InputControllerTests
    {
        // Test case: Valid input with single-word representation
        [Theory]
        [InlineData("bir", "1")]
        [InlineData("on", "10")]
        [InlineData("yüz", "100")]
        [InlineData("bin", "1000")]
        [InlineData("milyon", "1000000")]
        public void ConvertTextToNumber_ValidSingleWordInput_ReturnsExpectedResult(string input, string expectedResult)
        {
            // Arrange & Act
            var result = InputController.ConvertTextToNumber(input);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        // Test case: Valid input with multi-word representation
        [Theory]
        [InlineData("on bir", "11")]
        [InlineData("yüz on", "110")]
        [InlineData("bin yirmi üç", "1023")]
        [InlineData("beş yüz altmış üç milyon dokuz yüz kırk iki bin iki yüz on bir", "563942011")]
        public void ConvertTextToNumber_ValidMultiWordInput_ReturnsExpectedResult(string input, string expectedResult)
        {
            // Arrange & Act
            var result = InputController.ConvertTextToNumber(input);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        // Test case: Invalid input (null, empty, or unrecognized)
        [Theory]
        [InlineData(null, "Null bir değer girdiniz")]
        [InlineData("", "Null bir değer girdiniz")]
        [InlineData("invalid input", "invalid input")]
        public void ConvertTextToNumber_InvalidInput_ReturnsErrorMessage(string input, string expectedErrorMessage)
        {
            // Arrange & Act
            var result = InputController.ConvertTextToNumber(input);

            // Assert
            Assert.Equal(expectedErrorMessage, result);
        }
    }
}
