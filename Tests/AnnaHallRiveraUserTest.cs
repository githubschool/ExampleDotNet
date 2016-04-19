using Xunit;
using MvcSample.Web.Models;

namespace MvcSample.Tests
{
    public class AnnaHallRiveraUserTest
    {
        [Fact]
        public void NameTest()
        {
            AnnaHallRivera user = new AnnaHallRiveraUser()
            {
                Name = "Anna Häll Rivera"
            };
            Assert.Equal("Anna Häll Rivera", user.Name);
        }
    }
}
