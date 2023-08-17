using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Web_Api_Project.Migrations
{
    /// <inheritdoc />
    public partial class AddData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 16, 15, 27, 12, 992, DateTimeKind.Local).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 16, 15, 27, 12, 992, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "CreatedAt", "Email", "Name" },
                values: new object[,]
                {
                    { 3, new DateTime(2023, 8, 16, 15, 27, 12, 992, DateTimeKind.Local).AddTicks(8045), "author3@gmail.com", "TestAuthor 3" },
                    { 4, new DateTime(2023, 8, 16, 15, 27, 12, 992, DateTimeKind.Local).AddTicks(8046), "author4@gmail.com", "TestAuthor 4" },
                    { 5, new DateTime(2023, 8, 16, 15, 27, 12, 992, DateTimeKind.Local).AddTicks(8048), "author5@gmail.com", "TestAuthor 5" },
                    { 6, new DateTime(2023, 8, 16, 15, 27, 12, 992, DateTimeKind.Local).AddTicks(8049), "author6@gmail.com", "TestAuthor 6" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorID", "Description", "Title" },
                values: new object[,]
                {
                    { 5, 1, "TestBook New Description 5", "TestBook New" },
                    { 6, 2, "TestBook New Description 6", "TestBook New" },
                    { 3, 3, "TestBook New Description 3", "TestBook New" },
                    { 4, 3, "TestBook New Description 4", "TestBook New" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 16, 12, 51, 18, 952, DateTimeKind.Local).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 16, 12, 51, 18, 952, DateTimeKind.Local).AddTicks(5039));
        }
    }
}
