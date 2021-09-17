using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoopsAndTestsExercises;

namespace LoopsAndTestingExercises_tests
{
    [TestClass]
    public class ReversedString_test
    {
        // Constraints:

        // #1) 1 <= input.length <= 100
        // #2) s consists of characters with ASCII values in the range[33, 122].
        // #3) s does not contain '"' or '\'

        [DataTestMethod] // Tests Constraint #1
        [DataRow("", DisplayName = "When input length is zero")]
        [DataRow("ooooooooooooooooooooooooo" + // Probably a better way to make this test string - I used REPL and a loop.
                 "ooooooooooooooooooooooooo" +
                 "ooooooooooooooooooooooooo" +
                 "oooooooooooooooooooooooooo",
                 DisplayName = "When input length is 101")]
        public void ReverseAString_InputLengthOutOfRange_ThrowsInputLengthException(string input)
        {
            // Arrange
            ReversedString sut = new();
            var expected = Errors.LengthError();

            // Act
            var result = sut.ReverseAString(input);

            // Assert
            Assert.AreEqual(expected, result);
        }


        [DataTestMethod] // Tests Constraint #2

        [DataRow("{", DisplayName = "When input contains an ASCII value is above 122")]
        [DataRow("\t", DisplayName = "When input contains an ASCII value is below 32")]
        public void ReverseAString_InputContainsNonPrintableASCII_ThrowsNonPrintableASCIIException(string input)
        {
            // Arrange
            ReversedString sut = new();
            var expected = Errors.ASCIIError();

            // Act
            var result = sut.ReverseAString(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod] // Tests Constraint #3
        [DataRow("\"", DisplayName = "When input is \"")]
        [DataRow("\\", DisplayName = "When input is \\")]
        public void ReverseAString_InputIsDoubleQuoteOrBackslash_ReturnsDoubleQuoteOrBackslashError(string input)
        {
            // Arrange
            ReversedString sut = new();
            var expected = Errors.DoubleQuoteOrBackslashError();

            // Act
            var result = sut.ReverseAString(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReverseAString_InputSingleWord_ReturnsReversedString()
        {
            // Arrange
            ReversedString sut = new();
            var expected = "olleh";

            // Act
            var result = sut.ReverseAString("hello");

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReverseAString_InputSingleLetter_ReturnsReversedString()
        {
            // Arrange
            ReversedString sut = new();
            var expected = "h";

            // Act
            var result = sut.ReverseAString("h");

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReverseAString_InputMultipleWords_ReturnsReversedString()
        {
            // Arrange
            ReversedString sut = new();
            var expected = "ecar taerG";

            // Act
            var result = sut.ReverseAString("Great race");

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
