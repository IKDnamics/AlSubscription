using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Stay.Web.Areas.Auth.Models
{
    public class JoinModel
    {
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(35, ErrorMessage = "Minimum length is 2 characters.", MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(35, ErrorMessage = "Minimum length is 2 characters.", MinimumLength = 2)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Confirm email is required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        [System.ComponentModel.DataAnnotations.Compare("Email", ErrorMessage = "Email and Confirm email do not match")]  // qualify to circumvent a bug
        public string ConfirmEmail { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        [ValidatePassword]
        public string Password { get; set; }

        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Key { get; set; }
    }
}