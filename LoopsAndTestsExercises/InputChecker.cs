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

        public static bool CheckInputLength(string input)
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

            if(input.Contains('\\') || input.Contains('\"'))
                return false;
            else
                return true;
        }
    }
}
