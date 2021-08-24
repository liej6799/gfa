using Microsoft.EntityFrameworkCore.Migrations;

namespace gfa_web.Migrations
{
    public partial class Add_ProfitLoss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "ProfitLoss",
                table: "Items",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfitLoss",
                table: "Items");
        }
    }
}
