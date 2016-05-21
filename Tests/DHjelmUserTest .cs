using Xunit;
using MvcSample.Web.Models;

namespace MvcSample.Tests
{
    public class DHjelmUserTest
    {
        [Fact]
        public void NameTest()
        {
            DHjelmUser user = new DHjelmUser()
            {
                Name = "Daniel Hjelm"
            };
            Assert.Equal("Daniel Hjelm", user.Name);
        }
    }
}
