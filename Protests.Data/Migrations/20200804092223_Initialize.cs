using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Protests.Data.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LicencePlate = table.Column<string>(nullable: false),
                    DriverId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CityName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organizers",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Phone = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RepairOptions",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepairOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Repairs",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CarId = table.Column<long>(nullable: false),
                    RepairOptionId = table.Column<long>(nullable: false),
                    RepairedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repairs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(maxLength: 256, nullable: false),
                    Password = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Protests",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(maxLength: 256, nullable: false),
                    Description = table.Column<string>(maxLength: 10000, nullable: false),
                    StartsAt = table.Column<DateTime>(nullable: false),
                    CityId = table.Column<long>(nullable: false),
                    OrganizerId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Protests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Protests_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Protests_Organizers_OrganizerId",
                        column: x => x.OrganizerId,
                        principalTable: "Organizers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CommentText = table.Column<string>(maxLength: 2048, nullable: false),
                    ProtestId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Protests_ProtestId",
                        column: x => x.ProtestId,
                        principalTable: "Protests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CreatedAt", "DriverId", "LicencePlate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2020, 8, 4, 11, 22, 23, 189, DateTimeKind.Local).AddTicks(6222), 1L, "ZG0123BK" },
                    { 2L, new DateTime(2020, 8, 4, 11, 22, 23, 192, DateTimeKind.Local).AddTicks(4069), 1L, "KA280JA" }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "CreatedAt", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1L, new DateTime(2020, 8, 4, 11, 22, 23, 194, DateTimeKind.Local).AddTicks(832), "Josip", "Josić" },
                    { 2L, new DateTime(2020, 8, 4, 11, 22, 23, 194, DateTimeKind.Local).AddTicks(1834), "Marko", "Marić" },
                    { 3L, new DateTime(2020, 8, 4, 11, 22, 23, 194, DateTimeKind.Local).AddTicks(1867), "Ivan", "Ivan" }
                });

            migrationBuilder.InsertData(
                table: "RepairOptions",
                columns: new[] { "Id", "CreatedAt", "Name", "Price" },
                values: new object[,]
                {
                    { 1L, new DateTime(2020, 8, 4, 11, 22, 23, 194, DateTimeKind.Local).AddTicks(9099), "Vulkanizacija", 250.0 },
                    { 2L, new DateTime(2020, 8, 4, 11, 22, 23, 195, DateTimeKind.Local).AddTicks(536), "Redovni servis", 1200.0 }
                });

            migrationBuilder.InsertData(
                table: "Repairs",
                columns: new[] { "Id", "CarId", "CreatedAt", "RepairOptionId", "RepairedAt" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2020, 8, 4, 11, 22, 23, 194, DateTimeKind.Local).AddTicks(4562), 1L, null },
                    { 2L, 2L, new DateTime(2020, 8, 4, 11, 22, 23, 194, DateTimeKind.Local).AddTicks(5649), 2L, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ProtestId",
                table: "Comments",
                column: "ProtestId");

            migrationBuilder.CreateIndex(
                name: "IX_Protests_CityId",
                table: "Protests",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Protests_OrganizerId",
                table: "Protests",
                column: "OrganizerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "RepairOptions");

            migrationBuilder.DropTable(
                name: "Repairs");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Protests");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Organizers");
        }
    }
}
