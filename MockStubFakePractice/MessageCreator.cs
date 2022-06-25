using System;
using System.Collections.Generic;
using System.Text;

namespace MockStubFakePractice
{
    public class MessageCreator
    {
        private readonly IMessageManager messageManager;

        public MessageCreator(IMessageManager messageManager)
        {
            this.messageManager = messageManager;
        }
        public bool CreateMessageAndSend(long contactNumber, string Message)
        {
            bool result=messageManager.SendMessage(contactNumber, Message);
            return result;
        }
    }
}
