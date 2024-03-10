using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Advertisements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fitment = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertisements", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Advertisements",
                columns: new[] { "Id", "Fitment", "Price", "Status", "Title" },
                values: new object[,]
                {
                    { 1, 0, 500000m, 0, "Test1" },
                    { 2, 0, 300000m, 1, "Test2" },
                    { 3, 1, 20000m, 1, "Test3" },
                    { 4, 1, 120000m, 0, "Test4" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advertisements");
        }
    }
}
