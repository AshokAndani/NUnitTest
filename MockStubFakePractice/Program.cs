using System;

namespace MockStubFakePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Phone Number of the Customer:");
            long contactNumber=long.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Message You Need To send:");
            string message=Console.ReadLine();

            IMessageManager manager = new MessageManager();
            MessageCreator messageCreator = new MessageCreator(manager);
            var flag=messageCreator.CreateMessageAndSend(contactNumber, message);
            if (flag)
            {
                Console.WriteLine("Message Sent Succesfully");
            }
            else
            {
                Console.WriteLine("could not send message");
            }
        }
    }
}
