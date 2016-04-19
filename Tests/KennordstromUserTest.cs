using Xunit;
using MvcSample.Web.Models;

namespace MvcSample.Tests
{
    public class KennordstromUserTest
    {
        [Fact]
        public void NameTest()
        {
            KennordstromUser user = new KennordstromUser()
            {
                Name = "Ken Nordström"
            };
            Assert.Equal("Ken Nordström", user.Name);
        }
    }
}