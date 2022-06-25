using System;
using System.Collections.Generic;
using System.Text;

namespace MockStubFakePractice
{
    public class NumberValidator
    {
        public static bool ValidateNumber(long number)
        {
            string NumberToString=number.ToString();
            if (NumberToString[0] != '9')
            {
                return false;
            }
            return true;
        }
    }
}
