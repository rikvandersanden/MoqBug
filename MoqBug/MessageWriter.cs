using System;

using AmbientContext.DateTimeService;

namespace MoqBug
{
    public class MessageWriter
    {
        private readonly AmbientDateTimeService _dateTimeProvider = new AmbientDateTimeService();

        public void Write(string message)
        {
            Console.WriteLine($"{_dateTimeProvider.Now.ToShortTimeString()} : {message}");
        }
    }
}
