using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore01.Context
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<models.Book> Book { get; set; }
        public DbSet<models.Author> Author { get; set; }
        public DbSet<models.Category> Category { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SALMA\\SQLEXPRESS;Database=EFCore01;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
