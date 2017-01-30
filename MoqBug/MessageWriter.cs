using System;

using AmbientContext.DateTimeService;
using AmbientContext.LogService.Serilog;

namespace MoqBug
{
    public class MessageWriter
    {
        private readonly AmbientDateTimeService _dateTimeProvider = new AmbientDateTimeService();
        private readonly AmbientLogService _logger = new AmbientLogService();

        public void Write(string message)
        {
            Console.WriteLine($"{_dateTimeProvider.Now.ToShortTimeString()} : {message}");
            _logger.Information("Message successfully written");
        }
    }
}
