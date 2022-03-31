using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Slipknotssite.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipknotssite.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<News> News { get; set; }
        public DbSet<Albums> Albums { get; set; }
        public DbSet<Concerts> Concerts{ get; set; }
        public DbSet<SugMessage> SugMessage { get; set; }
    }
}
