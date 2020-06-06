using Microsoft.EntityFrameworkCore.Migrations;

namespace LeilaoDoMeuCoracao.Migrations
{
    public partial class addingtipoleilao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoLeilaoEnum",
                table: "Leiloes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoLeilaoEnum",
                table: "Leiloes");
        }
    }
}
