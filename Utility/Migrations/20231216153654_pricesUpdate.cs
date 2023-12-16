using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Utility.Migrations
{
    /// <inheritdoc />
    public partial class pricesUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Prices",
                table: "Elements");

            migrationBuilder.CreateTable(
                name: "ElementsPrice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ElementId = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<int>(type: "INTEGER", nullable: false),
                    FurnitureElementId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElementsPrice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElementsPrice_Elements_FurnitureElementId",
                        column: x => x.FurnitureElementId,
                        principalTable: "Elements",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ElementsPrice_FurnitureElementId",
                table: "ElementsPrice",
                column: "FurnitureElementId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ElementsPrice");

            migrationBuilder.AddColumn<string>(
                name: "Prices",
                table: "Elements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
