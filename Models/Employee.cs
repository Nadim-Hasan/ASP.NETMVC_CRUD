using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCCrudCodeFast.Models
{
    public class Employee
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage ="Name is required")]
        [Display(Name ="emp. name")]
        public string Name { get; set; }
        [Display(Name = "emp. Eamil")]
        [EmailAddress(ErrorMessage ="Email is Invalid")]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
         [Display(Name="mobile no.")]
        [Required(ErrorMessage = "Mobile is required")]
        [RegularExpression("^{0-9}{12}", ErrorMessage= "invalid Mobile numbr")]
        public string Mobile {get; set;}
        [Required(ErrorMessage = "Age is required")]
        [Range(20,60, ErrorMessage="Age must be 20 to 60 ")]
        public int Age { get; set; }
    }   
}