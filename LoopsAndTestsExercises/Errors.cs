using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAndTestsExercises
{
    public class Errors
    {
        // Class contains error messages and returns them

        private static readonly List<string> ErrorMessages = new()
        {
            "You must enter a string between 1 and 100 characters long.",
            "Your input can only contain letters, numbers, and special characters aside from {, |, }, or ~ .",
            "Double quotes (\") and backslash (\\) characters are invalid inputs.",
            "The array must be between 2 and 500 indices.",
            "The array must contain integers between -1000 and 1000.",
            "You must enter a string between 1 and 210 characters long."
        };

        public static string ReverseLengthError()
        {
            return ErrorMessages[0];
        }

        public static string ASCIIError()
        {
            return ErrorMessages[1];
        }

        public static string DoubleQuoteOrBackslashError()
        {
            return ErrorMessages[2];
        }

        public static string ArrayLengthError()
        {
            return ErrorMessages[3];
        }

        public static string OutOfRangeError()
        {
            return ErrorMessages[4];
        }

        public static string PalindromeLengthError()
        {
            return ErrorMessages[5];
        }
    }
}
