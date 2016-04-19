using System.ComponentModel.DataAnnotations;

namespace MvcSample.Web.Models
{
    public class Employee
    {
        [Required]
        [MinLength(4)]
        public string Name { get; set; }
        public int EmployeeID { get; set; }
        public string OfficeLocation { get; set; }
    }
}