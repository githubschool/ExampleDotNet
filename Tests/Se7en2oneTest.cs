using Xunit;
using MvcSample.Web.Models;

namespace MvcSample.Tests
{
    public class Se7en2oneTest
    {
        [Fact]
        public void NameTest()
        {
            Se7en2one se7en2one = new Se7en2one()
            {
                Name = "Jim"
            };
            Assert.Equal("Jim", se7en2one.Name);
        }
    }
}
