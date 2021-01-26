using Microsoft.EntityFrameworkCore.Migrations;

namespace ProAgil.API.Migrations
{
    public partial class AdicionandoValor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Valor",
                table: "Eventos",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Valor",
                table: "Eventos");
        }
    }
}
