using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace esercizio1api.Migrations
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunni_Classi_ClasseEntityId",
                table: "Alunni");

            migrationBuilder.DropIndex(
                name: "IX_Alunni_ClasseEntityId",
                table: "Alunni");

            migrationBuilder.DropColumn(
                name: "ClasseEntityId",
                table: "Alunni");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Classi",
                newName: "ClasseId");

            migrationBuilder.AddColumn<string>(
                name: "ClasseId",
                table: "Alunni",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Alunni_ClasseId",
                table: "Alunni",
                column: "ClasseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunni_Classi_ClasseId",
                table: "Alunni",
                column: "ClasseId",
                principalTable: "Classi",
                principalColumn: "ClasseId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunni_Classi_ClasseId",
                table: "Alunni");

            migrationBuilder.DropIndex(
                name: "IX_Alunni_ClasseId",
                table: "Alunni");

            migrationBuilder.DropColumn(
                name: "ClasseId",
                table: "Alunni");

            migrationBuilder.RenameColumn(
                name: "ClasseId",
                table: "Classi",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "ClasseEntityId",
                table: "Alunni",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Alunni_ClasseEntityId",
                table: "Alunni",
                column: "ClasseEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunni_Classi_ClasseEntityId",
                table: "Alunni",
                column: "ClasseEntityId",
                principalTable: "Classi",
                principalColumn: "Id");
        }
    }
}
