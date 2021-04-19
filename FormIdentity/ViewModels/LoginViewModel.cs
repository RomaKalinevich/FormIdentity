using System.ComponentModel.DataAnnotations;
using System;

namespace CustomIdentityApp.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Запомнить?")]
        public bool RememberMe { get; set; }

        public DateTime dateTime = DateTime.Now;
        public string ReturnUrl { get; set; }
    }
}
