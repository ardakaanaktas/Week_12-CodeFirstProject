using CodeFirstProject.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstProject.Data
{
    public class PatikaFirstDbContext : DbContext
    {
        public PatikaFirstDbContext(DbContextOptions<PatikaFirstDbContext> options) : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}
