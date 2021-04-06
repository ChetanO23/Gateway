using HRM.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRM.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // An entity set that can be used for the database CRUD Operations
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }
    }
}
