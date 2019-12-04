using System;
using System.Collections.Generic;
using System.Text;
using Architecture.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Architecture.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Student> Student { get; set; }
       
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
