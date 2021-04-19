using Microsoft.AspNetCore.Identity;
using System;

namespace CustomIdentityApp.Models
{
    public class User : IdentityUser
    {
        public DateTime? registrationDate { get; set; }
        public DateTime? lastLoginDate { get; set; }
        public bool Status { get; set; }
    }
}