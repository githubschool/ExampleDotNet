using Xunit;
using MvcSample.Web.Models;

namespace MvcSample.Tests
{
    public class LGTaubeUserTest
    {
        [Fact]
        public void NameTest()
        {
            User user = new User()
            {
                Name = "LG Taube"
            };
            Assert.Equal("LG Taube", user.Name);
        }
    }
}
