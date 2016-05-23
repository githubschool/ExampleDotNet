using Xunit;
using MvcSample.Web.Models;

namespace MvcSample.Tests
{
    public class DgfreememUserTest
    {
        [Fact]
        public void NameTest()
        {
            DgfreememUser user = new DgfreememUser()
            {
                Name = "DGFreemem"
            };
            Assert.Equal("DGFreemem", user.Name);
        }
    }
}
