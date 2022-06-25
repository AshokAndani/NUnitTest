using System;
using System.Collections.Generic;
using System.Text;

namespace MockStubFakePractice
{
    public class MockMessageManager : IMessageManager
    {
        public bool SendMessage(long number, string message)
        {
           // validate the number
           bool isNumberValid=NumberValidator.ValidateNumber(number);
            if (isNumberValid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
