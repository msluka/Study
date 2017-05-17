using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Student
    {
        [Display(Name = "Id")]
        public int StudentId { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string StudentName { get; set; }
        [Required(ErrorMessage = "Enter age.")]
        public int Age { get; set; }
        public Gender Gender { get; set; }
        [Display(Name = "Is Newly Enrold?")]
        public bool isNewlyEnrolled { get; set; }
        public string Password { get; set; }
        
    }

    public enum Gender
    {
        Male,
        Female
    }
}