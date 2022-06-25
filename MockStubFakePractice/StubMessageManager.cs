using System;
using System.Collections.Generic;
using System.Text;

namespace MockStubFakePractice
{
    // it is like static
    // A stub can replace an object in the unit testing world
    public class StubMessageManager : IMessageManager
    {
        public bool SendMessage(long number, string message)
        {
            // return true always 
            return true;
        }
    }
}
