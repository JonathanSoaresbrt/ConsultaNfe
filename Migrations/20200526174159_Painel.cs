using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace RelatoriosWeb.Migrations
{
    public partial class Painel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Painel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Cnpj = table.Column<string>(nullable: true),
                    Nr_Serie = table.Column<string>(nullable: true),
                    Dt_Termino = table.Column<DateTime>(nullable: false),
                    Nf_Numero = table.Column<int>(nullable: false),
                    Retorno = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Movimento = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Painel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Painel_Nfe",
                columns: table => new
                {
                    Nf_numero = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Nr_serie = table.Column<string>(nullable: true),
                    Cnpj = table.Column<string>(nullable: true),
                    Tp_nota = table.Column<int>(nullable: false),
                    Serie_Nfe = table.Column<string>(nullable: true),
                    Modelo_Nfe = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    Retorno = table.Column<string>(nullable: true),
                    Chave_Nfe = table.Column<string>(nullable: true),
                    Cxml = table.Column<string>(nullable: true),
                    Dt_Termino = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Painel_Nfe", x => x.Nf_numero);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Nome = table.Column<string>(nullable: true),
                    Login = table.Column<string>(nullable: false),
                    Senha = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Painel");

            migrationBuilder.DropTable(
                name: "Painel_Nfe");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
