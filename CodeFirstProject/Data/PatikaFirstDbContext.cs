using CodeFirstProject.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstProject.Data
{
    public class PatikaFirstDbContext : DbContext
    {
        private readonly PatikaFirstDbContext _database;

        public PatikaFirstDbContext(PatikaFirstDbContext database)
        {
            _database = database;
        }
        public PatikaFirstDbContext(DbContextOptions<PatikaFirstDbContext> options) : base(options)
        {
            
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().HasData(
                new Game { Id = 1, Name = "The Witcher 3: Wild Hunt", Platform = "PC", Raiting = 9.8m },
                new Game { Id = 2, Name = "Cyberpunk 2077", Platform = "PC", Raiting = 7.2m },
                new Game { Id = 3, Name = "Grand Theft Auto V", Platform = "PC", Raiting = 9.5m }
            );
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "The Shawshank Redemption", Genre = "Drama", ReleaseYear = 1994 },
                new Movie { Id = 2, Title = "The Godfather", Genre = "Crime", ReleaseYear = 1972 },
                new Movie { Id = 3, Title = "The Dark Knight", Genre = "Action", ReleaseYear = 2008 }
            );
        }
    }
}
