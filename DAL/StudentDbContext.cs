using Microsoft.EntityFrameworkCore;
using DotVVMcrud.DAL.Entities;
namespace DotVVMcrud.DAL
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Student> Students { get; set; }
    }
}
