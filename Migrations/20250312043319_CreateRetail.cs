using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RetailWebApp_1.Migrations
{
    /// <inheritdoc />
    public partial class CreateRetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "varchar(25)", nullable: false),
                    Description = table.Column<string>(type: "varchar(100)", nullable: true),
                    Brand = table.Column<string>(type: "varchar(25)", nullable: true),
                    Size = table.Column<string>(type: "varchar(25)", nullable: true),
                    Colour = table.Column<string>(type: "varchar(25)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "Decimal(6,2)", nullable: false),
                    Image = table.Column<string>(type: "varchar(100)", nullable: true),
                    StaffId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
