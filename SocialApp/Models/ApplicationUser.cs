using System;
using Microsoft.AspNetCore.Identity;
using SocialApp.Models;
using System.Collections.Generic;

namespace SocialApp.Models
{
	public class ApplicationUser : IdentityUser
	{
    	public List<Post> Posts { get; set; }		
	}
}