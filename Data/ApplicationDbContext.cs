using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ClassyCooksWeb.Data;

namespace ClassyCooksWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ClassyCooksWeb.Data.Cooks> Cooks { get; set; }
        public DbSet<ClassyCooksWeb.Data.Departments> Departments { get; set; }
        public DbSet<ClassyCooksWeb.Data.Resturants> Resturants { get; set; }
    }
}
