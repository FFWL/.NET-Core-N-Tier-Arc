using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name="Name Surname")]
        [Required(ErrorMessage = "Please enter name and surname")]
        public string NameSurname { get; set; }
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter password")]
        public string Password { get; set; }
        [Display(Name = "Confirm Password")]
        [Compare("Password",ErrorMessage ="Passwords do not match")]
        public string ConfirmPassword { get; set; }
        [Display(Name = "Mail Address")]
        [Required(ErrorMessage = "Please enter mail address")]
        public string MailAddress { get; set; }
        [Display(Name = "User Name")]
        [Required(ErrorMessage = "Please enter username")]
        public string UserName { get; set; }
    }
}
