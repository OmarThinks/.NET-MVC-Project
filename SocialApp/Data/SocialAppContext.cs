using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;


    public class SocialAppContext : IdentityDbContext
    {
        public SocialAppContext (DbContextOptions<SocialAppContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Post> Post { get; set; }
    }
