using Microsoft.EntityFrameworkCore.Migrations;

namespace Consultorio.Migrations
{
    public partial class CriandoRelacionamento2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_consulta_tb_especialidade_especialidade_id",
                table: "tb_consulta");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_consulta_tb_paciente_paciente_id",
                table: "tb_consulta");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_consulta_tb_profissional_profissional_id",
                table: "tb_consulta");

            migrationBuilder.DropTable(
                name: "tb_profissional_especialidade");

            migrationBuilder.DropIndex(
                name: "IX_tb_consulta_especialidade_id",
                table: "tb_consulta");

            migrationBuilder.DropIndex(
                name: "IX_tb_consulta_paciente_id",
                table: "tb_consulta");

            migrationBuilder.DropIndex(
                name: "IX_tb_consulta_profissional_id",
                table: "tb_consulta");

            migrationBuilder.DropColumn(
                name: "especialidade_id",
                table: "tb_consulta");

            migrationBuilder.DropColumn(
                name: "paciente_id",
                table: "tb_consulta");

            migrationBuilder.DropColumn(
                name: "profissional_id",
                table: "tb_consulta");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "especialidade_id",
                table: "tb_consulta",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "paciente_id",
                table: "tb_consulta",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "profissional_id",
                table: "tb_consulta",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "tb_profissional_especialidade",
                columns: table => new
                {
                    especialidade_id = table.Column<int>(type: "integer", nullable: false),
                    profissional_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_profissional_especialidade", x => new { x.especialidade_id, x.profissional_id });
                    table.ForeignKey(
                        name: "FK_tb_profissional_especialidade_tb_especialidade_profissional~",
                        column: x => x.profissional_id,
                        principalTable: "tb_especialidade",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_profissional_especialidade_tb_profissional_especialidade~",
                        column: x => x.especialidade_id,
                        principalTable: "tb_profissional",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_consulta_especialidade_id",
                table: "tb_consulta",
                column: "especialidade_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_consulta_paciente_id",
                table: "tb_consulta",
                column: "paciente_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_consulta_profissional_id",
                table: "tb_consulta",
                column: "profissional_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_profissional_especialidade_profissional_id",
                table: "tb_profissional_especialidade",
                column: "profissional_id");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_consulta_tb_especialidade_especialidade_id",
                table: "tb_consulta",
                column: "especialidade_id",
                principalTable: "tb_especialidade",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_consulta_tb_paciente_paciente_id",
                table: "tb_consulta",
                column: "paciente_id",
                principalTable: "tb_paciente",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_consulta_tb_profissional_profissional_id",
                table: "tb_consulta",
                column: "profissional_id",
                principalTable: "tb_profissional",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
