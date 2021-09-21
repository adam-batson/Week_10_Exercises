using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoopsAndTestsExercises;

namespace LoopsAndTestingExercises_tests
{
    [TestClass]
    public class DoubledInt_tests
    {
        // Constraints

        // #1) 2 <= arr.length <= 500
        // #2) -10^3 <= arr[i] <= 10^3

        // check if there exists two indices i and j such that:
        // i != j
        // 0 <= i, j<arr.length
        // arr[i] == 2 * arr[j]

        [TestMethod] // Tests Constraint #1 - Below minimum length
        public void DoesDoubleExist_ArrayLengthBelow2_ReturnsArrayLengthError()
        {
            // Arrange
            var sut = new DoubledInt();
            var expected = Errors.ArrayLengthError();
            int[] array = new int[1] { 1 };


            // Act
            var result = sut.DoesDoubleExist(array);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod] // Tests Constraint #1 - Above maximum length
        public void DoesDoubleExist_ArrayLengthOver500_ReturnsArrayLengthError()
        {
            // Arrange
            var sut = new DoubledInt();
            var expected = Errors.ArrayLengthError();
            int[] array = new int[501];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            // Act
            var result = sut.DoesDoubleExist(array);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod] // Tests Constraint #2 - Array with values below -1000
        public void DoesDoubleExist_ValueInArrayBelowNegative1000_ReturnsOutOfRangeError()
        {
            // Arrange
            var sut = new DoubledInt();
            var expected = Errors.OutOfRangeError();
            int[] array = new int[] { 0, 90, 456, -3000, 17 };

            // Act
            var result = sut.DoesDoubleExist(array);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod] // Tests Constraint #2 - Array with values above 1000
        public void DoesDoubleExist_ValueInArrayAbove1000_ReturnsOutOfRangeError()
        {
            // Arrange
            var sut = new DoubledInt();
            var expected = Errors.OutOfRangeError();
            int[] array = new int[] { 0, 90, 456, 3000, 17 };

            // Act
            var result = sut.DoesDoubleExist(array);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod] // Functions properly using Example 1 from exercise
        public void DoesDoubleExist_UsesExample1FromExercise_ReturnsTrue()
        {
            // Arrange
            var sut = new DoubledInt();
            var expected = true;
            int[] array = new int[] { 10, 2, 5, 3}; // Double exists before single

            // Act
            var result = sut.DoesDoubleExist(array);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod] // Functions properly using Example 2 from exercise
        public void DoesDoubleExist_UsesExample2FromExercise_ReturnsTrue()
        {
            // Arrange
            var sut = new DoubledInt();
            var expected = true;
            int[] array = new int[] { 7, 1, 14, 11 }; // Double exists after single

            // Act
            var result = sut.DoesDoubleExist(array);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod] // Functions properly using Example 3 from exercise
        public void DoesDoubleExist_UsesExample3FromExercise_ReturnsFalse()
        {
            // Arrange
            var sut = new DoubledInt();
            var expected = false;
            int[] array = new int[] { 3, 1, 7, 11 }; // Double does not exist

            // Act
            var result = sut.DoesDoubleExist(array);

            // Assert
            Assert.AreEqual(expected, result);
        }



    }
}
