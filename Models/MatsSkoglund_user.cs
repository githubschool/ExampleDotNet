using System.ComponentModel.DataAnnotations;

namespace MvcSample.Web.Models
{
    public class MatsSkoglund_User
    {
        private string name;
        [Required]
        [MinLength(4)]
        public string Name { 
            get{ 
                return "Skoglund Mats"; 
            } 
            set{ 
                name=value;    
            }   
        }
        public string Address { get; set; }
        public int Age { get; set; }
    }
}