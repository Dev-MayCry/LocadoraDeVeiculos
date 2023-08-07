using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocadoraDeVeiculos.Infra.Orm.Migrations
{
    /// <inheritdoc />
    public partial class AddBoolNaTBGrupo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "PossuiPlanoControlador",
                table: "TBGrupoAutomovel",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PossuiPlanoDiario",
                table: "TBGrupoAutomovel",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PossuiPlanoLivre",
                table: "TBGrupoAutomovel",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<decimal>(
                name: "Salario",
                table: "TBFuncionario",
                type: "Decimal(38,17)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(18,0)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PossuiPlanoControlador",
                table: "TBGrupoAutomovel");

            migrationBuilder.DropColumn(
                name: "PossuiPlanoDiario",
                table: "TBGrupoAutomovel");

            migrationBuilder.DropColumn(
                name: "PossuiPlanoLivre",
                table: "TBGrupoAutomovel");

            migrationBuilder.AlterColumn<decimal>(
                name: "Salario",
                table: "TBFuncionario",
                type: "Decimal(18,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(38,17)");
        }
    }
}
