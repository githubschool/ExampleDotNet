using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Xunit;
using MvcSample.Web.Models;

/// <summary>
/// Summary description for CannqaTest
/// </summary>
namespace MvcSample.Tests
{
    public class CannqaTest
    {
        [Fact]
        public CannqaTest()
        {
            User user = new User()
            {
                Name = "Catrin Andersson"
            };
            Assert.Equal("Catrin Andersson", user.Name);
        }
        
    }
}
