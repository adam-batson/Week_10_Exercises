using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAndTestsExercises
{
    public class DoubledInt
    {
        // Constraints

        // #1) 2 <= arr.length <= 500
        // #2) -10^3 <= arr[i] <= 10^3

        // check if there exists two indices i and j such that:
        // i != j
        // 0 <= i, j<arr.length
        // arr[i] == 2 * arr[j]

        public dynamic DoesDoubleExist(int[] array) // Dynamic allows me to return strings or bools
        {
            var doubleExists = false;

            if (!InputChecker.CheckArrayLength(array)) // Checks Constraint #1
                return Errors.ArrayLengthError();
            else if (!InputChecker.CheckArrayValuesInRange(array)) // Checks Constraint #2
                return Errors.OutOfRangeError();
            else // Checks array to see if, for any value, does its double exist?
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (i == j) continue;
                        else if (array[i] == 2 * array[j])
                        {
                            doubleExists = true;
                        }
                    }
                }
            }

            return doubleExists;
        }
    }
}
