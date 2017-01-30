using AmbientContext.DateTimeService;

using Moq;

using MoqBug.Tests.Customizations;

using Ploeh.AutoFixture.Xunit2;

using Xunit;

namespace MoqBug.Tests
{
    public class MessageWriterTests
    {
        [Theory, AutoMoqData]
        public void Write_Always_CallsDateTimeService(
            [Frozen] Mock<IDateTimeService> dateTimeServiceMock,
            DateTimeFixture dateTimeFixture,
            MessageWriter sut,
            string message)
        {
            sut.Write(message);

            dateTimeServiceMock.Verify(dt => dt.Now, Times.Once());
        }

        [Theory, AutoMoqData]
        public void Write_Always_CallsLogService(
            LogFixture logFixture,
            MessageWriter sut,
            string message)
        {
            sut.Write(message);

            logFixture.LoggerMock.Verify(l=> l.Information(It.IsAny<string>()));
        }
    }
}
