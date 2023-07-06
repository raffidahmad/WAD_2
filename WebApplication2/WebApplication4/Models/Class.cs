using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class person
    {
        [RegularExpression("^[a-zA-Z]{1,30}$", ErrorMessage = "Maximum 30 characters and alphabets only")]
        [DisplayName("First name")]
        public string? FirstName { get; set; }

        [RegularExpression("^[a-zA-Z]{1,30}$", ErrorMessage = "Maximum 30 characters and alphabets only")]
        [DisplayName("Last name")]
        public string? LastName { get; set; }

        public string? Date { get; set; }
        public string? month { get; set; }
        public string? year { get; set; }

        [DisplayName("Email ID")]
        public string? Email { get; set; }

        [RegularExpression("^[0-9]{11}$", ErrorMessage = "11 Digit Number")]
        [Required]
        [DisplayName("Mobile Number")]
        public string? MobileNumber { get; set; }

        [DisplayName("Gender")]
        public string? Gender { get; set; }

        [DisplayName("Address")]
        public string? Address { get; set; }

        [RegularExpression("^[a-zA-Z]{1,30}$", ErrorMessage = "Maximum 30 characters and alphabets only")]
        [DisplayName("City")]
        public string? City { get; set; }

        [RegularExpression("^[0-9]{6}$", ErrorMessage = "6 Digit Number")]
        [DisplayName("Pin Code")]
        public int? pincode { get; set; }

        [RegularExpression("^[a-zA-Z]{1,30}$", ErrorMessage = "Maximum 30 characters and alphabets only")]
        [DisplayName("State")]
        public string? state { get; set; }

        [DisplayName("Country")]
        public string? coun { get; set; }

        [DisplayName("Hobbies")]
		public List<string?> Hobb { get; set; }

        [Required(ErrorMessage ="Qualification is required")]
        //[RegularExpression("^[A-Za-z]{1,10}$", ErrorMessage = "Maximum 10 characters")]
        public string? classXB { get; set; }

        [RegularExpression("^[0-9]{2,50}$", ErrorMessage = "Upto 2 decimal Characters")]
        [Required]
        public string? classXP { get; set; }
        public string? classXY { get; set; }

        //[RegularExpression("^[A-Za-z]{1,10}$", ErrorMessage = "Maximum 10 characters")]
        [Required]
        public string? classXIIB { get; set; }

        [RegularExpression("^[0-9]{2,50}$", ErrorMessage = "Upto 2 decimal Characters")]
        [Required]
        public string? classXIIP { get; set; }
        public string? classXIIY { get; set; }

        [RegularExpression("^[A-Za-z]{1,10}$", ErrorMessage = "Maximum 10 characters")]
        [Required]
        public string? GraduationB { get; set; }

        [RegularExpression("^[0-9]{2,50}$", ErrorMessage = "Upto 2 decimal Characters")]
        [Required]
        public string? GraduationP { get; set; }
        public string? GraduationY { get; set; }

        //[RegularExpression("^[A-Za-z]{1,10}$", ErrorMessage = "Maximum 10 characters")]
        [Required]
        public string? MastersB { get; set; }

        [RegularExpression("^[0-9]{2,50}$", ErrorMessage = "Upto 2 decimal Characters")]
        [Required]
        public string? MastersP { get; set; }
        public string? MastersY { get; set; }


        [DisplayName("Courses Applied for")]
        public string? courses { get; set; }
    }
}
