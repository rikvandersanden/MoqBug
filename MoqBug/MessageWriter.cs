using System;

namespace MoqBug
{
    public class MessageWriter
    {
        private readonly IDateTimeProvider _dateTimeProvider;

        public MessageWriter(IDateTimeProvider dateTimeProvider)
        {
            _dateTimeProvider = dateTimeProvider;
        }

        public void Write(string message)
        {
            Console.WriteLine($"{_dateTimeProvider.Now.ToShortTimeString()} : {message}");
        }
    }
}
