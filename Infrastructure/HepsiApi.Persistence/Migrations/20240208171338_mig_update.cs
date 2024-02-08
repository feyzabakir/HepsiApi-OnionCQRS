using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HepsiApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 13, 37, 524, DateTimeKind.Local).AddTicks(8095), "Toys" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 13, 37, 524, DateTimeKind.Local).AddTicks(8153), "Baby, Computers & Baby" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 13, 37, 524, DateTimeKind.Local).AddTicks(8159), "Grocery" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 8, 20, 13, 37, 525, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 8, 20, 13, 37, 525, DateTimeKind.Local).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 8, 20, 13, 37, 525, DateTimeKind.Local).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 8, 20, 13, 37, 525, DateTimeKind.Local).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 13, 37, 527, DateTimeKind.Local).AddTicks(7377), "Bilgisayarı nihil dışarı quasi yaptı.", "Dicta." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 13, 37, 527, DateTimeKind.Local).AddTicks(7412), "Umut aut duyulmamış ea kulu.", "Türemiş amet." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 13, 37, 527, DateTimeKind.Local).AddTicks(7439), "Neque öyle için voluptatem ducimus.", "Quam." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 13, 37, 531, DateTimeKind.Local).AddTicks(3145), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 4.01736384449110m, 81.10m, "Handcrafted Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 13, 37, 531, DateTimeKind.Local).AddTicks(3172), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 8.005372366199490m, 891.85m, "Rustic Frozen Cheese" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 13, 21, 12, 11, 694, DateTimeKind.Local).AddTicks(6459), "Beauty, Electronics & Books" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 13, 21, 12, 11, 694, DateTimeKind.Local).AddTicks(6493), "Industrial" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 13, 21, 12, 11, 694, DateTimeKind.Local).AddTicks(6523), "Tools, Electronics & Kids" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 13, 21, 12, 11, 695, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 13, 21, 12, 11, 695, DateTimeKind.Local).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 13, 21, 12, 11, 695, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 13, 21, 12, 11, 695, DateTimeKind.Local).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 1, 13, 21, 12, 11, 698, DateTimeKind.Local).AddTicks(3862), "Dolores incidunt voluptatem praesentium yazın.", "Orta." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 1, 13, 21, 12, 11, 698, DateTimeKind.Local).AddTicks(3895), "Ullam aspernatur beatae nostrum adresini.", "Açılmadan sit." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 1, 13, 21, 12, 11, 698, DateTimeKind.Local).AddTicks(3953), "Ea numquam kutusu gördüm rem.", "Türemiş." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 1, 13, 21, 12, 11, 701, DateTimeKind.Local).AddTicks(8537), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 0.8624741662409930m, 873.24m, "Ergonomic Cotton Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 1, 13, 21, 12, 11, 701, DateTimeKind.Local).AddTicks(8565), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 3.322706263886130m, 229.12m, "Fantastic Wooden Soap" });
        }
    }
}
