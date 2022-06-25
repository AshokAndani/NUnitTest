using MockStubFakePractice;
using Moq;
using NUnit.Framework;

namespace TestingMockFakeStubPractice
{
    [TestFixture]
    public class StubTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreateAndSendMessage_ContactNumberAndMessage_returnSendsMessage()
        {
            // Arrange
            StubMessageManager stubMessageManager = new StubMessageManager();
            MessageCreator messageCreator= new MessageCreator(stubMessageManager);
            string message = "Hello jsdjkflHow a354re you...!";
            long contactNumber = 765873456546;

            // Act
            var result = messageCreator.CreateMessageAndSend(contactNumber, message);

            // assert
            Assert.IsTrue(result);
        }
      
    }
}