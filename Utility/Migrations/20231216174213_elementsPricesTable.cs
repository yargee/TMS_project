﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Utility.Migrations
{
    /// <inheritdoc />
    public partial class elementsPricesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "ElementsPrice",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "ElementsPrice");
        }
    }
}
