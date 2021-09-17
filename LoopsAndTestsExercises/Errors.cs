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
            "Double quotes (\") and backslash (\\) characters are invalid inputs."
        };

        public static string LengthError()
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
    }
}
