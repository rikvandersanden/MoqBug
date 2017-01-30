using AmbientContext.DateTimeService;

namespace MoqBug.Tests.Customizations
{
    public class DateTimeFixture
    {
        public IDateTimeService DateTimeService { get; }

        public DateTimeFixture(IDateTimeService dateTimeService)
        {
            DateTimeService = dateTimeService;
            AmbientDateTimeService.Create = () => new AmbientDateTimeService() { Instance = dateTimeService };
        }
    }
}