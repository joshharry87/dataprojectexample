using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace jwdiadata.Migrations
{
    /// <inheritdoc />
    public partial class SurveyDataFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Err_143_Nd",
                table: "GeochemSurveyDataModels");

            migrationBuilder.DropColumn(
                name: "Err_87_Sr",
                table: "GeochemSurveyDataModels");

            migrationBuilder.AlterColumn<string>(
                name: "Top_1_Elements",
                table: "GeochemSurveyDataModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Top_1_Elements",
                table: "GeochemSurveyDataModels",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<decimal>(
                name: "Err_143_Nd",
                table: "GeochemSurveyDataModels",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Err_87_Sr",
                table: "GeochemSurveyDataModels",
                type: "decimal(18,2)",
                nullable: true);
        }
    }
}
