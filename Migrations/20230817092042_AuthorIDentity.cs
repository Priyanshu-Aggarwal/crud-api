using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_Api_Project.Migrations
{
    /// <inheritdoc />
    public partial class AuthorIDentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 17, 14, 50, 42, 412, DateTimeKind.Local).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 17, 14, 50, 42, 412, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 17, 14, 50, 42, 412, DateTimeKind.Local).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 17, 14, 50, 42, 412, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 17, 14, 50, 42, 412, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 17, 14, 50, 42, 412, DateTimeKind.Local).AddTicks(3578));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 17, 12, 45, 56, 262, DateTimeKind.Local).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 17, 12, 45, 56, 262, DateTimeKind.Local).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 17, 12, 45, 56, 262, DateTimeKind.Local).AddTicks(617));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 17, 12, 45, 56, 262, DateTimeKind.Local).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 17, 12, 45, 56, 262, DateTimeKind.Local).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 17, 12, 45, 56, 262, DateTimeKind.Local).AddTicks(620));
        }
    }
}
