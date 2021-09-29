using Microsoft.EntityFrameworkCore.Migrations;

namespace Consultorio.Migrations
{
    public partial class Relacionamentos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "id_especialidade",
                table: "tb_consulta",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_profissional",
                table: "tb_consulta",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tb_consulta_id_especialidade",
                table: "tb_consulta",
                column: "id_especialidade");

            migrationBuilder.CreateIndex(
                name: "IX_tb_consulta_id_profissional",
                table: "tb_consulta",
                column: "id_profissional");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_consulta_tb_especialidade_id_especialidade",
                table: "tb_consulta",
                column: "id_especialidade",
                principalTable: "tb_especialidade",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_consulta_tb_profissional_id_profissional",
                table: "tb_consulta",
                column: "id_profissional",
                principalTable: "tb_profissional",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_consulta_tb_especialidade_id_especialidade",
                table: "tb_consulta");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_consulta_tb_profissional_id_profissional",
                table: "tb_consulta");

            migrationBuilder.DropIndex(
                name: "IX_tb_consulta_id_especialidade",
                table: "tb_consulta");

            migrationBuilder.DropIndex(
                name: "IX_tb_consulta_id_profissional",
                table: "tb_consulta");

            migrationBuilder.DropColumn(
                name: "id_especialidade",
                table: "tb_consulta");

            migrationBuilder.DropColumn(
                name: "id_profissional",
                table: "tb_consulta");
        }
    }
}
