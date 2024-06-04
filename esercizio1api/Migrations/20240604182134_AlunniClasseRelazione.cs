using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace esercizio1api.Migrations
{
    /// <inheritdoc />
    public partial class AlunniClasseRelazione : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunni_Classi_ClasseId",
                table: "Alunni");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Classi",
                newName: "ClasseId");

            migrationBuilder.RenameColumn(
                name: "ClasseId",
                table: "Alunni",
                newName: "SezioneClasseId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Alunni",
                newName: "AlunnoId");

            migrationBuilder.RenameIndex(
                name: "IX_Alunni_ClasseId",
                table: "Alunni",
                newName: "IX_Alunni_SezioneClasseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunni_Classi_SezioneClasseId",
                table: "Alunni",
                column: "SezioneClasseId",
                principalTable: "Classi",
                principalColumn: "ClasseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunni_Classi_SezioneClasseId",
                table: "Alunni");

            migrationBuilder.RenameColumn(
                name: "ClasseId",
                table: "Classi",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "SezioneClasseId",
                table: "Alunni",
                newName: "ClasseId");

            migrationBuilder.RenameColumn(
                name: "AlunnoId",
                table: "Alunni",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Alunni_SezioneClasseId",
                table: "Alunni",
                newName: "IX_Alunni_ClasseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunni_Classi_ClasseId",
                table: "Alunni",
                column: "ClasseId",
                principalTable: "Classi",
                principalColumn: "Id");
        }
    }
}
