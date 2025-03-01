using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagement.Migrations
{
    /// <inheritdoc />
    public partial class hotelmanagement_14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "User",
                newName: "FullName");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Booking",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Booking_ApplicationUserId",
                table: "Booking",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_User_ApplicationUserId",
                table: "Booking",
                column: "ApplicationUserId",
                principalTable: "User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_User_ApplicationUserId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_ApplicationUserId",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Booking");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "User",
                newName: "Name");
        }
    }
}
