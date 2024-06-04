using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace esercizio1api.Migrations
{
    /// <inheritdoc />
    public partial class NoRelationAlunniClassi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunni_Classi_SezioneClasseId",
                table: "Alunni");

            migrationBuilder.DropIndex(
                name: "IX_Alunni_SezioneClasseId",
                table: "Alunni");

            migrationBuilder.DropColumn(
                name: "SezioneClasseId",
                table: "Alunni");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SezioneClasseId",
                table: "Alunni",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Alunni_SezioneClasseId",
                table: "Alunni",
                column: "SezioneClasseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunni_Classi_SezioneClasseId",
                table: "Alunni",
                column: "SezioneClasseId",
                principalTable: "Classi",
                principalColumn: "ClasseId");
        }
    }
}
