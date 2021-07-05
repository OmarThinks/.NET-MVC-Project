using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;


public class SocialAppContext : IdentityDbContext<ApplicationUser>
    {
        public SocialAppContext (DbContextOptions<SocialAppContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    public DbSet<RazorPagesMovie.Models.Post> Post { get; set; }

        public DbSet<RazorPagesMovie.Models.Comment> Comment { get; set; }
    }
