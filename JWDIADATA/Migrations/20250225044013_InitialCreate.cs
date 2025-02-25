using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace jwdiadata.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WeatherDataModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_epoch = table.Column<int>(type: "int", nullable: true),
                    hour = table.Column<int>(type: "int", nullable: true),
                    maxtemp_c = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    maxtemp_f = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    mintemp_c = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    mintemp_f = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    avgtemp_c = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    avgtemp_f = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    maxwind_mph = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    maxwind_kph = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    totalprecip_mm = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    totalprecip_in = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    totalsnow_cm = table.Column<int>(type: "int", nullable: true),
                    avgvis_km = table.Column<int>(type: "int", nullable: true),
                    avgvis_miles = table.Column<int>(type: "int", nullable: true),
                    avghumidity = table.Column<int>(type: "int", nullable: true),
                    daily_will_it_rain = table.Column<int>(type: "int", nullable: true),
                    daily_chance_of_rain = table.Column<int>(type: "int", nullable: true),
                    daily_will_it_snow = table.Column<int>(type: "int", nullable: true),
                    daily_chance_of_snow = table.Column<int>(type: "int", nullable: true),
                    condition_text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    condition_icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    condition_code = table.Column<int>(type: "int", nullable: true),
                    uv = table.Column<int>(type: "int", nullable: true),
                    sunrise = table.Column<int>(type: "int", nullable: true),
                    sunset = table.Column<int>(type: "int", nullable: true),
                    moonrise = table.Column<int>(type: "int", nullable: true),
                    moonset = table.Column<int>(type: "int", nullable: true),
                    moon_phase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    moon_illumination = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherDataModels", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeatherDataModels");
        }
    }
}
