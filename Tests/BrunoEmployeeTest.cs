using Xunit;
using MvcSample.Web.Models;

namespace MvcSample.Tests
{
   public class BrunoEmployeeTest
   {
       [Theory]
       [InlineData("Bruno",65000,26, "IKB")]
       public void RichUserTest(string name, long salary, int age, string department)
       {
           var employee = new BrunoEmployee() {
               Name = name,
               Salary = salary,
               Age = age,
               Department = department
           };
           
           Assert.True(employee.Salary > 60000, "Not rich enough! Get out!");
       }
       
       [Theory]
       [InlineData("John",5000,52, "IS")]
       public void PoorUserTest(string name, long salary, int age, string department)
       {
           var employee = new BrunoEmployee() {
               Name = name,
               Salary = salary,
               Age = age,
               Department = department
           };
           
           Assert.True(employee.Salary < 10000, "Not poor enough, pal!");
       }
       
   }
}