using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SocialApp.Models;


namespace SocialApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
	    {
	        base.OnModelCreating(builder);
	    }
        public DbSet<SocialApp.Models.Post> Post { get; set; }
        public DbSet<SocialApp.Models.Comment> Comment { get; set; }
    }
}
