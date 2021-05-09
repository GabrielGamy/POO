using System;

namespace Polymorphisme
{
    class Logger : IMessageLogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void LogMessage(string [] messages)
        {
            foreach (var message in messages) {
                Console.WriteLine(message);
            }
        }
    }
}
