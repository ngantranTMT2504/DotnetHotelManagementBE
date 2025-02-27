using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagement.Migrations
{
    /// <inheritdoc />
    public partial class hotelmanagement12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "UserTokens",
                newName: "UserToken");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                newName: "UserRole");

            migrationBuilder.RenameTable(
                name: "UserLogins",
                newName: "UserLogin");

            migrationBuilder.RenameTable(
                name: "UserClaims",
                newName: "UserClaim");

            migrationBuilder.RenameTable(
                name: "RoleClaims",
                newName: "RoleClaim");

            migrationBuilder.RenameTable(
                name: "IdentityUser<string>",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "IdentityRole<string>",
                newName: "Role");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "User",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "UserToken",
                newName: "UserTokens");

            migrationBuilder.RenameTable(
                name: "UserRole",
                newName: "UserRoles");

            migrationBuilder.RenameTable(
                name: "UserLogin",
                newName: "UserLogins");

            migrationBuilder.RenameTable(
                name: "UserClaim",
                newName: "UserClaims");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "IdentityUser<string>");

            migrationBuilder.RenameTable(
                name: "RoleClaim",
                newName: "RoleClaims");

            migrationBuilder.RenameTable(
                name: "Role",
                newName: "IdentityRole<string>");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "IdentityUser<string>",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
