using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.Client.Be.Migrations
{
    /// <inheritdoc />
    public partial class CityAddedToUserMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "UserEntity");

            migrationBuilder.AddColumn<long>(
                name: "CityId",
                table: "UserEntity",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_UserEntity_CityId",
                table: "UserEntity",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserEntity_CityEntity_CityId",
                table: "UserEntity",
                column: "CityId",
                principalTable: "CityEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserEntity_CityEntity_CityId",
                table: "UserEntity");

            migrationBuilder.DropIndex(
                name: "IX_UserEntity_CityId",
                table: "UserEntity");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "UserEntity");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "UserEntity",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
