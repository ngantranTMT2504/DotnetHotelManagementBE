using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagement.Migrations
{
    /// <inheritdoc />
    public partial class hotelmanagement10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageRoom",
                table: "Room");

            migrationBuilder.AddColumn<string>(
                name: "ImageRoom",
                table: "TypeRoom",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageRoom",
                table: "TypeRoom");

            migrationBuilder.AddColumn<string>(
                name: "ImageRoom",
                table: "Room",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
