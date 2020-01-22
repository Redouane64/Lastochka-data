using Xunit;

namespace Lastochka.Data.Xml.Tests
{
    public class ParseFileDoesNotFail
    {
        [Fact]
        public void ParseFileDoesReturnNonNull()
        {
            var result = LastochkaXmlDataReader.ParseFile();

            Assert.NotNull(result);
        }
    }
}
