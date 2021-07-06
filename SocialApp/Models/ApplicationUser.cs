using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


	public class ApplicationUser : IdentityUser
	{
	}

/*
$ dotnet aspnet-codegenerator identity --dbContext SocialAppContext
*/