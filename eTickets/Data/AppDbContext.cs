using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActorMovie>().HasKey(p => new
            {
                p.ActorId,
                p.MovieId
            });
            modelBuilder.Entity<ActorMovie>().HasOne(m => m.Movie).WithMany(m => m.ActorMovies).HasForeignKey(m =>
            m.MovieId);
            modelBuilder.Entity<ActorMovie>().HasOne(m => m.Actor).WithMany(m => m.ActorMovies).HasForeignKey(m =>
                 m.ActorId);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<ActorMovie> ActorMovies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }

}
}
