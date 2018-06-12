using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Stay.Web.Areas.Auth.Models
{
    public class ResetModel
    {
        public string Token { get; set; }

        [Required(ErrorMessage = "New Password is required")]
        [ValidatePassword]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Confirm New Password is required")]
        [ValidatePassword]
        [System.ComponentModel.DataAnnotations.Compare("NewPassword", ErrorMessage = "New Password and Confirm New Password do not match")]  // qualify to circumvent a bug
        public string ConfirmPassword { get; set; }
    }
}