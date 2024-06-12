using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Identity;

namespace ASP_pr1
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}