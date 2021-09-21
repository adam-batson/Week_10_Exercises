using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoopsAndTestsExercises;

namespace LoopsAndTestingExercises_tests
{
    [TestClass]
    public class ReversedString_test
    {
        // ReverseAString Constraints:

        // #1) 1 <= input.length <= 100
        // #2) s consists of characters with ASCII values in the range[33, 122].
        // #3) s does not contain '"' or '\'

        // IsPalindrome Constraints
        //
        // #1) 1 <= str.length <= 2 * 105
        // #2) The string only consists of printable ASCII characters.

        [DataTestMethod] // Tests Constraint #1
        [DataRow("", DisplayName = "When input length is zero")]
        [DataRow("ooooooooooooooooooooooooo" + // Probably a better way to make this test string - I used REPL and a loop.
                 "ooooooooooooooooooooooooo" +
                 "ooooooooooooooooooooooooo" +
                 "oooooooooooooooooooooooooo",
                 DisplayName = "When input length is 101")]
        public void ReverseAString_InputLengthOutOfRange_ReturnsLengthErrorString(string input) // Tests ReverseAString Constraint #1
        {
            // Arrange
            ReversedString sut = new();
            var expected = Errors.ReverseLengthError();

            // Act
            var result = sut.ReverseAString(input);

            // Assert
            Assert.AreEqual(expected, result);
        }


        [DataTestMethod] // Tests Constraint #2

        [DataRow("{", DisplayName = "When input contains an ASCII value is above 122")]
        [DataRow("\t", DisplayName = "When input contains an ASCII value is below 32")]
        public void ReverseAString_InputContainsNonPrintableASCII_ReturnsASCIIErrorString(string input) // Tests ReverseAString Constraint #2
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
        public void ReverseAString_InputIsDoubleQuoteOrBackslash_ReturnsDoubleQuoteOrBackslashErrorString(string input) // Tests ReverseAString Constraint #3
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
        public void ReverseAString_InputSingleWord_ReturnsReversedString() // Tests reversing single word
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
        public void ReverseAString_InputSingleLetter_ReturnsReversedString() // Tests with single letter
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
        public void ReverseAString_InputMultipleWords_ReturnsReversedString() // Tests with capital letters in string
        {
            // Arrange
            ReversedString sut = new();
            var expected = "ecar taerG";

            // Act
            var result = sut.ReverseAString("Great race");

            // Assert
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow("racecar", DisplayName = "When word is all lowercase")]
        [DataRow("A man, a plan, a canal: Panama", DisplayName = "When input has spaces and symbols")]
        public void IsPalindrome_InputsArePalindromes_ReturnsTrue(string input) // Tests known palindromes
        {
            // Arrange
            ReversedString sut = new();
            var expected = true;

            // Act
            var result = sut.IsPalindrome(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsPalindrome_InputIsNotPalindrome_ReturnsFalse() // Tests non-palindrome
        {
            // Arrange
            ReversedString sut = new();
            var expected = false;
            var input = "race a car";

            // Act
            var result = sut.IsPalindrome(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow("", DisplayName = "When length is zero")]
        [DataRow("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                 "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                 "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                 "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                 "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                 "aaaaaaaaaaaa", DisplayName = "When length is over 210")]
        public void IsPalindrome_InputsOutOfRange_Returns(string input) // Tests IsPalindrome Constraint #1
        {
            // Arrange
            ReversedString sut = new();
            var expected = Errors.PalindromeLengthError();

            // Act
            var result = sut.IsPalindrome(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod] 
        [DataRow("{", DisplayName = "When input contains an ASCII value is above 122")]
        [DataRow("\t", DisplayName = "When input contains an ASCII value is below 32")]
        public void IsPalindrome_InputContainsNonPrintableASCII_ReturnsASCIIErrorString(string input) // Tests IsPalindrome Constraint #2
        {
            // Arrange
            ReversedString sut = new();
            var expected = Errors.ASCIIError();

            // Act
            var result = sut.IsPalindrome(input);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
