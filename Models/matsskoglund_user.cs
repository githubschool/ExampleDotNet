using System.ComponentModel.DataAnnotations;

namespace MvcSample.Web.Models
{
    public class matsskoglund_User
    {
        [Required]
        [MinLength(4)]
        public string Name { 
        get {return "Mats Skoglund"; }
        set; 
        }
        public string Address { get; set; }
        public int Age { get; set; }
    }
}