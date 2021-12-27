using BingeWatcher.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BingeWatcher.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });

            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(a => a.Actor).WithMany(am => am.Actors_Movies).HasForeignKey(a => a.ActorId);

            modelBuilder.Entity<Actor_Series>().HasKey(aas => new
            {
                aas.ActorId,
                aas.SeriesId
            });

            modelBuilder.Entity<Actor_Series>().HasOne(s => s.Series).WithMany(aas => aas.Actors_Series).HasForeignKey(s => s.SeriesId);
            modelBuilder.Entity<Actor_Series>().HasOne(a => a.Actor).WithMany(aas => aas.Actors_Series).HasForeignKey(a => a.ActorId);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }
        public DbSet<Actor_Series> Actors_Series { get; set; }
        public DbSet<Producer> Producers { get; set; }
    }
}
