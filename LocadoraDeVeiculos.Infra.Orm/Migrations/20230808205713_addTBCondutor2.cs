using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocadoraDeVeiculos.Infra.Orm.Migrations
{
    /// <inheritdoc />
    public partial class addTBCondutor2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBCondutor_TBCliente_ClienteId",
                table: "TBCondutor");

            migrationBuilder.AlterColumn<decimal>(
                name: "Salario",
                table: "TBFuncionario",
                type: "Decimal(38,17)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(18,0)");

            migrationBuilder.AddForeignKey(
                name: "FK_TBCondutor_TBCliente",
                table: "TBCondutor",
                column: "ClienteId",
                principalTable: "TBCliente",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBCondutor_TBCliente",
                table: "TBCondutor");

            migrationBuilder.AlterColumn<decimal>(
                name: "Salario",
                table: "TBFuncionario",
                type: "Decimal(18,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(38,17)");

            migrationBuilder.AddForeignKey(
                name: "FK_TBCondutor_TBCliente_ClienteId",
                table: "TBCondutor",
                column: "ClienteId",
                principalTable: "TBCliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
