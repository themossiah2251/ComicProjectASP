using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComicProjectASP.Data.Migrations
{
    /// <inheritdoc />
    public partial class tryAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CartItems",
                table: "Cart",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CartItems",
                table: "Cart");
        }
    }
}
