using System;
using System.Collections.Generic;
using System.Text;

namespace MockStubFakePractice
{
    public class MessageManager : IMessageManager
    {
        public bool SendMessage(long number, string message)
        {
            // logic to check whether the number is valid
            //logic to connect to service provider
            // logic to send the message to given number
            return false;
        }
    }
}
