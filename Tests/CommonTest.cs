using Xunit;

namespace MvcSample.Tests
{
    public class CommonTest
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2, 3));
        }

        int Add(int x, int y)
        {
            return x + y;
        }
    }
}
