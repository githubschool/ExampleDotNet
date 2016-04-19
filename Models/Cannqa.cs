using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Summary description for Cannqa
/// </summary>
namespace MvcSample.Web.Models
{
    public class Cannqa
    {
	    public Cannqa()
	    {
		[Required]
        [MinLength(4)]

        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
	    }
    }

}