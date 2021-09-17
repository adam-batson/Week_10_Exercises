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
            StringBuilder reversed = new();

            if (!InputChecker.CheckInputLength(input))
                return Errors.LengthError();
            else if (!InputChecker.CheckASCIIValues(input))
                return Errors.ASCIIError();
            else if (!InputChecker.CheckDoubleQuoteOrBackslash(input))
                return Errors.DoubleQuoteOrBackslashError();
            else
                for (int i = (input.Length - 1); i >= 0; i--)
                {
                    reversed.Append(input[i]);
                }
            
            return reversed.ToString();
        }
    }
}
