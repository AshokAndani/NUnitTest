using MockStubFakePractice;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestingMockFakeStubPractice
{
    [TestFixture]
    public class MockTest
    {
        [Test]
        public void SendMessage_ContactNumberAndMessage_ReturnsStatus()
        {
            //Arrange
            IMessageManager messageManager = new MockMessageManager();
            MessageCreator messageCreator=new MessageCreator(messageManager);
            string message = "Hello how are you...!";
            long contactNumber = 9973457234;
            // Act
            bool isMessageSent = messageCreator.CreateMessageAndSend(contactNumber, message);

            //Assert
            Assert.IsTrue(isMessageSent);
        }
        [Test]
        public void CreateAndSendMessage_ContactNumberAndMessage_ReturnsStatusUsingMoqFrmeWork()
        {
            Mock<IMessageManager> messageManagerObject = new Mock<IMessageManager>();
            messageManagerObject.Setup(m => m.SendMessage(It.IsAny<long>(), It.IsAny<string>())).Returns(true);
            MessageCreator messageCreator = new MessageCreator(messageManagerObject.Object);
            var result = messageCreator.CreateMessageAndSend(86845356, "jsdjk");
            Assert.IsTrue(result);
        }
    }
}
