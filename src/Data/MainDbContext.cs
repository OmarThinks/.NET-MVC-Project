using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Application.Models;

    public class MainDbContext : DbContext
    {
        public MainDbContext (DbContextOptions<MainDbContext> options)
            : base(options)
        {
        }

        public DbSet<Application.Models.Post> Post { get; set; }

        public DbSet<Application.Models.Comment> Comment { get; set; }
    }
