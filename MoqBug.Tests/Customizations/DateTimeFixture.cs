using AmbientContext.DateTimeService;

using Moq;


namespace MoqBug.Tests.Customizations
{
    public class DateTimeFixture
    {
        public Mock<IDateTimeService> DateTimeMock { get; }

        public DateTimeFixture(Mock<IDateTimeService> dateTimeMock)
        {
            DateTimeMock = dateTimeMock;
            AmbientDateTimeService.Create = () => new AmbientDateTimeService() { Instance = dateTimeMock.Object };
        }
    }
}