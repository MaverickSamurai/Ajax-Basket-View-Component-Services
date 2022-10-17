using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiorello.Migrations
{
    public partial class CreateSettingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Key = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 10, 17, 18, 1, 53, 424, DateTimeKind.Local).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 10, 17, 18, 1, 53, 426, DateTimeKind.Local).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 10, 17, 18, 1, 53, 426, DateTimeKind.Local).AddTicks(5451));

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "IsDeleted", "Key", "Value" },
                values: new object[,]
                {
                    { 1, false, "HeaderLogo", "logo.png" },
                    { 2, false, "Phone", "6516516516" },
                    { 3, false, "ProductTake", "4" },
                    { 4, false, "Email", "Azerrh@code.edu.az" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 10, 17, 16, 51, 55, 296, DateTimeKind.Local).AddTicks(1332));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 10, 17, 16, 51, 55, 297, DateTimeKind.Local).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 10, 17, 16, 51, 55, 297, DateTimeKind.Local).AddTicks(5645));
        }
    }
}
