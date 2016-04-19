using Xunit;
using MvcSample.Web.Models;

namespace MvcSample.Tests
{
   public class BrunoEmployeeTest
   {
       [Theory]
       [InlineData("Bruno",65000,26, "IKB")]
       public void SalaryCheckTest(string name, long salary, int age, string department)
       {
           var employee = new BrunoEmployee() {
               Name = name,
               Salary = salary,
               Age = age,
               Department = department
           };
           
           Assert.False(employee.Salary > 60000, "You're too rich! Get out!");
       }
   }
}