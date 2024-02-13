using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComicProjectASP.Data.Migrations
{
    /// <inheritdoc />
    public partial class cartRepoContro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "UnitPrice",
                table: "Cart Details",
                type: "float",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnitPrice",
                table: "Cart Details");
        }
    }
}
