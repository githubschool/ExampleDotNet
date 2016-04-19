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
                Name = "Anna H�ll Rivera"
            };
            Assert.Equal("Anna H�ll Rivera", user.Name);
        }
    }
}
