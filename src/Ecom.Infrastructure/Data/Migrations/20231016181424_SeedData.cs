using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecom.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cateogries",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Des1", "Cateogry one" },
                    { 2, "Des2", "Cateogry two" },
                    { 3, "Des3", "Cateogry three" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CateogryId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "DesP1", "Prod 1", 2000m },
                    { 2, 2, "DesP2", "Prod 2", 3000m },
                    { 3, 3, "DesP3", "Prod 3", 4000m },
                    { 4, 1, "DesP4", "Prod 4", 5000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cateogries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cateogries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cateogries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
