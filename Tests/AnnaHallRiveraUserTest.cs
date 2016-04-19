using Xunit;
using MvcSample.Web.Models;

namespace MvcSample.Tests
{
    public class AnnaHallRiveraUserTest
    {
        [Fact]
        public void myNameTest()
        {
            AnnaHallRivera myuser = new AnnaHallRiveraUser()
            {
                myName = "Anna H�ll Rivera"
            };
            Assert.Equal("Anna H�ll Rivera", myuser.myName);
        }
    }
}
