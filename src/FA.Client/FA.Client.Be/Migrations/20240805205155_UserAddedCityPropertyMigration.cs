using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.Client.Be.Migrations
{
    /// <inheritdoc />
    public partial class UserAddedCityPropertyMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "UserEntity",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "UserEntity");
        }
    }
}
