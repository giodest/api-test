using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace esercizio1api.Migrations
{
    /// <inheritdoc />
    public partial class test1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClasseId",
                table: "Alunni");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClasseId",
                table: "Alunni",
                type: "text",
                nullable: true);
        }
    }
}
