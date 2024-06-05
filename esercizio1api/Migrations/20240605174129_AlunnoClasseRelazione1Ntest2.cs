using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace esercizio1api.Migrations
{
    /// <inheritdoc />
    public partial class AlunnoClasseRelazione1Ntest2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunni_Classi_ClasseEntityClasseId",
                table: "Alunni");

            migrationBuilder.RenameColumn(
                name: "ClasseId",
                table: "Classi",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ClasseEntityClasseId",
                table: "Alunni",
                newName: "ClasseEntityId");

            migrationBuilder.RenameColumn(
                name: "AlunnoId",
                table: "Alunni",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Alunni_ClasseEntityClasseId",
                table: "Alunni",
                newName: "IX_Alunni_ClasseEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunni_Classi_ClasseEntityId",
                table: "Alunni",
                column: "ClasseEntityId",
                principalTable: "Classi",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunni_Classi_ClasseEntityId",
                table: "Alunni");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Classi",
                newName: "ClasseId");

            migrationBuilder.RenameColumn(
                name: "ClasseEntityId",
                table: "Alunni",
                newName: "ClasseEntityClasseId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Alunni",
                newName: "AlunnoId");

            migrationBuilder.RenameIndex(
                name: "IX_Alunni_ClasseEntityId",
                table: "Alunni",
                newName: "IX_Alunni_ClasseEntityClasseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunni_Classi_ClasseEntityClasseId",
                table: "Alunni",
                column: "ClasseEntityClasseId",
                principalTable: "Classi",
                principalColumn: "ClasseId");
        }
    }
}
