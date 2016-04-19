using Xunit;
using MvcSample.Web.Models;

namespace MvcSample.Tests
{
    public class MajaUserTest
    {
        [Fact]
        public void NameTest()
        {
            MajaUser user = new MajaUser()
            {
                Name = "Maja"
            };
            Assert.Equal("Maja", user.Name);
        }
    }
}
