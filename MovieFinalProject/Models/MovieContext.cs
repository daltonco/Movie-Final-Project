using Microsoft.EntityFrameworkCore;

namespace MovieFinalProject.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId = "A", Name = "Action" },
                new Genre { GenreId = "C", Name = "Comedy" },
                new Genre { GenreId = "D", Name = "Drama" },
                new Genre { GenreId = "H", Name = "Horror" },
                new Genre { GenreId = "M", Name = "Musical" },
                new Genre { GenreId = "R", Name = "Romance" },
                new Genre { GenreId = "S", Name = "SciFi" },
                new Genre { GenreId = "F", Name = "Fantasy" },
                new Genre { GenreId = "N", Name = "Noir" }
            );

            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    MovieId = 1,
                    Name = "My Neighbor Totoro",
                    Year = 1988,
                    Rating = 4,
                    GenreId = "F"
                },
                new Movie
                {
                    MovieId = 2,
                    Name = "Your Name",
                    Year = 2016,
                    Rating = 4,
                    GenreId = "R"
                },
                new Movie
                {
                    MovieId = 3,
                    Name = "Dodgeball",
                    Year = 2004,
                    Rating = 3,
                    GenreId = "C"
                },
                new Movie
                {
                    MovieId = 4,
                    Name = "Pineapple Express",
                    Year = 2008,
                    Rating = 3,
                    GenreId = "C"
                },
                new Movie
                {
                    MovieId = 5,
                    Name = "About Time",
                    Year = 2013,
                    Rating = 4,
                    GenreId = "R"
                }
            );
        }
    }
}
