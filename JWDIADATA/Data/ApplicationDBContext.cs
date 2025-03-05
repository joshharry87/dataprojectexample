using Microsoft.EntityFrameworkCore;
using JWDIADATA.Data.Entities;
using dataintegrationexample;

namespace JWDIADATA.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}

		// Define DbSet properties for each entity model
		public DbSet<WeatherDataModel> WeatherDataModels { get; set; }
		public DbSet<GeochemSurveyDataModel> GeochemSurveyDataModels { get; set; }



		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			// Configure entity properties and relationships
			modelBuilder.Entity<WeatherDataModel>().HasKey(p => p.Id);
			modelBuilder.Entity<GeochemSurveyDataModel>().HasKey(p => p.SampleID);

	
		}

	}
}