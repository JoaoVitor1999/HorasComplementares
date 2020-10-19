using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoHorasCompl.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aluno",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AluNome = table.Column<string>(nullable: true),
                    IdTurmaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluno", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aluno_Turma_IdTurmaId",
                        column: x => x.IdTurmaId,
                        principalTable: "Turma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TipoComprovante",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TipNome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoComprovante", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comprovante",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CmpDescricao = table.Column<string>(nullable: true),
                    CmpDataInicio = table.Column<DateTime>(nullable: false),
                    CmpDataFim = table.Column<DateTime>(nullable: false),
                    CmpQtdHoras = table.Column<int>(nullable: false),
                    CmpAluIdId = table.Column<int>(nullable: true),
                    CmpTipoComprovantesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comprovante", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comprovante_Aluno_CmpAluIdId",
                        column: x => x.CmpAluIdId,
                        principalTable: "Aluno",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comprovante_TipoComprovante_CmpTipoComprovantesId",
                        column: x => x.CmpTipoComprovantesId,
                        principalTable: "TipoComprovante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aluno_IdTurmaId",
                table: "Aluno",
                column: "IdTurmaId");

            migrationBuilder.CreateIndex(
                name: "IX_Comprovante_CmpAluIdId",
                table: "Comprovante",
                column: "CmpAluIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Comprovante_CmpTipoComprovantesId",
                table: "Comprovante",
                column: "CmpTipoComprovantesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comprovante");

            migrationBuilder.DropTable(
                name: "Aluno");

            migrationBuilder.DropTable(
                name: "TipoComprovante");
        }
    }
}
