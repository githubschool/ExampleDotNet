using Xunit;
using MvcSample.Web.Models;

namespace MvcSample.Tests
{
    public class NeerajUserTest
    {
        [Fact]
        public void NameTest()
        {
            User user = new User()
            {
                Name = "Neeraj"
            };
            Assert.Equal("Neeraj", user.Name);
        }
    }
}
