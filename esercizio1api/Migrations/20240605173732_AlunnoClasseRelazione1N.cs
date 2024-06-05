using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace esercizio1api.Migrations
{
    /// <inheritdoc />
    public partial class AlunnoClasseRelazione1N : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClasseEntityClasseId",
                table: "Alunni",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClasseId",
                table: "Alunni",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Alunni_ClasseEntityClasseId",
                table: "Alunni",
                column: "ClasseEntityClasseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunni_Classi_ClasseEntityClasseId",
                table: "Alunni",
                column: "ClasseEntityClasseId",
                principalTable: "Classi",
                principalColumn: "ClasseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunni_Classi_ClasseEntityClasseId",
                table: "Alunni");

            migrationBuilder.DropIndex(
                name: "IX_Alunni_ClasseEntityClasseId",
                table: "Alunni");

            migrationBuilder.DropColumn(
                name: "ClasseEntityClasseId",
                table: "Alunni");

            migrationBuilder.DropColumn(
                name: "ClasseId",
                table: "Alunni");
        }
    }
}
