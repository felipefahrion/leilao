using Microsoft.EntityFrameworkCore.Migrations;

namespace LeilaoDoMeuCoracao.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Itens_Leilao_LeilaoId",
                table: "Itens");

            migrationBuilder.DropForeignKey(
                name: "FK_Lances_Leilao_LeilaoId",
                table: "Lances");

            migrationBuilder.DropForeignKey(
                name: "FK_Leilao_Users_UserCriadorUserId",
                table: "Leilao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Leilao",
                table: "Leilao");

            migrationBuilder.DropColumn(
                name: "TipoLeilaoEnum",
                table: "Leilao");

            migrationBuilder.RenameTable(
                name: "Leilao",
                newName: "Leiloes");

            migrationBuilder.RenameIndex(
                name: "IX_Leilao_UserCriadorUserId",
                table: "Leiloes",
                newName: "IX_Leiloes_UserCriadorUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Leiloes",
                table: "Leiloes",
                column: "LeilaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Itens_Leiloes_LeilaoId",
                table: "Itens",
                column: "LeilaoId",
                principalTable: "Leiloes",
                principalColumn: "LeilaoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lances_Leiloes_LeilaoId",
                table: "Lances",
                column: "LeilaoId",
                principalTable: "Leiloes",
                principalColumn: "LeilaoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Leiloes_Users_UserCriadorUserId",
                table: "Leiloes",
                column: "UserCriadorUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Itens_Leiloes_LeilaoId",
                table: "Itens");

            migrationBuilder.DropForeignKey(
                name: "FK_Lances_Leiloes_LeilaoId",
                table: "Lances");

            migrationBuilder.DropForeignKey(
                name: "FK_Leiloes_Users_UserCriadorUserId",
                table: "Leiloes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Leiloes",
                table: "Leiloes");

            migrationBuilder.RenameTable(
                name: "Leiloes",
                newName: "Leilao");

            migrationBuilder.RenameIndex(
                name: "IX_Leiloes_UserCriadorUserId",
                table: "Leilao",
                newName: "IX_Leilao_UserCriadorUserId");

            migrationBuilder.AddColumn<int>(
                name: "TipoLeilaoEnum",
                table: "Leilao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Leilao",
                table: "Leilao",
                column: "LeilaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Itens_Leilao_LeilaoId",
                table: "Itens",
                column: "LeilaoId",
                principalTable: "Leilao",
                principalColumn: "LeilaoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lances_Leilao_LeilaoId",
                table: "Lances",
                column: "LeilaoId",
                principalTable: "Leilao",
                principalColumn: "LeilaoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Leilao_Users_UserCriadorUserId",
                table: "Leilao",
                column: "UserCriadorUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
