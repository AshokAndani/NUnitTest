using System;
using System.Collections.Generic;
using System.Text;

namespace MockStubFakePractice
{
    public interface IMessageManager
    {
        bool SendMessage(long number, string message);
    }
}
