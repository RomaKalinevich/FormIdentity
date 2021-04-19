using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FormIdentity.ViewModels
{
    public class EditUserViewModel
    {
        public string Id { get; set; }
        public DateTime? lastLoginDate { get; set; }
    }
}
