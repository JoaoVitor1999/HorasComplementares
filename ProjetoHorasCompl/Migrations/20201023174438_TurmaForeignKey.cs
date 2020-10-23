using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoHorasCompl.Migrations
{
    public partial class TurmaForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aluno_Turma_IdTurmaId",
                table: "Aluno");

            migrationBuilder.DropIndex(
                name: "IX_Aluno_IdTurmaId",
                table: "Aluno");

            migrationBuilder.DropColumn(
                name: "IdTurmaId",
                table: "Aluno");

            migrationBuilder.AddColumn<int>(
                name: "TurmaId",
                table: "Aluno",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Aluno_TurmaId",
                table: "Aluno",
                column: "TurmaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aluno_Turma_TurmaId",
                table: "Aluno",
                column: "TurmaId",
                principalTable: "Turma",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aluno_Turma_TurmaId",
                table: "Aluno");

            migrationBuilder.DropIndex(
                name: "IX_Aluno_TurmaId",
                table: "Aluno");

            migrationBuilder.DropColumn(
                name: "TurmaId",
                table: "Aluno");

            migrationBuilder.AddColumn<int>(
                name: "IdTurmaId",
                table: "Aluno",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Aluno_IdTurmaId",
                table: "Aluno",
                column: "IdTurmaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aluno_Turma_IdTurmaId",
                table: "Aluno",
                column: "IdTurmaId",
                principalTable: "Turma",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
