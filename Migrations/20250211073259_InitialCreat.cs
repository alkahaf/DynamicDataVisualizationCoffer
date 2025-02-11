using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Coffer.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coffers",
                columns: table => new
                {
                    end_year = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    citylng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    citylat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    intensity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    topic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    insight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    swot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    start_year = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    impact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    added = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    published = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    relevance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pestle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    likelihood = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coffers");
        }
    }
}
