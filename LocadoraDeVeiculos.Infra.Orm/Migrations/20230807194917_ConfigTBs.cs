﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocadoraDeVeiculos.Infra.Orm.Migrations
{
    /// <inheritdoc />
    public partial class ConfigTBs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBCliente",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(100)", nullable: false),
                    Cpf = table.Column<string>(type: "varchar(100)", nullable: false),
                    Cnpj = table.Column<string>(type: "varchar(100)", nullable: false),
                    NumeroDaCasa = table.Column<string>(type: "varchar(100)", nullable: false),
                    Cidade = table.Column<string>(type: "varchar(100)", nullable: false),
                    Estado = table.Column<string>(type: "varchar(100)", nullable: false),
                    Bairro = table.Column<string>(type: "varchar(100)", nullable: false),
                    Rua = table.Column<string>(type: "varchar(100)", nullable: false),
                    TipoCliente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBCliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBFuncionario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    DataAdmissao = table.Column<DateTime>(type: "Date", nullable: false),
                    Salario = table.Column<decimal>(type: "Decimal(38,17)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBFuncionario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBGrupoAutomovel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    PossuiPlanoDiario = table.Column<bool>(type: "bit", nullable: false),
                    PossuiPlanoControlador = table.Column<bool>(type: "bit", nullable: false),
                    PossuiPlanoLivre = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBGrupoAutomovel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBParceiro",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBParceiro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBAutomovel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Placa = table.Column<string>(type: "varchar(100)", nullable: false),
                    Modelo = table.Column<string>(type: "varchar(100)", nullable: false),
                    Marca = table.Column<string>(type: "varchar(100)", nullable: false),
                    Cor = table.Column<string>(type: "varchar(100)", nullable: false),
                    TipoCombustivel = table.Column<int>(type: "int", nullable: false),
                    CapacidadeLitros = table.Column<int>(type: "int", nullable: false),
                    Quilometragem = table.Column<int>(type: "int", nullable: false),
                    Ano = table.Column<int>(type: "int", nullable: false),
                    Foto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    GrupoAutomovelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBAutomovel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBAutomovel_TBGrupoAutomovel",
                        column: x => x.GrupoAutomovelId,
                        principalTable: "TBGrupoAutomovel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TBPlanoCobranca",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    grupoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tipo = table.Column<int>(type: "int", nullable: false),
                    PrecoDiaria = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    PrecoKm = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    KmDisponiveis = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBPlanoCobranca", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBPlanoCobranca_TBGrupoAutomoveis",
                        column: x => x.grupoId,
                        principalTable: "TBGrupoAutomovel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TBCupom",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    ParceiroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataValidade = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBCupom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBCupom_TBParceiro",
                        column: x => x.ParceiroId,
                        principalTable: "TBParceiro",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBAutomovel_GrupoAutomovelId",
                table: "TBAutomovel",
                column: "GrupoAutomovelId");

            migrationBuilder.CreateIndex(
                name: "IX_TBCupom_ParceiroId",
                table: "TBCupom",
                column: "ParceiroId");

            migrationBuilder.CreateIndex(
                name: "IX_TBPlanoCobranca_grupoId",
                table: "TBPlanoCobranca",
                column: "grupoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBAutomovel");

            migrationBuilder.DropTable(
                name: "TBCliente");

            migrationBuilder.DropTable(
                name: "TBCupom");

            migrationBuilder.DropTable(
                name: "TBFuncionario");

            migrationBuilder.DropTable(
                name: "TBPlanoCobranca");

            migrationBuilder.DropTable(
                name: "TBParceiro");

            migrationBuilder.DropTable(
                name: "TBGrupoAutomovel");
        }
    }
}
