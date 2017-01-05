using Moq;

using MoqBug.Tests.Customizations;

using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;
using Ploeh.AutoFixture.Xunit2;

using Xunit;

namespace MoqBug.Tests
{
    public class MessageWriterTests
    {
        [Theory, AutoMoqData]
        public void Write_Always_CallsDateTimeService(
            DateTimeFixture dateTimeFixture,
            MessageWriter sut,
            string message)
        {
            sut.Write(message);

            dateTimeFixture.DateTimeMock.Verify(dt => dt.Now, Times.Once());
        }

        [Theory, AutoData]
        public void Write_Always_CallsDateTimeService_Manual(
            string message)
        {
            IFixture fixture = new Fixture().Customize(new AutoMoqCustomization());
            DateTimeFixture dateTimeFixture = fixture.Create<DateTimeFixture>();

            MessageWriter sut = fixture.Create<MessageWriter>();
            
            sut.Write(message);

            dateTimeFixture.DateTimeMock.Verify(m => m.Now, Times.Once());
        }
    }
}
