using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practical_7.Models
{
    public class Student
    {
       
        [Required]
        public string name { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        [Range(18,100)]
        public int age { get; set; }
        [Required]
        public string adderss { get; set; }
    }
}