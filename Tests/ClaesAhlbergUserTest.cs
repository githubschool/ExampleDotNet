using ExampleDotNet.Models;
using Xunit;
using MvcSample.Web.Models;

namespace MvcSample.Tests
{
    public class ClaesAhlbergUserTest
    {
        [Fact]
        public void NameTest()
        {
            var user = new ClaesAhlbergUser();

            Assert.Equal("Claes Ahlberg", user.Name);
        }
    }
}
