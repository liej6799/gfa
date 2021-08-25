using Microsoft.EntityFrameworkCore.Migrations;

namespace gfa_web.Migrations
{
    public partial class Add_Vendor_Source : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SourceId",
                table: "Vendors",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SourceId",
                table: "Vendors");
        }
    }
}
