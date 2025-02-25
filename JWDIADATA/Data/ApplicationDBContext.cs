using Microsoft.EntityFrameworkCore;
using JWDIADATA.Data.Entities;

namespace JWDIADATA.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}

		// Define DbSet properties for each entity model
		public DbSet<WeatherDataModel> WeatherDataModels { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			// Configure entity properties and relationships
			modelBuilder.Entity<WeatherDataModel>().HasKey(p => p.Id);
	
		}

	}
}