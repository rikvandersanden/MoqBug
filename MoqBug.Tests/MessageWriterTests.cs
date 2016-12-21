using Moq;

using MoqBug.Tests.Customizations;

using Ploeh.AutoFixture.Xunit2;

using Xunit;

namespace MoqBug.Tests
{
    public class MessageWriterTests
    {
        [Theory, AutoMoqData]
        public void Write_Always_CallsDateTimeProvider(
            [Frozen] Mock<IDateTimeProvider> dateTimeProviderMock,
            MessageWriter sut,
            string message)
        {
            sut.Write(message);

            dateTimeProviderMock.Verify(m => m.Now, Times.Once());
        }
    }
}
