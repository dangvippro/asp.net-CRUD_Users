using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AMT_Company.Models
{
    public class User
    {
        [Key]
        [Required(ErrorMessage = "Username cannot be blank")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password cannot be blank")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "ConfirmPassword cannot be blank")]
        [NotMapped]
        [System.ComponentModel.DataAnnotations.Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Fullname")]
        [Required(ErrorMessage = "Fullname cannot be blank")]
        public string Fullname { get; set; }

        [Display(Name = "Birthday")]
        [Required(ErrorMessage = "Birthday cannot be blank")]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}")]
        public DateTime Birthday { get; set; }

        [Display(Name = "Avatar")]
        [Required(ErrorMessage = "Avatar cannot be blank")]
        public string Avatar { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "Gender cannot be blank")]
        public string Gender { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email cannot be blank")]
        public string Email { get; set; }

        [Display(Name = "Phone")]
        [Required(ErrorMessage = "Phone cannot be blank")]
        public string Phone { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Address cannot be blank")]
        public string Address { get; set; }
    }
}