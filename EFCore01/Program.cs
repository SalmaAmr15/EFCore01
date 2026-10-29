using EFCore01.Context;
using Microsoft.EntityFrameworkCore;

namespace EFCore01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AppDbContext>();
            builder.UseSqlServer("Server=SALMA\\SQLEXPRESS;Database=EFCore01;Trusted_Connection=True;TrustServerCertificate=True;");
            AppDbContext context = new AppDbContext(builder.Options);
        }
    }
}
