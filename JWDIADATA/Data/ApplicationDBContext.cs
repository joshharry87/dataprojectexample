// https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-9.0&tabs=net-cli

using Microsoft.EntityFrameworkCore;
using Microsoft.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

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
		public DbSet<GeochemSurveyDataModel> GeochemSurveyDataModels { get; set; }
		public DbSet<UserDataModel> Users { get; set; }



		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			// Configure entity properties and relationships
			modelBuilder.Entity<WeatherDataModel>().HasKey(p => p.Id);
			modelBuilder.Entity<GeochemSurveyDataModel>().HasKey(p => p.SampleID);
            modelBuilder.Entity<UserDataModel>().HasKey(p => p.Id);
            modelBuilder.Entity<UserDataModel>().HasIndex(p => p.Username).IsUnique();

        }
		

    }
}