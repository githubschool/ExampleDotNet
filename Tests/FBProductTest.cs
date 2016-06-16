using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace ExampleDotNet.Tests
{
    public class FBProductTest
    {
        public string Name { get; private set; }

        [Fact]
        public void NameTest()
        {
            FBProductTest product = new FBProductTest()
            {
                Name = "Standard Laptop"
            };
            Assert.Equal("Standard Laptop", product.Name);
        }
    }
}
