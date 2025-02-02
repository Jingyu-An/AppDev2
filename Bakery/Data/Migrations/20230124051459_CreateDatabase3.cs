﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bakery.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageFileName", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "A scrumptious mini-carrot cake encrusted with sliced almonds", "carrot_cake.jpg", "Carrot Cake", 8.99m },
                    { 2, "A delicious lemon tart with fresh meringue cooked to perfection", "lemon_tart.jpg", "Lemon Tart", 9.99m },
                    { 3, "Delectable vanilla and chocolate cupcakes", "cupcakes.jpg", "Cupcakes", 5.99m },
                    { 4, "Fresh baked French-style bread", "bread.jpg", "Bread", 1.49m },
                    { 5, "A glazed pear tart topped with sliced almonds and a dash of cinnamon", "pear_tart.jpg", "Pear Tart", 5.99m },
                    { 6, "Rich chocolate frosting cover this chocolate lover's dream", "chocolate_cake.jpg", "Chocolate Cake", 8.99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
