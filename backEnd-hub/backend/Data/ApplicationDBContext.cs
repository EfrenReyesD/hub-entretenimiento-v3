using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Data 
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions)
        :base(dbContextOptions)
        {
            
        }

        public DbSet<User> Users {get; set;}
        public DbSet<Movie> Movies {get; set;}
        public DbSet<Series> Series {get; set;}
        public DbSet<Episode> Episodes {get; set;}
        public DbSet<Genre> Genres {get; set;}
        public DbSet<Favorite> Favorites {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Favorite>()
                .HasOne(f => f.Movie)
                .WithMany(m => m.Favorites)
                .HasForeignKey(f => f.movie_id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Favorite>()
                .HasOne(f => f.Series)
                .WithMany(s => s.Favorites)
                .HasForeignKey(f => f.series_id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Series>()
                .HasMany(s => s.Episodes)
                .WithOne(e => e.Series)
                .HasForeignKey(e => e.series_id);
        }

    }
}
