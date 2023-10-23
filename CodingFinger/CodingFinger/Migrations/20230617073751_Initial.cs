using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingFinger.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployerNum = table.Column<int>(type: "int", nullable: false),
                    EmployerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployerDesignation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployerAge = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployerSalary = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employer", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employer");
        }
    }
}
