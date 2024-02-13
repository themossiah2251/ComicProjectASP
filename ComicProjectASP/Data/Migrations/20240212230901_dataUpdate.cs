using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ComicProjectASP.Data.Migrations
{
    /// <inheritdoc />
    public partial class dataUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brand",
                columns: new[] { "Id", "Brand_Name" },
                values: new object[,]
                {
                    { 1, "Marvel" },
                    { 2, "DC" },
                    { 3, "WOTC" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Books" },
                    { 2, "Toys" },
                    { 3, "Games" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "BrandName", "CategoryId", "Category_Name", "Images", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Marvel", 1, null, "storm.jpg", "Storm 002", 10.0 },
                    { 2, 1, "Marvel", 1, null, "capbp.jpg", "Flag Of Our Fathers", 4.0 },
                    { 3, 1, "Marvel", 1, null, "bp.jpg", "Black Panter vs Luke Cage", 3.0 },
                    { 4, 2, "Dc", 1, null, "gl.jpg", "Green Lantern", 1.5 },
                    { 5, 2, "Dc", 1, null, "flash.jpg", "The Flash", 1.0 },
                    { 6, 2, "Dc", 1, null, "ww.jpg", "Wonder Woman", 2.0 },
                    { 7, 1, "Marvel", 1, null, "xmen.jpg", "The Uncanny DeadPool", 4.0 },
                    { 8, 1, "Marvel", 1, null, "dp.jpg", "Marvel Zomvies: DeadPool", 4.0 },
                    { 9, 2, "Dc", 2, null, "joker.jpg", "Joker", 20.0 },
                    { 10, 2, "Dc", 2, null, "joker_boss.jpg", "Joker Boss", 20.0 },
                    { 11, 2, "Dc", 2, null, "harley.jpg", "Harley Quinn", 20.0 },
                    { 12, 3, "WOTC", 3, null, "dndmtg.jpg", "Mind Flayer Deck", 100.0 },
                    { 13, 3, "WOTC", 3, null, "faceless_menace.jpg", "Faceless Menace Deck", 100.0 }
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
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
