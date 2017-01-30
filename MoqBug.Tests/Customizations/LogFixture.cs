using AmbientContext.LogService.Serilog;

using Moq;

namespace MoqBug.Tests.Customizations
{
    public class LogFixture
    {
        public Mock<ILogger> LoggerMock { get; }

        public LogFixture(Mock<ILogger> loggerMock, Mock<ILogContext> logContextMock)
        {
            LoggerMock = loggerMock;
            loggerMock.Setup(x => x.LogContext).Returns(logContextMock.Object);
            AmbientLogService.Create = () => new AmbientLogService() { Instance = loggerMock.Object };
        }
    }
}