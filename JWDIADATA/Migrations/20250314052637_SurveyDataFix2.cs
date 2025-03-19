using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace jwdiadata.Migrations
{
    /// <inheritdoc />
    public partial class SurveyDataFix2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LABnegNR_NONE",
                table: "GeochemSurveyDataModels");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "LABnegNR_NONE",
                table: "GeochemSurveyDataModels",
                type: "decimal(18,2)",
                nullable: true);
        }
    }
}
