using Xunit;
using MvcSample.Web.Models;

namespace MvcSample.Tests
{
    public class AnneUserTest
    {
        [Fact]
        public void NameTest()
        {
            AnneUser user = new AnneUser()
            {
                Name = "Anne Laukka"
            };
            Assert.Equal("Anme Laukka", user.Name);
        }
    }
}
