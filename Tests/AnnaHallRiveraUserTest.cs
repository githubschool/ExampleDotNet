using Xunit;
using MvcSample.Web.Models;

namespace MvcSample.Tests
{
    public class AnnaHallRiveraUserTest
    {
        [Fact]
        public void myNameTest()
        {
            AnnaHallRiveraUser myuser = new AnnaHallRiveraUser()
            {
                myName = "Anna Häll Rivera"
            };
            Assert.Equal("Anna Häll Rivera", myuser.myName);
        }
    }
}
