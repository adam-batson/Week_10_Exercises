using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAndTestsExercises
{
    public class ReversedString
    {
        public string ReverseAString(string input)
        {
            // Constraints:

            // #1) 1 <= input.length <= 100
            // #2) s consists of characters with ASCII values in the range[33, 122].
            // #3) s does not contain '"' or '\'

            StringBuilder reversed = new();

            if (!InputChecker.CheckReverseInputLength(input)) // Checks Constraint #1
                return Errors.ReverseLengthError(); 
            else if (!InputChecker.CheckASCIIValues(input)) // Checks Constraint #2
                return Errors.ASCIIError(); 
            else if (!InputChecker.CheckDoubleQuoteOrBackslash(input)) // Checks Constraint #3
                return Errors.DoubleQuoteOrBackslashError();
            else // Creates reversed string
                for (int i = (input.Length - 1); i >= 0; i--)
                {
                    reversed.Append(input[i]);
                }
            
            return reversed.ToString();
        }

        public dynamic IsPalindrome(string input)
        {
            // Constraints
            //
            // #1) 1 <= str.length <= 2 * 105
            // #2) The string only consists of printable ASCII characters.

            if (!InputChecker.CheckPalindromeInputLength(input)) // Checks Constraint #1
                return Errors.PalindromeLengthError();
            if (!InputChecker.CheckASCIIValues(input)) // Checks Constraint #2
                return Errors.ASCIIError();

            input = input.ToLower(); // Ensures case isn't an issue
            
            for (int i = 0; i < input.Length; i++)
            {
                if (!Char.IsLetter(input[i])) // Strips string of non-letter characters
                {
                    input = input.Remove(i, 1);
                    i--; // Removed the current index i so decrement allows us to check the new index i
                }
            }
            if (input == ReverseAString(input)) return true; // Checks is input is the same in reverse
            else return false;
        }
    }
}
