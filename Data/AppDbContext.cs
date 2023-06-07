using System;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modeluBuilder)
		{

			modeluBuilder.Entity<Actor_Movie>().HasKey(am => new
			{
				am.ActorId,
				am.MovieId
			});

			modeluBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actor_Movies).HasForeignKey(m => m.MovieId);

			modeluBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am => am.Actor_Movies).HasForeignKey(m => m.ActorId);


            base.OnModelCreating(modeluBuilder);
		}

		public DbSet<Actor> Actors { get; set; }

		public DbSet<Movie> Movies { get; set; }

		public DbSet<Actor_Movie> Actors_Movies { get; set; }

		public DbSet<Cinema> Cinemas { get; set; }

		public DbSet<Producer> Producers { get; set; }
	}
}

