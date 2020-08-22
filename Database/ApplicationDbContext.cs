using Microsoft.EntityFrameworkCore;
using RencontreContemporainesAPI.Models;

namespace RencontreContemporainesAPI.Database
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        
        public DbSet<DbFile> Files { get; set; }
        public DbSet<Concert> Concerts { get; set; }
        public DbSet<Atelier> Ateliers { get; set; }
    }
}