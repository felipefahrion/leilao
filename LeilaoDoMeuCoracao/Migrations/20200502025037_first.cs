using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeilaoDoMeuCoracao.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    Cnpj = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Leilao",
                columns: table => new
                {
                    LeilaoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserCriadorUserId = table.Column<int>(nullable: true),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    DataMaxLances = table.Column<DateTime>(nullable: false),
                    Valor = table.Column<double>(nullable: false),
                    TipoLeilaoEnum = table.Column<int>(nullable: false),
                    StatusLeilaoEnum = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leilao", x => x.LeilaoId);
                    table.ForeignKey(
                        name: "FK_Leilao_Users_UserCriadorUserId",
                        column: x => x.UserCriadorUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Itens",
                columns: table => new
                {
                    ItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    DescricaoBreve = table.Column<string>(nullable: true),
                    DescricaoCompleta = table.Column<string>(nullable: true),
                    CategoriaId = table.Column<int>(nullable: true),
                    Imagem = table.Column<string>(nullable: true),
                    LeilaoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itens", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_Itens_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Itens_Leilao_LeilaoId",
                        column: x => x.LeilaoId,
                        principalTable: "Leilao",
                        principalColumn: "LeilaoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lances",
                columns: table => new
                {
                    LanceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataHoraLance = table.Column<DateTime>(nullable: false),
                    Valor = table.Column<double>(nullable: false),
                    Aceito = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: true),
                    LeilaoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lances", x => x.LanceId);
                    table.ForeignKey(
                        name: "FK_Lances_Leilao_LeilaoId",
                        column: x => x.LeilaoId,
                        principalTable: "Leilao",
                        principalColumn: "LeilaoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lances_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Itens_CategoriaId",
                table: "Itens",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Itens_LeilaoId",
                table: "Itens",
                column: "LeilaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Lances_LeilaoId",
                table: "Lances",
                column: "LeilaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Lances_UserId",
                table: "Lances",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Leilao_UserCriadorUserId",
                table: "Leilao",
                column: "UserCriadorUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Itens");

            migrationBuilder.DropTable(
                name: "Lances");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Leilao");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
