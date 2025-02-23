using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagement.Migrations
{
    /// <inheritdoc />
    public partial class intial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookingId",
                table: "BookingService",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    DateCkeckin = table.Column<DateOnly>(type: "date", nullable: false),
                    DateCheckout = table.Column<DateOnly>(type: "date", nullable: false),
                    TotalPrice = table.Column<int>(type: "int", nullable: false),
                    TotalRoom = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeRoom",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeRoom", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    PaymentDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Method = table.Column<int>(type: "int", nullable: false),
                    UpFrontPayment = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BookingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payment_Booking_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Booking",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberRoom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageRoom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TypeRoomId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Room_TypeRoom_TypeRoomId",
                        column: x => x.TypeRoomId,
                        principalTable: "TypeRoom",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomBooked",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateBooked = table.Column<DateOnly>(type: "date", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    BookingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomBooked", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomBooked_Booking_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Booking",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomBooked_Room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookingService_BookingId",
                table: "BookingService",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_BookingId",
                table: "Payment",
                column: "BookingId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Room_TypeRoomId",
                table: "Room",
                column: "TypeRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomBooked_BookingId",
                table: "RoomBooked",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomBooked_RoomId",
                table: "RoomBooked",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingService_Booking_BookingId",
                table: "BookingService",
                column: "BookingId",
                principalTable: "Booking",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingService_Booking_BookingId",
                table: "BookingService");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "RoomBooked");

            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "TypeRoom");

            migrationBuilder.DropIndex(
                name: "IX_BookingService_BookingId",
                table: "BookingService");

            migrationBuilder.DropColumn(
                name: "BookingId",
                table: "BookingService");
        }
    }
}
