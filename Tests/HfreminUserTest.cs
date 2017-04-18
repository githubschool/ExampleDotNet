using Xunit;
using MvcSample.Web.Models;

namespace MvcSample.Tests
{
    public class HfreminUserTest
    {
        [Fact]
        public void NameTest()
        {
            User user = new User()
            {
                Name = "Bas Peters"
            };
            Assert.Equal("Bas Peters", user.Name);
        }
    }
}
