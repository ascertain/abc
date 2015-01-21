using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication4.Models
{
    public class Country
    {
        public string CountryName { get; set;}
        public string CountryCode { get; set;}
    }
    public class LoginDetails
    {
        [Required(ErrorMessage = "Enter the UserName")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Enter the Password")]
        public string Password { get; set; }
        
    }

   
    
}


