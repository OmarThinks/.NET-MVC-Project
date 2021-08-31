using System;
using Microsoft.AspNetCore.Identity;
using Application.Models;
using System.Collections.Generic;

namespace Application.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<Post> Posts { get; set; }       
    }
}