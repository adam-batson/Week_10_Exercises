using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAndTestsExercises
{
    public static class InputChecker
    {
        // The only thing this class does is check for valid input
        // and return true if the input is valid or false if it's not.

        public static bool CheckReverseInputLength(string input)
        {
            // If input.Length is between 1 and 100, this returns true.
            return input.Length >= 1 && input.Length <= 100;
        }

        public static bool CheckASCIIValues(string input)
        {
            foreach (char letter in input)
            { 
                // If a non-printable ASCII character is found, returns false.
                // Else, when loop finishes, we know input is valid so it's returned.
                // The constraint as written in the problem means we can't
                // use spaces (ASCII 32) but Example 3 uses one. I made this true
                // to the spirit of the exercise and allowed spaces also.
                if (letter < 32 || letter > 122)
                    return false;
                else continue;
            }
            return true;
        }

        public static bool CheckDoubleQuoteOrBackslash(string input)
        {
            // If input contains \ or ", returns false.
            // Otherwise, input is valid so returns true.

            return !(input.Contains('\\') || input.Contains('\"'));
        }

        public static bool CheckArrayLength(int[] array)
        {
            // If array length is between 2 and 500,
            // returns true. Otherwise, array length is
            // not acceptable, so returns false.

            return (array.Length >= 2 && array.Length <= 500);
        }

        public static bool CheckArrayValuesInRange(int[] array)
        {
            // If array input contains values below -1000
            // or above 1000, returns false. Otherwise, 
            // array input values are within valid range,
            // so returns true.

            var inRange = true;

            foreach (int item in array)
                if (item < -1000 || item > 1000)
                {
                    inRange = false;
                    break; // We only need one value out of range to be invalid, so ends loop.
                }

            return inRange; 
        }

        public static bool CheckPalindromeInputLength(string input)
        {
            // If input.Length is between 1 and 210, this returns true.
            return input.Length >= 1 && input.Length <= 210;
        }

    }
}
